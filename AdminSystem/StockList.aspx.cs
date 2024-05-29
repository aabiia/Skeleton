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
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        clsProductCollection AllProducts = new clsProductCollection();
        lstProductList.DataSource = AllProducts.ProductList;
        lstProductList.DataValueField = "Product_ID";
        lstProductList.DataTextField = "Product_Name";
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

        if (lstProductList.SelectedIndex != -1)
        {
            Product_ID = Convert.ToInt32(lstProductList.SelectedValue);
            Session["Product_ID"] = Product_ID;
            Response.Redirect("StockDataEntry.aspx");


        }
        else
        {
            lblError.Text = "Please select a Record Form the list to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 Product_ID;

        if (lstProductList.SelectedIndex != -1)
        {
            Product_ID = Convert.ToInt32(lstProductList.SelectedValue);
            Session["Product_ID"] = Product_ID;

            Response.Redirect("StockConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a product from the List to Delete.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsProductCollection Product = new clsProductCollection();
        Product.ReportByProductName("txtProductName.Text");
        lstProductList.DataSource = Product.ProductList;
        lstProductList.DataValueField = "Product_ID";
        lstProductList.DataTextField = "Product_Name";
        lstProductList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsProductCollection Product = new clsProductCollection();
        Product.ReportByProductName("");
        txtProductName.Text = "";
        lstProductList.DataSource = Product.ProductList;
        lstProductList.DataValueField = "Product_ID";
        lstProductList.DataTextField = "Product_Name";
        lstProductList.DataBind();
    }
}