using System;
using System.Collections.Generic;
using System.Linq;
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
        Product.Product_Name = txtProduct_Name.Text;

        //Capture the Prod_Description.
        Product.Prod_Description = txtProd_Description.Text;

        //Capture the Prod_Price.
        Product.Prod_Price = (int)(float)Convert.ToDouble(txtProd_Price.Text);

        //Capture the Prod_Quantity.
        Product.Prod_Quantity = Convert.ToInt32(txtProd_Quantity.Text);

        //Capture the Date_Added.
        Product.Date_Added = Convert.ToDateTime(DateTime.Now);

        //Capture the Supplier_ID.
        Product.Supplier_ID = Convert.ToInt32(txtSupplier_ID.Text);


        Session["Product"] = Product;
        
        //Nevigate to the view page
        Response.Redirect("StockViewer.aspx");
    }
}
