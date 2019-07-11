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
    public partial class StudentInformation : Form
    {
        private int studyCoachID;
        private string study;
        private Student student;
        // private List<Module> StudyCourseList;
        StudyCourse studyCourse;

        public StudentInformation(int studyCoachID, string study, Student student, StudyCourse studyCourse)
        {
            this.studyCoachID = studyCoachID;
            this.study = study;
            this.student = student;
            this.studyCourse = studyCourse;
            InitializeComponent();
        }

        //Method to load window with initial settings
        private void StudentInformation_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.ReadOnly = true;
            LastNameTextBox.ReadOnly = true;
            StudyTextBox.ReadOnly = true;
            StartStudyTextBox.ReadOnly = true;
            EndStudyTextBox.ReadOnly = true;

            FirstNameTextBox.Text = student.GetFirstName();
            LastNameTextBox.Text = student.GetLastName();
            StudyTextBox.Text = study;
            StartStudyTextBox.Text = student.GetStartTIme().ToShortDateString();
            EndStudyTextBox.Text = student.GetEndTIme().ToShortDateString();
        }

        private void SubscribedOverviewButton_Click(object sender, EventArgs e)
        {
            SubscriptionOverview overview = new SubscriptionOverview(student, studyCourse);
            overview.Show();
        }

        //Method to activate button to go back to student overview
        private void StudentOverview_Click(object sender, EventArgs e)
        {
            StudentOverview overview = new StudentOverview();
            this.Hide();
            overview.Show();
        }

        //Method to activate Studycourse button
        private void StudyCourseButton_Click(object sender, EventArgs e)
        {
            OverviewStudyCourse studyCourseOverview = new OverviewStudyCourse(studyCourse);
            studyCourseOverview.Show();
        }
    }
}
