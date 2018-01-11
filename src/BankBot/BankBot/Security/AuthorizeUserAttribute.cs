using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Results;
using System.Web.Routing;

namespace BankBot.Security
{
    public class AuthorizeBotAttribute : AuthorizeAttribute
    {
        private string _reason = "";
        public bool ByPassAuthorization { get; set; }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden);
            if (!string.IsNullOrEmpty(_reason))
                actionContext.Response.ReasonPhrase = _reason;

        }

        //private IEnumerable<SecureCallAttribute> GetApiAuthorizeAttributes(HttpActionDescriptor descriptor)
        //{
        //    return descriptor.GetCustomAttributes<SecureCallAttribute>(true)
        //        .Concat(descriptor.ControllerDescriptor.GetCustomAttributes<SecureCallAttribute>(true));
        //}

        //private bool IsSecuredApiCallRequested(HttpActionContext actionContext)
        //{
        //    var apiAttributes = GetApiAuthorizeAttributes(actionContext.ActionDescriptor);
        //    if (apiAttributes != null && apiAttributes.Any())
        //        return true;
        //    return false;
        //}

        public override void OnAuthorization(HttpActionContext actionContext)
        {

            //If not authorized
            this.HandleUnauthorizedRequest(actionContext);
            _reason = "You are not authorized please type validate";

            //if authorized
            //base.OnAuthorization(actionContext);

            //if (IsSecuredApiCallRequested(actionContext))
            //{

            //    var queryParams = actionContext.Request.GetQueryNameValuePairs();
            //    if (queryParams.Any(x => x.Key.ToLower() == "requestToken") && queryParams.Any(x => x.Key.ToLower() == "epoch"))
            //    {
            //        this.HandleUnauthorizedRequest(actionContext);
            //        _reason = "Invalid Request , No RequestToken and Epoch";
            //    }
            //    else
            //    {
            //        base.OnAuthorization(actionContext);
            //    }
            //}
        }



        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
              this.HandleUnauthorizedRequest(actionContext);
                _reason = "Invalid Epoch or RequestToken, Access Denied";
                return false;
        }

        //private bool IsValidRequestTokenWithEpoch(IEnumerable<KeyValuePair<string, string>> QueryParams)
        //{
        //    throw new NotImplementedException();
        //}

    }

    //References
    //https://gist.github.com/thehoneymad/c10fec5821c2a618fc8f

}