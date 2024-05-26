using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DisplayProducts();

        }

    }

    void DisplayProducts()
    {
        clsProductCollection Products = new clsProductCollection();

        lstProductList.DataSource = Products.ProductList;

        lstProductList.DataValueField = "Product_ID";

        lstProductList.DataValueField = "Product_Name";

        lstProductList.DataBind();



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Product_ID"] = -1;

        Response.Redirect("StockDataEntry.aspx");
    }
}