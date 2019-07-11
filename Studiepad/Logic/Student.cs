using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Studiepad.Logic
{
    public class Student:Person
    {
       
        private int studentID;
        private DateTime startTime;
        private DateTime endTime;
        private StudyCoach studyCoach;
        private Faculty faculty;
        DataAccess.DataAccess dal = new DataAccess.DataAccess();

        public Student(string firstName, string lastName, int role, int studentID, DateTime startTime, DateTime endTime, Faculty faculty)
            :base(firstName, lastName, role)
        {
            this.studentID = studentID;
            this.startTime = startTime;
            this.endTime = endTime;
            this.faculty = faculty;
        }

        //Overloading constructor
        public Student() { }

        public int GetStudentID()
        {
            return studentID;
        }

        public DateTime GetStartTIme()
        {
            return startTime;
        }

        public DateTime GetEndTIme()
        {
            return endTime;
        }

        public Faculty GetFaculty()
        {
            return faculty;
        }

        //Method to get students
        public List<Student> GetStudent(int id)
        {
            List<Student> Students = dal.GetStudentData(id);
            return Students;

        }

        public void RegisterModule(string _ModuleCode)
        {
            int UserID = this.studentID;
            Logic.StudyCourse studyCourse = new Logic.StudyCourse(null, false, "");
            studyCourse.SaveStudyCourse(UserID, _ModuleCode);
        }
    }
}
