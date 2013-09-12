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
    }
}
