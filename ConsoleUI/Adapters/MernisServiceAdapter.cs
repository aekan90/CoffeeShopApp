using Entities.Concrete;
using MernisKPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisKPS.KPSPublicSoapClient;

namespace ConsoleUI.Adapters
{ 
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool ChackIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            TCKimlikNoDogrulaResponse tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                (
                customer.NationalityId,
                customer.FirstName,
                customer.LastName,
                customer.DateOfBirth.Year
                ).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        }
    }
}
