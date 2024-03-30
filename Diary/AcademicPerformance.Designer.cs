namespace Diary
{
    partial class AcademicPerformance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Discipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ball1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ball2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Discipline,
            this.Ball1,
            this.tip,
            this.ball2,
            this.date_exam,
            this.itog});
            this.dataGridView1.Location = new System.Drawing.Point(26, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 392);
            this.dataGridView1.TabIndex = 10;
            // 
            // Discipline
            // 
            this.Discipline.HeaderText = "Дисциплина";
            this.Discipline.MinimumWidth = 8;
            this.Discipline.Name = "Discipline";
            this.Discipline.Width = 200;
            // 
            // Ball1
            // 
            this.Ball1.HeaderText = "Балл за семестр";
            this.Ball1.MinimumWidth = 8;
            this.Ball1.Name = "Ball1";
            this.Ball1.Width = 200;
            // 
            // tip
            // 
            this.tip.HeaderText = "Тип";
            this.tip.MinimumWidth = 8;
            this.tip.Name = "tip";
            this.tip.Width = 200;
            // 
            // ball2
            // 
            this.ball2.HeaderText = "Балл";
            this.ball2.MinimumWidth = 8;
            this.ball2.Name = "ball2";
            this.ball2.Width = 200;
            // 
            // date_exam
            // 
            this.date_exam.HeaderText = "Дата сдачи";
            this.date_exam.MinimumWidth = 8;
            this.date_exam.Name = "date_exam";
            this.date_exam.Width = 200;
            // 
            // itog
            // 
            this.itog.HeaderText = "Итоговая оценка";
            this.itog.MinimumWidth = 8;
            this.itog.Name = "itog";
            this.itog.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(406, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Успеваемость за работу в семестре";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить  или изменить Дисциплину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 68);
            this.button3.TabIndex = 14;
            this.button3.Text = "Удалить Дисциплину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AcademicPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1261, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "AcademicPerformance";
            this.Text = "AcademicPerformance";
            this.Load += new System.EventHandler(this.AcademicPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ball1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ball2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn itog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}