namespace controlGoogle
{
    partial class frmChatGpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessager = new System.Windows.Forms.TextBox();
            this.btnSaveAPI = new System.Windows.Forms.Button();
            this.txtIdAPI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(975, 408);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(837, 441);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 100);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_2);
            // 
            // txtMessager
            // 
            this.txtMessager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessager.Location = new System.Drawing.Point(12, 441);
            this.txtMessager.Multiline = true;
            this.txtMessager.Name = "txtMessager";
            this.txtMessager.Size = new System.Drawing.Size(819, 100);
            this.txtMessager.TabIndex = 2;
            // 
            // btnSaveAPI
            // 
            this.btnSaveAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAPI.Location = new System.Drawing.Point(836, 547);
            this.btnSaveAPI.Name = "btnSaveAPI";
            this.btnSaveAPI.Size = new System.Drawing.Size(151, 51);
            this.btnSaveAPI.TabIndex = 3;
            this.btnSaveAPI.Text = "Save API";
            this.btnSaveAPI.UseVisualStyleBackColor = true;
            this.btnSaveAPI.Click += new System.EventHandler(this.btnLoadAPI_Click);
            // 
            // txtIdAPI
            // 
            this.txtIdAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAPI.Location = new System.Drawing.Point(12, 547);
            this.txtIdAPI.Multiline = true;
            this.txtIdAPI.Name = "txtIdAPI";
            this.txtIdAPI.Size = new System.Drawing.Size(818, 51);
            this.txtIdAPI.TabIndex = 4;
            this.txtIdAPI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIdAPI_MouseClick);
            this.txtIdAPI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdAPI_KeyDown);
            this.txtIdAPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAPI_KeyPress);
            // 
            // frmChatGpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 610);
            this.Controls.Add(this.txtIdAPI);
            this.Controls.Add(this.btnSaveAPI);
            this.Controls.Add(this.txtMessager);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmChatGpt";
            this.Text = "ChatGPT";
            this.Load += new System.EventHandler(this.frmChatGpt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessager;
        private System.Windows.Forms.Button btnSaveAPI;
        private System.Windows.Forms.TextBox txtIdAPI;
    }
}