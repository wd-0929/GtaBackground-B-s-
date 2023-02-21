using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GtaBackground.BLL
{
    public class AccountService
    {
        /// <summary>
        /// 退出
        /// </summary>
        public void Logout()
        {
            AccountState.LoginUser = null;
            if (System.Web.HttpContext.Current.Request.Path.IndexOf("Home") < 0)
            {
                // 避免重定向循环
                System.Web.HttpContext.Current.Response.Redirect("~/Home/Index");
            }
        }
        public void Login(Account model)
        {

            // 保存会话
            AccountState.LoginUser = model;
        }
    }
}