using GtaBackground.DAL;
using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GtaBackground.BLL
{
    public class MarkBLL
    {
        private MarksDAL marksDAL;
        public MarkBLL()
        {
            marksDAL = new MarksDAL();
        }
        public List<MemberMarks> GetList()
        {
            return marksDAL.GetList();
        }
        public bool Save(MemberMarks memberMarks)
        {
            return marksDAL.Save(memberMarks);
        }
    }
}