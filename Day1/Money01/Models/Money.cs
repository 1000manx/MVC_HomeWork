﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Money01.Models
{  
    public class Money
    {
        [Display(Name="類別")]
        public string Category { get; set; }

        [Display(Name = "日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

       
        [DisplayFormat(DataFormatString = "{0:###,###}")]
        [Display(Name = "金額")]
        public int Amount { get; set; }

        [Display(Name = "備註")]
        public string Notes { get; set; }
    }
}