namespace Xucxac
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.picChoose = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btQuayso = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.lbLose = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Controls.Add(this.picChoose);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(525, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hãy chọn một số";
            // 
            // bt1
            // 
            this.bt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Location = new System.Drawing.Point(30, 31);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(45, 38);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.toolTip1.SetToolTip(this.bt1, "Click một nút để đoán số\r\n");
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Location = new System.Drawing.Point(30, 119);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(45, 38);
            this.bt3.TabIndex = 1;
            this.bt3.Text = "3";
            this.toolTip1.SetToolTip(this.bt3, "Click một nút để đoán số\r\n");
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Location = new System.Drawing.Point(30, 75);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(45, 38);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.toolTip1.SetToolTip(this.bt2, "Click một nút để đoán số\r\n");
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Location = new System.Drawing.Point(435, 75);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(45, 38);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.toolTip1.SetToolTip(this.bt5, "Click một nút để đoán số\r\n");
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt6
            // 
            this.bt6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Location = new System.Drawing.Point(435, 119);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(45, 38);
            this.bt6.TabIndex = 4;
            this.bt6.Text = "6";
            this.toolTip1.SetToolTip(this.bt6, "Click một nút để đoán số\r\n");
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Location = new System.Drawing.Point(435, 31);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(45, 38);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4";
            this.toolTip1.SetToolTip(this.bt4, "Click một nút để đoán số\r\n");
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt1_Click);
            // 
            // picChoose
            // 
            this.picChoose.Location = new System.Drawing.Point(207, 45);
            this.picChoose.Name = "picChoose";
            this.picChoose.Size = new System.Drawing.Size(112, 90);
            this.picChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoose.TabIndex = 1;
            this.picChoose.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.btQuayso);
            this.groupBox2.Controls.Add(this.picResult);
            this.groupBox2.Location = new System.Drawing.Point(13, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(525, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quay Số (sinh số ngẫu nhiên)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btQuayso
            // 
            this.btQuayso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btQuayso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQuayso.Location = new System.Drawing.Point(7, 142);
            this.btQuayso.Name = "btQuayso";
            this.btQuayso.Size = new System.Drawing.Size(250, 38);
            this.btQuayso.TabIndex = 1;
            this.btQuayso.Text = "Quay số (Enter)";
            this.btQuayso.UseVisualStyleBackColor = false;
            this.btQuayso.Click += new System.EventHandler(this.btQuayso_Click);
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(207, 45);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(112, 90);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReset.Location = new System.Drawing.Point(253, 142);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(250, 38);
            this.btReset.TabIndex = 2;
            this.btReset.Text = "Reset(ESC)";
            this.btReset.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.lbLose);
            this.groupBox3.Controls.Add(this.lbWin);
            this.groupBox3.Controls.Add(this.lbCount);
            this.groupBox3.Location = new System.Drawing.Point(13, 433);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(525, 213);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống Kê";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCount.Location = new System.Drawing.Point(11, 54);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(64, 25);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "label1";
            this.lbCount.Click += new System.EventHandler(this.lbCount_Click);
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.ForeColor = System.Drawing.Color.Yellow;
            this.lbWin.Location = new System.Drawing.Point(11, 105);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(64, 25);
            this.lbWin.TabIndex = 1;
            this.lbWin.Text = "label1";
            // 
            // lbLose
            // 
            this.lbLose.AutoSize = true;
            this.lbLose.ForeColor = System.Drawing.Color.Red;
            this.lbLose.Location = new System.Drawing.Point(11, 160);
            this.lbLose.Name = "lbLose";
            this.lbLose.Size = new System.Drawing.Size(64, 25);
            this.lbLose.TabIndex = 2;
            this.lbLose.Text = "label1";
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 25;
            this.listResult.Location = new System.Drawing.Point(545, 24);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(535, 629);
            this.listResult.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Đoán Số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1122, 677);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò chơi đoán số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.PictureBox picChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btQuayso;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

