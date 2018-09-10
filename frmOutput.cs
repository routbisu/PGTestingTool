using PaymentGatewayTestingTool.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentGatewayTestingTool
{
    public partial class frmOutput : Form
    {
        public frmOutput()
        {
            InitializeComponent();
            txtOutputData.Text = frmHome.outputData;
            //Common.HighlightRTF(txtOutputData);
        }

        private void rbXML_CheckedChanged(object sender, EventArgs e)
        {
            if(rbXML.Checked)
            {
                txtOutputData.Text = frmHome.outputData;
            }
        }

        private void rbJSON_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJSON.Checked)
            {
                txtOutputData.Text = Common.JsonPrettify(frmHome.outputDataJSON);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XML File|*.xml|JSON|*.json";
            saveFile.Title = "Save output data";

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != "")
            {
                string path = Path.GetFullPath(saveFile.FileName);
                File.WriteAllText(path, txtOutputData.Text);
            }
        }

    }
}
