using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GtaBackground.BLL
{
    public static class Factory
    {
        private static HashSet<KeyValuePair<Type, object>> has = null;
        static Factory()
        {
            has = new HashSet<KeyValuePair<Type, object>>();
        }
        static AccountService _AccountService;
        public static AccountService AccountService
        {
            get { return _AccountService ?? (_AccountService = new AccountService()); }
        }
        static AuthenticationService _AuthenticationService;
        public static AuthenticationService AuthenticationService
        {
            get { return _AuthenticationService ?? (_AuthenticationService = new AuthenticationService()); }
        }
    }
}