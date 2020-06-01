using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using WebApi.Models;
using WebApi.Models.System;
using WebApi.Utility.Filter;

namespace WebApi.Controllers
{
    public class SystemController : ApiController
    {
        [Route("api/System/GetMenuList")]
        //[CustomBasicAuthorize]
        public string GetMenuList()
        {
            AjaxApiModel<MenuInfo> result = new AjaxApiModel<MenuInfo>();
            List<MenuInfo> menus = new List<MenuInfo>() {
                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="菜单",
                    Ico="layui-icon-home",
                    Submenu=new List<MenuInfo>(){
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="菜单1",
                            Ico="layui-icon-code-circle"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="菜单2",
                            Ico="layui-icon-engine"
                        }
                    }
                },

                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="系统",
                    Ico="layui-icon-component",
                    Submenu=new List<MenuInfo>(){
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="用户管理",
                            Ico="layui-icon-username",
                            Url="Userview.html"
                        },
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="菜单管理",
                            Ico="layui-icon-senior",
                            Url="MenuView.html"
                        },
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="图片管理",
                            Ico="layui-icon-template",
                            Url="FileUpload.html"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="图片懒加载",
                            Ico="layui-icon-component",
                            Url="lazyImage.html"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="轮播",
                            Ico="layui-icon-component",
                            Url="WheelPlanting.html"
                        }
                    }
                }
            };
            result.Data = menus;
            result.Result = true;
            return Newtonsoft.Json.JsonConvert.SerializeObject(result); ;
        }
         
        //[CustomBasicAuthorize]
        [Route("api/System/GetNavigationBarList")]
        public string GetNavigationBarList(int nav)
        {
            AjaxApiModel<MenuInfo> result = new AjaxApiModel<MenuInfo>();
            List<MenuInfo> menus = new List<MenuInfo>() {
                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="控制台",
                },
                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="商品管理",
                },
                 new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="用户",
                },
                new MenuInfo(){
                    MenuGuid=Guid.NewGuid(),
                    MenuName="其他系统",
                    Ico="layui-icon-component",
                    Submenu=new List<MenuInfo>(){
                        new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="邮件管理"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="消息管理"
                        },
                         new MenuInfo(){
                            MenuGuid=Guid.NewGuid(),
                            MenuName="授权管理"
                        }
                    }
                }
            };

            result.Result = true;
            result.Data = menus;
            return Newtonsoft.Json.JsonConvert.SerializeObject(result); ;
        }


        [HttpGet]
        [Route("api/System/GetNavigationBarList")]
        //[CustomBasicAuthorize] 
        public string GetTreeList(string random)
        {
            AjaxApiModel<TreeResultData> result = new AjaxApiModel<TreeResultData>(); 
            List<TreeResultData> treeList = new List<TreeResultData>()
            {
                new TreeResultData(){
                    id=Guid.NewGuid(),
                    title="节点1",
                    href=null,
                    disabled=false,
                    children=new List<TreeResultData>(){
                        new TreeResultData(){
                            id=Guid.NewGuid(),
                            title="节点1-1",
                            href="http://www.baidu.com",
                            disabled=false
                        },
                        new TreeResultData(){
                            id=Guid.NewGuid(),
                            title="节点1-2",
                            href="http://www.baidu.com",
                            disabled=false
                        }

                    }
                },
                new TreeResultData(){
                    id=Guid.NewGuid(),
                    title="节点2",
                    href=null,
                    disabled=false,
                    children=new List<TreeResultData>(){
                        new TreeResultData(){
                            id=Guid.NewGuid(),
                            title="节点2-1",
                            href="http://www.baidu.com",
                            disabled=false
                        },
                        new TreeResultData(){
                            id=Guid.NewGuid(),
                            title="节点2-2",
                            href="http://www.baidu.com",
                            disabled=true
                        }
                    }
                }

            }; 
            result.Result = true;
            result.Data = treeList; 
            return Newtonsoft.Json.JsonConvert.SerializeObject(result); ;
        }

    }
}
