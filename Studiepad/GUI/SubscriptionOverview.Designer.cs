namespace Studiepad.GUI
{
    partial class SubscriptionOverview
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
            this.SubScriptionsOverviewDataGrid = new System.Windows.Forms.DataGridView();
            this.ModuleCodeLabel = new System.Windows.Forms.Label();
            this.ModuleCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModuleNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModuleNotesTextBox = new System.Windows.Forms.TextBox();
            this.ApproveSubscriptionButton = new System.Windows.Forms.Button();
            this.ApproveAllSubscriptionsButton = new System.Windows.Forms.Button();
            this.DeclineAllSubscriptionsButton = new System.Windows.Forms.Button();
            this.DeclineSubscriptionButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApprovedSubscriptionsLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SubScriptionsOverviewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(9, 28);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(181, 31);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Inschrijvingen";
            // 
            // SubScriptionsOverviewDataGrid
            // 
            this.SubScriptionsOverviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubScriptionsOverviewDataGrid.Location = new System.Drawing.Point(9, 72);
            this.SubScriptionsOverviewDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubScriptionsOverviewDataGrid.Name = "SubScriptionsOverviewDataGrid";
            this.SubScriptionsOverviewDataGrid.RowTemplate.Height = 24;
            this.SubScriptionsOverviewDataGrid.Size = new System.Drawing.Size(786, 292);
            this.SubScriptionsOverviewDataGrid.TabIndex = 3;
            this.SubScriptionsOverviewDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubScriptionsOverviewDataGrid_CellContentClick);
            // 
            // ModuleCodeLabel
            // 
            this.ModuleCodeLabel.AutoSize = true;
            this.ModuleCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleCodeLabel.Location = new System.Drawing.Point(340, 375);
            this.ModuleCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModuleCodeLabel.Name = "ModuleCodeLabel";
            this.ModuleCodeLabel.Size = new System.Drawing.Size(89, 17);
            this.ModuleCodeLabel.TabIndex = 13;
            this.ModuleCodeLabel.Text = "Modulecode:";
            // 
            // ModuleCodeTextBox
            // 
            this.ModuleCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleCodeTextBox.Location = new System.Drawing.Point(343, 394);
            this.ModuleCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModuleCodeTextBox.Name = "ModuleCodeTextBox";
            this.ModuleCodeTextBox.Size = new System.Drawing.Size(453, 23);
            this.ModuleCodeTextBox.TabIndex = 12;
            this.ModuleCodeTextBox.TextChanged += new System.EventHandler(this.ModuleCodeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 485);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Notities/opmerkingen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 17;
            // 
            // ModuleNameTextBox
            // 
            this.ModuleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleNameTextBox.Location = new System.Drawing.Point(343, 448);
            this.ModuleNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModuleNameTextBox.Name = "ModuleNameTextBox";
            this.ModuleNameTextBox.Size = new System.Drawing.Size(453, 23);
            this.ModuleNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 430);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Modulenaam:";
            // 
            // ModuleNotesTextBox
            // 
            this.ModuleNotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleNotesTextBox.Location = new System.Drawing.Point(343, 504);
            this.ModuleNotesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModuleNotesTextBox.Multiline = true;
            this.ModuleNotesTextBox.Name = "ModuleNotesTextBox";
            this.ModuleNotesTextBox.Size = new System.Drawing.Size(453, 76);
            this.ModuleNotesTextBox.TabIndex = 19;
            // 
            // ApproveSubscriptionButton
            // 
            this.ApproveSubscriptionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApproveSubscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveSubscriptionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ApproveSubscriptionButton.Location = new System.Drawing.Point(9, 381);
            this.ApproveSubscriptionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApproveSubscriptionButton.Name = "ApproveSubscriptionButton";
            this.ApproveSubscriptionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApproveSubscriptionButton.Size = new System.Drawing.Size(188, 35);
            this.ApproveSubscriptionButton.TabIndex = 20;
            this.ApproveSubscriptionButton.Text = "Inschrijving goedkeuren";
            this.ApproveSubscriptionButton.UseVisualStyleBackColor = false;
            this.ApproveSubscriptionButton.Click += new System.EventHandler(this.ApproveSubscriptionButton_Click);
            // 
            // ApproveAllSubscriptionsButton
            // 
            this.ApproveAllSubscriptionsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApproveAllSubscriptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveAllSubscriptionsButton.Location = new System.Drawing.Point(9, 504);
            this.ApproveAllSubscriptionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApproveAllSubscriptionsButton.Name = "ApproveAllSubscriptionsButton";
            this.ApproveAllSubscriptionsButton.Size = new System.Drawing.Size(188, 49);
            this.ApproveAllSubscriptionsButton.TabIndex = 21;
            this.ApproveAllSubscriptionsButton.Text = "Alle inschrijvingen goedkeuren";
            this.ApproveAllSubscriptionsButton.UseVisualStyleBackColor = false;
            this.ApproveAllSubscriptionsButton.Click += new System.EventHandler(this.ApproveAllSubscriptionsButton_Click);
            // 
            // DeclineAllSubscriptionsButton
            // 
            this.DeclineAllSubscriptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineAllSubscriptionsButton.Location = new System.Drawing.Point(9, 566);
            this.DeclineAllSubscriptionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeclineAllSubscriptionsButton.Name = "DeclineAllSubscriptionsButton";
            this.DeclineAllSubscriptionsButton.Size = new System.Drawing.Size(188, 49);
            this.DeclineAllSubscriptionsButton.TabIndex = 22;
            this.DeclineAllSubscriptionsButton.Text = "Alle inschrijvingen afkeuren";
            this.DeclineAllSubscriptionsButton.UseVisualStyleBackColor = true;
            // 
            // DeclineSubscriptionButton
            // 
            this.DeclineSubscriptionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeclineSubscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineSubscriptionButton.Location = new System.Drawing.Point(9, 427);
            this.DeclineSubscriptionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeclineSubscriptionButton.Name = "DeclineSubscriptionButton";
            this.DeclineSubscriptionButton.Size = new System.Drawing.Size(188, 35);
            this.DeclineSubscriptionButton.TabIndex = 23;
            this.DeclineSubscriptionButton.Text = "Inschrijving afkeuren";
            this.DeclineSubscriptionButton.UseVisualStyleBackColor = false;
            this.DeclineSubscriptionButton.Click += new System.EventHandler(this.DeclineSubscriptionButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(675, 636);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 35);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Opslaan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(518, 636);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 35);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Annuleren";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApprovedSubscriptionsLabel
            // 
            this.ApprovedSubscriptionsLabel.AutoSize = true;
            this.ApprovedSubscriptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ApprovedSubscriptionsLabel.Location = new System.Drawing.Point(648, 54);
            this.ApprovedSubscriptionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApprovedSubscriptionsLabel.Name = "ApprovedSubscriptionsLabel";
            this.ApprovedSubscriptionsLabel.Size = new System.Drawing.Size(154, 17);
            this.ApprovedSubscriptionsLabel.TabIndex = 26;
            this.ApprovedSubscriptionsLabel.TabStop = true;
            this.ApprovedSubscriptionsLabel.Text = "ApprovedSubscriptions";
            this.ApprovedSubscriptionsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ApprovedSubscriptionsLabel_LinkClicked);
            // 
            // SubscriptionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 681);
            this.Controls.Add(this.ApprovedSubscriptionsLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeclineSubscriptionButton);
            this.Controls.Add(this.DeclineAllSubscriptionsButton);
            this.Controls.Add(this.ApproveAllSubscriptionsButton);
            this.Controls.Add(this.ApproveSubscriptionButton);
            this.Controls.Add(this.ModuleNotesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModuleNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModuleCodeLabel);
            this.Controls.Add(this.ModuleCodeTextBox);
            this.Controls.Add(this.SubScriptionsOverviewDataGrid);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubscriptionOverview";
            this.Text = "SubscriptionOverview";
            this.Load += new System.EventHandler(this.SubscriptionOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubScriptionsOverviewDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView SubScriptionsOverviewDataGrid;
        private System.Windows.Forms.Label ModuleCodeLabel;
        private System.Windows.Forms.TextBox ModuleCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModuleNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModuleNotesTextBox;
        private System.Windows.Forms.Button ApproveSubscriptionButton;
        private System.Windows.Forms.Button ApproveAllSubscriptionsButton;
        private System.Windows.Forms.Button DeclineAllSubscriptionsButton;
        private System.Windows.Forms.Button DeclineSubscriptionButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.LinkLabel ApprovedSubscriptionsLabel;
    }
}