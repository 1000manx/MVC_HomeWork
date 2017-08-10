using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Money01.Models.ViewModels
{
    public class MoneyListViewModel
    {       
        public List<Money> MyMoney { get; set; }
    }

    public class AddMoneyViewModel
    {
        public string Category { get; set; }

        public DateTime Date { get; set; }
       
        public int Amount { get; set; }
                
        public string Notes { get; set; }

    }
}