using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Studiepad.DataAccess
{
    class DataAccess
    {
        // Database connection
        private readonly SqlConnection conn = new SqlConnection(
            "Data Source=INSERTDATABASESERVER;" +
            "Initial Catalog=INSERTDATABASENAME;" +
            "Persist Security Info=True;" +
            "User ID=INSERTUSERNAME;" +
            "Password=INSERTPASSWORD;

        public void DataExamineStudyCourse(int studentID, bool approved, string notes)
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE StudyCourse " +
                "SET approved = @val1," +
                "notes = @val2 " +
                "WHERE studentnumber = @val3", conn);
            cmd.Parameters.AddWithValue("@val1", approved);
            cmd.Parameters.AddWithValue("@val2", notes);
            cmd.Parameters.AddWithValue("@val3", studentID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Logic.Report> GetReportData()
        {
            List<Logic.Report> ReportData = new List<Logic.Report>();
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Report", conn))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReportData.Add(new Logic.Report(Int32.Parse(reader[0].ToString()), reader[1].ToString(),
                            reader[2].ToString(), reader[3].ToString(), DateTime.Parse(reader[4].ToString()))); 
                    }
                }
            }
            conn.Close();
            return ReportData;
        }

        public DataTable GetAllData(string name)                                                                        
        {
            DataTable collectedData = new DataTable();                                                                  //Create empty datatable
            conn.Open();
            if(name == "Aantal studenten per studie")                                                                   //Decide based on name which query will be executed
            {
                using(SqlCommand cmd = new SqlCommand("Select * from Student", conn))
                {
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))                                         
                    {
                        dataAdapter.Fill(collectedData);                                                                //Fill data adapter with queryData
                    }
                }
            }
            else if(name == "Aantal inschrijvingen onderwijseenheden")
            {
                using(SqlCommand cmd = new SqlCommand("SELECT Module.moduleCode, StudyCourse_has_Module.approved FROM Module LEFT JOIN  StudyCourse_has_Module ON Module.moduleCode = StudyCourse_has_Module.moduleCode", conn))
                {
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(collectedData);
                    }
                }
            }

            return collectedData;
        }

        // Grab modules in studycourse
        public DataTable DataGetStudyCourseModules(int UserID)
        {
            conn.Close();
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(
                "SELECT StudyCourse_has_Module.idStudyCourse, Module.moduleCode, Module.moduleName, Module.EC, Module.period, Module.type, StudyCourse_has_Module.notes, StudyCourse_has_Module.approved FROM Module JOIN StudyCourse_has_Module ON StudyCourse_has_Module.moduleCode = Module.moduleCode WHERE StudyCourse_has_Module.studentNummer = @val", conn);
            adapt.SelectCommand.Parameters.AddWithValue("@val", 1);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        // Grab status of studycourse (approved, rejected or not examined)
        public bool? DataGetStudyCourseStatus(int userID)
        {
            bool? status = null;

            SqlCommand cmd = new SqlCommand("SELECT approved FROM StudyCourse WHERE studentNumber = @val", conn);
            cmd.Parameters.AddWithValue("@val", userID);
            conn.Close(); // CONNECTION IS NOT CLOSED???
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    status = reader.IsDBNull(0) ? (bool?)null : reader.GetBoolean(0);
                    return status;
                }
            }
            conn.Close();
            return status;
        }

        // Grab notes of studycourse
        public string DataGetStudyCourseNotes(int UserID)
        {
            conn.Close(); // CONNECTION IS NOT CLOSED???
            conn.Open();
            SqlCommand cmd = new SqlCommand
                ("SELECT notes FROM StudyCourse WHERE studentNumber = @val", conn);
            cmd.Parameters.AddWithValue("@val", UserID);
            string notes = cmd.ExecuteScalar().ToString();
            conn.Close();
            return notes;
        }
     
        
        // Method to get unsubscribed Modules from a student
        public DataTable DataGetUnsubscribedModules(int UserID)
        {
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter
                ("SELECT moduleCode, moduleName, EC, idFaculty, Module.period, Module.type FROM Module EXCEPT SELECT StudyCourse_has_Module.moduleCode, Module.moduleName, EC, idFaculty, Module.period, Module.type FROM Module JOIN StudyCourse_has_Module ON StudyCourse_has_Module.moduleCode = Module.moduleCode WHERE StudyCourse_has_Module.studentNummer = @val", conn);
            adapt.SelectCommand.Parameters.AddWithValue("@val", UserID);
            DataTable da = new DataTable();
            adapt.Fill(da);
            conn.Close();
            return da;
        }

        // Method to get unsubscribed Modules from a student
        public DataTable DataGetUnsubscribedModulesWithFilter(int UserID, string type)
        {
            conn.Close();
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter
                ("SELECT moduleCode, moduleName, EC, idFaculty, Module.period, Module.type FROM Module WHERE Module.type = @val2 EXCEPT SELECT StudyCourse_has_Module.moduleCode, Module.moduleName, EC, idFaculty, Module.period, Module.type FROM Module JOIN StudyCourse_has_Module ON StudyCourse_has_Module.moduleCode = Module.moduleCode WHERE StudyCourse_has_Module.studentNummer = @val1", conn);
            adapt.SelectCommand.Parameters.AddWithValue("@val1", UserID);
            adapt.SelectCommand.Parameters.AddWithValue("@val2", type);
            DataTable da = new DataTable();
            adapt.Fill(da);
            conn.Close();
            return da;
        }

        //Method to get studentData
        public List<Logic.Student> GetStudentData(int id)
        {

            List<Logic.Student> StudentData = new List<Logic.Student>();
            conn.Open();

            //Execute query to get correct data from database from separate tables
            using (SqlCommand cmd = new SqlCommand("SELECT Account.firstName, Account.lastName, Account.role, Student.studentNumber, Student.startTime, Student.endTime, idFaculty FROM Account INNER JOIN Student ON Student.userID= Account.id WHERE idStudyCoach = @idStudyCoach", conn))
            {
                cmd.Parameters.AddWithValue("idStudyCoach", id);

                //Compile list
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentData.Add(new Logic.Student(reader[0].ToString(), reader[1].ToString(), Int32.Parse(reader[2].ToString()), Int32.Parse(reader[3].ToString()), DateTime.Parse(reader[4].ToString()), DateTime.Parse(reader[5].ToString()), new Logic.Faculty(Int32.Parse(reader[6].ToString()))));
                    }
                }
            }
            conn.Close();
            return StudentData;
        }

        //Method to get list of modules included in studycourse of selected student
        public List<Logic.Module> GetModuleInformation(int id)
        {
            bool? approved = false;
            List<Logic.Module> Modules = new List<Logic.Module>();

            conn.Close();
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT StudyCourse_has_Module.idStudyCourse, Module.moduleCode, Module.moduleName, Module.period, Module.type, Module.EC, StudyCourse_has_Module.approved, StudyCourse_has_Module.notes FROM Module JOIN StudyCourse_has_Module ON StudyCourse_has_Module.moduleCode = Module.moduleCode WHERE StudyCourse_has_Module.studentNummer = @id", conn))

            {
                cmd.Parameters.AddWithValue("@id", id);
                using(SqlDataReader moduleReader = cmd.ExecuteReader())
                {
                    while (moduleReader.Read())
                    {
                        if(moduleReader[6].ToString() == false.ToString())
                        {
                            approved = null;
                        }
                        else if(moduleReader[6].ToString() == true.ToString())
                        {
                            approved = true;
                        }
                        else
                        {
                            approved = null;
                        }
                        Modules.Add(new Logic.Module(moduleReader[1].ToString(), moduleReader[2].ToString(), Int32.Parse(moduleReader[3].ToString()), moduleReader[4].ToString(), double.Parse(moduleReader[5].ToString()), approved, moduleReader[7].ToString()));
                    }
                }
            }
            conn.Close();
            return Modules;
        }

        //Method to save approved modules in the database
        public void SaveApprovedModules(List<Logic.Module> Modules, int ID)
        {
            List<Logic.Module> Module = Modules;

            conn.Open();
            foreach (Logic.Module module in Module)
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE StudyCourse_has_Module SET approved = @approved, notes = @notes WHERE studentNummer = @studentNumber AND moduleCode = @moduleCode", conn))
                {
                    cmd.Parameters.AddWithValue("@approved", module.GetApproved());
                    cmd.Parameters.AddWithValue("@notes", module.GetNotes());
                    cmd.Parameters.AddWithValue("@studentNumber", ID);
                    cmd.Parameters.AddWithValue("@moduleCode", module.GetModuleCode());
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }

        public void SaveStudyCourse(int StudyCourseID, int UserID, string ModuleCode)
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO StudyCourse_has_Module VALUES(@Val1, @Val2, @Val3, NULL, NULL)", conn);
            cmd.Parameters.AddWithValue("@Val1", StudyCourseID);
            cmd.Parameters.AddWithValue("@Val2", 1); //CHANGE TO UserID WHEN LOGIN IS GUCCI
            cmd.Parameters.AddWithValue("@Val3", ModuleCode);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Method to get all moduledata from database
        public DataTable GetAllModules()
        {
            DataTable Modules = new DataTable();
            using(SqlCommand cmd = new SqlCommand("SELECT moduleCode, moduleName FROM Module", conn))
            {
                using(SqlDataAdapter ModuleAdapter = new SqlDataAdapter(cmd))
                {
                    ModuleAdapter.Fill(Modules);
                }
            }
            conn.Close();
            return Modules;
        }

        public void DeleteSubscribedModule(string code)
        {

        }
    }
}
