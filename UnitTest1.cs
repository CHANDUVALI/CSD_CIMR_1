using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xamarin.Essentials;

namespace CIMR
{
    [TestFixture]
    public class Ayurveda_Department
    {
        string Url = "https://csd-test.manipal.edu/mopms/";

        [Test]
        public void Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxPrefix"))).SelectByText("MR");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Name")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Name")).SendKeys("Test4");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Age")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Age")).SendKeys("24");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Sexlist")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Sexlist"))).SelectByText("Male");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("STU");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Telephone")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Telephone")).SendKeys("4444444444");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlFatherPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlFatherPrefix"))).SelectByText("MR");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForHName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForHName")).SendKeys("abc");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlMotherPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlMotherPrefix"))).SelectByText("MRS.");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForMName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForMName")).SendKeys("def");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ReligionList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ReligionList"))).SelectByText("HINDU");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_MaritalStatusList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_MaritalStatusList"))).SelectByText("Single");
            Task.Delay(3000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_FHGList")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_FHGList"))).SelectByText("Guardian");
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSGPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSGPrefix"))).SelectByText("MR");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxHGNAme")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxHGNAme")).SendKeys("xyz");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).SendKeys("Eshwar nagar");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL2")).SendKeys("manipal");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlDistrict")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlDistrict"))).SelectByText("UDUPI");
            Task.Delay(3000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCityTown")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCityTown"))).SelectByText("MANIPAL");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlState")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlState"))).SelectByText("KARNATAKA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCountry")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCountry"))).SelectByText("INDIA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLDoctor")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLDoctor"))).SelectByText("suma");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PayTypeList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PayTypeList"))).SelectByText("Cash");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();


            //-------------------To copy and paste the hospital number-------------------------//

            //String hospitalno = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_HospNo")).GetAttribute("value");

            //driver.FindElement(By.LinkText("Repeat Registration")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SHospNo")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SHospNo")).SendKeys(hospitalno);
            //Task.Delay(2000).Wait();


            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Repeat_Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Repeat Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SHospNo")).SendKeys("08006645");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSHospNo")).Click();
            Task.Delay(4000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddpvisitype")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddpvisitype"))).SelectByText("Consultation");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Search")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SerHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SerHospNo")).SendKeys("08006647");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSearch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_btnView_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).SendKeys("Gandhi nagar");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnUpdate")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Reprint()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Reprint / CancelRegBill")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_HospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_HospNo")).SendKeys("08006647");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).SendKeys("NA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPrint")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Billing()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Billing")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).SendKeys("08006647");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDoctor")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ChkBill")).Click();
            Task.Delay(3000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLTreatment1")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLTreatment1"))).SelectByText("A1-test");
            Task.Delay(4000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            String Billno = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).GetAttribute("value");

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("BillCancel / Reprint")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).SendKeys(Billno);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).SendKeys("NA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnCancel")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Bill_Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Bill Search")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txthospino")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txthospino")).SendKeys("08006647");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnserach")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void MRD_Dispatch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("MRD Dispatch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GVDispatchToday_CheckBoxMark1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnDispatchToday")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("rec123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("rec@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("rec@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void BOS_Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("rec123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("BOS Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender1_day_0_6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender2_today")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void actML_Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("actML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("act123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("act123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("act@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("act@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void actML_BOS_Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("actML");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("act123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("BOS Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender1_day_0_6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender2_today")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Company_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCP")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCP")).SendKeys("ABC");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCN")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCN")).SendKeys("1111111111");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button3")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void Department_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox4")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox4")).SendKeys("01");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("ABC");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).SendKeys("AYU");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1"))).SelectByText("Ayurveda");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList2_0")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Doctor_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton3")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[3]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_EmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_EmailId")).SendKeys("abc@gmail.com");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_doctxtCN")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_doctxtCN")).SendKeys("1111111111");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button3")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void Tariff_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton4")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList3")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList3"))).SelectByText("A1-test");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).SendKeys("50");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("100");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox5")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox5")).SendKeys("0");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox6")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox6")).SendKeys("0");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList2_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Treatment_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton5")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void PayOption_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Bill_Category_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton7")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).SendKeys("DOCTOR");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("DOC");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Occupation_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton9")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Country_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton8")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void State_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton10")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void District_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton11")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Taluk_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton12")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Religion_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton14")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void SAC_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton13")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void FreePay_Type_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton15")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Add_User()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Add User")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1"))).SelectByText("AdminAyurveda");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtID")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtID")).SendKeys("abcd");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtName")).SendKeys("ayurveda");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtPW")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtPW")).SendKeys("ad123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Admin_Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("admin");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("ad123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("ad123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("ad@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("ad@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Item_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Itemgeneric")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Itemgeneric")).SendKeys("test");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList3")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList3"))).SelectByText("10C");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList4")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList4"))).SelectByText("409");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Package_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Product_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton3")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Group_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton4")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void HSN_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton5")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Manufacture_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Supplier_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton7")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtAddress")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtAddress")).SendKeys("Eshwar nagar");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtplace")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtplace")).SendKeys("Manipal");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtphoneo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtphoneo")).SendKeys("2145451");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList2_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void Pharmacy_Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Search")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SerHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SerHospNo")).SendKeys("08006647");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSearch")).Click();
            Task.Delay(3000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_btnView_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GVBillDetail_acntBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[4]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_CashBilling_and_Billcancel()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Cash Billing")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).SendKeys("08006647");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DoctorName")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GVBillDetail_acntBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[4]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            String Billno = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).GetAttribute("value");

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Bill Cancel / Reprint")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).SendKeys(Billno);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).SendKeys("NA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnCancel")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_Bill_Edit()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Bill Edit")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).SendKeys("AYU/20-21/30");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).SendKeys("NA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnEdit")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_Bill_Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Bill Search")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txthospino")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txthospino")).SendKeys("08006648");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_popGridBill_lnkBillNumber_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("pharmacy");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("pha@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("pha@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_Credit_Billing()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Credit Billing")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).SendKeys("08006647");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DoctorName")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_IPNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_IPNo")).SendKeys("2");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GVBillDetail_acntBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[4]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_Stock_View()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Stock View")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("AY00113190");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_GRN_View()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("GRN View")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSupplier")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSupplier"))).SelectByText("SHRI DHANVANTHARI AGENCIES");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_popGridItem_lnkView_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Pharmacy_GRN_Entry()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("pharmacy");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("GRN Entry")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_2")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(3000).Wait();
            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPoLineDesc_CheckBoxMarkPO_1"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPoLineDesc_CheckBoxMarkPO_1")).Click();
            Task.Delay(2000).Wait();
            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSupplier")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSupplier"))).SelectByText("Stock Transfer , Eshwar nagar");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_BNo_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_BNo_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_BNo_0")).SendKeys("151");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Exp_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//td[contains(text(),'Sep')]")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_BNo_0")).SendKeys("100");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Mrp_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Mrp_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Mrp_0")).SendKeys("200");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_PurchasePrice_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_PurchasePrice_0")).Click();
            
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_PurchasePrice_0")).Clear();
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_PurchasePrice_0")).SendKeys("100");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Discount_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Discount_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Discount_0")).Clear();
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Discount_0")).SendKeys("5");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Tax_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Tax_0")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_GRNEntry_Tax_0"))).SelectByText("18");
            Task.Delay(2000).Wait();

            var element11 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script11 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js11 = (IJavaScriptExecutor)driver;
            js11.ExecuteScript(script11, element11);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnsubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(3000).Wait(); 
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }
    }

    [TestFixture]
    public class Yoga_Department
    {
        string Url = "https://csd-test.manipal.edu/mopms/";

        [Test]
        public void Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxPrefix"))).SelectByText("MR");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Name")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Name")).SendKeys("Test2");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Age")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Age")).SendKeys("22");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Sexlist")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Sexlist"))).SelectByText("Male");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("STU");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Telephone")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Telephone")).SendKeys("2222222222");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlFatherPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlFatherPrefix"))).SelectByText("MR");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForHName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForHName")).SendKeys("abc");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlMotherPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlMotherPrefix"))).SelectByText("MRS.");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForMName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ForMName")).SendKeys("def");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ReligionList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ReligionList"))).SelectByText("HINDU");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_MaritalStatusList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_MaritalStatusList"))).SelectByText("Single");
            Task.Delay(3000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_FHGList")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_FHGList"))).SelectByText("Guardian");
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSGPrefix")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlSGPrefix"))).SelectByText("MR");
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxHGNAme")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtBoxHGNAme")).SendKeys("xyz");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).SendKeys("Eshwar nagar");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL2")).SendKeys("manipal");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlDistrict")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlDistrict"))).SelectByText("UDUPI");
            Task.Delay(3000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCityTown")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCityTown"))).SelectByText("MANIPAL");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlState")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlState"))).SelectByText("KARNATAKA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCountry")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlCountry"))).SelectByText("INDIA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLDoctor")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLDoctor"))).SelectByText("Dr. Lavya Shetty");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PayTypeList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PayTypeList"))).SelectByText("Cash");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Repeat_Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Repeat Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SHospNo")).SendKeys("08006645");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSHospNo")).Click();
            Task.Delay(4000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddpvisitype")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddpvisitype"))).SelectByText("Consultation");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLDoctor")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLDoctor"))).SelectByText("Dr. Lavya Shetty");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Yoga_Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Search")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SerHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SerHospNo")).SendKeys("08006645");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSearch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_btnView_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddressL1")).SendKeys("Gandhi nagar");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnUpdate")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Reprint()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Reprint / CancelRegBill")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_HospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_HospNo")).SendKeys("08006645");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).SendKeys("NA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPrint")).Click();
            Task.Delay(1000).Wait();
            //driver.SwitchTo().Window(driver.WindowHandles.Last());
            //Task.Delay(1000).Wait();
            //driver.SwitchTo().Window(driver.WindowHandles.First());

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Billing_and_BillCancle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Billing")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillHospNo")).SendKeys("08006645");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDoctor")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ChkBill")).Click();
            Task.Delay(3000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLTreatment1")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DDLTreatment1"))).SelectByText("YOG009-YOGA THERAPY-OPD A");
            Task.Delay(4000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSave")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            String Billno = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).GetAttribute("value");

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("BillCancel / Reprint")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BillNo")).SendKeys(Billno);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Remark")).SendKeys("NA");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnCancel")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Bill_Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Bill Search")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txthospino")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txthospino")).SendKeys("08006645");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnserach")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void MRD_Dispatch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("MRD Dispatch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GVDispatchToday_CheckBoxMark1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnDispatchToday")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("yoga123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("yoga@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("yoga@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void BOS_Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("recyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("yoga123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("BOS Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender1_day_0_6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender2_today")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Accounts_Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("acyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("acyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("acyoga");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("acyoga@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("acyoga@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Accounts_BOS_Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("acyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("acyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("BOS Registration")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender1_day_0_6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender2_today")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Company_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCP")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCP")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCP")).SendKeys("ABC");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCN")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_comptxtCN")).SendKeys("9878446465");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button3")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void Department_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox4")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox4")).SendKeys("02");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            Task.Delay(2000).Wait();
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("ABC");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).SendKeys("YOG");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1"))).SelectByText("Yoga");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList2_0")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Doctor_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton3")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[3]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_EmailId")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_EmailId")).SendKeys("abc@gmail.com");
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList2")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList2"))).SelectByText("Reader");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_doctxtCN")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_doctxtCN")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_doctxtCN")).SendKeys("9874569874");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button3")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void Tariff_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton4")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList3")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList3"))).SelectByText("YOG009-YOGA THERAPY-OPD A");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).SendKeys("50");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("100");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox5")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox5")).SendKeys("0");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox6")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox6")).SendKeys("0");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList2_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Treatment_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton5")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void PayOption_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Bill_Category_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton7")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2")).SendKeys("DOCTOR");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox3")).SendKeys("DOC");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Occupation_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton9")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Country_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton8")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void State_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton10")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void District_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton11")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Taluk_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton12")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Religion_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton14")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void SAC_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton13")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void FreePay_Type_Master()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Master Data")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_LinkButton15")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_imageBkCbtn")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("BES001");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchid")).Click();
            //Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("//tr[2]//td[1]//a[1]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Add_User()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Add User")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownList1"))).SelectByText("AdminYoga");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtID")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtID")).SendKeys("abcd");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtName")).SendKeys("Yoga");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtPW")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_usertxtPW")).SendKeys("ad123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Admin_Change_Password()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink1")).Click();
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("adyoga");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.LinkText("Change Password")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCurntPwd")).SendKeys("adyoga");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextNewPwd")).SendKeys("adyoga@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextConfirmPwd")).SendKeys("adyoga@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(4000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLink2")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }
    }
}
