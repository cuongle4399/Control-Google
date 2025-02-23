using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.IO.Compression;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace controlGoogle
{
    public partial class frmcontrol : Form
    {
        public frmcontrol()
        {
            InitializeComponent();
        }
        private Form active = null;
        public bool ChromeVIP = true;

        private void openChillForm(Form chillForm)
        {
            if (active != null)
            {
                active.Close();
            }
            active = chillForm;
            chillForm.TopLevel = false;
            chillForm.FormBorderStyle = FormBorderStyle.None;
            chillForm.Dock = DockStyle.Fill;
            pnhome.Controls.Add(chillForm);
            chillForm.BringToFront();
            chillForm.Show();
        }
        private void hidepanel()
        {
            if (pnmenu.Visible)
            {
                pnmenu.Visible = false;
            }
            else
            {
                pnmenu.Visible = true;
            }
        }
        public static String inputVip = null;
        public void CreateButtonOnPanel()
        {
            string nameButton;
            int buttonHeigh = 45;
            int index = 0;
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
                string[] files = Directory.GetFiles(filePath, "*.txt");
                for (int i = 0; i < files.Length; i++)
                {
                    nameButton = Path.GetFileName(files[i]);
                    nameButton = nameButton.Substring(0, nameButton.Length - 4);
                    Button createButton = new Button
                    {
                        Name = nameButton,
                        Text = "🎩" + nameButton,
                        Height = buttonHeigh,
                        ForeColor = Color.Black,
                        Location = new Point(0, pnmenu.Height),
                        Dock = DockStyle.Bottom,
                        Font = new Font("Microsoft Sans Serif", 19, FontStyle.Bold),
                        BackColor = Color.White,
                        Tag = files[i],
                    };
                    index += buttonHeigh;
                    pnmenu.Height = index;
                    createButton.Click += createButton_Click;
                    pnmenu.Controls.Add(createButton);
                }
            }
            catch
            {

            }
            
            
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Tag is string filePath)
            {
                string[] content = File.ReadAllLines(filePath);
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("--headless");
                Task.Run(() =>{
                    ChromeDriverService cmd = ChromeDriverService.CreateDefaultService();
                    cmd.HideCommandPromptWindow = true;
                    if (ChromeVIP)
                    {
                        using (ChromeDriver chromeDriver = new ChromeDriver(cmd))
                        {
                            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(3));
                            chromeDriver.Manage().Window.Size = new Size(80, 720);
                            for (int i = 0; i < content.Length; i++)
                            {
                                string[] content1 = content[i].Split('|');
                                if (content1[0].Equals("Load website"))
                                {
                                    chromeDriver.Navigate().GoToUrl(content1[1]);
                                }
                                else if (content1[0].Equals("Send Input"))
                                {
                                    var sendInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[2])));

                                    for (int k = 0; k < content1[1].Length; k++)
                                    {
                                        sendInput.SendKeys(content1[1][k].ToString());
                                        Thread.Sleep(50);
                                    }

                                }
                                else if (content1[0].Equals("Send File"))
                                {
                                    var sendFile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[2])));
                                    sendFile.SendKeys(content1[1].ToString());

                                }
                                else if (content1[0].Equals("Enter method"))
                                {
                                    var sendInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[1])));
                                    if (content1[2].Equals("Click"))
                                    {
                                        sendInput.Click();
                                    }
                                    else if (content1[2].Equals("Back"))
                                    {
                                        chromeDriver.Navigate().Back();
                                    }
                                    else if (content1[2].Equals("Forward"))
                                    {
                                        chromeDriver.Navigate().Forward();
                                    }
                                    else if (content1[2].Equals("Refresh"))
                                    {
                                        chromeDriver.Navigate().Refresh();
                                    }
                                    else if (content1[2].Equals("Phím Enter"))
                                    {
                                        sendInput.SendKeys(OpenQA.Selenium.Keys.Enter);
                                    }
                                }
                                else if (content1[0].Equals("Get Word"))
                                {
                                    var input = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[1])));
                                    frmhome frmHome = Application.OpenForms["frmhome"] as frmhome;
                                    if (frmHome != null)
                                    {
                                        frmHome.setTxtOutputText(input.Text);
                                    }
                                }
                                else if (content1[0].Equals("ScreenShot"))
                                {
                                    string pictureFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PicTure");
                                    if (!Directory.Exists(pictureFolder))
                                    {
                                        Directory.CreateDirectory(pictureFolder);
                                    }
                                    string fileName = $"picture{DateTime.Now:dd_HHmmss}.png";
                                    string filePathPicture = Path.Combine(pictureFolder, fileName);
                                    ITakesScreenshot screenshotDriver = (ITakesScreenshot)chromeDriver;
                                    Screenshot screenshot = screenshotDriver.GetScreenshot();
                                    frmhome frmHome = Application.OpenForms["frmhome"] as frmhome;
                                    if (frmHome != null)
                                    {
                                        frmHome.setPicture(screenshot);
                                        screenshot.SaveAsFile(filePathPicture);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy yêu cầu!");
                                }
                            }
                            Thread.Sleep(1500);
                            chromeDriver.Close();

                        }
                    }
                    else
                    {
                        using (ChromeDriver chromeDriver = new ChromeDriver(cmd,option))
                        {
                            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(3));
                            chromeDriver.Manage().Window.Size = new Size(80, 720);
                            for (int i = 0; i < content.Length; i++)
                            {
                                string[] content1 = content[i].Split('|');
                                if (content1[0].Equals("Load website"))
                                {
                                    chromeDriver.Navigate().GoToUrl(content1[1]);
                                }
                                else if (content1[0].Equals("Send Input"))
                                {
                                    var sendInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[2])));

                                    for (int k = 0; k < content1[1].Length; k++)
                                    {
                                        sendInput.SendKeys(content1[1][k].ToString());
                                        Thread.Sleep(50);
                                    }

                                }
                                else if (content1[0].Equals("Send File"))
                                {
                                    var sendFile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[2])));
                                    sendFile.SendKeys(content1[1].ToString());

                                }
                                else if (content1[0].Equals("Enter method"))
                                {
                                    var sendInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[1])));
                                    if (content1[2].Equals("Click"))
                                    {
                                        sendInput.Click();
                                    }
                                    else if (content1[2].Equals("Back"))
                                    {
                                        chromeDriver.Navigate().Back();
                                    }
                                    else if (content1[2].Equals("Forward"))
                                    {
                                        chromeDriver.Navigate().Forward();
                                    }
                                    else if (content1[2].Equals("Refresh"))
                                    {
                                        chromeDriver.Navigate().Refresh();
                                    }
                                    else if (content1[2].Equals("Phím Enter"))
                                    {
                                        sendInput.SendKeys(OpenQA.Selenium.Keys.Enter);
                                    }
                                }
                                else if (content1[0].Equals("Get Word"))
                                {
                                    var input = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(content1[1])));
                                    frmhome frmHome = Application.OpenForms["frmhome"] as frmhome;
                                    if (frmHome != null)
                                    {
                                        frmHome.setTxtOutputText(input.Text);
                                    }
                                }
                                else if (content1[0].Equals("ScreenShot"))
                                {
                                    string pictureFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PicTure");
                                    if (!Directory.Exists(pictureFolder))
                                    {
                                        Directory.CreateDirectory(pictureFolder);
                                    }
                                    string fileName = $"CuongLe {DateTime.Now:dd_HHmmss}.png";
                                    string filePathPicture = Path.Combine(pictureFolder, fileName);
                                    ITakesScreenshot screenshotDriver = (ITakesScreenshot)chromeDriver;
                                    Screenshot screenshot = screenshotDriver.GetScreenshot();
                                    frmhome frmHome = Application.OpenForms["frmhome"] as frmhome;
                                    if (frmHome != null)
                                    {
                                        frmHome.setPicture(screenshot);
                                        screenshot.SaveAsFile(filePathPicture);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy yêu cầu!");
                                }
                            }
                            chromeDriver.Close();

                        }
                        
                    }
                });
            }
        }
        public void frmcontrol_Load(object sender, EventArgs e)
        {
            pnmenu.Visible = false;
            CreateButtonOnPanel();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChillForm(new frmhome(this));
            hidepanel();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            if (active != null)
            {
                active.Close();
                active = null;
            }
            pnmenu.Visible = false;
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            pnmenu.Visible = false;
            Process.Start("https://www.facebook.com/cuongle1002");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/cuongle1002");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                if (!webClient.DownloadString("https://www.dropbox.com/scl/fi/pvk30m0b32g9ge4m0z35h/update.txt?rlkey=4xns5ks33ueu3c3eeainlqipv&st=m6xtzrhm&dl=1").Contains("1.0.0"))
                {
                    if (MessageBox.Show("Đã có phiên bản mới. Bạn có muốn cập nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string zipPath = @".\GoogleControl.zip";
                            string msiPath = @".\GoogleControl.msi";
                            if (File.Exists(msiPath)) { File.Delete(msiPath); }
                            if (File.Exists(zipPath)) { File.Delete(zipPath); }
                            webClient.DownloadFile("https://www.dropbox.com/scl/fi/0jwv2gtfvvnv8djcw8gxn/GoogleControl.zip?rlkey=czzfak3gvaqa1vphzkar66ryf&st=m6ax29qa&dl=1", zipPath);
                            ZipFile.ExtractToDirectory(zipPath, @".\");
                            File.Delete(zipPath);
                            Process process = new Process();
                            process.StartInfo.FileName = "setup.exe";
                            process.StartInfo.Arguments = "/i GoogleControl.msi";
                            process.Start();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi update:  " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đang là phiên bản mới nhất","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChillForm(new frmChatGpt());
            pnmenu.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChillForm(new frmCMD());
            pnmenu.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/cuongle1002");
        }
    }
}
