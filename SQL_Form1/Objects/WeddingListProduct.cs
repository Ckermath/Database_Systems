using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    class WeddingListProduct
    {
        int WeddingListNo, Qty;
        string ProductCode, ConfirmedPurchase, CustomerName;
        DateTime PurchasedDate;

        public WeddingListProduct()
        {

        }
        public WeddingListProduct(int weddingListNo, int qty, string productCode, string confirmedPurchase, string customerName, DateTime purchasedDate)
        {
            WeddingListNo = weddingListNo;
            Qty = qty;
            ProductCode = productCode;
            ConfirmedPurchase = confirmedPurchase;
            CustomerName = customerName;
            PurchasedDate = purchasedDate;
        }

        public int WeddingListNo1 { get => WeddingListNo; set => WeddingListNo = value; }
        public int Qty1 { get => Qty; set => Qty = value; }
        public string ProductCode1 { get => ProductCode; set => ProductCode = value; }
        public string ConfirmedPurchase1 { get => ConfirmedPurchase; set => ConfirmedPurchase = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public DateTime PurchasedDate1 { get => PurchasedDate; set => PurchasedDate = value; }
    }
}
