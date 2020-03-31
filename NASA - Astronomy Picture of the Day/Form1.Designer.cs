namespace NASA___Astronomy_Picture_of_the_Day
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImagesTodayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LimitRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowTodaysImageCheckBox = new System.Windows.Forms.CheckBox();
            this.ImageCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(22, 25);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 0;
            this.MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // LaunchButton
            // 
            this.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchButton.Location = new System.Drawing.Point(58, 194);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(142, 36);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Go to APOD launch date";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImagesTodayTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.LimitRangeCheckBox);
            this.groupBox1.Controls.Add(this.ShowTodaysImageCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ImagesTodayTextBox
            // 
            this.ImagesTodayTextBox.Location = new System.Drawing.Point(158, 77);
            this.ImagesTodayTextBox.Name = "ImagesTodayTextBox";
            this.ImagesTodayTextBox.ReadOnly = true;
            this.ImagesTodayTextBox.Size = new System.Drawing.Size(32, 20);
            this.ImagesTodayTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Images downloaded today:.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(196, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // LimitRangeCheckBox
            // 
            this.LimitRangeCheckBox.AutoSize = true;
            this.LimitRangeCheckBox.Location = new System.Drawing.Point(14, 47);
            this.LimitRangeCheckBox.Name = "LimitRangeCheckBox";
            this.LimitRangeCheckBox.Size = new System.Drawing.Size(148, 17);
            this.LimitRangeCheckBox.TabIndex = 1;
            this.LimitRangeCheckBox.Text = "Limit range to current year";
            this.LimitRangeCheckBox.UseVisualStyleBackColor = true;
            this.LimitRangeCheckBox.CheckedChanged += new System.EventHandler(this.LimitRangeCheckBox_CheckedChanged);
            // 
            // ShowTodaysImageCheckBox
            // 
            this.ShowTodaysImageCheckBox.AutoSize = true;
            this.ShowTodaysImageCheckBox.Location = new System.Drawing.Point(14, 19);
            this.ShowTodaysImageCheckBox.Name = "ShowTodaysImageCheckBox";
            this.ShowTodaysImageCheckBox.Size = new System.Drawing.Size(173, 17);
            this.ShowTodaysImageCheckBox.TabIndex = 0;
            this.ShowTodaysImageCheckBox.Text = "Show today\'s image on start up";
            this.ShowTodaysImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImageCopyrightTextBox
            // 
            this.ImageCopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ImageCopyrightTextBox.Location = new System.Drawing.Point(33, 375);
            this.ImageCopyrightTextBox.Name = "ImageCopyrightTextBox";
            this.ImageCopyrightTextBox.Size = new System.Drawing.Size(217, 20);
            this.ImageCopyrightTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image Credit and Copyright";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DescriptionTextBox.Location = new System.Drawing.Point(33, 426);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(847, 132);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(270, 12);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(610, 401);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox.TabIndex = 7;
            this.ImagePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "** Choose a date to display the image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageCopyrightTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.MonthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NASA\'s Astronomy Picture of the Day (APOD)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LimitRangeCheckBox;
        private System.Windows.Forms.CheckBox ShowTodaysImageCheckBox;
        private System.Windows.Forms.TextBox ImagesTodayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ImageCopyrightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

