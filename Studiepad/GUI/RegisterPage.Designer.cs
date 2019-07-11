namespace Studiepad.GUI
{
    partial class RegisterPage
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
            this.ModulesDataGrid = new System.Windows.Forms.DataGridView();
            this.Onderwijseenheid_Button = new System.Windows.Forms.Button();
            this.Minor_Button = new System.Windows.Forms.Button();
            this.Stage_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.debug_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ModulesDataGrid
            // 
            this.ModulesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModulesDataGrid.Location = new System.Drawing.Point(175, 12);
            this.ModulesDataGrid.MultiSelect = false;
            this.ModulesDataGrid.Name = "ModulesDataGrid";
            this.ModulesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModulesDataGrid.Size = new System.Drawing.Size(674, 336);
            this.ModulesDataGrid.TabIndex = 0;
            // 
            // Onderwijseenheid_Button
            // 
            this.Onderwijseenheid_Button.Location = new System.Drawing.Point(13, 25);
            this.Onderwijseenheid_Button.Name = "Onderwijseenheid_Button";
            this.Onderwijseenheid_Button.Size = new System.Drawing.Size(142, 23);
            this.Onderwijseenheid_Button.TabIndex = 1;
            this.Onderwijseenheid_Button.Text = "Onderwijseenheden";
            this.Onderwijseenheid_Button.UseVisualStyleBackColor = true;
            this.Onderwijseenheid_Button.Click += new System.EventHandler(this.Onderwijseenheid_Button_Click);
            // 
            // Minor_Button
            // 
            this.Minor_Button.Location = new System.Drawing.Point(13, 55);
            this.Minor_Button.Name = "Minor_Button";
            this.Minor_Button.Size = new System.Drawing.Size(142, 23);
            this.Minor_Button.TabIndex = 2;
            this.Minor_Button.Text = "Minoren";
            this.Minor_Button.UseVisualStyleBackColor = true;
            this.Minor_Button.Click += new System.EventHandler(this.Minor_Button_Click);
            // 
            // Stage_Button
            // 
            this.Stage_Button.Location = new System.Drawing.Point(13, 85);
            this.Stage_Button.Name = "Stage_Button";
            this.Stage_Button.Size = new System.Drawing.Size(142, 23);
            this.Stage_Button.TabIndex = 3;
            this.Stage_Button.Text = "Stages";
            this.Stage_Button.UseVisualStyleBackColor = true;
            this.Stage_Button.Click += new System.EventHandler(this.Stage_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(706, 415);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(143, 23);
            this.Back_Button.TabIndex = 4;
            this.Back_Button.Text = "Annuleren";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Register_Button
            // 
            this.Register_Button.Location = new System.Drawing.Point(13, 415);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(142, 23);
            this.Register_Button.TabIndex = 5;
            this.Register_Button.Text = "Inschrijven";
            this.Register_Button.UseVisualStyleBackColor = true;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // debug_text
            // 
            this.debug_text.Location = new System.Drawing.Point(13, 192);
            this.debug_text.Name = "debug_text";
            this.debug_text.Size = new System.Drawing.Size(142, 20);
            this.debug_text.TabIndex = 6;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.debug_text);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Stage_Button);
            this.Controls.Add(this.Minor_Button);
            this.Controls.Add(this.Onderwijseenheid_Button);
            this.Controls.Add(this.ModulesDataGrid);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ModulesDataGrid;
        private System.Windows.Forms.Button Onderwijseenheid_Button;
        private System.Windows.Forms.Button Minor_Button;
        private System.Windows.Forms.Button Stage_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.TextBox debug_text;
    }
}