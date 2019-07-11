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
    public partial class SubscriptionOverview : Form
    {

        //List<Logic.Module> ModuleInformation;
        List<Logic.Module> RatedModules = new List<Logic.Module>();
        Logic.Student student = new Logic.Student();
        Logic.Module module = new Logic.Module();
        Logic.StudyCourse studyCourse;

        public SubscriptionOverview(Logic.Student student, Logic.StudyCourse studyCourse)
        {
            this.student = student;
            this.studyCourse = studyCourse;
            InitializeComponent();
        }

        public SubscriptionOverview()
        {
        }


        //Method to load window with initial settings
        private void SubscriptionOverview_Load(object sender, EventArgs e)
        {
            ModuleCodeTextBox.ReadOnly = true;
            ModuleNameTextBox.ReadOnly = true;
            SubScriptionsOverviewDataGrid.ReadOnly = true;
            RefreshSubscriptionOverviewDataGrid();
            InitItems();
        }

        //Method to refresh datagrid with data from list
        private void RefreshSubscriptionOverviewDataGrid()
        {
            DataTable SubscriptionTable = new DataTable();
            SubscriptionTable.Columns.Add("Modulecode", typeof(string));
            SubscriptionTable.Columns.Add("Modulenaam", typeof(string));
            SubscriptionTable.Columns.Add("Periode", typeof(string));
            SubscriptionTable.Columns.Add("Type", typeof(string));
            SubscriptionTable.Columns.Add("Aantal EC", typeof(double));
            SubscriptionTable.Columns.Add("Notities/opmerkingen", typeof(string));

            for (int i = 0; i < studyCourse.StudyCourseList.Count(); i++)
            {
                if (studyCourse.StudyCourseList[i].GetApproved() == null)
                    SubscriptionTable.Rows.Add(studyCourse.StudyCourseList[i].GetModuleCode(), studyCourse.StudyCourseList[i].GetName(), studyCourse.StudyCourseList[i].GetPeriod(),
                        studyCourse.StudyCourseList[i].GetType(), studyCourse.StudyCourseList[i].GetEC(), studyCourse.StudyCourseList[i].GetNotes());
            }

            SubScriptionsOverviewDataGrid.DataSource = SubscriptionTable;
            SubScriptionsOverviewDataGrid.Refresh();
            SubScriptionsOverviewDataGrid.Columns[5].MinimumWidth = 250;
        }

        //Method to activate cancelbutton
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Method to sync textboxes with datagrid cells
        private void SubScriptionsOverviewDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ModuleCodeTextBox.Text = SubScriptionsOverviewDataGrid[0, e.RowIndex].Value.ToString();
                ModuleNameTextBox.Text = SubScriptionsOverviewDataGrid[1, e.RowIndex].Value.ToString();
                ModuleNotesTextBox.Text = SubScriptionsOverviewDataGrid[5, e.RowIndex].Value.ToString();
            }
            catch
            {
                ModuleCodeTextBox.Clear();
                ModuleNameTextBox.Clear();
                ModuleNotesTextBox.Clear();
            }
        }

        //Method to activate approve button
        private void ApproveSubscriptionButton_Click(object sender, EventArgs e)
        {
            //Search for correct modulecode and if notes have been changed
            foreach (Logic.Module module in studyCourse.StudyCourseList)
            {
                if (module.GetModuleCode() == ModuleCodeTextBox.Text)
                {
                    module.ApproveModule(true);

                    if((module.GetNotes() != ModuleNotesTextBox.Text))
                    {
                        module.SetNotes(ModuleNotesTextBox.Text);
                    }

                    RatedModules.Add(module);
                }
            }

            RefreshSubscriptionOverviewDataGrid();
            InitItems();
        }

        //Method to sync textboxes with new datagrid selection
        //Clear textboxes if there is no datagrid selection left
        private void InitItems()
        {
            try
            {
                ModuleCodeTextBox.Text = SubScriptionsOverviewDataGrid[0, 0].Value.ToString();
                ModuleNameTextBox.Text = SubScriptionsOverviewDataGrid[1, 1].Value.ToString();
                ModuleNotesTextBox.Text = SubScriptionsOverviewDataGrid[5, 5].Value.ToString();
            }
            catch
            {
                ModuleCodeTextBox.Clear();
                ModuleNameTextBox.Clear();
                ModuleNotesTextBox.Clear();
            }
        }

        //Method to activate button to approve all subscriptions
        private void ApproveAllSubscriptionsButton_Click(object sender, EventArgs e)
        {
          DialogResult approveAll = MessageBox.Show("Weet u zeker dat u alle inschrijvingen wilt goedkeuren?\nEventuele notities zullen hierbij niet opgeslagen worden.", "Alle inschrijvingen goedkeuren", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (approveAll == DialogResult.Yes)
            {
                foreach (Logic.Module module in studyCourse.StudyCourseList)
                {
                        module.ApproveModule(true);
                }

                RefreshSubscriptionOverviewDataGrid();
                InitItems();
            }

        }

        //Method to activate save button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(RatedModules.Count() > 0)
            module.ProcessSubScriptionChanges(RatedModules, student.GetStudentID());
            this.Hide();
        }

        //Method to activate the approved subscriptions linklabel
        private void ApprovedSubscriptionsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApprovedSubscriptions approvedSubscriptions = new ApprovedSubscriptions(studyCourse);
            approvedSubscriptions.Show();
        }

        //Methods to disable buttons while textbox with modulecode is empty
        private void ModuleCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ModuleCodeTextBox.Text, "^[a-zA-Z]"))
            {
                ApproveSubscriptionButton.Enabled = false;
                DeclineSubscriptionButton.Enabled = false;
                ModuleNotesTextBox.Enabled = false;
            }
            else
            {
                ApproveSubscriptionButton.Enabled = true;
                DeclineSubscriptionButton.Enabled = true;
                ModuleNotesTextBox.Enabled = true;
            }
        }

        private void DeclineSubscriptionButton_Click(object sender, EventArgs e)
        {
            //Search for correct modulecode and if notes have been changed
            foreach (Logic.Module module in studyCourse.StudyCourseList)
            {
                if (module.GetModuleCode() == ModuleCodeTextBox.Text)
                {
                    module.RejectModule(false);

                    if ((module.GetNotes() != ModuleNotesTextBox.Text))
                    {
                        module.SetNotes(ModuleNotesTextBox.Text);
                    }

                    RatedModules.Add(module);
                }
            }

            RefreshSubscriptionOverviewDataGrid();
            InitItems();
        }
    }
}
