using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace controlGoogle
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }
        public frmhome(frmcontrol mainControl)
        {
            InitializeComponent();
            control = mainControl; 
        }
        private bool kiemtraOFFON(String status,string status1)
        {
            bool ktra = true;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(status) ||
                    dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(status1))
                    {
                    ktra = false;
                    }
                }
                return ktra;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(btnstatus.Text == "Status")
            {
                MessageBox.Show("Chọn trạng thái đi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnstatus.Text == "Load website" && !string.IsNullOrEmpty(txtinput.Text))
            {
                dataGridView1.Rows.Add(dataGridView1.RowCount, btnstatus.Text, txtinput.Text, "", "");
            }
            else if (btnstatus.Text == "Enter method" && !string.IsNullOrEmpty(txtxpath.Text) && !string.IsNullOrEmpty(cbbmethod.Text))
            {
                dataGridView1.Rows.Add(dataGridView1.RowCount, btnstatus.Text, "", txtxpath.Text, cbbmethod.Text);
            }
            else if (btnstatus.Text == "Send Input" && !string.IsNullOrEmpty(txtxpath.Text) && !string.IsNullOrEmpty(txtinput.Text))
            {
                dataGridView1.Rows.Add(dataGridView1.RowCount, btnstatus.Text, txtinput.Text, txtxpath.Text);
            }
            else if (btnstatus.Text == "Get Word" && !string.IsNullOrEmpty(txtxpath.Text))
            {
                dataGridView1.Rows.Add(dataGridView1.RowCount, btnstatus.Text, "", txtxpath.Text);
            }
            else if (btnstatus.Text == "ScreenShot")
            {
                dataGridView1.Rows.Add(dataGridView1.RowCount, btnstatus.Text);
            }
            else
            {
                MessageBox.Show("Điền đầy đủ dự vào !!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void setTxtOutputText(string text) {
            txtOutputText.Clear();
            txtOutputText.Text=text;
        }
        private void btnerase_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    int rowIndex = cell.RowIndex;
                    rowsToDelete.Add(rowIndex);
                }

                foreach (int rowIndex in rowsToDelete.OrderByDescending(i => i))
                {
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ô để xóa hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value = btnstatus.Text;
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value = txtinput.Text;
            }
            catch {
                MessageBox.Show("Đã chọn vào đâu, đã chạm vào đâu ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnurl_Click(object sender, EventArgs e)
        {
            btnstatus.Text = "Load website";
            status1(false, false, false, true, true);
        }

        private void btnsenkey_Click(object sender, EventArgs e)
        {
            btnstatus.Text = "Enter method";
            status1(true, true, true);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string trangthai = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string dulieu = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnstatus.Text = trangthai;
                txtinput.Text = dulieu;
                
            }  
        }

        private void btn_Click(object sender, EventArgs e)
        {
 
        }

        private void btnsendInput_Click(object sender, EventArgs e)
        {
            btnstatus.Text = "Send Input";
            status1(true, true, false, true, true);

        }
        private void status1(bool a = false, bool b = false , bool c = false , bool d = false , bool e = false)
        {
            txtxpath.Visible = a;
            lblxpath.Visible = b;
            cbbmethod.Visible = c;
            txtinput.Visible = d;
            lblinput.Visible = e;
            if (a)
            {
                txtxpath.Clear();
            }
            if (d)
            {
                txtinput.Clear();
            }
        }

        private void btnGettext_Click(object sender, EventArgs e)
        {
            btnstatus.Text = "Get Word";
            status1(true,true);
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOutputText.Text))
            {
                Clipboard.SetText(txtOutputText.Text);
                MessageBox.Show("Copy thành công", "ClipBoard", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtOutputText.Clear();
            }
            else
            {
                MessageBox.Show("Đã có gì đâu mà copy =))","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
        private string save = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
                int number = 0;
                try
                {
                    string[] files = Directory.GetFiles(filePath, "*.txt");
                    number = files.Length;
                }
                catch
                {

                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value?.ToString() == "Load website")
                    {
                        save += dataGridView1.Rows[i].Cells[1].Value?.ToString() + '|'
                            + dataGridView1.Rows[i].Cells[2].Value?.ToString();
                    }
                    else if (dataGridView1.Rows[i].Cells[1].Value?.ToString() == "Send Input")
                    {
                        save += dataGridView1.Rows[i].Cells[1].Value?.ToString() + '|'
                            + dataGridView1.Rows[i].Cells[2].Value?.ToString() + '|'
                            + dataGridView1.Rows[i].Cells[3].Value?.ToString();
                    }
                    else if (dataGridView1.Rows[i].Cells[1].Value?.ToString() == "Enter method")
                    {
                        save += dataGridView1.Rows[i].Cells[1].Value?.ToString() + '|' +
                              dataGridView1.Rows[i].Cells[3].Value?.ToString() + '|'
                            + dataGridView1.Rows[i].Cells[4].Value?.ToString();
                    }
                    else if (dataGridView1.Rows[i].Cells[1].Value?.ToString() == "Get Word")
                    {
                        save += dataGridView1.Rows[i].Cells[1].Value?.ToString() + '|'
                            + dataGridView1.Rows[i].Cells[3].Value?.ToString();
                    }
                    else if (dataGridView1.Rows[i].Cells[1].Value?.ToString() == "ScreenShot")
                    {
                        save += dataGridView1.Rows[i].Cells[1].Value?.ToString();
                    }
                    else
                    {
                        MessageBox.Show("j z má");
                    }
                    save += '\n';
                }

                if (string.IsNullOrEmpty(save))
                {
                    MessageBox.Show("Không có dữ liệu để lưu");
                    return;
                }
                number++;
                string namefile = "Function" + number.ToString() + ".txt";
                string pathfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function", namefile);
                File.WriteAllText(pathfile, save);
                MessageBox.Show("Dữ liệu đã được lưu vào " + namefile);
                Application.Restart();

            }
            catch
            {
                MessageBox.Show("Không tìm thấy thư mục lưu code", "Thông báo lỗi");
            }
            
        }
        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            string pathDebug = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
            string[] numberFile = Directory.GetFiles(pathDebug, "*.txt");
            Process.Start("explorer.exe",pathDebug);
        }

        private void btnaddcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Hộp thoại thêm code tính năng | Cường Lê",
                Filter = "File code (*.txt)|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string functionFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
                string destinationPath = Path.Combine(functionFolder, Path.GetFileName(sourceFilePath)); // nối //

                try
                {
                    File.Copy(sourceFilePath, destinationPath, true);
                    MessageBox.Show("Đã thêm tính năng thành công");
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }
        public void setPicture(Screenshot screenshot)
        {
            using (var stream = new MemoryStream(screenshot.AsByteArray))
            {
                pbOutput.Image = Image.FromStream(stream);
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            status1();
            btnstatus.Text = "ScreenShot";

        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            frmPicture frmPicture = new frmPicture();
            frmPicture.ShowDialog();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            status1(true, true, false , true ,true);
            btnstatus.Text = "Send File";
        }
        private frmcontrol control = new frmcontrol();
        private void btnChrome_Click(object sender, EventArgs e)
        {
            
            if(control.ChromeVIP)
            {
                control.ChromeVIP = false;
                btnChrome.Text = "Turn ON";
            }
            else
            {
                control.ChromeVIP= true;
                btnChrome.Text = "Turn OFF";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pathDebug = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
            string[] numberFile = Directory.GetFiles(pathDebug, "*.txt");
            Process.Start("explorer.exe", pathDebug);
        }

        private void btnAPICapcha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này hiện tại đã ngừng hoạt động","thông báo");
        }
    }
}
