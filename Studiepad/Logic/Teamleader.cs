using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiepad.Logic
{
    class Teamleader:Person
    {
        private Faculty faculty;

        //Derived class constructo
        public Teamleader(string firstName, string lastName, int role, Faculty faculty)
            :base(firstName, lastName, role)
        {
            this.faculty = faculty;
        }

        //Overloading Constructor
        public Teamleader()
        {

        }

        //Method to list Reports for teamleader
        public List<Report> ListReports()
        {
            Report report = new Report();

            List<Report> AvailableReports = report.GetAvailableReports();
            return AvailableReports;
        }
    }
}
