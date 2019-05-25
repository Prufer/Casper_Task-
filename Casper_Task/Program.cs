using System;
using OpenQA.Selenium;
using NUnit.Framework;
using Casper_Task.BaseClass;
using OpenQA.Selenium.Support.UI;
namespace Casper_Task
{
    public class Program : BaseTest
    {
        static void Main(string[] args)
        {
        }


        [Test]
        public void CreatePatient()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Patienten anlegen')]"))).Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var FirstName = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@formcontrolname='first_name']")));
            FirstName.Click();
            FirstName.SendKeys("Sanith");

            
            IWebElement LastName = driver.FindElement(By.XPath("//*[@formcontrolname='last_name']"));
            LastName.SendKeys("Kobe");

            IWebElement date = driver.FindElement(By.XPath("//span[contains(.,'Tag')]"));
            date.Click();
            //var selectElement = new SelectElement(date);
            //selectElement.SelectByIndex(4);
            IWebElement DateDropDown = driver.FindElement(By.XPath("//mat-option[3]/span"));
            DateDropDown.Click();


            Boolean invisible = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//mat-option[3]/span")));

            if (invisible)
            {
                IWebElement month = driver.FindElement(By.XPath("//span[contains(.,'Monat')]"));
                month.Click();
            }
            IWebElement MonthDropDown = driver.FindElement(By.XPath("//mat-option[5]/span"));
            DateDropDown.Click();
      
    

            //IWebElement Year = driver.FindElement(By.XPath("//span[contains(.,'Jahr')]"));
            //date.Click();
            //IWebElement YearDropDown = driver.FindElement(By.XPath("//mat-option[1]/span"));
            //DateDropDown.Click();

            //IWebElement Country = driver.FindElement(By.XPath("//span[contains(.,'Land')]"));
            //date.Click();
            //IWebElement CountryDropDown = driver.FindElement(By.XPath("//mat-option[1]/span"));
            //DateDropDown.Click();


            driver.Quit();


        }

    }
    }

