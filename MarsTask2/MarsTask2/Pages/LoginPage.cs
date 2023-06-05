using DocumentFormat.OpenXml.Bibliography;
using MarsTask2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTask2.Pages
{
    public class Login_Page: Commondriver
    {
        public static IWebElement signinbutton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        public static IWebElement usernametxtbox => driver.FindElement(By.Name("email"));
        public static IWebElement pwdtxtbox => driver.FindElement(By.Name("password"));
        public static IWebElement loginbtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void LoginActions()
        {
            siginbutton.Click();
        }
    }

}
