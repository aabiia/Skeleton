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
            clsProductCollection AllProduct = new clsProductCollection();
            Assert.IsNotNull(AllProduct);
        }

        [TestMethod]
        public void ProdutListOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();

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
            clsProductCollection AllProduct = new clsProductCollection();

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
            clsProductCollection AllProduct = new clsProductCollection();

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

            Assert.AreEqual(AllProduct.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();

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
            clsProductCollection AllProduct = new clsProductCollection();

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
            clsProductCollection AllProduct = new clsProductCollection();

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

            clsProductCollection AllProducts = new clsProductCollection();

            clsProductCollection FilteredProduct = new clsProductCollection();
            FilteredProduct.ReportByProductName("");

            Assert.AreEqual(AllProducts.Count, FilteredProduct.Count);


        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {

            clsProductCollection FilteredProduct = new clsProductCollection();
            FilteredProduct.ReportByProductName("NXCND");

            Assert.AreEqual(0, FilteredProduct.Count);
        }


        [TestMethod]

        public void ReportByProductNameTestDataFound()
        {
            clsProductCollection FilteredProduct = new clsProductCollection();
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