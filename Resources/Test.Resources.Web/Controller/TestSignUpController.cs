using System.Web.Mvc;
using NUnit.Framework;
using Resources.Web.Controllers;

namespace Test.Resources.Web.Controller
{
    [TestFixture]
    public class TestSignUpController
    {
        [Test]
        public void SignUp_get_method_returns_a_view()
        {
            var signUpController = new SignUpController();

            var viewResult = signUpController.SignUp();

            Assert.That(viewResult, Is.Not.Null);
        }

        [Test]
        public void SignUp_get_view_has_ViewName_set_to_Index()
        {
            var signUpController = new SignUpController();

            var viewResult = signUpController.SignUp();

            Assert.That(viewResult.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void SignUp_post_returns_RedirectToRouteResult()
        {
            var signUpController = new SignUpController();

            var actionResult = signUpController.SignUp(null);

            Assert.That(actionResult, Is.Not.Null);
            Assert.That(actionResult, Is.TypeOf<RedirectResult>());
        }

        [Test]
        public void SignUp_post_redirects_to_Success_view()
        {
            var signUpController = new SignUpController();

            var actionResult = (RedirectResult) signUpController.SignUp(null);

            Assert.That(actionResult.Url, Is.EqualTo("Success"));
        }

        [Test]
        public void Success_action_returns_ViewResult()
        {
            var signUpController = new SignUpController();

            var viewResult = signUpController.Success();

            Assert.That(viewResult, Is.Not.Null);
        }
    }
}
