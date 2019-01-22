using System;

public partial class LandingPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["Role"].ToString().Equals("Manager"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
    }

    protected void GoToManager(object sender, EventArgs e)
    {
        Server.Transfer("Manager_1.aspx");
    }

    protected void GoToStaff(object sender, EventArgs e)
    {
        Server.Transfer("Staff.aspx");
    }
}