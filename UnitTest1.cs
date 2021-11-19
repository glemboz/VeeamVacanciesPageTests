using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VeeamVacanciesPageTests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            driver.Manage().Window.Maximize();
        }

        [Test]
        [TestCase(6)]
        public void Test1(int expectedVacanciesCount)
        {
            PageObjects.VacanciesPageObject vacancies = new(driver);
            vacancies
                .AcceptCookies()
                .SelectDepartment()
                .ClickProductDevelopmentDept()
                .SelectLanguage()
                .SelectEnglishLanguage();

            int totalVacanciesCount = driver.FindElements(By.ClassName("card-sm")).Count;

            Assert.AreEqual(expectedVacanciesCount, totalVacanciesCount, " оличество вакансий не совпадает с ожидаемым!");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}