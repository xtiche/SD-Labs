using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PayMentRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PayMentRESTService.svc or PayMentRESTService.svc.cs at the Solution Explorer and start debugging.
    public class PayMentRESTService : IPayMentRESTService
    {
        public string PayBill(string PayId)
        {
            return "Transaction having PayId " + PayId + " was successful";
        }
    }
}
