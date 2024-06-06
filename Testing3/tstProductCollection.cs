using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstProductCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();
            Assert.IsNotNull(AllProduct);
        }

        [TestMethod]
        public void ProdutListOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.Product_ID = 1;
            TestItem.Product_Name = "Skincare";
            TestItem.Prod_Description = "Description";
            TestItem.Prod_Price = 10;
            TestItem.Prod_Quantity = 10;
            TestItem.Date_Added = DateTime.Now;
            TestItem.Supplier_ID = 1;

            TestList.Add(TestItem);

            AllProduct.ProductList = TestList;

            Assert.AreEqual(AllProduct.ProductList, TestList);
        }


        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();

            clsStock TestProduct = new clsStock();

            TestProduct.Product_ID = 1;
            TestProduct.Product_Name = "Skincare";
            TestProduct.Prod_Description = "Description";
            TestProduct.Prod_Price = 10;
            TestProduct.Prod_Quantity = 10;
            TestProduct.Date_Added = DateTime.Now;
            TestProduct.Supplier_ID = 1;

            AllProduct.ThisProduct = TestProduct;

            Assert.AreEqual(AllProduct.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.Product_ID = 1;
            TestItem.Product_Name = "Skincare";
            TestItem.Prod_Description = "Description";
            TestItem.Prod_Price = 10;
            TestItem.Prod_Quantity = 20;
            TestItem.Date_Added = DateTime.Now;
            TestItem.Supplier_ID = 1;

            TestList.Add(TestItem);

            AllProduct.ProductList = TestList;

            Assert.AreEqual(AllProduct.Count,TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();

            clsStock TestItem = new clsStock();

            int PrimaryKey = 0;

            TestItem.Product_ID = 1;
            TestItem.Product_Name = "Skincare";
            TestItem.Prod_Description = "Description";
            TestItem.Prod_Price = 10;
            TestItem.Prod_Quantity = 20;
            TestItem.Date_Added = DateTime.Now;
            TestItem.Supplier_ID = 1;

            AllProduct.ThisProduct = TestItem;

            PrimaryKey = AllProduct.Add();

            TestItem.Product_ID = PrimaryKey;

            AllProduct.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProduct.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();

            clsStock TestItem = new clsStock();

            int PrimaryKey = 0;

            TestItem.Product_Name = "Skincare";
            TestItem.Prod_Description = "Description";
            TestItem.Prod_Price = 10;
            TestItem.Prod_Quantity = 20;
            TestItem.Date_Added = DateTime.Now;
            TestItem.Supplier_ID = 1;

            AllProduct.ThisProduct = TestItem;

            PrimaryKey = AllProduct.Add();

            TestItem.Product_ID = PrimaryKey;

            AllProduct.ThisProduct.Find(PrimaryKey);

            TestItem.Product_Name = "Care Skin";
            TestItem.Prod_Description = "Product info.";
            TestItem.Prod_Price = 30;
            TestItem.Prod_Quantity = 30;
            TestItem.Date_Added = DateTime.Now;
            TestItem.Supplier_ID = 2;

            AllProduct.ThisProduct = TestItem;

            AllProduct.Update();

            AllProduct.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProduct.ThisProduct, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllProduct = new clsStockCollection();

            clsStock TestItem = new clsStock();

            int PrimaryKey = 0;

            TestItem.Product_ID = 1;
            TestItem.Product_Name = "Skincare";
            TestItem.Prod_Description = "Description";
            TestItem.Prod_Price = 10;
            TestItem.Prod_Quantity = 20;
            TestItem.Date_Added = DateTime.Now;
            TestItem.Supplier_ID = 1;

            AllProduct.ThisProduct = TestItem;

            PrimaryKey = AllProduct.Add();

            TestItem.Product_ID = PrimaryKey;

            AllProduct.ThisProduct.Find(PrimaryKey);

            AllProduct.Delete();

            Boolean Found = AllProduct.ThisProduct.Find(PrimaryKey);

            Assert.IsFalse( Found );
        }




        [TestMethod]
        public void ReportByProductNameMethodOK()
        {

            clsStockCollection AllProducts = new clsStockCollection();

            clsStockCollection FilteredProduct = new clsStockCollection();
            FilteredProduct.ReportByProductName("");

            Assert.AreEqual(AllProducts.Count, FilteredProduct.Count);


        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {

            clsStockCollection FilteredProduct = new clsStockCollection();
            FilteredProduct.ReportByProductName("NXCND");

            Assert.AreEqual(0, FilteredProduct.Count);
        }


        [TestMethod]

        public void ReportByProductNameTestDataFound()
        {
            clsStockCollection FilteredProduct = new clsStockCollection();
            Boolean OK = true;
            FilteredProduct.ReportByProductName("Aloe Vera");

            if (FilteredProduct.Count == 2)
            {
                if (FilteredProduct.ProductList[0].Product_ID != 25)
                {
                    OK = false;
                }
                if (FilteredProduct.ProductList[0].Product_ID != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
}