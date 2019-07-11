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
    public partial class ApprovedSubscriptions : Form
    {
        Logic.StudyCourse studyCourse;
        public ApprovedSubscriptions(Logic.StudyCourse studyCourse)
        {
            this.studyCourse = studyCourse;
            InitializeComponent();
        }

        //Method to load form with initial settings
        private void ApprovedSubscriptions_Load(object sender, EventArgs e)
        {
            ModuleCodeTextBox.ReadOnly = true;
            ModuleNameTextBox.ReadOnly = true;
            RefreshApprovedSubscriptionDataGrid();
            InitItems();
        }

        //Method to refresh datagrid with data from list
        private void RefreshApprovedSubscriptionDataGrid()
        {
            DataTable SubscriptionTable = new DataTable();
            SubscriptionTable.Columns.Add("Modulecode", typeof(string));
            SubscriptionTable.Columns.Add("Modulenaam", typeof(string));
            SubscriptionTable.Columns.Add("Periode", typeof(string));
            SubscriptionTable.Columns.Add("Type", typeof(string));
            SubscriptionTable.Columns.Add("Aantal EC", typeof(double));
            SubscriptionTable.Columns.Add("Noties/opmerkingen", typeof(string));

            for (int i = 0; i < studyCourse.StudyCourseList.Count(); i++)
            {
                if (studyCourse.StudyCourseList[i].GetApproved() == true)
                    SubscriptionTable.Rows.Add(studyCourse.StudyCourseList[i].GetModuleCode(), studyCourse.StudyCourseList[i].GetName(), studyCourse.StudyCourseList[i].GetPeriod(),
                        studyCourse.StudyCourseList[i].GetType(), studyCourse.StudyCourseList[i].GetEC(), studyCourse.StudyCourseList[i].GetNotes());
            }

            ApprovedSubscriptionsDataGrid.DataSource = SubscriptionTable;
            ApprovedSubscriptionsDataGrid.Refresh();
        }

        //Method to sync textboxes with datagrid cell selected
        private void ApprovedSubscriptionsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ModuleCodeTextBox.Text = ApprovedSubscriptionsDataGrid[0, e.RowIndex].Value.ToString();
                ModuleNameTextBox.Text = ApprovedSubscriptionsDataGrid[1, e.RowIndex].Value.ToString();
            }
            catch
            {
                ModuleCodeTextBox.Clear();
                ModuleNameTextBox.Clear();
            }
        }

        //Method to sync textboxes with new datagrid selection
        //Clear textboxes if there is no datagrid selection left
        private void InitItems()
        {
            try
            {
                ModuleCodeTextBox.Text = ApprovedSubscriptionsDataGrid[0, 0].Value.ToString();
                ModuleNameTextBox.Text = ApprovedSubscriptionsDataGrid[1, 1].Value.ToString();
            }
            catch
            {
                ModuleCodeTextBox.Clear();
                ModuleNameTextBox.Clear();
            }
        }

        //Methods to disable buttons while textbox with modulecode is empty
        private void ModuleCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ModuleCodeTextBox.Text, "^[a-zA-Z]"))
            {
                DeclineSubscriptionButton.Enabled = false;
            }
            else
            {
                DeclineSubscriptionButton.Enabled = true;
            }
        }
    }
}
