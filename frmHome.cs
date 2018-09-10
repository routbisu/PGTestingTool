using PaymentGatewayTestingTool.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PaymentGatewayTestingTool
{
    public partial class frmHome : Form
    {
        private Ezidebit.NonPCIServiceClient _pgAPIReference;
        private EzidebitPCI.PCIServiceClient _pgAPIReferencePCI;
        private Common _businessLogic;
        private string _selectedAPILink = "";
        private OperationType _operationType;
        private ActionType _actionType;

        private string _publicKey;
        private string _digitalKey;

        public static string outputData;
        public static string outputDataJSON;

        public void OpenConnection()
        {
            _pgAPIReference = new Ezidebit.NonPCIServiceClient();
            _pgAPIReferencePCI = new EzidebitPCI.PCIServiceClient();

            btnFetchData.Text = "Fetching ...";
            btnFetchData.Enabled = false;
            btnFetchColumns.Enabled = false;
        }
        
        public void CloseConnection()
        {
            if (_pgAPIReference != null) _pgAPIReference.Close();
            if (_pgAPIReferencePCI != null) _pgAPIReferencePCI.Close();

            btnFetchData.Text = "Fetch Data";
            btnFetchData.Enabled = true;
            btnFetchColumns.Enabled = true;
        }

        public frmHome()
        {
            InitializeComponent();
            _businessLogic = new Common();

            // Fetch configuration from App.config
            _publicKey = ConfigurationManager.AppSettings["PGPublicKey"];
            _digitalKey = ConfigurationManager.AppSettings["PGDigitalKey"];

            //_pgAPIReference.AddCustomer()
            //populateLegends(ActionType.GetPayments, OperationType.NonPCI);

            // Populate action dropdowns
            //cbOperations.Items.AddRange()
        }

        public void populateLegends(ActionType action)
        {
            string legend = "";

            // Find operation details from action name
            List<string> columns = new List<string>();

            if(_operationType == OperationType.PCI)
            {
                foreach(var operation in _businessLogic._pCIOperations)
                {
                    if (operation.Action == action)
                    {
                        columns = operation.InputColumns;
                        _selectedAPILink = operation.HelpLink;
                    }
                }
            }

            if (_operationType == OperationType.NonPCI)
            {
                foreach (var operation in _businessLogic._nonPCIOperations)
                {
                    if (operation.Action == action)
                    {
                        columns = operation.InputColumns;
                        _selectedAPILink = operation.HelpLink;
                    }
                }
            }

            foreach (var column in columns)
            {
                legend = legend + column + Environment.NewLine;
            }

            txtLegend.Text = legend;
        }

        private void radioPCI_CheckedChanged(object sender, EventArgs e)
        {
            cbOperations.Items.Clear();
            cbOperations.Items.Insert(0, "Select Operation");
            if (radioPCI.Checked)
            {
                foreach(var item in _businessLogic._pCIOperations)
                {
                    cbOperations.Items.Add(item.Action);
                }
            }
            cbOperations.SelectedIndex = 0;
            _operationType = OperationType.PCI;
        }

        private void radioNonPCI_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cbOperations.Items.Clear();
                cbOperations.Items.Insert(0, "Select Operation");
                if (radioNonPCI.Checked)
                {
                    foreach (var item in _businessLogic._nonPCIOperations)
                    {
                        cbOperations.Items.Add(item.Action);
                    }
                }
                cbOperations.SelectedIndex = 0;
                _operationType = OperationType.NonPCI;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFetchColumns_Click(object sender, EventArgs e)
        {
            try
            {
                _actionType = (ActionType)cbOperations.SelectedItem;
                populateLegends(_actionType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbOperations.SelectedItem.ToString() != "Select Operation")
                {
                    btnFetchColumns.Enabled = true;
                    btnFetchData.Enabled = true;
                }
                else
                {
                    btnFetchColumns.Enabled = false;
                    btnFetchData.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llAPIReference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_selectedAPILink);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an operation to view its API Reference");
            }
        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();

                //object returnData = null;

                string inputText = txtInputs.Text;
                string[] inputs = inputText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                string[] inputValues = new string[30];
                for(int i = 0; i < 30; i++)
                {
                    try
                    {
                        inputValues[i] = inputs[i].ToString();
                    }
                    catch (Exception)
                    {
                        inputValues[i] = "";
                    }
                }

                // Make the PG Call
                if(_operationType == OperationType.NonPCI)
                {
                    switch(_actionType)
                    {
                        case ActionType.GetPayments:
                            Task<Ezidebit.EziResponseOfArrayOfPaymentTHgMB7oL> returnData = _pgAPIReference.GetPaymentsAsync(_digitalKey,
                                inputValues[0],
                                inputValues[1],
                                inputValues[2],
                                inputValues[3],
                                inputValues[4],
                                inputValues[5],
                                inputValues[6],
                                inputValues[7],
                                inputValues[8]
                           );
                            
                            Ezidebit.EziResponseOfArrayOfPaymentTHgMB7oL finalOutput = await returnData;
                            outputData = Serialize<Ezidebit.EziResponseOfArrayOfPaymentTHgMB7oL>(finalOutput);
                            outputDataJSON = new JavaScriptSerializer().Serialize(finalOutput);
                            break;

                        case ActionType.GetPaymentStatus:
                            Task<Ezidebit.EziResponseOfstring> returnData0 = _pgAPIReference.GetPaymentStatusAsync(_digitalKey,
                                inputValues[0]
                           );

                            Ezidebit.EziResponseOfstring finalOutput0 = await returnData0;
                            outputData = Serialize<Ezidebit.EziResponseOfstring>(finalOutput0);
                            outputDataJSON = new JavaScriptSerializer().Serialize(finalOutput0);
                            break;

                        case ActionType.ProcessRefund:
                            Task<Ezidebit.EziResponseOfRefundPaymentTHgMB7oL> returnData1 = _pgAPIReference.ProcessRefundAsync(_digitalKey,
                                inputValues[0],
                                inputValues[1],
                                Convert.ToInt64(inputValues[2])
                           );

                            Ezidebit.EziResponseOfRefundPaymentTHgMB7oL finalOutput1 = await returnData1;
                             outputData = Serialize<Ezidebit.EziResponseOfRefundPaymentTHgMB7oL>(finalOutput1);
                            outputDataJSON = new JavaScriptSerializer().Serialize(finalOutput1);
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();

                frmOutput form = new frmOutput();
                form.ShowDialog();
            }
        }

        public static string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
