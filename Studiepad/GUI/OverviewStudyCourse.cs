using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studiepad.GUI
{
    public partial class OverviewStudyCourse : Form
    {
        Logic.StudyCourse studyC;

        public OverviewStudyCourse(Logic.StudyCourse course)
        {
            this.studyC = course;
            InitializeComponent();
            LoadStudyCourse();
        }

        private void LoadStudyCourse()
        {
            
            LoadDataGrid();
            ShowStudyCourseStatus();
            ShowStudyCourseNotes();
        }

        private void RadioButtonAccept_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonAccept.Checked)
            {
                RadioButtonReject.Checked = false;
                TextBoxNote.Enabled = false;
                ButtonSave.Enabled = true;
            }

            LabelSavedMessage.Visible = false;
        }

        public void LoadDataGrid()
        {
            DataTable ModulesTable = new DataTable();
            ModulesTable.Columns.Add("Modulecode", typeof(string));
            ModulesTable.Columns.Add("Modulenaam", typeof(string));
            ModulesTable.Columns.Add("Periode", typeof(string));
            ModulesTable.Columns.Add("Type", typeof(string));
            ModulesTable.Columns.Add("Aantal EC", typeof(double));
            ModulesTable.Columns.Add("Goedgekeurd", typeof(bool));
            ModulesTable.Columns.Add("Notities/opmerkingen", typeof(string));


            for (int i = 0; i < studyC.StudyCourseList.Count(); i++)
            {
                    ModulesTable.Rows.Add(studyC.StudyCourseList[i].GetModuleCode(), studyC.StudyCourseList[i].GetName(), studyC.StudyCourseList[i].GetPeriod(),
                        studyC.StudyCourseList[i].GetType(), studyC.StudyCourseList[i].GetEC(), studyC.StudyCourseList[i].GetApproved(), studyC.StudyCourseList[i].GetNotes());
            }

            DataGridStudyCourseOverview.DataSource = ModulesTable;
            DataGridStudyCourseOverview.Refresh();
        }

        private void RadioButtonReject_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonReject.Checked)
            {
                RadioButtonAccept.Checked = false;
                TextBoxNote.Enabled = true;
                ButtonSave.Enabled = (!NoteIsEmpty());
            }

            LabelSavedMessage.Visible = false;
        }

        private bool NoteIsEmpty()
        {
            return (string.IsNullOrWhiteSpace(TextBoxNote.Text));

        }

        private void TextBoxNote_TextChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = (!NoteIsEmpty());
        }

        private void ShowStudyCourseStatus()
        {
            if (studyC.GetStudyCourseStatus() == true)
            {
                LabelStatusStudyCourse.Text = "Studiepad is goedgekeurd";
                LabelStatusStudyCourse.ForeColor = Color.Green;
            }
            else if (studyC.GetStudyCourseStatus() == false)
            {
                LabelStatusStudyCourse.Text = "Studiepad is afgekeurd";
                LabelStatusStudyCourse.ForeColor = Color.Red;
            }
            else if (studyC.GetStudyCourseStatus() == null)
            {
                LabelStatusStudyCourse.Text = "Studiepad is nog niet beoordeeld";
                LabelStatusStudyCourse.ForeColor = Color.Black;
            }
        }

        private void ShowStudyCourseNotes()
        {
            TextBoxNote.Text = studyC.GetStudyCourseNotes();
        }

        private void ButtonEditStudyCourse_Click(object sender, EventArgs e)
        {
            EditSubscribedModules edit = new EditSubscribedModules(studyC);
            edit.Show();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            studyC.ExamineStudyCourse(RadioButtonAccept.Checked, TextBoxNote.Text);
            ButtonSave.Enabled = false;
            TextBoxNote.Enabled = false;
            ShowStudyCourseStatus();
            LabelSavedMessage.Visible = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
