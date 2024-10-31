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
            this.btnLoadAPI = new System.Windows.Forms.Button();
            this.txtIdAPI = new System.Windows.Forms.TextBox();
            this.btnShowID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(967, 408);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(837, 490);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(143, 51);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
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
            // btnLoadAPI
            // 
            this.btnLoadAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAPI.Location = new System.Drawing.Point(836, 547);
            this.btnLoadAPI.Name = "btnLoadAPI";
            this.btnLoadAPI.Size = new System.Drawing.Size(143, 51);
            this.btnLoadAPI.TabIndex = 3;
            this.btnLoadAPI.Text = "Load API";
            this.btnLoadAPI.UseVisualStyleBackColor = true;
            // 
            // txtIdAPI
            // 
            this.txtIdAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAPI.Location = new System.Drawing.Point(120, 547);
            this.txtIdAPI.Multiline = true;
            this.txtIdAPI.Name = "txtIdAPI";
            this.txtIdAPI.Size = new System.Drawing.Size(710, 51);
            this.txtIdAPI.TabIndex = 4;
            // 
            // btnShowID
            // 
            this.btnShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowID.Location = new System.Drawing.Point(12, 547);
            this.btnShowID.Name = "btnShowID";
            this.btnShowID.Size = new System.Drawing.Size(102, 51);
            this.btnShowID.TabIndex = 5;
            this.btnShowID.Text = "Show";
            this.btnShowID.UseVisualStyleBackColor = true;
            this.btnShowID.Click += new System.EventHandler(this.btnShowID_Click);
            // 
            // frmChatGpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 610);
            this.Controls.Add(this.btnShowID);
            this.Controls.Add(this.txtIdAPI);
            this.Controls.Add(this.btnLoadAPI);
            this.Controls.Add(this.txtMessager);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmChatGpt";
            this.Text = "ChatGPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessager;
        private System.Windows.Forms.Button btnLoadAPI;
        private System.Windows.Forms.TextBox txtIdAPI;
        private System.Windows.Forms.Button btnShowID;
    }
}