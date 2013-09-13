using System.Web.Mvc;

namespace Resources.Web.Controllers
{
    public class SignUpController : Controller
    {
        public ViewResult SignUp()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult SignUp(SignUpFormCollection signUpFormCollection)
        {
            var redirectResult = Redirect("Success");
            return redirectResult;
        }

        public ViewResult Success()
        {
            return View();
        }
    }
}