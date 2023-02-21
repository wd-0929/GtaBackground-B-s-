using GtaBackground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GtaBackground.DAL
{
    public class MarksDAL : BaseDAL
    {
        /// <summary>
        /// 获取到系统的标记
        /// </summary>
        /// <returns></returns>
        public List<MemberMarks> GetList()
        {
            var sql = @"select * from MemberMarks where MemberId is null";

            return _dapperUtil.GetModelList<MemberMarks>(sql);
        }
        public bool Save(MemberMarks member)
        {
            var sql = @"insert MemberMarks (Title,ShortTitle,MType,Foreground,Background,Sort,Remark,IsCancel) values (@Title,@ShortTitle,@MType,@Foreground,@Background,@Sort,@Remark,@IsCancel)";

            return _dapperUtil.ExecuteCommand(sql, new
            {
                Title = member.Title,
                ShortTitle = member.ShortTitle,
                MType = member.MType,
                Foreground = member.Foreground,
                Background = member.Background,
                Sort = member.Sort,
                Remark = member.Remark,
                IsCancel = member.IsCancel,
            });
        }
    }
}
