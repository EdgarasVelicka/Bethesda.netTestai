namespace SeleniumFramework.Bethesda
{
    public class BethesdaHomePage
    {
        public static void Open()
        {
            Common.OpenPage("https://bethesda.net");
        }
        public static void ClickChangeCookiePreferencesButton()
        {
            Common.ClickElement(Locators.BethesdaHomePage.ChangeCookiePreferencesButton);
        }

        public static void ClickConfirmCookieChoices()
        {
            Common.ClickElement(Locators.BethesdaHomePage.ConfirmCookieChoicesButton);
        }

        public static void ClickLogInSignUpButton()
        {
            Common.ClickElement(Locators.BethesdaHomePage.LogInSignUpButton);
        }

        public static void ClickSearchIcon()
        {
            Common.ClickElement(Locators.BethesdaHomePage.SearchIcon);
        }

        public static void EnterSearchText(string enterText)
        {
            Common.SendKeysToElement(Locators.BethesdaHomePage.SearchInput, enterText);
        }

        public static void ClickSearchButton()
        {
            Common.ClickElement(Locators.BethesdaHomePage.SearchButton);
        }

        public static void ClickSearchResultsInHelp()
        {
            Common.ClickElement(Locators.BethesdaHomePage.Help);
        }

        public static string ActualSearchResults()
        {
            return Common.GetElementText(Locators.BethesdaHomePage.SearchResultsInHelp);
        }

        public static void ClickMenuIcon()
        {
            Common.ClickElement(Locators.BethesdaHomePage.MenuIcon);
        }

        public static void ClickElderScrollsVIcon()
        {
            Common.ClickElement(Locators.BethesdaHomePage.ElderScrollsVIcon);
            SwitchWindowControl();
        }

        public static void SwitchWindowControl()
        {
            string currentHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParentWindowByHandle(currentHandle);
        }
    }
}
