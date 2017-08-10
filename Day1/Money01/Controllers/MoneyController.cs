using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money01.Models;
using Money01.Models.ViewModels;

namespace Money01.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {            
            //ViewModel
            MoneyListViewModel MoneyList = new MoneyListViewModel();
           
            MoneyList.MyMoney = DataSource();

            return View(MoneyList);
        }

        [HttpPost]
        public ActionResult AddItem()
        {



            return View();
        }

       

        private List<Money> DataSource()
        {            
            List<Money> listMyMoney = new List<Money>();
            listMyMoney.Add(new Money() { Category = "支出", Date = Convert.ToDateTime("2016-01-01"), Amount = 300, Notes = "早餐" });
            listMyMoney.Add(new Money() { Category = "支出", Date = Convert.ToDateTime("2016-01-02"), Amount = 1600, Notes = "午餐" });
            listMyMoney.Add(new Money() { Category = "支出", Date = Convert.ToDateTime("2016-01-03"), Amount = 800, Notes = "晚餐" });

            return listMyMoney;
        }
    }

    
}