using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpCond = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace VeeamVacanciesPageTests.PageObjects
{
    class VacanciesPageObject
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;


        private readonly By acceptCookiesButton = By.XPath("//*[@id='cookiescript_accept']");
        private readonly By selectDepartmentButton = By.XPath("//button[text()='Все отделы']"); 
        private readonly By productDevelopmentLink = By.XPath("//a[text()='Разработка продуктов']");
        private readonly By selectLanguageButton = By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[1]/div/div[3]/div/div/button");
        private readonly By languageEnglishlabel = By.Id("lang-option-1"); //Английский

        public VacanciesPageObject(IWebDriver _driver)
        {
            driver = _driver;
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        public VacanciesPageObject AcceptCookies()
        {
            wait.Until(ExpCond.ElementExists(acceptCookiesButton)).Click();
            return new VacanciesPageObject(driver);
        }

        public VacanciesPageObject SelectDepartment()
        {
            wait.Until(ExpCond.ElementExists(selectDepartmentButton)).Click();
            return new VacanciesPageObject(driver);
        }

        public VacanciesPageObject ClickProductDevelopmentDept()
        {
            wait.Until(ExpCond.ElementExists(productDevelopmentLink)).Click();
            return new VacanciesPageObject(driver);
        }

        public VacanciesPageObject SelectLanguage()
        {
            wait.Until(ExpCond.ElementExists(selectLanguageButton)).Click();
            return new VacanciesPageObject(driver);
        }

        public VacanciesPageObject SelectEnglishLanguage()
        {
            wait.Until(ExpCond.ElementExists(languageEnglishlabel)).Click();
            return new VacanciesPageObject(driver);
        }
    }
}
