namespace Studiepad.GUI
{
    partial class Login
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
            this.LabelErrorLogin = new System.Windows.Forms.Label();
            this.StudentLoginButton = new System.Windows.Forms.Button();
            this.StudyCoachLoginButton = new System.Windows.Forms.Button();
            this.TeamleaderLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelErrorLogin
            // 
            this.LabelErrorLogin.AutoSize = true;
            this.LabelErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorLogin.Location = new System.Drawing.Point(357, 293);
            this.LabelErrorLogin.Name = "LabelErrorLogin";
            this.LabelErrorLogin.Size = new System.Drawing.Size(0, 13);
            this.LabelErrorLogin.TabIndex = 5;
            this.LabelErrorLogin.Visible = false;
            // 
            // StudentLoginButton
            // 
            this.StudentLoginButton.Location = new System.Drawing.Point(12, 12);
            this.StudentLoginButton.Name = "StudentLoginButton";
            this.StudentLoginButton.Size = new System.Drawing.Size(130, 73);
            this.StudentLoginButton.TabIndex = 6;
            this.StudentLoginButton.Text = "Student";
            this.StudentLoginButton.UseVisualStyleBackColor = true;
            this.StudentLoginButton.Click += new System.EventHandler(this.StudentLoginButton_Click);
            // 
            // StudyCoachLoginButton
            // 
            this.StudyCoachLoginButton.Location = new System.Drawing.Point(12, 114);
            this.StudyCoachLoginButton.Name = "StudyCoachLoginButton";
            this.StudyCoachLoginButton.Size = new System.Drawing.Size(130, 78);
            this.StudyCoachLoginButton.TabIndex = 7;
            this.StudyCoachLoginButton.Text = "StudyCoach";
            this.StudyCoachLoginButton.UseVisualStyleBackColor = true;
            this.StudyCoachLoginButton.Click += new System.EventHandler(this.StudyCoachLoginButton_Click);
            // 
            // TeamleaderLoginButton
            // 
            this.TeamleaderLoginButton.Location = new System.Drawing.Point(12, 224);
            this.TeamleaderLoginButton.Name = "TeamleaderLoginButton";
            this.TeamleaderLoginButton.Size = new System.Drawing.Size(130, 78);
            this.TeamleaderLoginButton.TabIndex = 8;
            this.TeamleaderLoginButton.Text = "Teamleader";
            this.TeamleaderLoginButton.UseVisualStyleBackColor = true;
            this.TeamleaderLoginButton.Click += new System.EventHandler(this.TeamleaderLoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(222, 334);
            this.Controls.Add(this.TeamleaderLoginButton);
            this.Controls.Add(this.StudyCoachLoginButton);
            this.Controls.Add(this.StudentLoginButton);
            this.Controls.Add(this.LabelErrorLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Studiepad";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelErrorLogin;
        private System.Windows.Forms.Button StudentLoginButton;
        private System.Windows.Forms.Button StudyCoachLoginButton;
        private System.Windows.Forms.Button TeamleaderLoginButton;
    }
}