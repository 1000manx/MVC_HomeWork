using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money02.Models;
using Money02.Models.ViewModels;
using Money02.Repositories;
using PagedList;

namespace Money02.Controllers
{
    public class MoneyController : Controller
    {
        private int pageSize = 10;
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
             
        public ActionResult Create()
        {
            ViewBag.Category = _moneyService.GetCategoryItems();

            ShowMoneyListViewModel MoneyList = new ShowMoneyListViewModel();
            MoneyList.MyMoney = _moneyService.DisplayPagedData(1, pageSize);
            ViewData["MoneyData"] = MoneyList;

            return View();
        }

        [HttpPost]
        public ActionResult Create(MoneyCreateViewModel NewMoney)
        {
            if (ModelState.IsValid)
            {
                NewMoney.Id = Guid.NewGuid();                
                _moneyService.Create(NewMoney);
                _moneyService.Save();                
            }

            ViewBag.Category = _moneyService.GetCategoryItems();

            ShowMoneyListViewModel MoneyList = new ShowMoneyListViewModel();
            MoneyList.MyMoney = _moneyService.DisplayPagedData(1, pageSize);
            ViewData["MoneyData"] = MoneyList;

            return View();            
        }

        [HttpPost]
        public ActionResult ShowMoneyList(int? page)
        {          
            var pageIndex = page ?? 1;

            ShowMoneyListViewModel MoneyList = new ShowMoneyListViewModel();
            MoneyList.MyMoney = _moneyService.DisplayPagedData(pageIndex, pageSize);

            return PartialView("_ShowMoneyList", MoneyList);
        }      

        
    }
}