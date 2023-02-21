using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GtaBackground.Models
{
    public class Account
    {
        [Display(Name = "账户名")]
        public string AccountName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string AccountPassword { get; set; }
    }
}
