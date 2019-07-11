using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Studiepad.Logic
{
    public class StudyCourse
    {
        DataAccess.DataAccess data = new DataAccess.DataAccess();

        public List<Module> StudyCourseList = new List<Module>();
        private Student studentID;
        private bool? approved;
        private string notes;

        public StudyCourse(List<Module> StudyCourseList, bool? approved, string notes)
        {
            this.StudyCourseList = StudyCourseList;
            int StudentNumber = 1;
            this.approved = data.DataGetStudyCourseStatus(StudentNumber);
            this.notes = notes;
        }

        public StudyCourse() { }

        public List<Module> ShowStudyCourse()
        {
            int StudentNumber = 1;
            List<Module> Modules = data.GetModuleInformation(StudentNumber);
            foreach (Module modules in Modules)
            {
                StudyCourseList.Add(modules);
            }
            //Save Modules in List StudyCourseList
            return StudyCourseList;
        }

        public bool? GetStudyCourseStatus()
        {
            //int StudentNumber = 1;
            //approved = data.DataGetStudyCourseStatus(StudentNumber);
            return approved;
        }

        public string GetStudyCourseNotes()
        {
            int StudentNumber = 1; // nog aan te passen
            notes = data.DataGetStudyCourseNotes(StudentNumber);
            return notes;
        }

        public void ExamineStudyCourse(bool approve, string notes)
        {
            approved = approve;
            data.DataExamineStudyCourse(Convert.ToInt32(1), approve, notes);
        }

        public void SaveStudyCourse(int UserID, string ModuleCode)
        {
            int StudyCourseID = 1;
            data.SaveStudyCourse(StudyCourseID, UserID, ModuleCode);
        }

        public void AddModules(int ID, string _moduleCode)
        {
            Logic.StudyCourse studyCourse = new Logic.StudyCourse(null, false, "");
            studyCourse.SaveStudyCourse(ID, _moduleCode);
        }

        public void UnsubscribeModule(string code)
        {
            StudyCourseList.Remove(code);
        }

        public List<Module> ListModules(int id)
        {
            Module module = new Module();
            List<Module> Modules = module.GetModules(id);
            foreach(Module modules in Modules)
            {
                StudyCourseList.Add(modules);
            }
            return StudyCourseList;
        }

        public DataTable GetModuleInformation(int UserID, string type)
        {
            DataTable UnsubdModules = data.DataGetUnsubscribedModulesWithFilter(UserID, type);

            return UnsubdModules;
        }
    }
}
