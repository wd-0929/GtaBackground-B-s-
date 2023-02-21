using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GtaBackground.Models
{
    public class ApiDataResult
    { /// <summary>
      /// Api返回数据
      /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 成功或错误消息
        /// </summary>
        public string Message { get; set; }
    }
}