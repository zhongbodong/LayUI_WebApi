using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Utility.Filter;

namespace WebApi.Controllers
{
    public class MenuController : ApiController
    {
        [CustomAllowAnonymous]
        [HttpPost]
        public string AddNodeDetail(string parentid, string nodeName)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Success = true,
                Message = "新增成功了"
            });
        }

        [CustomActionFilter]
        [CustomAllowAnonymous]
        [HttpGet]
        public string GetUpdateNode(string parentGuid, string title,int random)
        { 
            return Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Success = true,
                Message = "修改成功了"
            });
        }
    }
}
