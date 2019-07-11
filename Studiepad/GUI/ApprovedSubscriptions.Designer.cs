namespace Studiepad.GUI
{
    partial class ApprovedSubscriptions
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
            this.ApprovedSubscriptionsDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ModuleNameTextBox = new System.Windows.Forms.TextBox();
            this.ModuleCodeLabel = new System.Windows.Forms.Label();
            this.ModuleCodeTextBox = new System.Windows.Forms.TextBox();
            this.DeclineSubscriptionButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedSubscriptionsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ApprovedSubscriptionsDataGrid
            // 
            this.ApprovedSubscriptionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovedSubscriptionsDataGrid.Location = new System.Drawing.Point(12, 71);
            this.ApprovedSubscriptionsDataGrid.Name = "ApprovedSubscriptionsDataGrid";
            this.ApprovedSubscriptionsDataGrid.RowTemplate.Height = 24;
            this.ApprovedSubscriptionsDataGrid.Size = new System.Drawing.Size(837, 244);
            this.ApprovedSubscriptionsDataGrid.TabIndex = 0;
            this.ApprovedSubscriptionsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApprovedSubscriptionsDataGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Modulenaam:";
            // 
            // ModuleNameTextBox
            // 
            this.ModuleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleNameTextBox.Location = new System.Drawing.Point(225, 392);
            this.ModuleNameTextBox.Name = "ModuleNameTextBox";
            this.ModuleNameTextBox.Size = new System.Drawing.Size(603, 27);
            this.ModuleNameTextBox.TabIndex = 21;
            // 
            // ModuleCodeLabel
            // 
            this.ModuleCodeLabel.AutoSize = true;
            this.ModuleCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleCodeLabel.Location = new System.Drawing.Point(98, 342);
            this.ModuleCodeLabel.Name = "ModuleCodeLabel";
            this.ModuleCodeLabel.Size = new System.Drawing.Size(104, 20);
            this.ModuleCodeLabel.TabIndex = 20;
            this.ModuleCodeLabel.Text = "Modulecode:";
            // 
            // ModuleCodeTextBox
            // 
            this.ModuleCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleCodeTextBox.Location = new System.Drawing.Point(225, 339);
            this.ModuleCodeTextBox.Name = "ModuleCodeTextBox";
            this.ModuleCodeTextBox.Size = new System.Drawing.Size(603, 27);
            this.ModuleCodeTextBox.TabIndex = 19;
            this.ModuleCodeTextBox.TextChanged += new System.EventHandler(this.ModuleCodeTextBox_TextChanged);
            // 
            // DeclineSubscriptionButton
            // 
            this.DeclineSubscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineSubscriptionButton.Location = new System.Drawing.Point(625, 433);
            this.DeclineSubscriptionButton.Name = "DeclineSubscriptionButton";
            this.DeclineSubscriptionButton.Size = new System.Drawing.Size(203, 43);
            this.DeclineSubscriptionButton.TabIndex = 25;
            this.DeclineSubscriptionButton.Text = "Module afkeuren";
            this.DeclineSubscriptionButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(440, 38);
            this.NameLabel.TabIndex = 26;
            this.NameLabel.Text = "Goedgekeurde inschrijvingen";
            // 
            // ApprovedSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 488);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DeclineSubscriptionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModuleNameTextBox);
            this.Controls.Add(this.ModuleCodeLabel);
            this.Controls.Add(this.ModuleCodeTextBox);
            this.Controls.Add(this.ApprovedSubscriptionsDataGrid);
            this.Name = "ApprovedSubscriptions";
            this.Text = "ApprovedSubscriptions";
            this.Load += new System.EventHandler(this.ApprovedSubscriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedSubscriptionsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ApprovedSubscriptionsDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModuleNameTextBox;
        private System.Windows.Forms.Label ModuleCodeLabel;
        private System.Windows.Forms.TextBox ModuleCodeTextBox;
        private System.Windows.Forms.Button DeclineSubscriptionButton;
        private System.Windows.Forms.Label NameLabel;
    }
}