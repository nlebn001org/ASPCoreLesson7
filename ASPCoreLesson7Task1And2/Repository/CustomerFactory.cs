using ASPCoreLesson7Task1And2.Models;
using System.Collections.Generic;

namespace ASPCoreLesson7Task1And2.Repository
{
    public static class CustomerFactory
    {
        public static List<Customer> CreateCustomer(int count)
        {
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < count; i++)
                customers.Add(new Customer() { CustomerID = i, Name = $"CustomerName{i}", Surname = $"CustomerSurname{i}" });
            return customers;

        }

    }
}
