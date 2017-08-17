using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money02.Models;
using Money02.Repositories;
using Money02.Models.ViewModels;


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

        public IEnumerable<MoneyModel> GetAllData()
        {
            var source = _accountBookRep.LookupAll();

            var result = source.Select(m => new MoneyModel()
            {
                Id= m.Id,
                Category= ((Categories)m.Categoryyy).ToString(),
                Date =m.Dateee,
                Amount=m.Amounttt,
                Notes=m.Remarkkk                
            });            

            return result;
        }

        public void Create(AccountBook ActBook)
        {
            _accountBookRep.Create(ActBook);
        }

        public void Save()
        {
            _accountBookRep.Commit();
        }

        enum Categories
        {
            支出,
            收入,
        };
    }
}