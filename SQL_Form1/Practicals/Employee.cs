using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    public class Employee
    {
        int deptNo;
        int empId;
        string name;

        public Employee(int deptNo, int empId, string name)
        {
            this.deptNo = deptNo;
            this.empId = empId;
            this.name = name;
        }

        public Employee()
        { 

        }

        public int DeptNo { get => deptNo; set => deptNo = value; }
        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
    }
}
