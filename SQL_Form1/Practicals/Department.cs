using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    public class Department
    {
        int id;
        string name;

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Department()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
