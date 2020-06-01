using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace WebApi.Utility.Filter
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

            if (actionExecutedContext.Exception is HttpResponseException)
            {
                HttpResponseException httpEx = (HttpResponseException)actionExecutedContext.Exception;
                if (HttpStatusCode.Unauthorized == httpEx.Response.StatusCode)
                {
                    

                }
            }

            //base.OnException(actionExecutedContext);
        }
    }
}