using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiepad.Logic
{
    public class Faculty
    {
        private int ID;
        private string name;
        private int type;

        public Faculty(int ID, string name, int type)
        {
            this.ID = ID;
            this.name = name;
            this.type = type;
        }

        public Faculty(int ID)
        {
            this.ID = ID;
        }

        public int GetType()
        {
            return type;
        }
    }
}
