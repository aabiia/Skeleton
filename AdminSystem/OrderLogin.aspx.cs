using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsOrderUser AnUser = new clsOrderUser();
        string Username = tstUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        Username = Convert.ToString(tstUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(Username, Password);
        Session["AnUser"] = AnUser;
        if (tstUsername.Text == "")
        {
            lblError.Text = "Username is Empty";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Password is Empty";
        }

        else if (Found == true)
        {
            Response.Redirect("OrderList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Username or Password is incorrect.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.apsx");
    }
}