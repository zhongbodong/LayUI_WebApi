using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models.System;
using WebApi.Utility.Filter;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        [CustomAllowAnonymousAttribute]
        public List<MenuInfo> GetMenuList()
        {
            List<MenuInfo> menus = new List<MenuInfo>() {
                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="菜单",
                    Ico="layui-icon-home",
                    Submenu=new List<MenuInfo>(){
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="菜单1"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="菜单2"
                        }
                    }
                },

                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="用户",
                    Ico="layui-icon-component",
                    Submenu=new List<MenuInfo>(){
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="用户管理"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="角色管理"
                        }
                    }
                }
            };

            return menus;
            //return Newtonsoft.Json.JsonConvert.SerializeObject(menus);
        }
    }
}
