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
        //Create a new Instance of clsStock.
        clsStock Product = new clsStock();

        // Capture and validate the Product_ID.
        int Product_ID;

        if (int.TryParse(txtProduct_ID.Text, out Product_ID))
        {
            Product.Product_ID = Product_ID;
        }
        else
        {
            lblError.Text = "Invalid Product ID format.";
            return;
        }

        //Capture the Product_Name.
        string Product_Name = txtProduct_Name.Text;

        //Capture the Prod_Description.
        string Prod_Description = txtProd_Description.Text;

        //Capture the Prod_Price.
        string Prod_Price = txtProd_Price.Text;

        //Capture the Prod_Quantity.
        string Prod_Quantity = txtProd_Quantity.Text;

        //Capture the Date_Added.
        string Date_Added = txtDate_Added.Text;

        //Capture the Supplier_ID.
        string Supplier_ID = txtSupplier_ID.Text;

        //Variable to store any Error message.
        string Error = "";
        // Validate the data.
        Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
        if (Error == "")
        {
            int Product_Id;
            if (int.TryParse(Product_ID.ToString(), out Product_Id))
            {
                Product.Product_ID = Product_Id;
            }
            else
            {
                lblError.Text = "Invalid supplier ID format.";
                return;
            }
            //Capture the Product_Name.
            Product.Product_Name = Product_Name;
            //Capture the Product_Name.
            Product.Prod_Description = Prod_Description;
            //Capture the Product_Name.
            float Price;
            if (float.TryParse(Prod_Price, out Price))
            {
                Product.Prod_Price = (int)Price;
            }
            else
            {
                lblError.Text = "Invalid price format  : ";
                return;
            }
            //Capture the Product_Name.
            // Convert and capture the Prod_Quantity.
            int quantity;
            if (int.TryParse(Prod_Quantity, out quantity))
            {
                Product.Prod_Quantity = quantity;
            }
            else
            {
                lblError.Text = "Invalid quantity format  : ";
                return;
            }
            //Capture the Product_Name.
            Product.Date_Added = Convert.ToDateTime(Date_Added);

            //Capture the Product_Name.
            int Supplier_Id;
            if (int.TryParse(Supplier_ID, out Supplier_Id))
            {
                Product.Supplier_ID = Supplier_Id;
            }
            else
            {
                lblError.Text = "Invalid supplier ID format.";
                return;
            }

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
            //Display the Error Message.
            lblError.Text = Error;

        }

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Product = new clsStock();

        // Clear any previous messages
        lblError.Text = "";

        int Product_ID;
        // Try to parse the Product_ID
        if (!Int32.TryParse(txtProduct_ID.Text, out Product_ID))
        {
            lblError.Text = "Error: Invalid ID format. Please enter a numeric value  :";
            return;
        }

        // Attempt to find the product
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
