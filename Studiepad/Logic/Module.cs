using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiepad.Logic
{
    public class Module
    {
        private string moduleCode;
        private string name;
        private int period;
        private string type;
        private double EC;
        private bool? approved;
        private string notes;
        private DataAccess.DataAccess dal = new DataAccess.DataAccess();

        public Module(string moduleCode, string name,
            int period, string type, double EC, bool? approved, string notes)
        {
            this.moduleCode = moduleCode;
            this.name = name;
            this.period = period;
            this.type = type;
            this.EC = EC;
            this.approved = approved;
            this.notes = notes;
        }

        //Overloading constructor
        public Module() { }

        public string GetModuleCode()
        {
            return moduleCode;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPeriod()
        {
            return period;
        }

        public string GetType()
        {
            return type;
        }

        public double GetEC()
        {
            return EC;
        }

        public bool? GetApproved()
        {
            return approved;
        }

        public string GetNotes()
        {
            return notes;
        }

        public void SetNotes(string value)
        {
            notes = value;
        }

        //Method to get list of modules of specified student
        public List<Module> GetModules(int id) 
        {
            List<Module> ModuleInformation = dal.GetModuleInformation(id); 
            return ModuleInformation;
        }

        //Method to approve module
        public void ApproveModule(bool value)
        {
            approved = value;
        }

        public void RejectModule(bool value)
        {
            approved = value;
        }

        //Method to save subscription changes
        public void ProcessSubScriptionChanges(List<Module> Modules, int ID)
        {
            dal.SaveApprovedModules(Modules, ID);
        }
    }
}
