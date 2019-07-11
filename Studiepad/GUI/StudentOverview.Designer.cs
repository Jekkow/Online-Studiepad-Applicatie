namespace Studiepad.GUI
{
    partial class StudentOverview
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
            this.StudentOverviewNameLabel = new System.Windows.Forms.Label();
            this.StudentOverviewDataGrid = new System.Windows.Forms.DataGridView();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudyLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.StudyTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectStudentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentOverviewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentOverviewNameLabel
            // 
            this.StudentOverviewNameLabel.AutoSize = true;
            this.StudentOverviewNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentOverviewNameLabel.Location = new System.Drawing.Point(338, 27);
            this.StudentOverviewNameLabel.Name = "StudentOverviewNameLabel";
            this.StudentOverviewNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentOverviewNameLabel.Size = new System.Drawing.Size(371, 38);
            this.StudentOverviewNameLabel.TabIndex = 2;
            this.StudentOverviewNameLabel.Text = "Overzicht van studenten";
            // 
            // StudentOverviewDataGrid
            // 
            this.StudentOverviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentOverviewDataGrid.Location = new System.Drawing.Point(81, 87);
            this.StudentOverviewDataGrid.Name = "StudentOverviewDataGrid";
            this.StudentOverviewDataGrid.RowTemplate.Height = 24;
            this.StudentOverviewDataGrid.Size = new System.Drawing.Size(886, 299);
            this.StudentOverviewDataGrid.TabIndex = 3;
            this.StudentOverviewDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentOverviewDataGrid_CellContentClick);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(204, 400);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(763, 27);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(91, 403);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "Voornaam:";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Achternaam:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudyLabel
            // 
            this.StudyLabel.AutoSize = true;
            this.StudyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyLabel.Location = new System.Drawing.Point(120, 505);
            this.StudyLabel.Name = "StudyLabel";
            this.StudyLabel.Size = new System.Drawing.Size(61, 20);
            this.StudyLabel.TabIndex = 7;
            this.StudyLabel.Text = "Studie:";
            this.StudyLabel.Click += new System.EventHandler(this.StudyLabel_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(204, 448);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(763, 27);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // StudyTextBox
            // 
            this.StudyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyTextBox.Location = new System.Drawing.Point(204, 498);
            this.StudyTextBox.Name = "StudyTextBox";
            this.StudyTextBox.Size = new System.Drawing.Size(763, 27);
            this.StudyTextBox.TabIndex = 9;
            this.StudyTextBox.TextChanged += new System.EventHandler(this.StudyTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(48, 571);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(256, 47);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Annuleren";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectStudentButton
            // 
            this.SelectStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectStudentButton.Location = new System.Drawing.Point(711, 571);
            this.SelectStudentButton.Name = "SelectStudentButton";
            this.SelectStudentButton.Size = new System.Drawing.Size(256, 47);
            this.SelectStudentButton.TabIndex = 10;
            this.SelectStudentButton.Text = "Selecteer student";
            this.SelectStudentButton.UseVisualStyleBackColor = true;
            this.SelectStudentButton.Click += new System.EventHandler(this.SelectStudentButton_Click);
            // 
            // StudentOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 651);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectStudentButton);
            this.Controls.Add(this.StudyTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.StudyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.StudentOverviewDataGrid);
            this.Controls.Add(this.StudentOverviewNameLabel);
            this.Name = "StudentOverview";
            this.Text = "StudentOverview";
            this.Load += new System.EventHandler(this.StudentOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentOverviewDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentOverviewNameLabel;
        private System.Windows.Forms.DataGridView StudentOverviewDataGrid;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudyLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox StudyTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectStudentButton;
    }
}