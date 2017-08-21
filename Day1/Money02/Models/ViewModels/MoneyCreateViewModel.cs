using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Money02.Models.ViewModels
{
    public class MoneyCreateViewModel
    {
        public System.Guid Id { get; set; }

        [Required]
        [Display(Name = "類別")]
        public int Category { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:###,###}")]
        [Display(Name = "金額")]
        public int Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "日期")]
        public System.DateTime Date { get; set; }

        [Required]
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}