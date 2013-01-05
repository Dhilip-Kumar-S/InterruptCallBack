namespace TaskPriority
{
    partial class TaskPriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPriority));
            this.Frequency = new System.Windows.Forms.ComboBox();
            this.Urgent_Hrs = new System.Windows.Forms.ComboBox();
            this.Urgent_Mins = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.UrgentTip = new System.Windows.Forms.ToolTip(this.components);
            this.BringFocusTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimeLeft = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Remainder = new System.Windows.Forms.GroupBox();
            this.PopUP = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Blink = new System.Windows.Forms.RadioButton();
            this.BringFocus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TipTimeLeft = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Remainder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frequency
            // 
            this.Frequency.AllowDrop = true;
            this.Frequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Frequency.FormattingEnabled = true;
            this.Frequency.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "30",
            "60",
            "90",
            "120"});
            this.Frequency.Location = new System.Drawing.Point(137, 60);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(65, 23);
            this.Frequency.TabIndex = 5;
            this.Frequency.SelectedIndexChanged += new System.EventHandler(this.Frequency_SelectedIndexChanged_1);
            // 
            // Urgent_Hrs
            // 
            this.Urgent_Hrs.AllowDrop = true;
            this.Urgent_Hrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Urgent_Hrs.FormattingEnabled = true;
            this.Urgent_Hrs.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.Urgent_Hrs.Location = new System.Drawing.Point(94, 231);
            this.Urgent_Hrs.Name = "Urgent_Hrs";
            this.Urgent_Hrs.Size = new System.Drawing.Size(40, 23);
            this.Urgent_Hrs.TabIndex = 6;
            this.Urgent_Hrs.SelectedIndexChanged += new System.EventHandler(this.Urgent_Hrs_SelectedIndexChanged);
            // 
            // Urgent_Mins
            // 
            this.Urgent_Mins.AllowDrop = true;
            this.Urgent_Mins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Urgent_Mins.FormattingEnabled = true;
            this.Urgent_Mins.Items.AddRange(new object[] {
            "00",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.Urgent_Mins.Location = new System.Drawing.Point(232, 231);
            this.Urgent_Mins.Name = "Urgent_Mins";
            this.Urgent_Mins.Size = new System.Drawing.Size(40, 23);
            this.Urgent_Mins.TabIndex = 12;
            this.Urgent_Mins.SelectedIndexChanged += new System.EventHandler(this.Urgent_Mins_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 113);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.UrgentTip.SetToolTip(this.button1, "Have you completed it?");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 94);
            this.textBox1.MaxLength = 64;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 94);
            this.textBox2.MaxLength = 64;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(217, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 113);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 215);
            this.textBox3.MaxLength = 64;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(69, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 113);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UrgentTip
            // 
            this.UrgentTip.IsBalloon = true;
            this.UrgentTip.Tag = "Urgent";
            this.UrgentTip.ToolTipTitle = "Urgent";
            // 
            // BringFocusTimer
            // 
            this.BringFocusTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(215, 215);
            this.textBox4.MaxLength = 64;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(215, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 113);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Urgent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Not Urgent";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 69);
            this.label3.TabIndex = 10;
            this.label3.Text = "I\r\nm\r\np\r\n";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 115);
            this.label4.TabIndex = 11;
            this.label4.Text = "U\r\nn\r\nI\r\nm\r\np\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 343);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TimeLeft);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Location = new System.Drawing.Point(70, 137);
            this.TimeLeft.MarqueeAnimationSpeed = 5;
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(118, 23);
            this.TimeLeft.Step = 1;
            this.TimeLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimeLeft.TabIndex = 13;
            this.TimeLeft.Value = 5;
            this.TimeLeft.MouseHover += new System.EventHandler(this.TimeLeft_MouseHover);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Urgent_Mins);
            this.tabPage2.Controls.Add(this.Urgent_Hrs);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Remainder);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mins";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "TimeRemaining for Urgent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "%USERPROFILE%\\\\IntCallBack.xls";
            // 
            // Remainder
            // 
            this.Remainder.Controls.Add(this.Frequency);
            this.Remainder.Controls.Add(this.PopUP);
            this.Remainder.Controls.Add(this.label7);
            this.Remainder.Controls.Add(this.Blink);
            this.Remainder.Controls.Add(this.BringFocus);
            this.Remainder.Location = new System.Drawing.Point(6, 90);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(357, 94);
            this.Remainder.TabIndex = 5;
            this.Remainder.TabStop = false;
            this.Remainder.Text = "Remainder";
            // 
            // PopUP
            // 
            this.PopUP.AutoSize = true;
            this.PopUP.Checked = true;
            this.PopUP.Location = new System.Drawing.Point(137, 29);
            this.PopUP.Name = "PopUP";
            this.PopUP.Size = new System.Drawing.Size(65, 19);
            this.PopUP.TabIndex = 0;
            this.PopUP.TabStop = true;
            this.PopUP.Text = "Pop Up";
            this.PopUP.UseVisualStyleBackColor = true;
            this.PopUP.CheckedChanged += new System.EventHandler(this.PopUP_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Frequency (in mins)";
            // 
            // Blink
            // 
            this.Blink.AutoSize = true;
            this.Blink.Location = new System.Drawing.Point(220, 29);
            this.Blink.Name = "Blink";
            this.Blink.Size = new System.Drawing.Size(52, 19);
            this.Blink.TabIndex = 1;
            this.Blink.Text = "Blink";
            this.Blink.UseVisualStyleBackColor = true;
            this.Blink.CheckedChanged += new System.EventHandler(this.Blink_CheckedChanged);
            // 
            // BringFocus
            // 
            this.BringFocus.AutoSize = true;
            this.BringFocus.Location = new System.Drawing.Point(19, 29);
            this.BringFocus.Name = "BringFocus";
            this.BringFocus.Size = new System.Drawing.Size(72, 15);
            this.BringFocus.TabIndex = 2;
            this.BringFocus.Text = "Bring Focus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Config File";
            // 
            // TipTimeLeft
            // 
            this.TipTimeLeft.ToolTipTitle = "TimeLeft";
            // 
            // TaskPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(377, 346);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskPriority";
            this.Text = "Interrupt Callback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskPriority_FormClosing);
            this.Load += new System.EventHandler(this.TaskPriority_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Remainder.ResumeLayout(false);
            this.Remainder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip UrgentTip;
        private System.Windows.Forms.Timer BringFocusTimer;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton Blink;
        private System.Windows.Forms.RadioButton PopUP;
        private System.Windows.Forms.GroupBox Remainder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BringFocus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar TimeLeft;
        public System.Windows.Forms.ComboBox Frequency;
        public System.Windows.Forms.ComboBox Urgent_Hrs;
        public System.Windows.Forms.ComboBox Urgent_Mins;
        private System.Windows.Forms.ToolTip TipTimeLeft;

    }
}

