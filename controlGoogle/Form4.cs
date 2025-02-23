using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlGoogle
{
    public partial class frmCMD : Form
    {
        public frmCMD()
        {
            InitializeComponent();

        }
        public void runCMD(string command)
        {
            rtbCMD.Clear();
            Process pc = new Process();
            pc.StartInfo.FileName = "cmd.exe";
            pc.StartInfo.Arguments = "/c chcp 65001 & " + command; 
            pc.StartInfo.RedirectStandardError = true;
            pc.StartInfo.RedirectStandardOutput = true;
            pc.StartInfo.UseShellExecute = false;
            pc.StartInfo.CreateNoWindow = true;
            pc.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            pc.StartInfo.StandardErrorEncoding = Encoding.UTF8;

            try
            {
                pc.Start();
                String temp = null;
                while (!pc.StandardOutput.EndOfStream)
                {
                    
                    string line = pc.StandardOutput.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line) && temp != line)
                    {
                            rtbCMD.AppendText(line + '\n');
                        temp = line;
                    }
                }
                pc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                pc.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (cbbCMD.Text.Equals("Hiển thị thông tin máy"))
            {
                runCMD("systeminfo");
            }
            else if (cbbCMD.Text.Equals("Hiển thị toàn bộ wifi từng kết nối với máy"))
            {
                runCMD("netsh wlan show profiles");
            }
            else if (cbbCMD.Text.Equals("Hiển thị thời gian kết nối với wifi"))
            {
                runCMD("powershell -Command \"Get-WinEvent -LogName 'Microsoft-Windows-NetworkProfile/Operational' | Where-Object { $_.Message -match 'connected|disconnected' } | Select-Object @{Name='TimeCreated';Expression={ $_.TimeCreated.ToString('yyyy-MM-dd HH:mm:ss') }}, Message");
            }
            else if(cbbCMD.Text.Equals("Hiển thị ip mạng")){
                runCMD("ipconfig");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tính năng cần hiển thị");
            }
        }
    }
}
