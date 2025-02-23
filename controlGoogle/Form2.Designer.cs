namespace controlGoogle
{
    partial class frmhome
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnerase = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnurl = new System.Windows.Forms.Button();
            this.btnsenkey = new System.Windows.Forms.Button();
            this.btnsendInput = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnGettext = new System.Windows.Forms.Button();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.btnstatus = new System.Windows.Forms.Button();
            this.lblinput = new System.Windows.Forms.Label();
            this.lblxpath = new System.Windows.Forms.Label();
            this.txtxpath = new System.Windows.Forms.TextBox();
            this.cbbmethod = new System.Windows.Forms.ComboBox();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutputimg = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnaddcode = new System.Windows.Forms.Button();
            this.btnChrome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnAPICapcha = new System.Windows.Forms.Button();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnZoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(3, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(164, 41);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnerase
            // 
            this.btnerase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnerase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnerase.Location = new System.Drawing.Point(173, 3);
            this.btnerase.Name = "btnerase";
            this.btnerase.Size = new System.Drawing.Size(164, 41);
            this.btnerase.TabIndex = 1;
            this.btnerase.Text = "Erase";
            this.btnerase.UseVisualStyleBackColor = false;
            this.btnerase.Click += new System.EventHandler(this.btnerase_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(3, 50);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(164, 41);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnurl
            // 
            this.btnurl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurl.Location = new System.Drawing.Point(173, 50);
            this.btnurl.Name = "btnurl";
            this.btnurl.Size = new System.Drawing.Size(164, 41);
            this.btnurl.TabIndex = 3;
            this.btnurl.Text = "Load URL";
            this.btnurl.UseVisualStyleBackColor = false;
            this.btnurl.Click += new System.EventHandler(this.btnurl_Click);
            // 
            // btnsenkey
            // 
            this.btnsenkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsenkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsenkey.Location = new System.Drawing.Point(173, 97);
            this.btnsenkey.Name = "btnsenkey";
            this.btnsenkey.Size = new System.Drawing.Size(164, 41);
            this.btnsenkey.TabIndex = 4;
            this.btnsenkey.Text = "Senkey";
            this.btnsenkey.UseVisualStyleBackColor = false;
            this.btnsenkey.Click += new System.EventHandler(this.btnsenkey_Click);
            // 
            // btnsendInput
            // 
            this.btnsendInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsendInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsendInput.Location = new System.Drawing.Point(3, 97);
            this.btnsendInput.Name = "btnsendInput";
            this.btnsendInput.Size = new System.Drawing.Size(164, 41);
            this.btnsendInput.TabIndex = 5;
            this.btnsendInput.Text = "Send Input";
            this.btnsendInput.UseVisualStyleBackColor = false;
            this.btnsendInput.Click += new System.EventHandler(this.btnsendInput_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 186);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 48.12834F;
            this.Column1.HeaderText = "Step";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 125.9358F;
            this.Column2.HeaderText = "Process";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 125.9358F;
            this.Column3.HeaderText = "Input";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "xpath";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Method";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // txtinput
            // 
            this.txtinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput.Location = new System.Drawing.Point(516, 205);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(480, 33);
            this.txtinput.TabIndex = 7;
            // 
            // btnGettext
            // 
            this.btnGettext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGettext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGettext.Location = new System.Drawing.Point(3, 144);
            this.btnGettext.Name = "btnGettext";
            this.btnGettext.Size = new System.Drawing.Size(164, 41);
            this.btnGettext.TabIndex = 10;
            this.btnGettext.Text = "Get Text";
            this.btnGettext.UseVisualStyleBackColor = false;
            this.btnGettext.Click += new System.EventHandler(this.btnGettext_Click);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnScreenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenshot.Location = new System.Drawing.Point(173, 144);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(164, 41);
            this.btnScreenshot.TabIndex = 9;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = false;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnstatus
            // 
            this.btnstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstatus.Location = new System.Drawing.Point(15, 205);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(347, 33);
            this.btnstatus.TabIndex = 12;
            this.btnstatus.Text = "Status";
            this.btnstatus.UseVisualStyleBackColor = true;
            // 
            // lblinput
            // 
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput.Location = new System.Drawing.Point(384, 205);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(126, 33);
            this.lblinput.TabIndex = 13;
            this.lblinput.Text = "Input";
            this.lblinput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblxpath
            // 
            this.lblxpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxpath.Location = new System.Drawing.Point(384, 252);
            this.lblxpath.Name = "lblxpath";
            this.lblxpath.Size = new System.Drawing.Size(126, 32);
            this.lblxpath.TabIndex = 15;
            this.lblxpath.Text = "XPath";
            this.lblxpath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtxpath
            // 
            this.txtxpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxpath.Location = new System.Drawing.Point(516, 252);
            this.txtxpath.Multiline = true;
            this.txtxpath.Name = "txtxpath";
            this.txtxpath.Size = new System.Drawing.Size(480, 32);
            this.txtxpath.TabIndex = 14;
            // 
            // cbbmethod
            // 
            this.cbbmethod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmethod.FormattingEnabled = true;
            this.cbbmethod.Items.AddRange(new object[] {
            "Click",
            "Back",
            "Forward",
            "Refresh",
            "Phím Enter"});
            this.cbbmethod.Location = new System.Drawing.Point(15, 254);
            this.cbbmethod.Name = "cbbmethod";
            this.cbbmethod.Size = new System.Drawing.Size(347, 30);
            this.cbbmethod.TabIndex = 16;
            // 
            // txtOutputText
            // 
            this.txtOutputText.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputText.Location = new System.Drawing.Point(432, 397);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.Size = new System.Drawing.Size(385, 186);
            this.txtOutputText.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Output Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputimg
            // 
            this.lblOutputimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputimg.Location = new System.Drawing.Point(832, 365);
            this.lblOutputimg.Name = "lblOutputimg";
            this.lblOutputimg.Size = new System.Drawing.Size(164, 29);
            this.lblOutputimg.TabIndex = 21;
            this.lblOutputimg.Text = "Output Image";
            this.lblOutputimg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(660, 311);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 43);
            this.textBox2.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel1.Controls.Add(this.btnadd);
            this.flowLayoutPanel1.Controls.Add(this.btnerase);
            this.flowLayoutPanel1.Controls.Add(this.btnedit);
            this.flowLayoutPanel1.Controls.Add(this.btnurl);
            this.flowLayoutPanel1.Controls.Add(this.btnsendInput);
            this.flowLayoutPanel1.Controls.Add(this.btnsenkey);
            this.flowLayoutPanel1.Controls.Add(this.btnGettext);
            this.flowLayoutPanel1.Controls.Add(this.btnScreenshot);
            this.flowLayoutPanel1.Controls.Add(this.btnaddcode);
            this.flowLayoutPanel1.Controls.Add(this.btnChrome);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 220);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // btnaddcode
            // 
            this.btnaddcode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnaddcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcode.Location = new System.Drawing.Point(3, 191);
            this.btnaddcode.Name = "btnaddcode";
            this.btnaddcode.Size = new System.Drawing.Size(164, 43);
            this.btnaddcode.TabIndex = 53;
            this.btnaddcode.Text = "add code";
            this.btnaddcode.UseVisualStyleBackColor = false;
            this.btnaddcode.Click += new System.EventHandler(this.btnaddcode_Click);
            // 
            // btnChrome
            // 
            this.btnChrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChrome.Location = new System.Drawing.Point(173, 191);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(164, 41);
            this.btnChrome.TabIndex = 12;
            this.btnChrome.Text = "Turn OFF";
            this.btnChrome.UseVisualStyleBackColor = false;
            this.btnChrome.Click += new System.EventHandler(this.btnChrome_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 350);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 43);
            this.textBox1.TabIndex = 40;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(428, 589);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(389, 40);
            this.btnCopy.TabIndex = 45;
            this.btnCopy.Text = "Copy Output";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(12, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 43);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIf
            // 
            this.btnIf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIf.Location = new System.Drawing.Point(18, 350);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(75, 43);
            this.btnIf.TabIndex = 49;
            this.btnIf.Text = "If";
            this.btnIf.UseVisualStyleBackColor = true;
            // 
            // btnAPICapcha
            // 
            this.btnAPICapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPICapcha.Location = new System.Drawing.Point(389, 313);
            this.btnAPICapcha.Name = "btnAPICapcha";
            this.btnAPICapcha.Size = new System.Drawing.Size(249, 43);
            this.btnAPICapcha.TabIndex = 51;
            this.btnAPICapcha.Text = "Load API Next Capcha";
            this.btnAPICapcha.UseVisualStyleBackColor = true;
            this.btnAPICapcha.Click += new System.EventHandler(this.btnAPICapcha_Click);
            // 
            // pbOutput
            // 
            this.pbOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbOutput.Location = new System.Drawing.Point(832, 399);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(164, 185);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 18;
            this.pbOutput.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnZoom
            // 
            this.btnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.Location = new System.Drawing.Point(832, 590);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(164, 41);
            this.btnZoom.TabIndex = 54;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 43);
            this.button1.TabIndex = 55;
            this.button1.Text = "Show Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnAPICapcha);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOutputimg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.cbbmethod);
            this.Controls.Add(this.lblxpath);
            this.Controls.Add(this.txtxpath);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.btnstatus);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmhome";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnerase;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnurl;
        private System.Windows.Forms.Button btnsenkey;
        private System.Windows.Forms.Button btnsendInput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnGettext;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Button btnstatus;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lblxpath;
        private System.Windows.Forms.TextBox txtxpath;
        private System.Windows.Forms.ComboBox cbbmethod;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutputimg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnAPICapcha;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnaddcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnChrome;
        private System.Windows.Forms.Button button1;
    }
}