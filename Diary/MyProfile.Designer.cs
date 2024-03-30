namespace Diary
{
    partial class MyProfile
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
            this.AudienceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LessonTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LessonNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GoBackButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AudienceTextBox
            // 
            this.AudienceTextBox.Location = new System.Drawing.Point(105, 271);
            this.AudienceTextBox.Name = "AudienceTextBox";
            this.AudienceTextBox.Size = new System.Drawing.Size(270, 22);
            this.AudienceTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(154, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Направление";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(105, 196);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(270, 22);
            this.TimeTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(170, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Институт";
            // 
            // LessonTypeTextBox
            // 
            this.LessonTypeTextBox.Location = new System.Drawing.Point(105, 122);
            this.LessonTypeTextBox.Name = "LessonTypeTextBox";
            this.LessonTypeTextBox.Size = new System.Drawing.Size(270, 22);
            this.LessonTypeTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Группа";
            // 
            // LessonNameTextBox
            // 
            this.LessonNameTextBox.Location = new System.Drawing.Point(105, 47);
            this.LessonNameTextBox.Name = "LessonNameTextBox";
            this.LessonNameTextBox.Size = new System.Drawing.Size(270, 22);
            this.LessonNameTextBox.TabIndex = 16;
            this.LessonNameTextBox.TextChanged += new System.EventHandler(this.LessonNameTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(206, 21);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(60, 25);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(100, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Адрес электронной почты";
            // 
            // GoBackButton1
            // 
            this.GoBackButton1.Location = new System.Drawing.Point(131, 393);
            this.GoBackButton1.Name = "GoBackButton1";
            this.GoBackButton1.Size = new System.Drawing.Size(228, 79);
            this.GoBackButton1.TabIndex = 32;
            this.GoBackButton1.Text = "Сохранить изменения";
            this.GoBackButton1.UseVisualStyleBackColor = true;
            this.GoBackButton1.Click += new System.EventHandler(this.GoBackButton1_Click);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(489, 495);
            this.Controls.Add(this.GoBackButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AudienceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LessonTypeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonNameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.MaximizeBox = false;
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AudienceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LessonTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LessonNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GoBackButton1;
    }
}