using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.FirstName);
        Response.Write(AnStaff.LastName);
        Response.Write(AnStaff.Position);
        Response.Write(AnStaff.Email);
        Response.Write(AnStaff.Gender);
        Response.Write(AnStaff.StaffId);
        Response.Write(AnStaff.Address);
        Response.Write(AnStaff.DateHired);

    }
}
   