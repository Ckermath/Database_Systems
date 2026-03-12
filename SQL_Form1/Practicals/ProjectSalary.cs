using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    public class ProjectSalary
    {
        int empId;
        decimal hourlyRate;
        int projId;

        public ProjectSalary(int empId, decimal hourlyRate, int projId)
        {
            this.empId = empId;
            this.hourlyRate = hourlyRate;
            this.projId = projId;
        }

        public ProjectSalary()
        {

        }

        public int EmpId { get => empId; set => empId = value; }
        public decimal HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public int ProjId { get => projId; set => projId = value; }
    }
}
