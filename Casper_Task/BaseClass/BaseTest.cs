using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper_Task.BaseClass
{
    public class BaseTest
    {

        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://beta.caspar-health.com/de/#/user/sign_in";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("mat-input-0"))).SendKeys("IXE0865");

            IWebElement PasswordText = driver.FindElement(By.XPath("//input[@id='mat-input-1']"));
            PasswordText.SendKeys("78350619");

            IWebElement SigninButton = driver.FindElement(By.XPath("/html/body/app-root/div/ui-view/ng-component/ui-view/app-sign-in/div/div[2]/form/div[3]/div/button/span"));
            SigninButton.Click();
            
        }

        //[OneTimeTearDown]
        //public void Close()
        //{
        //    driver.Quit();
        //}
    }
}
