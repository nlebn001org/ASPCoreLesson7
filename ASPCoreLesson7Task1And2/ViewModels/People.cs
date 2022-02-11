using ASPCoreLesson7Task1And2.Models;
using System.Collections.Generic;

namespace ASPCoreLesson7Task1And2.ViewModels
{
    public class People
    {
        public List<Customer> Customers { get; set; }
        public List<Worker> Workers { get; set; }

    }
}
