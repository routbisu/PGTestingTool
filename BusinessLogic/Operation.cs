using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayTestingTool.BusinessLogic
{
    public class Operation
    {
        public OperationType OperationType { get; set; }
        public ActionType Action { get; set; }
        public string HelpLink { get; set; }
        public List<string> InputColumns { get; set; }
    }
}
