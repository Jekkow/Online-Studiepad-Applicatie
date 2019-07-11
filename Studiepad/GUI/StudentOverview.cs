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
    public partial class StudentOverview : Form
    {
        List<Student> Students;
        string study = "";
        StudyCourse studyCourse = new StudyCourse();

        public StudentOverview()
        {
            InitializeComponent();
        }

        //Method to load window with initial settings
        private void StudentOverview_Load(object sender, EventArgs e)
        {
            StudentOverviewDataGrid.ReadOnly = true;
            FirstNameTextBox.ReadOnly = true;
            LastNameTextBox.ReadOnly = true;
            StudyTextBox.ReadOnly = true;
            RefreshStudentOverviewDataGrid();
        }

        //Method to activate cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to load datagrid with data
        private void RefreshStudentOverviewDataGrid()
        {
            StudyCoach studyCoach = new StudyCoach();
            Students = studyCoach.ListStudents(1);

            DataTable studentOVerviewTable = new DataTable();
            studentOVerviewTable.Columns.Add("Voornaam", typeof(string));
            studentOVerviewTable.Columns.Add("Achternaam", typeof(string));
            studentOVerviewTable.Columns.Add("Studie", typeof(string));
            studentOVerviewTable.Columns.Add("Startdatum", typeof(DateTime));
            studentOVerviewTable.Columns.Add("Einddatum", typeof(DateTime));

            for (int i = 0; i < Students.Count(); i++)
            {
                //Recalculate faculty type
                Faculty faculty = Students[i].GetFaculty();
                int facultyType = faculty.GetType();
               if(facultyType.ToString() == "1")
                {
                    study = "Bachelor ICT";
                }
                else
                {
                    study = "AD-ICT";
                }

               //Add rows to datatable
                studentOVerviewTable.Rows.Add(Students[i].GetFirstName(), Students[i].GetLastName(), study, Students[i].GetStartTIme().ToString(), Students[i].GetEndTIme().ToString());

            }

            StudentOverviewDataGrid.DataSource = studentOVerviewTable;
            StudentOverviewDataGrid.Refresh();
        }

        //Method to sync textboxes with datagrid cells
        private void StudentOverviewDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FirstNameTextBox.Text = StudentOverviewDataGrid[0, e.RowIndex].Value.ToString();
                LastNameTextBox.Text = StudentOverviewDataGrid[1, e.RowIndex].Value.ToString();
                StudyTextBox.Text = StudentOverviewDataGrid[2, e.RowIndex].Value.ToString();
            }
            catch
            {
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                StudyTextBox.Clear();
            }
        }

        private Student SelectStudent(string firstName)
        {
            Student studentData = new Student();
            foreach(Student student in Students)
            {
                if(student.GetFirstName() == firstName)
                {
                    studentData = student;
                }
            }

            return studentData;
        }

        private void StudyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudyLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectStudentButton_Click(object sender, EventArgs e)
        {
            Student student = SelectStudent(FirstNameTextBox.Text);
            studyCourse = new StudyCourse(studyCourse.ShowStudyCourse(), studyCourse.GetStudyCourseStatus(), studyCourse.GetStudyCourseNotes());
            StudentInformation studentInformation = new StudentInformation(1, study, student, studyCourse);
            studentInformation.Show();
            this.Hide();
        }
    }
}
