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
}