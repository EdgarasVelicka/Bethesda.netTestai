namespace SeleniumFramework.Bethesda
{
    internal class Locators
    {
        internal class BethesdaHome
        {
            internal static string ChangeCookiePreferencesButton = "//*[@id='onetrust-pc-btn-handler']";
            internal static string ConfirmCookieChoicesButton = "(//*[@tabindex='0'])[28]";
            internal static string LogInSignUpButton = "(//*[@aria-haspopup='dialog'])[2]";
        }
        internal class LoginSignUp
        {
            internal static string SignUpButton = "//*[@id=\"createAccountBtn\"]";
            internal static string SelectCountry = "//*[@id=\"country-field\"]";
            internal static string ClearCountryInput = "//*[@class='MuiAutocomplete-endAdornment']";
            internal static string CreateAccountButton = "//*[@id=\"signupBtn\"]/span";
            internal static string EnterEmail = "//*[@id=\"optin-email-field\"]";
            internal static string ButtonContinue = "(//*[@class='MuiButton-label'])[5]";
            internal static string InputBorderColor = "//*[@formname='joinForm']/div";
            internal static string UserName = "//*[@id=\"username-input\"]";
            internal static string Password = "//*[@id=\"password-input\"]";
            internal static string LoginButton = "//*[@id=\"submitLoginBtn\"]";
            internal static string ErrorMessage = "(//*[@role='status'])[2]";
            internal static string UsernameVisible = " //*[@class='jss62']";
        }
    }
}
