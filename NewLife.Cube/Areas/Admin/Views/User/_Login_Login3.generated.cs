﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    
    #line 1 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
    using NewLife.Cube.Web;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_Login_Login3.cshtml")]
    public partial class _Areas_Admin_Views_User__Login_Login3_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__Login_Login3_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
  
    var set = NewLife.Cube.Setting.Current;
    var returnUrl = ViewBag.ReturnUrl as String;
    var ms = NewLife.Web.OAuthConfig.Current.Items.Where(e => !e.AppID.IsNullOrEmpty()).ToList();
    var dic = "NewLife=新生命,Baidu=百度,Weixin=微信,Taobao=淘宝".SplitAsDictionary("=", ",");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
 if (ms.Count > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"toolbar clearfix text-center\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"padding-top:30px;\"");

WriteLiteral(">\r\n            <span>\r\n                第三方登录：\r\n            </span>\r\n");

            
            #line 15 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
             foreach (var mi in ms)
            {
                var nickName = "";
                if (!dic.TryGetValue(mi.Name, out nickName)) { nickName = mi.Name; }

                var url = "Sso/Login?name=" + mi.Name;
                if (!returnUrl.IsNullOrEmpty()) { url += "&r=" + HttpUtility.UrlEncode(returnUrl); }

                url = HttpRuntime.AppDomainAppVirtualPath + url;


            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 925), Tuple.Create("\"", 936)
            
            #line 25 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
, Tuple.Create(Tuple.Create("", 932), Tuple.Create<System.Object, System.Int32>(url
            
            #line default
            #line hidden
, 932), false)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                    ");

            
            #line 27 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
               Write(nickName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 29 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

            
            #line 32 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
