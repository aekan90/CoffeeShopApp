using ConsoleUI.Adapters;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Business.Concrete
{
    public class CustomerCheckManager : IPersonCheckService
    {
        public bool ChackIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return true;
        }
    }
}
