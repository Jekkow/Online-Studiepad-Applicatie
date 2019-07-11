using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Studiepad.Logic
{
    class Report
    {
        private int ID;
        private string name;
        private string type;
        private string shortDescription;
        private DateTime published;
        DataAccess.DataAccess dal = new DataAccess.DataAccess();

        public Report(int ID, string name, string type, string shortDescription, DateTime published)
        {
            this.ID = ID;
            this.name = name;
            this.shortDescription = shortDescription;
            this.type = type;
            this.published = published;  
        }

        //Overloading Constructor
        public Report() { }

        public int GetID()
        {
            return ID;
        }

        public string GetName()
        {
            return name;
        }

        new public string GetType()
        {
            return type;
        }

        public string GetShortDescription()
        {
            return shortDescription;
        }

        public string GetPublished()
        {
            return published.ToString();
        }

        //Method to get available reports from Data Access.
        public List<Report> GetAvailableReports()
        {

            List<Report> ReportsFound = new List<Report>();
            ReportsFound = dal.GetReportData();
            return ReportsFound;
        }


        public DataTable GetReport(string name)                                             // method to get a report from DAL
        {

            if (name == "Aantal studenten per studie")                                      //Check name of report
            {
                int associateDegree = 0;
                int bachelor = 0;
                DataTable RawData = dal.GetAllData(name);                                   //Datatable for raw data
                DataTable ReportData = new DataTable();                                     //DataTable for modified data

                for (int i = 0; i < RawData.Rows.Count; i++)
                {
                    if (RawData.Rows[i]["idFaculty"].ToString() == 1.ToString())            //If idFaculty = 1, increment bachelor variable
                    {
                        bachelor += 1;
                    }
                    else if (RawData.Rows[i]["idFaculty"].ToString() == 2.ToString())       //If idFaculty = 2, increment associatDegree variable
                    {
                        {
                            associateDegree += 1;
                        }
                    }

                }

                ReportData.Columns.Add("Studie");                                           //Add columns to datatable
                ReportData.Columns.Add("Aantal studenten per studie", typeof(int));
                ReportData.Rows.Add("ICT Bachelor", bachelor.ToString());                   //Add rows to dataTable with generated data
                ReportData.Rows.Add("AD-ICT", bachelor.ToString());
                return ReportData;
            }
            else
            {
                DataTable RawData = dal.GetAllData(name);
                DataTable ModuleData = dal.GetAllModules();
                DataTable ReportData = new DataTable();
                int approved = 0;

                ReportData.Columns.Add("Module");
                ReportData.Columns.Add("Aantal voorlopige inschrijvingen");
                ReportData.Columns.Add("Aantal inschrijvingen");

                for (int i = 0; i < ModuleData.Rows.Count; i++)
                {
                    for (int j = 0; j < RawData.Rows.Count; j++)
                    {
                        if (RawData.Rows[j]["approved"].ToString() == true.ToString() && RawData.Rows[j]["moduleCode"].ToString() == ModuleData.Rows[i]["moduleCode"].ToString())
                        {
                            approved += 1;
                        }
                    }
                    ReportData.Rows.Add(ModuleData.Rows[i]["moduleCode"].ToString(), ModuleData.Rows[i]["moduleName"].ToString(), approved);
                    approved = 0;
                }
                return ReportData;
            }
        }

        public DataTable GenerateReport()                                                   // methode om een rapport te genereren
        {
            DataTable test = new DataTable();
            return test;
        }

        public void ShowReports()                                                           // methode om rapporten uit te draaien
        {

        }

    }

}
