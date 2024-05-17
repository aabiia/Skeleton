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
        //create a new instance of clscustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        AnCustomer.FirstName = txtFirstName.Text;
        AnCustomer.LastName = txtLastName.Text;
        AnCustomer.Email = txtEmail.Text;
        AnCustomer.Address = txtAddress.Text;
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnCustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        AnCustomer.Active = chkActive.Checked;

        //store the customer in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");


        
           
        }
    }
