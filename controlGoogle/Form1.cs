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

namespace controlGoogle
{
    public partial class frmcontrol : Form
    {
        public frmcontrol()
        {
            InitializeComponent();
        }
        private Form active = null;
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
        public void CreateButtonOnPanel()
        {
            string nameButton;
            int buttonHeigh = 45;
            int index = 0;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
            string[] files = Directory.GetFiles(filePath, "*.txt");
            foreach (string itemFile in files)
            {
                nameButton = Path.GetFileName(itemFile);
                nameButton = nameButton.Substring(0, nameButton.Length - 4);
                Button createbutton = new Button
                {
                    Text = "🎩"+ nameButton,
                    Height = buttonHeigh,
                    ForeColor = Color.Black,
                    Location = new Point(0,pnmenu.Height),
                    Dock = DockStyle.Bottom,
                    Font = new Font("Microsoft Sans Serif", 19, FontStyle.Bold),
                    BackColor = Color.White,
                };
                index += buttonHeigh;
                pnmenu.Height = index;
                pnmenu.Controls.Add(createbutton);
            }
            
        }
        public void frmcontrol_Load(object sender, EventArgs e)
        {
            pnmenu.Visible = false;
            CreateButtonOnPanel();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChillForm(new frmhome());
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
                            string zipPath = @".\MyAppSetup.zip";
                            string msiPath = @".\MyAppSetup.msi";
                            if (File.Exists(msiPath)) { File.Delete(msiPath); }
                            if (File.Exists(zipPath)) { File.Delete(zipPath); }
                            webClient.DownloadFile("link to web host/MyAppSetup.zip", zipPath);
                            ZipFile.ExtractToDirectory(zipPath, @".\");
                            File.Delete(zipPath);
                            Process process = new Process();
                            process.StartInfo.FileName = "msiexec.exe";
                            process.StartInfo.Arguments = "/i MyAppSetup.msi";
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
    }
}
