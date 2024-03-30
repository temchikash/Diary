namespace Diary
{
    partial class Groups
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Group_listBox = new System.Windows.Forms.ListBox();
            this.GoBackButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Group_listBox);
            this.panel1.Controls.Add(this.GoBackButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 538);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Смотреть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Group_listBox
            // 
            this.Group_listBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Group_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_listBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Group_listBox.FormattingEnabled = true;
            this.Group_listBox.ItemHeight = 25;
            this.Group_listBox.Location = new System.Drawing.Point(12, 110);
            this.Group_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_listBox.Name = "Group_listBox";
            this.Group_listBox.Size = new System.Drawing.Size(132, 304);
            this.Group_listBox.TabIndex = 17;
            // 
            // GoBackButton1
            // 
            this.GoBackButton1.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton1.Name = "GoBackButton1";
            this.GoBackButton1.Size = new System.Drawing.Size(124, 48);
            this.GoBackButton1.TabIndex = 16;
            this.GoBackButton1.Text = "Вернуться";
            this.GoBackButton1.UseVisualStyleBackColor = true;
            this.GoBackButton1.Click += new System.EventHandler(this.GoBackButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name_listBox
            // 
            this.Name_listBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Name_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_listBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Name_listBox.FormattingEnabled = true;
            this.Name_listBox.ItemHeight = 31;
            this.Name_listBox.Location = new System.Drawing.Point(204, 101);
            this.Name_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_listBox.Name = "Name_listBox";
            this.Name_listBox.Size = new System.Drawing.Size(604, 345);
            this.Name_listBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(219, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ученики";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 64);
            this.button2.TabIndex = 20;
            this.button2.Text = "Посмотреть успеваемость";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 464);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 64);
            this.button3.TabIndex = 21;
            this.button3.Text = "Редактировать данные студента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(868, 538);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_listBox);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoBackButton1;
        private System.Windows.Forms.ListBox Group_listBox;
        private System.Windows.Forms.ListBox Name_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}