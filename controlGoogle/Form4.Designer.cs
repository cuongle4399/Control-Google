namespace controlGoogle
{
    partial class frmCMD
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
            this.cbbCMD = new System.Windows.Forms.ComboBox();
            this.btnCMD = new System.Windows.Forms.Button();
            this.rtbCMD = new System.Windows.Forms.RichTextBox();
            this.lblTinhNangCMD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbCMD
            // 
            this.cbbCMD.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cbbCMD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCMD.FormattingEnabled = true;
            this.cbbCMD.Items.AddRange(new object[] {
            "Hiển thị thông tin máy",
            "Hiển thị ip mạng",
            "Hiển thị toàn bộ wifi từng kết nối với máy",
            "Hiển thị thời gian kết nối với wifi"});
            this.cbbCMD.Location = new System.Drawing.Point(183, 418);
            this.cbbCMD.Name = "cbbCMD";
            this.cbbCMD.Size = new System.Drawing.Size(421, 28);
            this.cbbCMD.TabIndex = 1;
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(629, 418);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(117, 28);
            this.btnCMD.TabIndex = 2;
            this.btnCMD.Text = "Show";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rtbCMD
            // 
            this.rtbCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCMD.Location = new System.Drawing.Point(12, 13);
            this.rtbCMD.Name = "rtbCMD";
            this.rtbCMD.Size = new System.Drawing.Size(734, 385);
            this.rtbCMD.TabIndex = 3;
            this.rtbCMD.Text = "";
            // 
            // lblTinhNangCMD
            // 
            this.lblTinhNangCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhNangCMD.Location = new System.Drawing.Point(12, 418);
            this.lblTinhNangCMD.Name = "lblTinhNangCMD";
            this.lblTinhNangCMD.Size = new System.Drawing.Size(165, 28);
            this.lblTinhNangCMD.TabIndex = 4;
            this.lblTinhNangCMD.Text = "Tính năng";
            this.lblTinhNangCMD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(758, 536);
            this.Controls.Add(this.lblTinhNangCMD);
            this.Controls.Add(this.rtbCMD);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.cbbCMD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCMD";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbCMD;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.RichTextBox rtbCMD;
        private System.Windows.Forms.Label lblTinhNangCMD;
    }
}