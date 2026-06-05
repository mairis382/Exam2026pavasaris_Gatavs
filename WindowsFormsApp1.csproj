using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenBrowser();
        }

        private void OpenBrowser()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.ebay.com");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenBrowser();

            IWebElement searchField = driver.FindElement(By.Id("gh-ac"));
            searchField.Clear();
            searchField.SendKeys(textBox1.Text);

            driver.FindElement(By.Id("gh-btn")).Click();

            string url = driver.Url;
            textBox2.Text = url;
            richTextBox1.AppendText(url + Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                driver.Navigate().Back();
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }

            base.OnFormClosing(e);
        }
    }
}
