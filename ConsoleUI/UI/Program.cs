using ConsoleUI.Business.Abstract;
using ConsoleUI.Business.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {

        BaseCustomerManager customerManager = new NeroCustomerManager();
        customerManager.Save(new Entities.Concrete.Customer
        {
            DateOfBirth = new DateTime(1990, 1, 15),
            FirstName = "Atıf Ertuğrul",
            LastName = "Kan",
            NationalityId = 40399173916,
        });
    }
}