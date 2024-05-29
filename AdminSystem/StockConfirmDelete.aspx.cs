using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 Product_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Product_ID"] != null && int.TryParse(Session["Product_ID"].ToString(), out Product_ID))
        {
            // Product_ID is successfully parsed
        }
        else
        {
            // Handle the case where Product_ID is not in the session or not valid
            Response.Write("Product ID not found in session or is not a valid number.");
            Response.Redirect("StockList.aspx");
        }

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsProductCollection Product = new clsProductCollection();

        Product.ThisProduct.Find(Product_ID);

        Product.Delete();

        Response.Redirect("StockList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}