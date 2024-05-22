﻿using System;
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
        if (IsPostBack == false)
        {
            DisplayCustomer();
            
        }

    }
    void DisplayCustomer ()
    { 
    clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }
}