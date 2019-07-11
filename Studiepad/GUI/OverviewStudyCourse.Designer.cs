namespace Studiepad.GUI
{
    partial class OverviewStudyCourse
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
            this.DataGridStudyCourseOverview = new System.Windows.Forms.DataGridView();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelStudyCourseNoteTitle = new System.Windows.Forms.Label();
            this.RadioButtonAccept = new System.Windows.Forms.RadioButton();
            this.RadioButtonReject = new System.Windows.Forms.RadioButton();
            this.LabelExamineTitle = new System.Windows.Forms.Label();
            this.LabelSavedMessage = new System.Windows.Forms.Label();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.LabelStatusStudyCourse = new System.Windows.Forms.Label();
            this.LabelStatusStudyCourseTitle = new System.Windows.Forms.Label();
            this.ButtonEditStudyCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudyCourseOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridStudyCourseOverview
            // 
            this.DataGridStudyCourseOverview.AllowUserToAddRows = false;
            this.DataGridStudyCourseOverview.AllowUserToDeleteRows = false;
            this.DataGridStudyCourseOverview.AllowUserToResizeColumns = false;
            this.DataGridStudyCourseOverview.AllowUserToResizeRows = false;
            this.DataGridStudyCourseOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridStudyCourseOverview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridStudyCourseOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStudyCourseOverview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridStudyCourseOverview.Location = new System.Drawing.Point(12, 12);
            this.DataGridStudyCourseOverview.MultiSelect = false;
            this.DataGridStudyCourseOverview.Name = "DataGridStudyCourseOverview";
            this.DataGridStudyCourseOverview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridStudyCourseOverview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridStudyCourseOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridStudyCourseOverview.Size = new System.Drawing.Size(603, 593);
            this.DataGridStudyCourseOverview.TabIndex = 0;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(881, 611);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Sluiten";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(618, 270);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Bevestigen";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelStudyCourseNoteTitle
            // 
            this.LabelStudyCourseNoteTitle.AutoSize = true;
            this.LabelStudyCourseNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudyCourseNoteTitle.Location = new System.Drawing.Point(621, 129);
            this.LabelStudyCourseNoteTitle.Name = "LabelStudyCourseNoteTitle";
            this.LabelStudyCourseNoteTitle.Size = new System.Drawing.Size(104, 16);
            this.LabelStudyCourseNoteTitle.TabIndex = 4;
            this.LabelStudyCourseNoteTitle.Text = "Opermkingen:";
            // 
            // RadioButtonAccept
            // 
            this.RadioButtonAccept.AutoSize = true;
            this.RadioButtonAccept.Location = new System.Drawing.Point(624, 77);
            this.RadioButtonAccept.Name = "RadioButtonAccept";
            this.RadioButtonAccept.Size = new System.Drawing.Size(80, 17);
            this.RadioButtonAccept.TabIndex = 5;
            this.RadioButtonAccept.TabStop = true;
            this.RadioButtonAccept.Text = "Accepteren";
            this.RadioButtonAccept.UseVisualStyleBackColor = true;
            this.RadioButtonAccept.CheckedChanged += new System.EventHandler(this.RadioButtonAccept_CheckedChanged);
            // 
            // RadioButtonReject
            // 
            this.RadioButtonReject.AutoSize = true;
            this.RadioButtonReject.Location = new System.Drawing.Point(624, 100);
            this.RadioButtonReject.Name = "RadioButtonReject";
            this.RadioButtonReject.Size = new System.Drawing.Size(68, 17);
            this.RadioButtonReject.TabIndex = 6;
            this.RadioButtonReject.TabStop = true;
            this.RadioButtonReject.Text = "Afkeuren";
            this.RadioButtonReject.UseVisualStyleBackColor = true;
            this.RadioButtonReject.CheckedChanged += new System.EventHandler(this.RadioButtonReject_CheckedChanged);
            // 
            // LabelExamineTitle
            // 
            this.LabelExamineTitle.AutoSize = true;
            this.LabelExamineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExamineTitle.Location = new System.Drawing.Point(621, 58);
            this.LabelExamineTitle.Name = "LabelExamineTitle";
            this.LabelExamineTitle.Size = new System.Drawing.Size(167, 16);
            this.LabelExamineTitle.TabIndex = 7;
            this.LabelExamineTitle.Text = "Studiepad beoordelen:";
            // 
            // LabelSavedMessage
            // 
            this.LabelSavedMessage.AutoSize = true;
            this.LabelSavedMessage.ForeColor = System.Drawing.Color.Green;
            this.LabelSavedMessage.Location = new System.Drawing.Point(699, 275);
            this.LabelSavedMessage.Name = "LabelSavedMessage";
            this.LabelSavedMessage.Size = new System.Drawing.Size(115, 13);
            this.LabelSavedMessage.TabIndex = 8;
            this.LabelSavedMessage.Text = "Succesvol opgeslagen";
            this.LabelSavedMessage.Visible = false;
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.Enabled = false;
            this.TextBoxNote.Location = new System.Drawing.Point(621, 148);
            this.TextBoxNote.Multiline = true;
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(335, 116);
            this.TextBoxNote.TabIndex = 9;
            this.TextBoxNote.TextChanged += new System.EventHandler(this.TextBoxNote_TextChanged);
            // 
            // LabelStatusStudyCourse
            // 
            this.LabelStatusStudyCourse.AutoSize = true;
            this.LabelStatusStudyCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelStatusStudyCourse.Location = new System.Drawing.Point(621, 28);
            this.LabelStatusStudyCourse.Name = "LabelStatusStudyCourse";
            this.LabelStatusStudyCourse.Size = new System.Drawing.Size(162, 13);
            this.LabelStatusStudyCourse.TabIndex = 10;
            this.LabelStatusStudyCourse.Text = "Studiepad is nog niet beoordeeld";
            // 
            // LabelStatusStudyCourseTitle
            // 
            this.LabelStatusStudyCourseTitle.AutoSize = true;
            this.LabelStatusStudyCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatusStudyCourseTitle.Location = new System.Drawing.Point(621, 12);
            this.LabelStatusStudyCourseTitle.Name = "LabelStatusStudyCourseTitle";
            this.LabelStatusStudyCourseTitle.Size = new System.Drawing.Size(128, 16);
            this.LabelStatusStudyCourseTitle.TabIndex = 11;
            this.LabelStatusStudyCourseTitle.Text = "Status studiepad:";
            // 
            // ButtonEditStudyCourse
            // 
            this.ButtonEditStudyCourse.Location = new System.Drawing.Point(490, 611);
            this.ButtonEditStudyCourse.Name = "ButtonEditStudyCourse";
            this.ButtonEditStudyCourse.Size = new System.Drawing.Size(125, 23);
            this.ButtonEditStudyCourse.TabIndex = 12;
            this.ButtonEditStudyCourse.Text = "Studiepad aanpassen";
            this.ButtonEditStudyCourse.UseVisualStyleBackColor = true;
            this.ButtonEditStudyCourse.Click += new System.EventHandler(this.ButtonEditStudyCourse_Click);
            // 
            // OverviewStudyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 646);
            this.Controls.Add(this.ButtonEditStudyCourse);
            this.Controls.Add(this.LabelStatusStudyCourseTitle);
            this.Controls.Add(this.LabelStatusStudyCourse);
            this.Controls.Add(this.TextBoxNote);
            this.Controls.Add(this.LabelSavedMessage);
            this.Controls.Add(this.LabelExamineTitle);
            this.Controls.Add(this.RadioButtonReject);
            this.Controls.Add(this.RadioButtonAccept);
            this.Controls.Add(this.LabelStudyCourseNoteTitle);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.DataGridStudyCourseOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverviewStudyCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studiepad overzicht";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudyCourseOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridStudyCourseOverview;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelStudyCourseNoteTitle;
        private System.Windows.Forms.RadioButton RadioButtonAccept;
        private System.Windows.Forms.RadioButton RadioButtonReject;
        private System.Windows.Forms.Label LabelExamineTitle;
        private System.Windows.Forms.Label LabelSavedMessage;
        private System.Windows.Forms.TextBox TextBoxNote;
        private System.Windows.Forms.Label LabelStatusStudyCourse;
        private System.Windows.Forms.Label LabelStatusStudyCourseTitle;
        private System.Windows.Forms.Button ButtonEditStudyCourse;
    }
}