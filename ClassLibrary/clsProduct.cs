using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Prod_Description { get; set; }
        public float Prod_Price { get; set; }
        public int Prod_Quantity { get; set; }
        public DateTime Date_Added { get; set; }
        public int Supplier_ID { get; set; }
    }
}