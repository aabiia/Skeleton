using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
        clsOrderUser AnUser = new clsOrderUser();
        AnUser = (clsOrderUser)Session["AnUser"];
        Response.Write("Logged in by : " + AnUser.Username);
    }

    void DisplayOrders()
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "Address";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select for Editing the record.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Select anythig to Delete any Record.";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByAddress(txtAddress.Text);
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "Address";
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByAddress("");
        txtAddress.Text = "";
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "Address";
        lstOrderList.DataBind();
    }
}