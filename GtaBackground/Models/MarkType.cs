using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GtaBackground.Models
{
    public enum MarkType : byte
    {
        /// <summary>
        /// 普通标记
        /// </summary>
        [Display(Name = "订单普通标记")]
        OrderNormal = 0,
        /// <summary>
        /// 异常标记
        /// </summary>
        [Display(Name = "订单异常标记")]
        OrderException = 1,
        /// <summary>
        /// 产品标记
        /// </summary>
        [Display(Name = "产品标记")]
        ProductMark = 2
    }
}