namespace Studiepad.GUI
{
    partial class StudentInformation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StudentOverview = new System.Windows.Forms.Button();
            this.SubscribedOverviewButton = new System.Windows.Forms.Button();
            this.StudyCourseButton = new System.Windows.Forms.Button();
            this.EndStudyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartStudyTextBox = new System.Windows.Forms.TextBox();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StudyTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.StudyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StudentOverview);
            this.splitContainer1.Panel1.Controls.Add(this.SubscribedOverviewButton);
            this.splitContainer1.Panel1.Controls.Add(this.StudyCourseButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.EndStudyTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.StartStudyTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.StartDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.StudyTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.LastNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.StudyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.FirstNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.FirstNameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 723);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            // 
            // StudentOverview
            // 
            this.StudentOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentOverview.Location = new System.Drawing.Point(3, 655);
            this.StudentOverview.Name = "StudentOverview";
            this.StudentOverview.Size = new System.Drawing.Size(163, 65);
            this.StudentOverview.TabIndex = 20;
            this.StudentOverview.Text = "Terug naar overzicht";
            this.StudentOverview.UseVisualStyleBackColor = true;
            this.StudentOverview.Click += new System.EventHandler(this.StudentOverview_Click);
            // 
            // SubscribedOverviewButton
            // 
            this.SubscribedOverviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubscribedOverviewButton.Location = new System.Drawing.Point(3, 101);
            this.SubscribedOverviewButton.Name = "SubscribedOverviewButton";
            this.SubscribedOverviewButton.Size = new System.Drawing.Size(160, 43);
            this.SubscribedOverviewButton.TabIndex = 1;
            this.SubscribedOverviewButton.Text = "Inschrijvingen";
            this.SubscribedOverviewButton.UseVisualStyleBackColor = true;
            this.SubscribedOverviewButton.Click += new System.EventHandler(this.SubscribedOverviewButton_Click);
            // 
            // StudyCourseButton
            // 
            this.StudyCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyCourseButton.Location = new System.Drawing.Point(3, 32);
            this.StudyCourseButton.Name = "StudyCourseButton";
            this.StudyCourseButton.Size = new System.Drawing.Size(160, 43);
            this.StudyCourseButton.TabIndex = 0;
            this.StudyCourseButton.Text = "Studiepad";
            this.StudyCourseButton.UseVisualStyleBackColor = true;
            this.StudyCourseButton.Click += new System.EventHandler(this.StudyCourseButton_Click);
            // 
            // EndStudyTextBox
            // 
            this.EndStudyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndStudyTextBox.Location = new System.Drawing.Point(267, 256);
            this.EndStudyTextBox.Name = "EndStudyTextBox";
            this.EndStudyTextBox.Size = new System.Drawing.Size(603, 27);
            this.EndStudyTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Einddatum studie:";
            // 
            // StartStudyTextBox
            // 
            this.StartStudyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStudyTextBox.Location = new System.Drawing.Point(267, 199);
            this.StartStudyTextBox.Name = "StartStudyTextBox";
            this.StartStudyTextBox.Size = new System.Drawing.Size(603, 27);
            this.StartStudyTextBox.TabIndex = 17;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(95, 202);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(146, 20);
            this.StartDateLabel.TabIndex = 16;
            this.StartDateLabel.Text = "Startdatum studie:";
            // 
            // StudyTextBox
            // 
            this.StudyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyTextBox.Location = new System.Drawing.Point(267, 144);
            this.StudyTextBox.Name = "StudyTextBox";
            this.StudyTextBox.Size = new System.Drawing.Size(603, 27);
            this.StudyTextBox.TabIndex = 15;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(267, 90);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(603, 27);
            this.LastNameTextBox.TabIndex = 14;
            // 
            // StudyLabel
            // 
            this.StudyLabel.AutoSize = true;
            this.StudyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyLabel.Location = new System.Drawing.Point(180, 147);
            this.StudyLabel.Name = "StudyLabel";
            this.StudyLabel.Size = new System.Drawing.Size(61, 20);
            this.StudyLabel.TabIndex = 13;
            this.StudyLabel.Text = "Studie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Achternaam:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(151, 45);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "Voornaam:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(267, 42);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(603, 27);
            this.FirstNameTextBox.TabIndex = 10;
            // 
            // StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 723);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StudentInformation";
            this.Text = "StudentInformation";
            this.Load += new System.EventHandler(this.StudentInformation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button StudentOverview;
        private System.Windows.Forms.Button SubscribedOverviewButton;
        private System.Windows.Forms.Button StudyCourseButton;
        private System.Windows.Forms.TextBox EndStudyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartStudyTextBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TextBox StudyTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label StudyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
    }
}