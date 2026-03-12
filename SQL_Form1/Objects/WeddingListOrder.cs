using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    class WeddingListOrder
    {
        int orderCode, weddingListNo;
        string customerName;

        public WeddingListOrder()
        {

        }
        public int OrderCode { get => orderCode; set => orderCode = value; }
        public int WeddingListNo { get => weddingListNo; set => weddingListNo = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
    }
}
