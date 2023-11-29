using OpenQA.Selenium;

namespace SeleniumFramework.Bethesda
{
    public class LoginSignUpForm
    {
        public static void ClickSignUpButton()
        {
            Common.ClickElement(Locators.LoginSignUp.SignUpButton);
        }

        public static void ClickCreateAccountButton()
        {
            Common.ClickElement(Locators.LoginSignUp.CreateAccountButton);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeysToElement(Locators.LoginSignUp.EnterEmail, email + Keys.Enter);
        }

        public static string EmailInputBorderColor()
        {
            return Common.GetElementCssPropertyValue(Locators.LoginSignUp.InputBorderColor, "border-color");
        }

        public static void EnterUserName(string username)
        {
            Common.SendKeysToElement(Locators.LoginSignUp.UserName, username);
        }

        public static void EnterPassword(string password)
        {
            Common.SendKeysToElement(Locators.LoginSignUp.Password, password);
        }

        public static void ClickLoginButton()
        {
            Common.ClickElement(Locators.LoginSignUp.LoginButton);
        }

        public static string ErrorMessageText()
        {
            Common.WaitForElementToBeVisible(Locators.LoginSignUp.ErrorMessage);
            return Common.GetElementText(Locators.LoginSignUp.ErrorMessage);
        }

        public static string VisibleUsernameIcon()
        {
            Common.WaitForElementToBeVisible(Locators.LoginSignUp.UsernameVisible);
            return Common.GetElementText(Locators.LoginSignUp.UsernameVisible);
        }

        public static void SelectCountry(string country)
        {
            Common.WaitForElementToBeVisible(Locators.LoginSignUp.ClearCountryInput);
            Common.ClickElement(Locators.LoginSignUp.ClearCountryInput);
            Common.SendKeysToElement(Locators.LoginSignUp.SelectCountry, country);
            Common.ClickElement("//*[@class='MuiAutocomplete-popper']");
        }
    }
}
