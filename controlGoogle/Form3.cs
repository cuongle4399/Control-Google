using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace controlGoogle
{
    public partial class frmChatGpt : Form
    {
        // AIzaSyBtBh-XhHqw9Sl5uuc16_oBtetx9j1G11I
        public frmChatGpt()
        {
            InitializeComponent();
            txtIdAPI.PasswordChar = '*';
        }

        private async Task<string> GetGeminiResponse(string prompt)
        {
            try
            {
                string apiKey = txtIdAPI.Text.Trim();

                using (HttpClient client = new HttpClient())
                {
                    var requestBody = new
                    {
                        contents = new[]
                        {
                            new
                            {
                                parts = new[]
                                {
                                    new { text = prompt }
                                }
                            }
                        }
                    };

                    var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                    // Gửi yêu cầu đến API Gemini
                    var response = await client.PostAsync($"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent?key={apiKey}", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    // Giải mã phản hồi
                    var responseObject = JsonConvert.DeserializeObject<dynamic>(responseString);
                    string answer = responseObject?.candidates[0].content?.parts[0]?.text ?? "Lỗi: Không thể nhận được phản hồi từ API Gemini";
                    return answer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ID API rồi !!!!!!");
                throw;
            }
        }

        private string dataapi= "";
        private void frmChatGpt_Load(object sender, EventArgs e)
        {
            if (File.Exists("API/ID_API.txt"))
            {
                dataapi = File.ReadAllText("API/ID_API.txt");
                dataapi = dataapi.Substring(0,dataapi.Length - 3);
                txtIdAPI.Text = Decrypt(dataapi);
            }
        }

        private async void btnSend_Click_2(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();              
                string userInput = txtMessager.Text;
                if (string.IsNullOrEmpty(userInput))
                {
                    MessageBox.Show("Vui lòng nhập một lời nhắn");
                    return;
                }

                richTextBox1.AppendText("Bạn: " + userInput + "\n\n");

                int loadingStartIndex = richTextBox1.TextLength;
                richTextBox1.AppendText("Gemini: Đang tải....\n\n");

                // Lấy phản hồi từ hàm bất đồng bộ
                string response = await GetGeminiResponse(userInput);

                // Thay thế "Đang tải...." bằng khoảng trống
                richTextBox1.Select(loadingStartIndex, "Gemini: Đang tải....".Length);
                richTextBox1.SelectedText = "Gemini: ";

                // Thêm từng ký tự của phản hồi với độ trễ
                for (int i = 0; i < response.Length; i++)
                {
                    richTextBox1.AppendText(response[i].ToString());
                    await Task.Delay(1); // Độ trễ giữa các ký tự (50ms)
                }

                // Xuống dòng sau khi hoàn tất
                richTextBox1.AppendText("\n\n");
                txtMessager.Clear();
            }
            catch
            {
            }
            
        }

        private static readonly byte[] key = Encoding.UTF8.GetBytes("1234567890123456"); // 16 bytes key
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456"); // 16 bytes IV
        public static string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                byte[] buffer = Convert.FromBase64String(cipherText);

                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void btnLoadAPI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdAPI.Text))
            {
                MessageBox.Show("Vui lòng nhập ID API Gemini !!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                string mahoa = Encrypt(txtIdAPI.Text) + "|bN";
                File.WriteAllText("API/ID_API.txt", mahoa);
                MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtIdAPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Chỉ được Paste (Crt + V) thôi không cho nhập nhé !!","Đây là tính năng không phải bug",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }

        private void txtIdAPI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                txtIdAPI.Clear();
                txtIdAPI.Paste();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                MessageBox.Show("ID API của người ta mà cứ đòi copy là sao máaaa");
            }
        }

        private void txtIdAPI_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
