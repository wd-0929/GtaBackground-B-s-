using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace GtaBackground.BLL
{
    public class AuthenticationService
    {
        private const string memberCookieName = "userName";
        public AuthenticationService()
        {
        }
        public Account GetUser()
        {
            Account user = null;
            HttpCookie authCookie = FormsAuthentication.GetAuthCookie(memberCookieName, false);
            if (HttpContext.Current.Request.Cookies.AllKeys.Contains(authCookie.Name))
            {
                try
                {
                    authCookie = HttpContext.Current.Request.Cookies[authCookie.Name];
                    FormsAuthenticationTicket newTicket = FormsAuthentication.Decrypt(authCookie.Value);
                    user = ContractHelper.Deserialize<Account>(newTicket.UserData);
                }
                catch { }
            }
            if (user == null)
            {
                var account = AccountState.LoginUser;
                if (account != null)
                {
                    user = new Account()
                    {
                        AccountName = account.AccountName,
                        AccountPassword = account.AccountPassword,
                    };
                }
            }
            return user;
        }

    }
}