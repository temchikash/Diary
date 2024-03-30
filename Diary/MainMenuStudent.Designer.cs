namespace Diary
{
    partial class MainMenuStudent
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
            this.AcademicPerfomanceLink = new System.Windows.Forms.Button();
            this.ProfileLinkButton = new System.Windows.Forms.Button();
            this.LessonLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcademicPerfomanceLink
            // 
            this.AcademicPerfomanceLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcademicPerfomanceLink.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AcademicPerfomanceLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcademicPerfomanceLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AcademicPerfomanceLink.Location = new System.Drawing.Point(20, 234);
            this.AcademicPerfomanceLink.Name = "AcademicPerfomanceLink";
            this.AcademicPerfomanceLink.Size = new System.Drawing.Size(994, 236);
            this.AcademicPerfomanceLink.TabIndex = 7;
            this.AcademicPerfomanceLink.Text = "Успеваемость";
            this.AcademicPerfomanceLink.UseVisualStyleBackColor = false;
            this.AcademicPerfomanceLink.Click += new System.EventHandler(this.AcademicPerfomanceLink_Click);
            // 
            // ProfileLinkButton
            // 
            this.ProfileLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileLinkButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProfileLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileLinkButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProfileLinkButton.Location = new System.Drawing.Point(20, 491);
            this.ProfileLinkButton.Name = "ProfileLinkButton";
            this.ProfileLinkButton.Size = new System.Drawing.Size(994, 241);
            this.ProfileLinkButton.TabIndex = 6;
            this.ProfileLinkButton.Text = "Личный кабинет";
            this.ProfileLinkButton.UseVisualStyleBackColor = false;
            this.ProfileLinkButton.Click += new System.EventHandler(this.ProfileLinkButton_Click);
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
            this.LessonLinkButton.TabIndex = 4;
            this.LessonLinkButton.Text = "Расписание";
            this.LessonLinkButton.UseVisualStyleBackColor = false;
            this.LessonLinkButton.Click += new System.EventHandler(this.LessonLinkButton_Click);
            // 
            // MainMenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1026, 759);
            this.Controls.Add(this.AcademicPerfomanceLink);
            this.Controls.Add(this.ProfileLinkButton);
            this.Controls.Add(this.LessonLinkButton);
            this.MaximizeBox = false;
            this.Name = "MainMenuStudent";
            this.Text = "MainMenuStudent";
            this.Load += new System.EventHandler(this.MainMenuStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcademicPerfomanceLink;
        private System.Windows.Forms.Button ProfileLinkButton;
        private System.Windows.Forms.Button LessonLinkButton;
    }
}