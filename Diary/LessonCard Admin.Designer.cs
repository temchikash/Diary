namespace Diary
{
    partial class LessonCard_Admin
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
            this.RedactButton = new System.Windows.Forms.Button();
            this.TeacherTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AudienceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LessonTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LessonNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedactButton
            // 
            this.RedactButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RedactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RedactButton.Location = new System.Drawing.Point(129, 461);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(238, 60);
            this.RedactButton.TabIndex = 30;
            this.RedactButton.Text = "Добавить занятие ";
            this.RedactButton.UseVisualStyleBackColor = false;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // TeacherTextBox
            // 
            this.TeacherTextBox.Location = new System.Drawing.Point(20, 386);
            this.TeacherTextBox.Name = "TeacherTextBox";
            this.TeacherTextBox.Size = new System.Drawing.Size(238, 22);
            this.TeacherTextBox.TabIndex = 29;
            this.TeacherTextBox.TextChanged += new System.EventHandler(this.TeacherTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Преподаватель";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AudienceTextBox
            // 
            this.AudienceTextBox.Location = new System.Drawing.Point(20, 334);
            this.AudienceTextBox.Name = "AudienceTextBox";
            this.AudienceTextBox.Size = new System.Drawing.Size(238, 22);
            this.AudienceTextBox.TabIndex = 27;
            this.AudienceTextBox.TextChanged += new System.EventHandler(this.AudienceTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Аудитория";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "День недели";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Время";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LessonTypeTextBox
            // 
            this.LessonTypeTextBox.Location = new System.Drawing.Point(20, 174);
            this.LessonTypeTextBox.Name = "LessonTypeTextBox";
            this.LessonTypeTextBox.Size = new System.Drawing.Size(238, 22);
            this.LessonTypeTextBox.TabIndex = 21;
            this.LessonTypeTextBox.TextChanged += new System.EventHandler(this.LessonTypeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Тип занятия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LessonNameTextBox
            // 
            this.LessonNameTextBox.Location = new System.Drawing.Point(20, 39);
            this.LessonNameTextBox.Name = "LessonNameTextBox";
            this.LessonNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.LessonNameTextBox.TabIndex = 19;
            this.LessonNameTextBox.TextChanged += new System.EventHandler(this.LessonNameTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(15, 11);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(199, 25);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Название предмета";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 225);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(20, 281);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 24);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Номер группы";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LessonCard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(516, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.TeacherTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AudienceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LessonTypeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonNameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.MaximizeBox = false;
            this.Name = "LessonCard_Admin";
            this.Text = "LessonCardAdmin";
            this.Load += new System.EventHandler(this.LessonCard_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.TextBox TeacherTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AudienceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LessonTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LessonNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}