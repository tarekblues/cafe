using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cafetownsend.Pages
{
    class LoginPage
    {
        private object ngDriver;

        public LoginPage()
        {
            PageFactory.InitElements(Browser.Current, this);

        }

        public LoginPage(object ngDriver)
        {
            this.ngDriver = ngDriver;
        }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "user.name")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "user.password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > fieldset > button")]
        public IWebElement LoginButton { get; set; }

        internal void Loginpage(string username1, string username2)
        {
            throw new NotImplementedException();
        }

        internal void Loginpage(IWebElement loginButton)
        {
            throw new NotImplementedException();
        }

        internal IWebElement LoginB()
        {
            throw new NotImplementedException();
        }

        internal LoginPage Loginpage()
        {
            throw new NotImplementedException();
        }
    }

    }




    }

