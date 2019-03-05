using System;
using OpenQA.Selenium;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafetownsend.Pages;
using System.Configuration;
using System.Runtime.InteropServices;

namespace cafetownsend.Steps
{

    [Binding]
   public  class Login
    {

        IWebDriver currentdriver = null;
        LoginPage page = new LoginPage();
        private object ngDriver;

        public object HomePage { get; private set; }

        [Given(@"I opened the Login Page*")]
        public void IopenedtheLoginPage ()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            currentdriver = Browser.Current;
        }

        [Given(@"I Typed the (.*) and (.*)")]

        public void GivenItypedtheand(string username, string password)

        {
            page.Loginpage(username, password);
        }

        [When(@"I click login*")]

        public void WhenIclicklogin()

        {
            page.LoginButton = new LoginPage(ngDriver)
                .LoginB();
        }


        [Then(@"then i should see the home page*")]

        public void Thenthenishouldseethehomepage()

        {
     
        }
    }
}
