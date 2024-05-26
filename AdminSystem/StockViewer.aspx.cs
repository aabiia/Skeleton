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
        //Create a new Instance of clsStock.
        clsStock Product = new clsStock();

        //Get the data from the Session Object.
        Product = (clsStock)Session["Product"];

        Response.Write(Product.Product_ID);

        //Display Product_Name for this entry.
        Response.Write(Product.Product_Name);

        //Display Prod_Description for this entry.
        Response.Write(Product.Prod_Description);

        //Display Prod_Price for this entry.
        Response.Write(Product.Prod_Price);

        //Display Prod_Quantity for this entry.
        Response.Write(Product.Prod_Quantity);

        //Display Date_Added for this entry.
        Response.Write(Product.Date_Added);

        //Display Supplier_ID for the entry.
        Response.Write(Product.Supplier_ID);

    }
}
