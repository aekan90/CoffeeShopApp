using ConsoleUI.Adapters;
using ConsoleUI.Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Business.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }


        public override void Save(Customer customer)
        {
            if (_personCheckService.ChackIfRealPerson(customer))
                base.Save(customer);
            throw new Exception("Geçerli bir kişi değil");
        }
    }
}
