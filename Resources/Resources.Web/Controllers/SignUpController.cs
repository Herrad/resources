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
            return RedirectToAction(null);
        }
    }
}