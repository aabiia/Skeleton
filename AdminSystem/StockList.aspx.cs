using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Product_ID"] = -1;

        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Product_ID;
        if(lstProductList.SelectedIndex != -1)
        {
            Product_ID = Convert.ToInt32(lstProductList.SelectedValue);
            Session["Produtc-ID"] = Product_ID;
            Response.Redirect("StokDcataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit :";
        }


    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 Produtct_ID;
        if (lstProductList.SelectedIndex != -1)
        {
            Produtct_ID = Convert.ToInt32(lstProductList.SelectedValue);
            Session["Produtc-ID"] = Produtct_ID;
            Response.Redirect("StockonCfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select any record from the list  :";
        }


    }
}