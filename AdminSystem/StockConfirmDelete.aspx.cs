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
        Product_ID = Convert.ToInt32(Session["Product_ID"]);

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