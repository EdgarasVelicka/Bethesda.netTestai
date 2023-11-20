using NUnit.Framework;
using SeleniumFramework.Bethesda;

namespace SeleniumTests.BethesdaTests
{
    internal class BethesdSearchTest : BaseTestForBethesda
    {
        [Test]

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
    }
}
