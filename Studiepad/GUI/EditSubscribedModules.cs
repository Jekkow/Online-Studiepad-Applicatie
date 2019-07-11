using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studiepad.Logic;

namespace Studiepad.GUI
{
    public partial class EditSubscribedModules : Form
    {
        Student student = new Student();
        StudyCourse studyC;


        public EditSubscribedModules(StudyCourse studyC)
        {
            this.studyC = studyC;
            InitializeComponent();
        }

        private void Aanpassen_Load(object sender, EventArgs e)
        {
            FillDataGridSubscribedModules();
        }

        private void TerugNaarHomePaginaAanpassenForm_Click(object sender, EventArgs e)
        {
            OverviewStudyCourse OS = new OverviewStudyCourse(studyC);
            this.Hide();
            OS.Show();
        }

        private void AanpassenModuleKnop_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage(studyC);
            registerPage.Show();
        }

        private void FillDataGridSubscribedModules()
        {
            DataTable SubscriptionTable = new DataTable();
            SubscriptionTable.Columns.Add("Modulecode", typeof(string));
            SubscriptionTable.Columns.Add("Modulenaam", typeof(string));
            SubscriptionTable.Columns.Add("Periode", typeof(string));
            SubscriptionTable.Columns.Add("Type", typeof(string));
            SubscriptionTable.Columns.Add("Aantal EC", typeof(double));


            for (int i = 0; i < studyC.StudyCourseList.Count(); i++)
            {
                if (studyC.StudyCourseList[i].GetApproved() == true)
                {
                    SubscriptionTable.Rows.Add(studyC.StudyCourseList[i].GetModuleCode(), studyC.StudyCourseList[i].GetName(), studyC.StudyCourseList[i].GetPeriod(),
                        studyC.StudyCourseList[i].GetType(), studyC.StudyCourseList[i].GetEC());
                }
            }

            TabelInschrijvingen.DataSource = SubscriptionTable;
            TabelInschrijvingen.Refresh();
        }

        private void UitschrijvenKnop_Click(object sender, EventArgs e)
        {
            studyC.UnsubscribeModule(TabelInschrijvingen.Rows[0].ToString());
        }
    }  
}
