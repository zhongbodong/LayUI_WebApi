using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Security;

namespace WebApi.Utility.Filter
{
    public class CustomBasicAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.ActionDescriptor.GetCustomAttributes<CustomAllowAnonymousAttribute>().FirstOrDefault() != null)
            {
                return;
            }
            else if (actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<CustomAllowAnonymousAttribute>().FirstOrDefault() != null)
            {
                return;
            }

            var authorization = actionContext.Request.Headers.Authorization;
            if (authorization==null||authorization.Parameter == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    Result = false,
                    Message = "票据已，请重新登陆系统！"
                }));
                return;
            }
            var ticket = FormsAuthentication.Decrypt(authorization.Parameter).UserData;
            if (string.Equals(ticket, "Richard&1"))
            {
                return;
            }
            else
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    Result = false,
                    Message = "授权码错误"
                }));
            }
        }
    }
}