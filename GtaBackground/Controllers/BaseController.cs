using GtaBackground.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GtaBackground.Controllers
{
    public abstract class BaseController : Controller
    {

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="requestContext"></param>
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.User = Factory.AuthenticationService.GetUser();
            if (!Request.IsAjaxRequest() && Request.IsAuthenticated)
            {
            }
            base.OnActionExecuting(filterContext);
        }

        protected virtual JsonResult JsonFail(string errorMessage)
        {
            return Json(new { Sucess = false, Message = errorMessage });
        }

        protected virtual JsonResult JsonFail<T>(string errorMessage, T data)
        {
            return Json(new { Sucess = false, Message = errorMessage, Data = data });
        }

        protected virtual JsonResult JsonSucess<T>(T data)
        {
            return Json(new { Sucess = true, Data = data });
        }
        protected JsonResult ApiResponse(Action<Models.ApiDataResult> action)
        {
            var apiRes = new Models.ApiDataResult();
            var jsonRes = new JsonResult() { Data = apiRes };
            try
            {
                action(apiRes);
                apiRes.Success = true;
                return jsonRes;
            }
            catch (Exception ex)
            {
                apiRes.Success = false;
                apiRes.Message = ex.Message;
                return jsonRes;
            }
        }
    }
}