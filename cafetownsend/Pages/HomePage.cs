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
    class log
    {


        [FindsBy(How = How.Id, Using = "bAdd")]
        public IWebElement CreateEmployeeButton { get; set; }

        [FindsBy(How = How.Id, Using = "bEdit")]
        public IWebElement EditEmployeeButton { get; set; }

        [FindsBy(How = How.Id, Using = "bDelete")]
        public IWebElement DeleteEmployeeButton { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "employee in employees")]
        public IList<IWebElement> Employees { get; set; }

        [FindsBy(How = How.Id, Using = "greetings")]
        public IWebElement Greetings { get; set; }

        }
    }


