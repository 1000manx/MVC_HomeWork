using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money02.Models;
using Money02.Repositories;
using Money02.Models.ViewModels;
using PagedList;


namespace Money02.Models
{
    public class MoneyService
    {
        private readonly IRepository<AccountBook> _accountBookRep;
        private readonly IUnitOfWork _uniOfWork;

        public MoneyService(IUnitOfWork unitOfWork)
        {
            _uniOfWork = unitOfWork;
            _accountBookRep = new Repository<AccountBook>(unitOfWork);
        }

        public List<SelectListItem>  GetCategoryItems()
        {
            List<SelectListItem> items = new List<SelectListItem>()
            {
                new SelectListItem {Text="請選擇", Value="" },
                new SelectListItem {Text="支出", Value="0" },
                new SelectListItem {Text="收入", Value="1" }
            };

            return items;
        }    

        public IPagedList<MoneyModel> DisplayPagedData(int currentPage, int pageSize)
        {
            var source = _accountBookRep.LookupAll().OrderByDescending(m => m.Dateee);

            var result = source.Select(m => new MoneyModel()
            {
                Id = m.Id,                
                Category = m.Categoryyy,
                Date = m.Dateee,
                Amount = m.Amounttt,
                Notes = m.Remarkkk
            });

            return result.ToPagedList(currentPage, pageSize);
        }

        public void Create(MoneyCreateViewModel MoneyCreateViewModel)
        {
            var ActBook = new AccountBook
            {
                Id=MoneyCreateViewModel.Id,
                Categoryyy=MoneyCreateViewModel.Category,
                Amounttt = MoneyCreateViewModel.Amount,
                Dateee=MoneyCreateViewModel.Date,
                Remarkkk=MoneyCreateViewModel.Remark
            };      

            _accountBookRep.Create(ActBook);
        }

        public void Save()
        {
            _accountBookRep.Commit();
        }
             
    }
}