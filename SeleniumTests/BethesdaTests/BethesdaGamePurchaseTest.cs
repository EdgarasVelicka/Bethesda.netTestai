using NUnit.Framework;
using SeleniumFramework.Bethesda;
using SeleniumFramework;

namespace SeleniumTests.BethesdaTests
{
    internal class BethesdaGamePurchaseTest : BaseTestForBethesda
    {
        [Test]

        public static void ConfirmThatSelectedGamePageIsOpened()
        {
            string username = TestContext.Parameters.Get("bethesdaUsername");
            string password = TestContext.Parameters.Get("bethesdaPassword");
            string expectedPageTitle = "The Elder Scrolls | Bethesda.net";

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.EnterUserName(username);
            LoginSignUpForm.EnterPassword(password);
            LoginSignUpForm.ClickLoginButton();
            BethesdaHomePage.ClickMenuIcon();
            BethesdaHomePage.ClickGameByTitle("The Elder Scrolls V: Skyrim Anniversary Edition");

            Assert.That(Driver.GetPageTitle, Is.EqualTo(expectedPageTitle));
        }
    }
}
