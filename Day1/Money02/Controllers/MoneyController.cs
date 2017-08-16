using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money02.Models;
using Money02.Models.ViewModels;
using Money02.Repositories;

namespace Money02.Controllers
{
    public class MoneyController : Controller
    {
        private readonly MoneyService _moneyService;

        public MoneyController()
        {
            var uniOfWork = new EFUnitOfWork();
            _moneyService = new MoneyService(uniOfWork);
        }


        // GET: Money
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(AddMoneyViewModel NewMoney)
        {         
            return View(); 
        }

        [ChildActionOnly]
        public ActionResult ShowMoneyList()
        {
            ShowMoneyListViewModel MoneyList = new ShowMoneyListViewModel();            
            var source = _moneyService.GetAllData();
            MoneyList.MyMoney = source.ToList();

            return View(MoneyList);
        }
    }
}