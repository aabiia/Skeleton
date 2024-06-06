using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {

        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }

        clsOrderUser AnUser = new clsOrderUser();
        AnUser = (clsOrderUser)Session["AnUser"];
        Response.Write("Logged in by : " + AnUser.Username);
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrder.Find(OrderID);

        if (Found == true)
        {
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
            txtAddress.Text = AnOrder.Address;
            txtDate.Text = AnOrder.Date.ToString();
            chkPaymentStatus.Checked = AnOrder.PaymentStatus;

        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string CustomerID = txtCustomerID.Text;
        string PaymentMethod = txtPaymentMethod.Text;
        string Address = txtAddress.Text;
        string Date = txtDate.Text;
        string PaymentStatus = Convert.ToString(chkPaymentStatus.Checked);

        string Error = "";
        Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.PaymentMethod = PaymentMethod;
            AnOrder.Address = Address;
            AnOrder.PaymentStatus = Convert.ToBoolean(PaymentStatus);
            AnOrder.Date = Convert.ToDateTime(Date);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();

            }
                Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


        
    }
    void DisplayOrder()
    {
        clsOrderCollection OrdersAll = new clsOrderCollection();
        OrdersAll.ThisOrder.Find(OrderID);

        txtOrderID.Text = OrdersAll.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrdersAll.ThisOrder.CustomerID.ToString();
        txtPaymentMethod.Text = OrdersAll.ThisOrder.PaymentMethod.ToString();
        txtAddress.Text = OrdersAll.ThisOrder.Address.ToString();
        txtDate.Text = OrdersAll.ThisOrder.Date.ToString();
        chkPaymentStatus.Checked = OrdersAll.ThisOrder.PaymentStatus;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}