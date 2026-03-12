using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    class OrderProduct
    {
        int orderCode, productCode, qty;

        public OrderProduct()
        {

        }

        public int OrderCode { get => orderCode; set => orderCode = value; }
        public int ProductCode { get => productCode; set => productCode = value; }
        public int Qty { get => qty; set => qty = value; }
    }
}
