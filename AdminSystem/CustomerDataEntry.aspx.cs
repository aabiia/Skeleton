using System;
using System.Activities.Expressions;
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
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string Address = txtAddress.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string IsActive = chkActive.Text;
        string Error = "";
        Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
        if (Error == "")
        {
            AnCustomer.FirstName = FirstName;
            AnCustomer.LastName = LastName;
            AnCustomer.Email = Email;
            AnCustomer.Address = Address;

            
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnCustomer.IsActive = chkActive.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = AnCustomer;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblErrorMessage.Text = Error;
            lblErrorMessage.Visible = true;    
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        try
        {
            //attempt to convert text input into integer
            CustomerId = Convert.ToInt32(txtCustomerId.Text);
            //find the id provided
            Found = AnCustomer.Find(CustomerId);
            if (Found == true)

            {

                txtFirstName.Text = AnCustomer.FirstName;
                txtLastName.Text = AnCustomer.LastName;
                txtEmail.Text = AnCustomer.Email;
                txtAddress.Text = AnCustomer.Address;
                txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
                chkActive.Checked = AnCustomer.IsActive;
                lblErrorMessage.Visible = false; //hides error message

            }
            else
            {
                lblErrorMessage.Text = "Customer not found. Please check the Customer ID ";
                lblErrorMessage.Visible = true;

                //clear the text boxes when not found.
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtDateOfBirth.Text = string.Empty;
                chkActive.Checked = false;
            }

        }
        // if input is not valid integer show error message
        catch (FormatException)
        {
            lblErrorMessage.Text = "Invalid Customer ID. Please try again.";
            lblErrorMessage.Visible = true;

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            chkActive.Checked = false;

        }
    }
}
