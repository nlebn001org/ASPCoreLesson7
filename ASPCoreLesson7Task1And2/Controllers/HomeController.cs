using ASPCoreLesson7Task1And2.Repository;
using ASPCoreLesson7Task1And2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreLesson7Task1And2.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            People people = new People();
            people.Customers = CustomerFactory.CreateCustomer(3);
            people.Workers = WorkerFactory.CreateWorker(3);
            return View(people);
        }
    }
}
