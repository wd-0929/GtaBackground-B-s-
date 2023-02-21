using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GtaBackground.BLL
{
    public class AccountState
    {
        private const string LOGIN_USER = "SESSION_KEY_LOGIN_USER";
        /// <summary>
        /// 获取登录用户IP
        /// </summary>
        public static string LoginUserIP
        {
            get
            {
                var ip = "";
                var request = System.Web.HttpContext.Current.Request;
                if (!string.IsNullOrEmpty(request.ServerVariables["HTTP_VIA"]))
                {
                    ip = Convert.ToString(request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
                }
                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.UserHostAddress;
                }
                return ip;
            }
        }

        /// <summary>
        /// 是否已登录
        /// </summary>
        public static bool IsLogin
        {
            get { return LoginUser != null; }
        }

        /// <summary>
        /// 设置或获取登录用户
        /// </summary>
        public static Account LoginUser
        {
            set
            {
                System.Web.HttpContext.Current.Session[LOGIN_USER] = value;
                if (value == null)
                {
                    System.Web.HttpContext.Current.Session.Remove(LOGIN_USER);
                }
            }
            get
            {
                try
                {
                    return System.Web.HttpContext.Current.Session[LOGIN_USER] as Account;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 注销登录信息
        /// </summary>
        public static void SignOut()
        {
            LoginUser = null;
        }
    }
}