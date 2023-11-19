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
            Common.ClickElement(Locators.BethesdaHome.ChangeCookiePreferencesButton);
        }

        public static void ClickConfirmCookieChoices()
        {
            Common.ClickElement(Locators.BethesdaHome.ConfirmCookieChoicesButton);
        }
    }
}
