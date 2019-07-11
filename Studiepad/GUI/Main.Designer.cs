namespace Studiepad
{
    partial class Main
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
            this.StudentOverviewButton = new System.Windows.Forms.Button();
            this.ReportOverviewButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RegisterPageButton = new System.Windows.Forms.Button();
            this.StudyCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentOverviewButton
            // 
            this.StudentOverviewButton.Location = new System.Drawing.Point(12, 12);
            this.StudentOverviewButton.Name = "StudentOverviewButton";
            this.StudentOverviewButton.Size = new System.Drawing.Size(151, 99);
            this.StudentOverviewButton.TabIndex = 0;
            this.StudentOverviewButton.Text = "Studenten overzicht";
            this.StudentOverviewButton.UseVisualStyleBackColor = true;
            this.StudentOverviewButton.Click += new System.EventHandler(this.StudentOverviewButton_Click);
            // 
            // ReportOverviewButton
            // 
            this.ReportOverviewButton.Location = new System.Drawing.Point(12, 269);
            this.ReportOverviewButton.Name = "ReportOverviewButton";
            this.ReportOverviewButton.Size = new System.Drawing.Size(151, 99);
            this.ReportOverviewButton.TabIndex = 1;
            this.ReportOverviewButton.Text = "Rapporten overzicht";
            this.ReportOverviewButton.UseVisualStyleBackColor = true;
            this.ReportOverviewButton.Click += new System.EventHandler(this.ReportOverviewButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 418);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(151, 117);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Terug";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RegisterPageButton
            // 
            this.RegisterPageButton.Location = new System.Drawing.Point(12, 142);
            this.RegisterPageButton.Name = "RegisterPageButton";
            this.RegisterPageButton.Size = new System.Drawing.Size(151, 99);
            this.RegisterPageButton.TabIndex = 3;
            this.RegisterPageButton.Text = "Inschrijven";
            this.RegisterPageButton.UseVisualStyleBackColor = true;
            this.RegisterPageButton.Click += new System.EventHandler(this.RegisterPageButton_Click);
            // 
            // StudyCourseButton
            // 
            this.StudyCourseButton.Location = new System.Drawing.Point(201, 12);
            this.StudyCourseButton.Name = "StudyCourseButton";
            this.StudyCourseButton.Size = new System.Drawing.Size(151, 99);
            this.StudyCourseButton.TabIndex = 4;
            this.StudyCourseButton.Text = "Studiepad bekijken";
            this.StudyCourseButton.UseVisualStyleBackColor = true;
            this.StudyCourseButton.Click += new System.EventHandler(this.StudyCourseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 547);
            this.Controls.Add(this.StudyCourseButton);
            this.Controls.Add(this.RegisterPageButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ReportOverviewButton);
            this.Controls.Add(this.StudentOverviewButton);
            this.Name = "Main";
            this.Text = "Welkom bij Studiapad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentOverviewButton;
        private System.Windows.Forms.Button ReportOverviewButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RegisterPageButton;
        private System.Windows.Forms.Button StudyCourseButton;
    }
}

