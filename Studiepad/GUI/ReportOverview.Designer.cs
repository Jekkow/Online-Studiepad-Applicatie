namespace Studiepad.GUI
{
    partial class ReportOverview
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
            this.ReportOverviewDatagrid = new System.Windows.Forms.DataGridView();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReportNameTextBox = new System.Windows.Forms.TextBox();
            this.ReportNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ReportTypeLabel = new System.Windows.Forms.Label();
            this.ReportTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportPublishedTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReportOverviewDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportOverviewDatagrid
            // 
            this.ReportOverviewDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportOverviewDatagrid.Location = new System.Drawing.Point(69, 82);
            this.ReportOverviewDatagrid.Name = "ReportOverviewDatagrid";
            this.ReportOverviewDatagrid.RowTemplate.Height = 24;
            this.ReportOverviewDatagrid.Size = new System.Drawing.Size(886, 266);
            this.ReportOverviewDatagrid.TabIndex = 0;
            this.ReportOverviewDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportOverviewDatagrid_CellContentClick);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(346, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(328, 38);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Rapportage overzicht";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReportButton.Location = new System.Drawing.Point(699, 629);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(256, 47);
            this.GenerateReportButton.TabIndex = 2;
            this.GenerateReportButton.Text = "Rapportage opvragen";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(39, 629);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(256, 47);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Annuleren";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReportNameTextBox
            // 
            this.ReportNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNameTextBox.Location = new System.Drawing.Point(199, 369);
            this.ReportNameTextBox.Name = "ReportNameTextBox";
            this.ReportNameTextBox.Size = new System.Drawing.Size(756, 27);
            this.ReportNameTextBox.TabIndex = 4;
            // 
            // ReportNameLabel
            // 
            this.ReportNameLabel.AutoSize = true;
            this.ReportNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNameLabel.Location = new System.Drawing.Point(113, 372);
            this.ReportNameLabel.Name = "ReportNameLabel";
            this.ReportNameLabel.Size = new System.Drawing.Size(58, 20);
            this.ReportNameLabel.TabIndex = 5;
            this.ReportNameLabel.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Beschrijving:";
            // 
            // ReportDescriptionTextBox
            // 
            this.ReportDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDescriptionTextBox.Location = new System.Drawing.Point(199, 462);
            this.ReportDescriptionTextBox.Name = "ReportDescriptionTextBox";
            this.ReportDescriptionTextBox.Size = new System.Drawing.Size(756, 27);
            this.ReportDescriptionTextBox.TabIndex = 6;
            // 
            // ReportTypeLabel
            // 
            this.ReportTypeLabel.AutoSize = true;
            this.ReportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeLabel.Location = new System.Drawing.Point(113, 417);
            this.ReportTypeLabel.Name = "ReportTypeLabel";
            this.ReportTypeLabel.Size = new System.Drawing.Size(50, 20);
            this.ReportTypeLabel.TabIndex = 9;
            this.ReportTypeLabel.Text = "Type:";
            // 
            // ReportTypeTextBox
            // 
            this.ReportTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeTextBox.Location = new System.Drawing.Point(199, 417);
            this.ReportTypeTextBox.Name = "ReportTypeTextBox";
            this.ReportTypeTextBox.Size = new System.Drawing.Size(756, 27);
            this.ReportTypeTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gepubliceerd op:";
            // 
            // ReportPublishedTextBox
            // 
            this.ReportPublishedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportPublishedTextBox.Location = new System.Drawing.Point(199, 510);
            this.ReportPublishedTextBox.Name = "ReportPublishedTextBox";
            this.ReportPublishedTextBox.Size = new System.Drawing.Size(756, 27);
            this.ReportPublishedTextBox.TabIndex = 10;
            // 
            // ReportOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 718);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReportPublishedTextBox);
            this.Controls.Add(this.ReportTypeLabel);
            this.Controls.Add(this.ReportTypeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportDescriptionTextBox);
            this.Controls.Add(this.ReportNameLabel);
            this.Controls.Add(this.ReportNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ReportOverviewDatagrid);
            this.Name = "ReportOverview";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportOverviewDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportOverviewDatagrid;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ReportNameTextBox;
        private System.Windows.Forms.Label ReportNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReportDescriptionTextBox;
        private System.Windows.Forms.Label ReportTypeLabel;
        private System.Windows.Forms.TextBox ReportTypeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReportPublishedTextBox;
    }
}