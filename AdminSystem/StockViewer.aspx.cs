using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Get the data from the Session Object
            clsStock Product = Session["Product"] as clsStock;

            // Check if Product is null
            if (Product != null)
            {
                Response.Write(Product.Product_ID + "<br>");

                // Display Product_Name for this entry
                Response.Write(Product.Product_Name + "<br>");

                // Display Prod_Description for this entry
                Response.Write(Product.Prod_Description + "<br>");

                // Display Prod_Price for this entry
                Response.Write(Product.Prod_Price.ToString("C") + "<br>");

                // Display Prod_Quantity for this entry
                Response.Write(Product.Prod_Quantity + "<br>");

                // Display Date_Added for this entry
                Response.Write(Product.Date_Added.ToShortDateString() + "<br>");

                // Display Supplier_ID for the entry
                Response.Write(Product.Supplier_ID + "<br>");
            }
            else
            {
                // Handle the case where the session object is null
                Response.Write("Error: No product data found in session.");
                // Optionally, you could redirect to an error page or the previous page
                // Response.Redirect("ErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            // Log the exception for debugging purposes
            Response.Write("An error occurred: " + ex.Message);
        }

    }


    protected void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
    {
        

    }
}
