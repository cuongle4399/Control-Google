using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlGoogle
{
    public partial class frmChatGpt : Form
    {
        public frmChatGpt()
        {
            InitializeComponent();
            txtIdAPI.PasswordChar = '*';
        }

        private void btnShowID_Click(object sender, EventArgs e)
        {
            if(txtIdAPI.PasswordChar == '\0')
            {
                txtIdAPI.PasswordChar = '*';
                btnShowID.Text = "Show";
                
                
            }
            else
            {
                txtIdAPI.PasswordChar = '\0';

                btnShowID.Text = "Hide";
            }
        }
    }
}
