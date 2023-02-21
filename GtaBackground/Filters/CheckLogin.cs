using GtaBackground.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GtaBackground.Filters
{
    public class CheckLogin : ActionFilterAttribute
    {
        bool _IsCheckLogin = false;
        readonly AccountService _AccountService;

        public CheckLogin(bool checkLogin)
        {
            _IsCheckLogin = checkLogin;
            _AccountService = Factory.AccountService;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (_IsCheckLogin && !AccountState.IsLogin)
            {
                _AccountService.Logout();
            }
            base.OnActionExecuting(filterContext);
        }
    }
}