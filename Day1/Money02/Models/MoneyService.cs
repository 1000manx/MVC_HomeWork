using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        enum Categories
        {
            支出,
            收入,
        };
    }
}