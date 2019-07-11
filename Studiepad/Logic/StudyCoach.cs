using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiepad.Logic
{
    class StudyCoach:Person
    {
        public List<Student> Students = new List<Student>();

        public StudyCoach(string firstName, string lastName, int role)
            : base(firstName, lastName, role)
        {
            
        }

        //Overloading constructor
        public StudyCoach() { }

        //Overloading constructor
       // public StudyCoach():base (username) { }

        //Method to list students
        public List<Student> ListStudents(int id)
        {
            Student theStudent = new Student();
            List<Student> StudentsFound = theStudent.GetStudent(id);
            foreach(Student foundStudent in StudentsFound)
            {
                Students.Add(foundStudent);
            }
            return Students;
        }
    }
}
