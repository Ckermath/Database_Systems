using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    class Order
    {
        int OrderCode;
        DateTime OrderDate;
        string Employee;

        public Order(int orderCode, DateTime orderDate, string employee)
        {
            OrderCode = orderCode;
            OrderDate = orderDate;
            Employee = employee;
        }

        public Order()
        {

        }

        public int OrderCode1 { get => OrderCode; set => OrderCode = value; }
        public DateTime OrderDate1 { get => OrderDate; set => OrderDate = value; }
        public string Employee1 { get => Employee; set => Employee = value; }
    }
}
