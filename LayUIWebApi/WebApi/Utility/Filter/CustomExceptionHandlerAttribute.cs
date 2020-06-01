using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace WebApi.Utility.Filter
{
    public class CustomExceptionHandlerAttribute : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            base.Handle(context);
        }

        public override bool ShouldHandle(ExceptionHandlerContext context)
        {
            return base.ShouldHandle(context);
        }
    }
}