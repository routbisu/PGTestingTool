using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PaymentGatewayTestingTool.BusinessLogic
{
    public class Common
    {
        public List<Operation> _pCIOperations;
        public List<Operation> _nonPCIOperations;

        public Common()
        {
            // Add all non pci operations
            #region NonPCI Operations
            _nonPCIOperations = new List<Operation>();
            _pCIOperations = new List<Operation>();

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetPayments,
                HelpLink = "https://www.getpayments.com/docs/#getpayments",
                InputColumns = new List<string>
                {
                    "PaymentType (Required)",
                    "PaymentMethod (Required)",
                    "PaymentSource (Required)",
                    "PaymentReference",
                    "DateFrom",
                    "DateTo",
                    "DateField",
                    "EziDebitCustomerID",
                    "YourSystemReference"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetPaymentStatus,
                HelpLink = "https://www.getpayments.com/docs/#getpaymentstatus",
                InputColumns = new List<string>
                {
                    "PaymentReference  (Required)"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.ProcessRefund,
                HelpLink = "https://www.getpayments.com/docs/#refunds",
                InputColumns = new List<string>
                {
                    "PaymentID (Required)",
                    "BankReceiptID",
                    "RefundAmountInCents (Required)"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetPaymentDetail,
                HelpLink = "https://www.getpayments.com/docs/#getpaymentdetail",
                InputColumns = new List<string>
                {
                    "PaymentReference (Required)"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.AddPayment,
                HelpLink = "https://www.getpayments.com/docs/#addpayment",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "DebitDate (Required)",
                    "PaymentAmountInCents (Required)",
                    "PaymentReference",
                    "Username"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.DeletePayment,
                HelpLink = "https://www.getpayments.com/docs/#deletepayment",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "PaymentReference",
                    "DebitDate",
                    "PaymentAmountInCents (Required)",
                    "Username"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetScheduledPayments,
                HelpLink = "https://www.getpayments.com/docs/#getscheduledpayments",
                InputColumns = new List<string>
                {
                    "DateFrom",
                    "DateTo",
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.ChangeCustomerStatus,
                HelpLink = "https://www.getpayments.com/docs/#changecustomerstatus",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "NewStatus (Required)",
                    "Username"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.EditCustomerDetails,
                HelpLink = "https://www.getpayments.com/docs/#editcustomerdetails",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "NewYourSystemReference",
                    "YourGeneralReference",
                    "LastName (Required)",
                    "FirstName",
                    "AddressLine1",
                    "AddressLine2",
                    "AddressSuburb",
                    "AddressPostCode",
                    "AddressState",
                    "EmailAddress",
                    "MobilePhoneNumber",
                    "SmsPaymentReminder (Required)",
                    "SmsFailedNotification (Required)",
                    "SmsExpiredCard (Required)",
                    "Username"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetCustomerDetails,
                HelpLink = "https://www.getpayments.com/docs/#getcustomerdetails",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetCustomerFees,
                HelpLink = "https://www.getpayments.com/docs/#getcustomerfees",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "PaymentSource (Required)",
                    "Username"
                }
            });

            _nonPCIOperations.Add(new Operation
            {
                OperationType = OperationType.NonPCI,
                Action = ActionType.GetCustomerList,
                HelpLink = "https://www.getpayments.com/docs/#getcustomerlist",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "CustomerStatus (Required)",
                    "OrderBy",
                    "Order",
                    "PageNumber (Required)"
                }
            });

            #endregion




            #region PCI Operations
            _pCIOperations.Add(new Operation
            {
                OperationType = OperationType.PCI,
                Action = ActionType.EditCustomerBankAccount,
                HelpLink = "https://www.getpayments.com/docs/#editcustomerbankaccount",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "BankAccountName (Required)",
                    "BankAccountBSB (Required)",
                    "BankAccountNumber (Required)",
                    "Reactivate",
                    "Username"
                }
            });

            _pCIOperations.Add(new Operation
            {
                OperationType = OperationType.PCI,
                Action = ActionType.EditCustomerCreditCard,
                HelpLink = "https://www.getpayments.com/docs/#editcustomercreditcard",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)",
                    "NameOnCreditCard (Required)",
                    "CreditCardNumber (Required)",
                    "CreditCardExpiryYear (Required)",
                    "CreditCardExpiryMonth (Required)",
                    "Reactivate (Required)",
                    "Username"
                }
            });

            _pCIOperations.Add(new Operation
            {
                OperationType = OperationType.PCI,
                Action = ActionType.GetCustomerAccountDetails,
                HelpLink = "https://www.getpayments.com/docs/#getcustomeraccountdetails",
                InputColumns = new List<string>
                {
                    "EziDebitCustomerID (Either)",
                    "YourSystemReference (Either)"
                }
            });
            #endregion
        }

        public static void HighlightRTF(RichTextBox rtb)
        {
            int k = 0;

            string str = rtb.Text;

            int st, en;
            int lasten = -1;
            while (k < str.Length)
            {
                st = str.IndexOf('<', k);

                if (st < 0)
                    break;

                if (lasten > 0)
                {
                    rtb.Select(lasten + 1, st - lasten - 1);
                    rtb.SelectionColor = HighlightColors.HC_INNERTEXT;
                }

                en = str.IndexOf('>', st + 1);
                if (en < 0)
                    break;

                k = en + 1;
                lasten = en;

                if (str[st + 1] == '!')
                {
                    rtb.Select(st + 1, en - st - 1);
                    rtb.SelectionColor = HighlightColors.HC_COMMENT;
                    continue;

                }
                String nodeText = str.Substring(st + 1, en - st - 1);


                bool inString = false;

                int lastSt = -1;
                int state = 0;
                /* 0 = before node name
                 * 1 = in node name
                   2 = after node name
                   3 = in attribute
                   4 = in string
                   */
                int startNodeName = 0, startAtt = 0;
                for (int i = 0; i < nodeText.Length; ++i)
                {
                    if (nodeText[i] == '"')
                        inString = !inString;

                    if (inString && nodeText[i] == '"')
                        lastSt = i;
                    else
                        if (nodeText[i] == '"')
                    {
                        rtb.Select(lastSt + st + 2, i - lastSt - 1);
                        rtb.SelectionColor = HighlightColors.HC_STRING;
                    }

                    switch (state)
                    {
                        case 0:
                            if (!Char.IsWhiteSpace(nodeText, i))
                            {
                                startNodeName = i;
                                state = 1;
                            }
                            break;
                        case 1:
                            if (Char.IsWhiteSpace(nodeText, i))
                            {
                                rtb.Select(startNodeName + st, i - startNodeName + 1);
                                rtb.SelectionColor = HighlightColors.HC_NODE;
                                state = 2;
                            }
                            break;
                        case 2:
                            if (!Char.IsWhiteSpace(nodeText, i))
                            {
                                startAtt = i;
                                state = 3;
                            }
                            break;

                        case 3:
                            if (Char.IsWhiteSpace(nodeText, i) || nodeText[i] == '=')
                            {
                                rtb.Select(startAtt + st, i - startAtt + 1);
                                rtb.SelectionColor = HighlightColors.HC_ATTRIBUTE;
                                state = 4;
                            }
                            break;
                        case 4:
                            if (nodeText[i] == '"' && !inString)
                                state = 2;
                            break;


                    }

                }
                if (state == 1)
                {
                    rtb.Select(st + 1, nodeText.Length);
                    rtb.SelectionColor = HighlightColors.HC_NODE;
                }

            }
        }

        public static string JsonPrettify(string json)
        {
            try
            {
                using (var stringReader = new StringReader(json))
                using (var stringWriter = new StringWriter())
                {
                    var jsonReader = new JsonTextReader(stringReader);
                    var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Newtonsoft.Json.Formatting.Indented };
                    jsonWriter.WriteToken(jsonReader);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

    public enum ActionType
    {
        EditCustomerBankAccount,
        EditCustomerCreditCard,
        GetCustomerAccountDetails,
        GetPayments,
        GetPaymentStatus,
        GetPaymentDetail,
        ProcessRefund,
        AddPayment,
        DeletePayment,
        GetScheduledPayments,
        ChangeCustomerStatus,
        EditCustomerDetails,
        GetCustomerDetails,
        GetCustomerFees,
        GetCustomerList
    }

    public enum OperationType
    {
        PCI,
        NonPCI
    }


    public class HighlightColors
    {
        public static Color HC_NODE = Color.Firebrick;
        public static Color HC_STRING = Color.Blue;
        public static Color HC_ATTRIBUTE = Color.Red;
        public static Color HC_COMMENT = Color.GreenYellow;
        public static Color HC_INNERTEXT = Color.Black;
    }


   
}
