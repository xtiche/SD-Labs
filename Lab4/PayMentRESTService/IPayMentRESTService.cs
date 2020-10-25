using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPayMentRESTService" in both code and config file together.
    [ServiceContract]
    public interface IPayMentRESTService
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "/PayBill/{PayId}",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string PayBill(string PayId);
    }
}
