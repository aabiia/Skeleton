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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new Instance of clsStock.
        clsStock Product = new clsStock();

        //Capture the Product_ID.
        Product.Product_ID = Convert.ToInt32(txtProduct_ID.Text);

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
                lblError.Text = "Invalid price format.";
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
                lblError.Text = "Invalid quantity format.";
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
            // Store the Product in the SessionObject.
            Session["Product"] = Product;
            //Nevigate to the view page
            Response.Redirect("StockViewer.aspx");

        }

        else
        {
            //Display the Error Message.
            lblError.Text = Error;

        }

    }

}
