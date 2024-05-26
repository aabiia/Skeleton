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


    }
}