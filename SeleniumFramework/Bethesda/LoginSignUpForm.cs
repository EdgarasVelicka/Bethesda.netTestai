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
            Common.SendKeysToElement(Locators.LoginSignUp.EnterEmail, email);
        }

        public static void ClickButtonContinue()
        {
            Common.ClickElement(Locators.LoginSignUp.ButtonContinue);
        }

        public static string EmailInputBorderColor()
        {
            return Common.GetElementCssPropertyValue(Locators.LoginSignUp.InputBorderColor, "border");
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
            return Common.GetElementText(Locators.LoginSignUp.ErrorMessage);
        }

        public static string VisibleUsernameIcon()
        {
            return Common.GetElementText(Locators.LoginSignUp.UsernameVisible);
        }

        public static void ClearCountryInput()
        {
            Common.ClickElement(Locators.LoginSignUp.ClearCountryInput);
        }

        public static void SelectCountry(string country)
        {
            Common.SendKeysToElement(Locators.LoginSignUp.SelectCountry, country);
            Common.ClickElement(Locators.LoginSignUp.ClearCountryInput);
        }
    }
}
