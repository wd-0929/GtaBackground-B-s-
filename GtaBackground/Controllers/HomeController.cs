using GtaBackground.BLL;
using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GtaBackground.Controllers
{
    public class HomeController : BaseController
    {
        private readonly AccountService _AccountService;

        public HomeController()
        {
            _AccountService = Factory.AccountService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Login(Account model)
        {
            var a = ApiResponse(x =>
              {
                  _AccountService.Login(model);
              });return RedirectToAction("MarksManage", "Datas");
        }
  
    }
}