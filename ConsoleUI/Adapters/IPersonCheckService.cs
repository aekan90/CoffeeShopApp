using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Adapters
{
    public interface IPersonCheckService
    {
        public bool ChackIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
