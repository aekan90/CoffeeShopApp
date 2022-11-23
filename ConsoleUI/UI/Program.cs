using ConsoleUI.Adapters;
using ConsoleUI.Business.Abstract;
using ConsoleUI.Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("----------------------------------------------------------------");
        BaseCustomerManager _starbuckscustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        _starbuckscustomerManager.Save(
            new Customer
            {
                DateOfBirth = new DateTime(1990, 1, 15),
                FirstName = "Atıf Ertuğrul",
                LastName = "Kan",
                NationalityId = 40399173916
            });
        Console.WriteLine("----------------------------------------------------------------");
        BaseCustomerManager _nerocustomerManager = new NeroCustomerManager();
        _nerocustomerManager.Save
            (
            new Customer()
            {
                DateOfBirth = new DateTime(1991, 02, 19),
                FirstName = "Gözde",
                LastName = "Kan",
                NationalityId = 20225242368
            }
            );
        Console.WriteLine("----------------------------------------------------------------");
    }
}