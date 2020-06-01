using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using WebApi.Utility.Filter;

namespace WebApi.Controllers
{
    public class FileController : ApiController
    {
        [CustomAllowAnonymousAttribute]
        [HttpPost]
        public string SaveFile()
        {
            try
            {
                //获取参数信息
                HttpContextBase context = (HttpContextBase)Request.Properties["MS_HttpContext"];
                HttpRequestBase request = context.Request;
                var file = request.Files[0];
                var fileName = file.FileName;
                int idxStart = fileName.LastIndexOf(".");
                string areviation = fileName.Substring(idxStart, fileName.Length - idxStart);
                string fileStorageName = Guid.NewGuid().ToString();
                string filePath = Path.Combine(HostingEnvironment.MapPath("~/fileUpload"), $"{fileStorageName}{areviation}");
                request.Files[0].SaveAs(filePath);



                //返回结果
                var result = new
                {
                    StorageName = $"{fileStorageName}{areviation}",
                    OldFileName = fileName,
                    IsImage = file.ContentType.Split('/')[0] == "image"
                };
                return Newtonsoft.Json.JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        [CustomAllowAnonymousAttribute]
        [HttpGet]
        public string GetFileList()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new List<object> {
                new { OldFileName="QQ截图20190716171059.png",StorageName="46a2603c-35e8-4bd6-9785-7f28eb012486.png",IsImage=true },
                new { OldFileName="QQ截图20190716171059.png",StorageName="46a2603c-35e8-4bd6-9785-7f28eb012486.png",IsImage=true },
                new { OldFileName="QQ截图20190716171059.png",StorageName="46a2603c-35e8-4bd6-9785-7f28eb012486.png",IsImage=true},
                new { OldFileName="QQ截图20190716171059.png",StorageName="46a2603c-35e8-4bd6-9785-7f28eb012486.png",IsImage=true },
                new { OldFileName="QQ截图20190716171059.png",StorageName="46a2603c-35e8-4bd6-9785-7f28eb012486.png",IsImage=true }
            });
        }
    }
}
