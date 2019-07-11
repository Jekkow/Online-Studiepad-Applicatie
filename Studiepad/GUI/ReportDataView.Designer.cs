namespace Studiepad.GUI
{
    partial class ReportDataView
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ReportDataDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(307, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(328, 38);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Rapportage overzicht";
            // 
            // ReportDataDataGrid
            // 
            this.ReportDataDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataDataGrid.Location = new System.Drawing.Point(12, 114);
            this.ReportDataDataGrid.Name = "ReportDataDataGrid";
            this.ReportDataDataGrid.RowTemplate.Height = 24;
            this.ReportDataDataGrid.Size = new System.Drawing.Size(932, 591);
            this.ReportDataDataGrid.TabIndex = 2;
            // 
            // ReportDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 809);
            this.Controls.Add(this.ReportDataDataGrid);
            this.Controls.Add(this.NameLabel);
            this.Name = "ReportDataView";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportDataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView ReportDataDataGrid;
    }
}