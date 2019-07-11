namespace Studiepad.GUI
{
    partial class StudyCourse
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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.RadioButtonAprrove = new System.Windows.Forms.RadioButton();
            this.RadioButtonDeny = new System.Windows.Forms.RadioButton();
            this.LabelErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(485, 380);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Opslaan";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.Enabled = false;
            this.TextBoxNote.Location = new System.Drawing.Point(257, 232);
            this.TextBoxNote.Multiline = true;
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxNote.Size = new System.Drawing.Size(303, 107);
            this.TextBoxNote.TabIndex = 2;
            this.TextBoxNote.TextChanged += new System.EventHandler(this.TextBoxNote_TextChanged);
            // 
            // RadioButtonAprrove
            // 
            this.RadioButtonAprrove.AutoCheck = false;
            this.RadioButtonAprrove.AutoSize = true;
            this.RadioButtonAprrove.Location = new System.Drawing.Point(257, 383);
            this.RadioButtonAprrove.Name = "RadioButtonAprrove";
            this.RadioButtonAprrove.Size = new System.Drawing.Size(84, 17);
            this.RadioButtonAprrove.TabIndex = 3;
            this.RadioButtonAprrove.TabStop = true;
            this.RadioButtonAprrove.Text = "Goedkeuren";
            this.RadioButtonAprrove.UseVisualStyleBackColor = true;
            this.RadioButtonAprrove.CheckedChanged += new System.EventHandler(this.RadioButtonAprrove_CheckedChanged);
            // 
            // RadioButtonDeny
            // 
            this.RadioButtonDeny.AutoCheck = false;
            this.RadioButtonDeny.AutoSize = true;
            this.RadioButtonDeny.Location = new System.Drawing.Point(347, 383);
            this.RadioButtonDeny.Name = "RadioButtonDeny";
            this.RadioButtonDeny.Size = new System.Drawing.Size(68, 17);
            this.RadioButtonDeny.TabIndex = 4;
            this.RadioButtonDeny.TabStop = true;
            this.RadioButtonDeny.Text = "Afkeuren";
            this.RadioButtonDeny.UseVisualStyleBackColor = true;
            this.RadioButtonDeny.CheckedChanged += new System.EventHandler(this.RadioButtonDeny_CheckedChanged);
            // 
            // LabelErrorMessage
            // 
            this.LabelErrorMessage.AutoSize = true;
            this.LabelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorMessage.Location = new System.Drawing.Point(257, 346);
            this.LabelErrorMessage.Name = "LabelErrorMessage";
            this.LabelErrorMessage.Size = new System.Drawing.Size(268, 13);
            this.LabelErrorMessage.TabIndex = 5;
            this.LabelErrorMessage.Text = "Geef toelichting waarom het studiepad wordt afgekeurd";
            this.LabelErrorMessage.Visible = false;
            // 
            // StudyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelErrorMessage);
            this.Controls.Add(this.RadioButtonDeny);
            this.Controls.Add(this.RadioButtonAprrove);
            this.Controls.Add(this.TextBoxNote);
            this.Controls.Add(this.ButtonSave);
            this.Name = "StudyCourse";
            this.Text = "StudyCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxNote;
        private System.Windows.Forms.RadioButton RadioButtonAprrove;
        private System.Windows.Forms.RadioButton RadioButtonDeny;
        private System.Windows.Forms.Label LabelErrorMessage;
    }
}