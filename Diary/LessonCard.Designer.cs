namespace Diary
{
    partial class LessonCard
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LessonNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LessonTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeekDayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AudienceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TeacherTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(17, 10);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(199, 25);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Название предмета";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // LessonNameTextBox
            // 
            this.LessonNameTextBox.Location = new System.Drawing.Point(22, 38);
            this.LessonNameTextBox.Name = "LessonNameTextBox";
            this.LessonNameTextBox.ReadOnly = true;
            this.LessonNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.LessonNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип занятия";
            // 
            // LessonTypeTextBox
            // 
            this.LessonTypeTextBox.Location = new System.Drawing.Point(22, 91);
            this.LessonTypeTextBox.Name = "LessonTypeTextBox";
            this.LessonTypeTextBox.ReadOnly = true;
            this.LessonTypeTextBox.Size = new System.Drawing.Size(238, 22);
            this.LessonTypeTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(22, 144);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(238, 22);
            this.TimeTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "День недели";
            // 
            // WeekDayTextBox
            // 
            this.WeekDayTextBox.Location = new System.Drawing.Point(22, 197);
            this.WeekDayTextBox.Name = "WeekDayTextBox";
            this.WeekDayTextBox.ReadOnly = true;
            this.WeekDayTextBox.Size = new System.Drawing.Size(238, 22);
            this.WeekDayTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Аудитория";
            // 
            // AudienceTextBox
            // 
            this.AudienceTextBox.Location = new System.Drawing.Point(22, 250);
            this.AudienceTextBox.Name = "AudienceTextBox";
            this.AudienceTextBox.ReadOnly = true;
            this.AudienceTextBox.Size = new System.Drawing.Size(238, 22);
            this.AudienceTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Преподаватель";
            // 
            // TeacherTextBox
            // 
            this.TeacherTextBox.Location = new System.Drawing.Point(22, 303);
            this.TeacherTextBox.Name = "TeacherTextBox";
            this.TeacherTextBox.ReadOnly = true;
            this.TeacherTextBox.Size = new System.Drawing.Size(238, 22);
            this.TeacherTextBox.TabIndex = 14;
            // 
            // LessonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(300, 362);
            this.Controls.Add(this.TeacherTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AudienceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeekDayTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LessonTypeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonNameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.MaximizeBox = false;
            this.Name = "LessonCard";
            this.Text = "LessonCardStudent";
            this.Load += new System.EventHandler(this.LessonCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LessonNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LessonTypeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeekDayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AudienceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TeacherTextBox;
    }
}