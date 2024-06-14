using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        string Gender = txtGender.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string StaffId = txtStaffId.Text;
        string IsActive = chkIsActive.Text;
        string Address = txtAddress.Text;
        string Email = txtEmail.Text;
        string Position = txtPosition.Text;
        string DateHired = txtDateHired.Text;
        string Error = "";
        Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
        if (Error == "")
        {   
            AnStaff.FirstName = FirstName;
            AnStaff.LastName = LastName;
            AnStaff.Gender = Gender;
            AnStaff.Position = Position;
            AnStaff.DateHired = Convert.ToDateTime(DateHired);
            AnStaff.Address = Address;
            AnStaff.Email = Email;
            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        lblError.Text = "";
        clsStaff AnStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AnStaff.Find(StaffId);

        if (Found == true)
        {
            // Populate the text fields with the product data
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtGender.Text = AnStaff.Gender;
            txtPosition.Text = AnStaff.Position;
            txtEmail.Text = AnStaff.Email;
            txtAddress.Text = AnStaff.Address;
            txtDateHired.Text = AnStaff.DateHired.ToString();
            chkIsActive.Checked = AnStaff.IsActive;
        }

        else
        {
            // Display an error message if the product is not found
            lblError.Text = "Error: Product with the specified ID does not exist  :";

        }
    }

    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }
}

       



