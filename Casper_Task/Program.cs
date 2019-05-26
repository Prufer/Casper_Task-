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

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Patienten anlegen')]"))).Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var FirstName = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@formcontrolname='first_name']")));
            FirstName.Click();
            FirstName.SendKeys("Bruce");

            
            IWebElement LastName = driver.FindElement(By.XPath("//*[@formcontrolname='last_name']"));
            LastName.SendKeys("Wayne");

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

            var monthdropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'April')]")));
            monthdropdown.Click();

         if (invisible)
            {
                IWebElement Year = driver.FindElement(By.XPath("//span[contains(.,'Jahr')]"));
                Year.Click();

            }


            IWebElement YearDropDown = driver.FindElement(By.XPath("//mat-option[1]/span"));
            YearDropDown.Click();

            IJavaScriptExecutor jse6 = driver as IJavaScriptExecutor;
            jse6.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");

            
            if (invisible)
            {

                var Country = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Land')]")));
            Country.Click();
            }

            IWebElement CountryDropDown = driver.FindElement(By.XPath("//mat-option[1]/span"));
            CountryDropDown.Click();


            IWebElement Submitbutton = driver.FindElement(By.XPath("//button[@class='divider-right mat-ripple caspar-button']"));
            Submitbutton.Click();


            //Boolean ele = driver.SwitchTo().ActiveElement().Equals(driver.FindElement(By.XPath("//*[@aria-labelledby='mat-dialog-title-0']")));

            //WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            string tempuserID = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-dialog-container[@id='mat-dialog-0']/app-new-user-dialog/div[2]/div[3]/div[3]/div[2]"))).Text;


            //WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            string TempPassword = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-dialog-container[@id='mat-dialog-0']/app-new-user-dialog/div[2]/div[3]/div[4]/div[2]"))).Text;
            
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Schließen')]"))).Click();


            //IWebDriver profilebutton = driver.FindElement(By.XPath("//span[contains(text(),'AT')]"));
            IWebElement profilebutton1 = driver.FindElement(By.XPath("//span[contains(text(),'AT')]"));
            profilebutton1.Click();

            IWebElement SignOutText = driver.FindElement(By.XPath("//div/div/button[2]"));
            SignOutText.Click();



            


            if (invisible)
            {
                var firstname2 = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("//*[@formcontrolname='login']")));
                firstname2.SendKeys(tempuserID);
            }

            IWebElement PasswordText = driver.FindElement(By.XPath("//*[@placeholder='Passwort']"));
            PasswordText.SendKeys(TempPassword);

            IWebElement SigninButton = driver.FindElement(By.XPath("/html/body/app-root/div/ui-view/ng-component/ui-view/app-sign-in/div/div[2]/form/div[3]/div/button/span"));
            SigninButton.Click();




            driver.Quit();





        }
        
    }
    }

