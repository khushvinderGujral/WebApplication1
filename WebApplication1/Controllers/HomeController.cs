using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using WebApplication1.BusinessObjects;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Process(SubcriptionPaymentWay models)
        {
            bool Result = BusinessLogicLayer.BusinessRuleSystem.PaymentProcessingSystem(models.PaymentWay);

            if (Result)
            {
                models.successMessage = GetSuccessMessage(models.PaymentWay);
                ViewBag.IsSuccess = true;
            }
            return View("Index");
        }

        private string GetSuccessMessage(SubPaymentWay paymentWay)
        {
            string Name = Enum.GetName(typeof(SubPaymentWay), paymentWay);

            var dict = typeof(PaymentSuccessMesages)
                .GetFields(BindingFlags.Static | BindingFlags.Public)
                .ToDictionary(f => f.Name, f => f.GetValue(null));

            return dict.Single(x => x.Key == Name).Value.ToString();

        }
    }
}