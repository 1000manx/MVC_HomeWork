using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money02.Models;
using Money02.Models.ViewModels;

namespace Money02.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {



            return View();
        }


        [HttpPost]
        public ActionResult Index(AddMoneyViewModel NewMoney)
        {
            /*
            ShowMoneyListViewModel MoneyList = new ShowMoneyListViewModel();
            List<MoneyModel> listMyMoney = new List<MoneyModel>();
            listMyMoney.Add(new MoneyModel() { Category = NewMoney.Category, Date = NewMoney.Date, Amount = NewMoney.Amount, Notes = NewMoney.Notes });
            MoneyList.MyMoney = listMyMoney;            
            return View(MoneyList);*/

            return View(); 
        }

        [ChildActionOnly]
        public ActionResult ShowMoneyList()
        {
            ShowMoneyListViewModel MoneyList = new ShowMoneyListViewModel();

            MoneyList.MyMoney = DataSource();

            return View(MoneyList);
        }

        private List<MoneyModel> DataSource()
        {
            List<MoneyModel> listMyMoney = new List<MoneyModel>();
            listMyMoney.Add(new MoneyModel() { Category = "支出", Date = Convert.ToDateTime("2016-01-01"), Amount = 300, Notes = "早餐" });
            listMyMoney.Add(new MoneyModel() { Category = "支出", Date = Convert.ToDateTime("2016-01-02"), Amount = 1600, Notes = "午餐" });
            listMyMoney.Add(new MoneyModel() { Category = "支出", Date = Convert.ToDateTime("2016-01-03"), Amount = 800, Notes = "晚餐" });

            return listMyMoney;
        }

    }
}