using NUnit.Framework;
using SeleniumFramework.Bethesda;

namespace SeleniumTests.BethesdaTests
{
    internal class LoginSignUpFormTests : BaseTestForBethesda
    {
        [Test, Order(1)]

        public static void SignUpEmailInputTurnsRedEnteringInvalidEmail()
        {
            string email = "email";
            string emailInputBorderColor = "rgb(235, 61, 26)";
            string country = "Lithuania";

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.ClickSignUpButton();
            LoginSignUpForm.SelectCountry(country);
            LoginSignUpForm.ClickCreateAccountButton();
            LoginSignUpForm.EnterEmail(email);

            Assert.That(LoginSignUpForm.EmailInputBorderColor(), Is.EqualTo(emailInputBorderColor));
        }

        [Test, Order(2)]

        public static void LoginUsingRandomUsernameAndPassword()
        {
            string username = "random";
            string password = "random";
            string expectedErrorMessage = "Incorrect username or password. Please try again.";

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.EnterUserName(username);
            LoginSignUpForm.EnterPassword(password);
            LoginSignUpForm.ClickLoginButton();

            Assert.That(LoginSignUpForm.ErrorMessageText(), Is.EqualTo(expectedErrorMessage));
        }

        [Test, Order(3)]

        public static void LoginWithValidCredentials()
        {
            string username = TestContext.Parameters.Get("bethesdaUsername");
            string password = TestContext.Parameters.Get("bethesdaPassword");

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.EnterUserName(username);
            LoginSignUpForm.EnterPassword(password);
            LoginSignUpForm.ClickLoginButton();

            Assert.That(LoginSignUpForm.VisibleUsernameIcon(), Is.EqualTo(username));
        }
    }
}
