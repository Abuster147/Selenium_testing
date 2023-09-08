using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

        try
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));

            IWebElement firstNameInput = wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(By.Id("fname"));
                if (element.Displayed)
                {
                    return element;
                }
                return null;
            });

            firstNameInput.SendKeys("Akash");

            IWebElement lastNameInput = wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(By.Id("lname"));
                if (element.Displayed)
                {
                    return element;
                }
                return null;
            });

            lastNameInput.SendKeys("Kumar");

            IWebElement mobileNumberInput = wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(By.Id("mobile"));
                if (element.Displayed)
                {
                    return element;
                }
                return null;
            });

            mobileNumberInput.SendKeys("1234567890");
       
            IWebElement emailInput = wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(By.Id("email"));
                if (element.Displayed)
                {
                    return element;
                }
                return null;
            });

            emailInput.SendKeys("akash@example.com");

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));

            driver.Quit();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
