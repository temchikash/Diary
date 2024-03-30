namespace Diary
{
    partial class MainMenu
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
            this.LessonLinkButton = new System.Windows.Forms.Button();
            this.GroupLinkButton = new System.Windows.Forms.Button();
            this.ProfileLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LessonLinkButton
            // 
            this.LessonLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LessonLinkButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LessonLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLinkButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LessonLinkButton.Location = new System.Drawing.Point(20, 12);
            this.LessonLinkButton.Name = "LessonLinkButton";
            this.LessonLinkButton.Size = new System.Drawing.Size(994, 201);
            this.LessonLinkButton.TabIndex = 0;
            this.LessonLinkButton.Text = "Расписание";
            this.LessonLinkButton.UseVisualStyleBackColor = false;
            this.LessonLinkButton.Click += new System.EventHandler(this.LessonLinkButton_Click);
            // 
            // GroupLinkButton
            // 
            this.GroupLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupLinkButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GroupLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLinkButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupLinkButton.Location = new System.Drawing.Point(20, 233);
            this.GroupLinkButton.Name = "GroupLinkButton";
            this.GroupLinkButton.Size = new System.Drawing.Size(994, 188);
            this.GroupLinkButton.TabIndex = 1;
            this.GroupLinkButton.Text = "Учебные группы";
            this.GroupLinkButton.UseVisualStyleBackColor = false;
            this.GroupLinkButton.Click += new System.EventHandler(this.GroupLinkButton_Click);
            // 
            // ProfileLinkButton
            // 
            this.ProfileLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileLinkButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProfileLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileLinkButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProfileLinkButton.Location = new System.Drawing.Point(20, 438);
            this.ProfileLinkButton.Name = "ProfileLinkButton";
            this.ProfileLinkButton.Size = new System.Drawing.Size(994, 208);
            this.ProfileLinkButton.TabIndex = 2;
            this.ProfileLinkButton.Text = "Добавить предмет";
            this.ProfileLinkButton.UseVisualStyleBackColor = false;
            this.ProfileLinkButton.Click += new System.EventHandler(this.ProfileLinkButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1026, 657);
            this.Controls.Add(this.ProfileLinkButton);
            this.Controls.Add(this.GroupLinkButton);
            this.Controls.Add(this.LessonLinkButton);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LessonLinkButton;
        private System.Windows.Forms.Button GroupLinkButton;
        private System.Windows.Forms.Button ProfileLinkButton;
    }
}