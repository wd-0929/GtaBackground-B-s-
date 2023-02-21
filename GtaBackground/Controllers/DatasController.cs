using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GtaBackground.Controllers
{
    [Filters.CheckLogin(true)]
    public class DatasController : BaseController
    {
        private DAL.MarksDAL marksDAL;
        public DatasController() 
        {
            marksDAL = new DAL.MarksDAL();
        }
        public ActionResult MarksManage()
        {
            return View("", marksDAL.GetList());
        }
        public ActionResult CreateMember()
        {
            return View("CreateMember");
        }
        public ActionResult Submit(MemberMarks memberMarks)
        {
            try
            {
                if (marksDAL.Save(memberMarks))
                {
                    return Content("<script>alert('保存成功');windonw.location.href=\"../DatasController/MarksManage\"</script> ");
                }
                else
                {
                    return Content("<script>alert('保存失败，请重新操作');history.go(-1);</script> ");
                }
            }
            catch (Exception ex)
            {
                return Content($"<script>alert('{ex.Message}');history.go(-1);</script> ");
            }
        }
    }
}