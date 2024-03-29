﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Business.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Yeni Müşterimiz : ["+customer.FirstName+" "+customer.LastName +"] VeriTabanına kayıt edildi.");
        }
    }
}
