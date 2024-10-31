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
using OpenQA.Selenium.DevTools.V127.Profiler;
using System.Diagnostics;
using OpenQA.Selenium.IE;

namespace controlGoogle
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
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
                dataGridView1.Rows.Add(dataGridView1.RowCount, btnstatus.Text, txtinput.Text, "", "","True","True");
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
            else
            {
                MessageBox.Show("Điền đầy đủ dự vào !!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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


        private void btnHideCmd_Click(object sender, EventArgs e)
        {
            if (btnHideCmd.Text == "Show Cmd")
            {
                btnHideCmd.Text = "Hide Cmd";
            }
            else
            {
                btnHideCmd.Text = "Show Cmd";
            }
        }

        private void btnHideChorme_Click(object sender, EventArgs e)
        {
            if (btnHideChorme.Text == "Show Chorme")
            {
                btnHideChorme.Text = "Hide Chorme";
            }
            else
            {
                btnHideChorme.Text = "Show Chorme";
            }
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOutputText.Text))
            {
                Clipboard.SetText(txtOutputText.Text);
                btnCopy.Text = "Copied";
                btnCopy.BackColor = Color.Green;
                await Task.Delay(500);
                btnCopy.BackColor = Color.White;
                btnCopy.Text = "Copy Output";
            }
            else
            {
                MessageBox.Show("Đã có gì đâu mà copy =))","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath =Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Function");
            string[] files = Directory.GetFiles(filePath, "*.txt");
            int number = files.Length;
            string save = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 1; j < 7; j++)
                {
                    save += dataGridView1.Rows[i].Cells[j].Value?.ToString() + '|';
                }
                save= save.TrimEnd('|');
                save += "\n";
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
            MessageBox.Show("Dữ liệu đã được lưu vào "+namefile);
            Application.Restart();
        }
        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            string pathDebug = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Function");
            string[] numberFile = Directory.GetFiles(pathDebug, "*.txt");
            Process.Start("explorer.exe",pathDebug);
        }
    }
}
