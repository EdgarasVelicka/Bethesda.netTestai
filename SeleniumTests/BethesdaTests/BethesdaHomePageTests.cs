using NUnit.Framework;
using SeleniumFramework.Bethesda;
using SeleniumFramework;

namespace SeleniumTests.BethesdaTests
{
    internal class BethesdaHomePageTests : BaseTestForBethesda
    {
        [Test, Order(1)]

        public static void SearchResultsInHelpTab()
        {
            string enterText = "elder scrolls skyrim";
            string expectedSearchResultsInHelp = "10 Results for \"elder scrolls skyrim\" in Help";

            BethesdaHomePage.ClickSearchIcon();
            BethesdaHomePage.EnterSearchText(enterText);
            BethesdaHomePage.ClickSearchButton();
            BethesdaHomePage.ClickSearchResultsInHelp();

            Assert.That(BethesdaHomePage.ActualSearchResults, Is.EqualTo(expectedSearchResultsInHelp));
        }

        [Test, Order(2)]

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
            BethesdaHomePage.ClickElderScrollsVIcon();

            Assert.That(Driver.GetPageTitle, Is.EqualTo(expectedPageTitle));
        }
    }
}
