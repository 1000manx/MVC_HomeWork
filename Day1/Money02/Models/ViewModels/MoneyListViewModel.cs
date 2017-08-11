using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Money02.Models.ViewModels
{
    public class ShowMoneyListViewModel
    {
        public List<MoneyModel> MyMoney { get; set; }
    }

    public class AddMoneyViewModel
    {
        [Display(Name = "類別")]
        public string Category { get; set; }

        [Display(Name = "日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Display(Name = "金額")]
        public int Amount { get; set; }

        [Display(Name = "備註")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

    }
}