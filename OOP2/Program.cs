using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.NationalId = "1234567890";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54677";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "124465467";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
        }
    }
}
