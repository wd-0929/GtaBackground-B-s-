using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GtaBackground.Models
{
    public class MemberMarks
    {
        /// <summary>
        /// 会员号
        /// </summary>
        [Display(Name = "会员号")]
        public int? MemberId { get; set; }

        /// <summary>
        /// 标记名称
        /// </summary>
        [Display(Name = "标记名称")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "标记名称不能为空")]
        public string Title { get; set; }

        /// <summary>
        /// 标记简写
        /// </summary>
        [Display(Name = "标记简写")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "标记简写不能为空")]
        public string ShortTitle { get; set; }

        /// <summary>
        /// 标记类型
        /// </summary>
        [Display(Name = "标记类型")]
        public MarkType MType { get; set; }

        /// <summary>
        /// 文字颜色
        /// </summary>
        [Display(Name = "文字颜色")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "文字颜色不能为空")]
        public string Foreground { get; set; }

        /// <summary>
        /// 背景颜色
        /// </summary>
        [Display(Name = "背景颜色")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "背景颜色不能为空")]
        public string Background { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        public int? Sort { get; set; } 

        /// <summary>
        /// Remark
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [Display(Name = "是否为订单类型")]
        public bool IsCancel { get; set; }
    }

}
