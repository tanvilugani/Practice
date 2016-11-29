using ModelBindingValidState.Models;
using System.Web.Mvc;

namespace ModelBindingValidState.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            var customer = new Customer();

            customer = customer.GetCustomer();

            var modelState = ModelState; //does not register any validation failure if initial value of age is 17.

            return View(customer);
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            var modelState = ModelState; //ModelState is readonly.

            var customer = new Customer();

            //For adding custom erros. May write a logic and then bind it.
            ModelState.AddModelError("xyz", "Name should always be error"); //Can put name of the field so as to work
            //in case of ValidationMessageFor.

            //If this in uncommented, the UpdateModel throws error since isvalid is false.
            //UpdateModel(customer); //Updates the customer model if no error received.

            //var isModelUpdated = TryUpdateModel(customer);

            return View();
        }

    }
}
