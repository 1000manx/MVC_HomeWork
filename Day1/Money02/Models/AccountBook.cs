﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Money02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountBook
    {
        public System.Guid Id { get; set; }
                        
        [Required]
        [Display(Name = "類別")]
        public int Categoryyy { get; set; }
           
        [Required]
        [DisplayFormat(DataFormatString = "{0:###,###}")]
        [Display(Name = "金額")]
        public int Amounttt { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "日期")]
        public System.DateTime Dateee { get; set; }

        [Required]
        [Display(Name = "備註")]        
        public string Remarkkk { get; set; }
    }
}
