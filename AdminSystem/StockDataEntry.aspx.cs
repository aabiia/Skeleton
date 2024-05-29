using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 Product_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        Product_ID = Convert.ToInt32(Session["Product_ID"]);
        if (IsPostBack == false)
        {
            if (Product_ID != -1)
            {
                DisplayProduct();
            }
        }

    }

    void DisplayProduct()
    {
        clsProductCollection Product = new clsProductCollection();
        Product.ThisProduct.Find(Product_ID);

        txtProduct_ID.Text = Product.ThisProduct.Product_ID.ToString();
        txtProduct_Name.Text = Product.ThisProduct.Product_Name.ToString();
        txtProd_Description.Text = Product.ThisProduct.Prod_Description.ToString();
        txtProd_Price.Text = Product.ThisProduct.Prod_Price.ToString();
        txtProd_Quantity.Text = Product.ThisProduct.Prod_Quantity.ToString();
        txtDate_Added.Text = Product.ThisProduct.Date_Added.ToString();
        txtSupplier_ID.Text = Product.ThisProduct.Supplier_ID.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock Product = new clsStock();
        string Product_Name = txtProduct_Name.Text;
        string Prod_Description = txtProd_Description.Text;
        string Prod_Price = txtProd_Price.Text;
        string Prod_Quantity = txtProd_Quantity.Text;
        string Date_Added = txtDate_Added.Text;
        string Supplier_ID = txtSupplier_ID.Text;

        string Error = "";
        Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
        if (Error == "")
        {
            Product.Product_ID = Product_ID;
            Product.Product_Name = Product_Name;
            Product.Prod_Description = Prod_Description;
            Product.Prod_Price = Convert.ToInt32(Prod_Price);
            Product.Prod_Quantity = Convert.ToInt32(Prod_Quantity);
            Product.Date_Added = Convert.ToDateTime(Date_Added);
            Product.Supplier_ID = Convert.ToInt32(Supplier_ID);

            clsProductCollection ProductList = new clsProductCollection();

            if (Product_ID == -1)
            {
                ProductList.ThisProduct = Product;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(Product_ID);
                ProductList.ThisProduct = Product;
                ProductList.Update();
            }

            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;

        }

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Product = new clsStock();

        lblError.Text = "";

        int Product_ID;
        if (!Int32.TryParse(txtProduct_ID.Text, out Product_ID))
        {
            lblError.Text = "Error: Invalid ID format. Please enter a numeric value  :";
            return;
        }

        Boolean Found = Product.Find(Product_ID);

        if (Found)
        {
            // Populate the text fields with the product data
            txtProduct_Name.Text = Product.Product_Name.ToString();
            txtProd_Description.Text = Product.Prod_Description.ToString();
            txtProd_Price.Text = Product.Prod_Price.ToString();
            txtProd_Quantity.Text = Product.Prod_Quantity.ToString();
            txtDate_Added.Text = Product.Date_Added.ToString();
            txtSupplier_ID.Text = Product.Supplier_ID.ToString();
        }
        else
        {
            // Display an error message if the product is not found
            lblError.Text = "Error: Product with the specified ID does not exist  :";
           
        }

    }


}
