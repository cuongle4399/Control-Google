using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace controlGoogle
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }
        private int index;
        private void nextLeftPicture()
        {
            string pictureFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PicTure");
            if (Directory.Exists(pictureFolder))
            {
                string[] files = Directory.GetFiles(pictureFolder, "*.png");
                if (files.Length > 1)
                {
                    if (index == 0)
                    {
                        index = files.Length - 1;
                        lblIndex.Text = index.ToString();
                        pcLoad.Image = Image.FromFile(files[index]);
                        

                    }
                    else
                    {
                        index--;
                        pcLoad.Image = Image.FromFile(files[index]);
                        lblIndex.Text = index.ToString();
                    }
                }
            }
        }
        private void nextRightPicture()
        {
            string pictureFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PicTure");
            if (Directory.Exists(pictureFolder))
            {
                string[] files = Directory.GetFiles(pictureFolder, "*.png");
                if (files.Length > 1)
                {
                    if (index == files.Length - 1)
                    {
                        index = 0;
                        lblIndex.Text = index.ToString();
                        pcLoad.Image = Image.FromFile(files[index]);
                    }
                    else
                    {
                        index++;
                        pcLoad.Image = Image.FromFile(files[index]);
                        lblIndex.Text = index.ToString();
                    }

                }
            }
        }
        private void frmPicture_Load(object sender, EventArgs e)
        {
            string pictureFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PicTure");
            if (Directory.Exists(pictureFolder))
            {
                string[] files = Directory.GetFiles(pictureFolder, "*.png");
                if (files.Length > 0)
                {
                    pcLoad.Image = Image.FromFile(files[index]);
                    index = 0;
                    lblIndex.Text = index.ToString();
                }
                else
                {
                    MessageBox.Show("Không có file ảnh nào trong thư mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            nextLeftPicture();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            nextRightPicture();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pathDebug = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Picture");
            string[] numberFile = Directory.GetFiles(pathDebug, "*.png");
            Process.Start("explorer.exe", pathDebug);
        }
    }
}
