using System;
using System.Net;
using Microsoft.Dynamics.Framework.UI.Extensibility;

namespace NaviPartner.Api
{
    [ControlAddInExport("NaviPartner.Api.HttpWebRequest.1.00")]
    public class HttpWebRequest 
    {
        public HttpWebRequest()
        {
        }

        public void SetTrustedCertificateValidation(ref System.Net.HttpWebRequest HttpWebRequest)
        {
            HttpWebRequest.ServerCertificateValidationCallback = delegate { return (true); };
        }
    }
}
