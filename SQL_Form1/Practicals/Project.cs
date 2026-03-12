using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    public class Project
    {
        decimal budget;
        int id;
        string managerName;
        string name;
        DateTime ProjectStartDate;
        DateTime ProjectEndDate;
        bool ProjectCompleted;

        public Project(decimal budget, int id, string managerName, string name)
        {
            this.budget = budget;
            this.id = id;
            this.managerName = managerName;
            this.name = name;
        }

        public Project()
        {

        }

        public Project(DateTime projectStartDate, DateTime projectEndDate, bool projectCompleted)
        {
            ProjectStartDate = projectStartDate;
            ProjectEndDate = projectEndDate;
            ProjectCompleted = projectCompleted;
        }

        private bool CheckPresent(string value)
        {
            if (String.IsNullOrWhiteSpace(value)) return false;
            
            else return true;
            
        }

        private bool CheckProjectDay(DateTime value)
        {
            if ((int)value.DayOfWeek == 6 || (int)value.DayOfWeek == 0)
                return false;
            else
                return true;
        }

        private bool CheckEndDate(DateTime value)
        {
            if (CheckProjectDay(value) && value >= ProjectStartDate.AddDays(7))
                return true;
            else
                return false;
        }

        public string ManagerName
        {
            get { return managerName; }
            set
            {
                if (CheckPresent(value))
                {
                    managerName = value;
                }
                else
                {
                    throw new Exception("Manager Name cannot be left blank.");
                }
            }
        }
        
        public DateTime ProjectStartDate1
        {
            get { return ProjectStartDate; }
            set
            {
                if (CheckProjectDay(value))
                {
                    ProjectStartDate = value;
                }
                else
                {
                    throw new Exception("Projects must start between Monday and Friday.");
                }
            }
        }

        public DateTime ProjectEndDate1
        {
            get { return ProjectEndDate; }
            set
            {
                if (CheckEndDate(value))
                {
                    ProjectEndDate = value;
                }
                else
                {
                   throw new Exception("Projects must end between Monday and Friday.");
                }
                
            }
        }

        public decimal Budget { get => budget; set => budget = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool ProjectCompleted1 { get => ProjectCompleted; set => ProjectCompleted = value; }
    }
}
