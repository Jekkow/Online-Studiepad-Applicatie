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
using Studiepad.GUI;

namespace Studiepad
{
    public partial class Main : Form
    {
        StudyCourse studyCourse = new StudyCourse();
        private int roleID;
        public Main(int roleID)
        {
            InitializeComponent();
            HideButtons(roleID);
            this.roleID = roleID;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void HideButtons(int roleID)
        {
            if (roleID == 1)
            {
                ReportOverviewButton.Hide();
                StudentOverviewButton.Hide();
            }
            else if (roleID == 2)
            {
                ReportOverviewButton.Hide();
                RegisterPageButton.Hide();
                StudyCourseButton.Hide();
            }
            else
            {
                StudentOverviewButton.Hide();
                RegisterPageButton.Hide();
                StudyCourseButton.Hide();
            }
        }
        private void StudentOverviewButton_Click(object sender, EventArgs e)
        {
            StudentOverview studentoverview = new StudentOverview();
            this.Hide();
            studentoverview.Show();
        }

        private void ReportOverviewButton_Click(object sender, EventArgs e)
        {
            ReportOverview reportoverview = new ReportOverview();
            this.Hide();
            reportoverview.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login loginscreen = new Login();
            this.Hide();
            loginscreen.Show();
        }

        private void RegisterPageButton_Click(object sender, EventArgs e)
        {
            studyCourse = new StudyCourse(studyCourse.ListModules(1), studyCourse.GetStudyCourseStatus(), studyCourse.GetStudyCourseNotes());
            RegisterPage registerscreen = new RegisterPage(studyCourse);
            this.Hide();
            registerscreen.Show();
        }

        private void StudyCourseButton_Click(object sender, EventArgs e)
        {
            studyCourse = new StudyCourse(studyCourse.ListModules(1), studyCourse.GetStudyCourseStatus(), studyCourse.GetStudyCourseNotes());
            OverviewStudyCourse studycoursescreen = new OverviewStudyCourse(studyCourse);
            this.Hide();
            studycoursescreen.Show();
        }
    }
}
