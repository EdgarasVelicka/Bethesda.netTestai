namespace SeleniumFramework.Bethesda
{
    internal class Locators
    {
        internal class BethesdaHomePage
        {
            internal static string ChangeCookiePreferencesButton = "//*[@id='onetrust-pc-btn-handler']";
            internal static string ConfirmCookieChoicesButton = "(//*[@tabindex='0'])[28]";
            internal static string LogInSignUpButton = "(//*[@aria-haspopup='dialog'])[2]";
            internal static string SearchIcon = "//*[@href='/en/search']";
            internal static string SearchInput = "//*[@id='search-input']";
            internal static string SearchButton = "(//*[@role='button'])[1]";
            internal static string Help = "(//*[@role='button'])[5]";
            internal static string SearchResultsInHelp = "//*[@id='_bnContent']//header";
            internal static string MenuIcon = "//*[@id='global-hamburger-menu']";
            internal static string ElderScrollsVIcon = "(//*[@target='_blank'])[25]";
        }

        internal class LoginSignUp
        {
            internal static string SignUpButton = "//*[@id='createAccountBtn']";
            internal static string SelectCountry = "//*[@id='country-field']";
            internal static string ClearCountryInput = "//*[@class='MuiAutocomplete-endAdornment']";
            internal static string CreateAccountButton = "//*[@id='signupBtn']/span";
            internal static string EnterEmail = "//*[@id='optin-email-field']";
            internal static string ButtonContinue = "(//*[@class='MuiButton-label'])[5]";
            internal static string InputBorderColor = "//*[@formname='joinForm']/div";
            internal static string UserName = "//*[@id='username-input']";
            internal static string Password = "//*[@id='password-input']";
            internal static string LoginButton = "//*[@id='submitLoginBtn']";
            internal static string ErrorMessage = "//*[@role='status']";
            internal static string UsernameVisible = " //*[@class='jss62']";
        }
    }
}
