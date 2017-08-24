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
        //[Range(0,1,ErrorMessage ="Please select a option.")]
        public int Category { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:###,###}")]
        [Display(Name = "金額")]
        public int Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]

        [Display(Name = "日期")]
        [IsDayValidation(ErrorMessage ="Must be less than or equl today.")]        
        public System.DateTime Date { get; set; }

        [Required]
        [Display(Name = "備註")]
        [DataType(DataType.Text)]
        [StringLength(100,ErrorMessage ="Must br less than or equl 100 words.")]
        public string Remark { get; set; }

        public int CurrentPage { get; set; }
    }

    public class IsDayValidation:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime d = Convert.ToDateTime(value);
            if (d.Day > DateTime.Now.Day)
            {
                return false;
            }            
            return true;
        }
        
    }
}