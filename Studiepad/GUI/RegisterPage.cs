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
    public partial class RegisterPage : Form
    {
        Logic.StudyCourse studyCourse;
        Logic.Student student = new Student();

        public RegisterPage(Logic.StudyCourse studyCourse)
        {
            this.studyCourse = studyCourse;
            InitializeComponent();
            ModulesDataGrid.ReadOnly = true;
        }


        private void RegisterPage_Load(object sender, EventArgs e)
        {
            ModulesDataGrid.DataSource = studyCourse.GetModuleInformation(1, "Onderwijseenheid");
        }

        private void Onderwijseenheid_Button_Click(object sender, EventArgs e)
        {
            //Filter op type = Onderwijseenheid
            ModulesDataGrid.DataSource = studyCourse.GetModuleInformation(1, "Onderwijseenheid");
            ModulesDataGrid.Refresh();
        }

        private void Minor_Button_Click(object sender, EventArgs e)
        {
            //Filter op type = Minor
            ModulesDataGrid.DataSource = studyCourse.GetModuleInformation(1, "Minor");
            ModulesDataGrid.Refresh();
        }

        private void Stage_Button_Click(object sender, EventArgs e)
        {
            //Filter op type = Stage
            ModulesDataGrid.DataSource = studyCourse.GetModuleInformation(1, "Stage");
            ModulesDataGrid.Refresh();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            int rowindex = ModulesDataGrid.CurrentCell.RowIndex;
            int ModuleNameIndex = 0;

            string SelectedModule = ModulesDataGrid.Rows[rowindex].Cells[ModuleNameIndex].Value.ToString();
            debug_text.Text = SelectedModule;
            studyCourse.AddModules(student.GetStudentID(), SelectedModule);

            MessageBox.Show("Je inschrijving is succesvol voltooid!", "Succesvolle inschrijving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
