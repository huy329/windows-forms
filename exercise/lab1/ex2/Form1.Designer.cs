
namespace cau2
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Movie = new System.Windows.Forms.CheckBox();
            this.checkBox_Sport = new System.Windows.Forms.CheckBox();
            this.comboBox_Movie = new System.Windows.Forms.ComboBox();
            this.textBox_Sport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_Male = new System.Windows.Forms.RadioButton();
            this.radio_Female = new System.Windows.Forms.RadioButton();
            this.dateTime_Birthday = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sở thích của bạn là";
            // 
            // checkBox_Movie
            // 
            this.checkBox_Movie.AutoSize = true;
            this.checkBox_Movie.Location = new System.Drawing.Point(56, 119);
            this.checkBox_Movie.Name = "checkBox_Movie";
            this.checkBox_Movie.Size = new System.Drawing.Size(92, 21);
            this.checkBox_Movie.TabIndex = 1;
            this.checkBox_Movie.Text = "Xem phim";
            this.checkBox_Movie.UseVisualStyleBackColor = true;
            this.checkBox_Movie.CheckedChanged += new System.EventHandler(this.checkBox_Movie_CheckedChanged);
            // 
            // checkBox_Sport
            // 
            this.checkBox_Sport.AutoSize = true;
            this.checkBox_Sport.Location = new System.Drawing.Point(56, 182);
            this.checkBox_Sport.Name = "checkBox_Sport";
            this.checkBox_Sport.Size = new System.Drawing.Size(87, 21);
            this.checkBox_Sport.TabIndex = 2;
            this.checkBox_Sport.Text = "Thể thao";
            this.checkBox_Sport.UseVisualStyleBackColor = true;
            this.checkBox_Sport.CheckedChanged += new System.EventHandler(this.checkBox_Sport_CheckedChanged);
            // 
            // comboBox_Movie
            // 
            this.comboBox_Movie.Enabled = false;
            this.comboBox_Movie.FormattingEnabled = true;
            this.comboBox_Movie.Items.AddRange(new object[] {
            "Kinh dị",
            "Hành động ",
            "Lãng mạn"});
            this.comboBox_Movie.Location = new System.Drawing.Point(221, 117);
            this.comboBox_Movie.Name = "comboBox_Movie";
            this.comboBox_Movie.Size = new System.Drawing.Size(279, 24);
            this.comboBox_Movie.TabIndex = 3;
            this.comboBox_Movie.Text = "Thể loại yêu thích";
            // 
            // textBox_Sport
            // 
            this.textBox_Sport.Enabled = false;
            this.textBox_Sport.Location = new System.Drawing.Point(221, 180);
            this.textBox_Sport.Name = "textBox_Sport";
            this.textBox_Sport.Size = new System.Drawing.Size(279, 22);
            this.textBox_Sport.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bạn là..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            // 
            // radio_Male
            // 
            this.radio_Male.AutoSize = true;
            this.radio_Male.Location = new System.Drawing.Point(221, 246);
            this.radio_Male.Name = "radio_Male";
            this.radio_Male.Size = new System.Drawing.Size(58, 21);
            this.radio_Male.TabIndex = 7;
            this.radio_Male.TabStop = true;
            this.radio_Male.Text = "Nam";
            this.radio_Male.UseVisualStyleBackColor = true;
            // 
            // radio_Female
            // 
            this.radio_Female.AutoSize = true;
            this.radio_Female.Location = new System.Drawing.Point(453, 246);
            this.radio_Female.Name = "radio_Female";
            this.radio_Female.Size = new System.Drawing.Size(47, 21);
            this.radio_Female.TabIndex = 8;
            this.radio_Female.TabStop = true;
            this.radio_Female.Text = "Nữ";
            this.radio_Female.UseVisualStyleBackColor = true;
            // 
            // dateTime_Birthday
            // 
            this.dateTime_Birthday.Location = new System.Drawing.Point(221, 316);
            this.dateTime_Birthday.Name = "dateTime_Birthday";
            this.dateTime_Birthday.Size = new System.Drawing.Size(279, 22);
            this.dateTime_Birthday.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lưu thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTime_Birthday);
            this.Controls.Add(this.radio_Female);
            this.Controls.Add(this.radio_Male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Sport);
            this.Controls.Add(this.comboBox_Movie);
            this.Controls.Add(this.checkBox_Sport);
            this.Controls.Add(this.checkBox_Movie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Movie;
        private System.Windows.Forms.CheckBox checkBox_Sport;
        private System.Windows.Forms.ComboBox comboBox_Movie;
        private System.Windows.Forms.TextBox textBox_Sport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_Male;
        private System.Windows.Forms.RadioButton radio_Female;
        private System.Windows.Forms.DateTimePicker dateTime_Birthday;
        private System.Windows.Forms.Button button1;
    }
}

