using System;
using System.Configuration;
using System.Web;
using System.Xml;


public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<marquee><h4>Number of user visits: " + Application["OnlineUsers"].ToString() + "</h4></marquee>");
        Message.Text = "";
        var myCookies = Request.Cookies["myCookies"];
    }

    protected void StoreCookie(object sender, EventArgs e)
    {
        if (Username.Text == "" || Useremail.Text == "" || Password.Text == "")
        {
            Message.Text = "Enter the right input";
            return;
        }

        Session["UserEmail"] = Useremail.Text;
        var myCookies = new HttpCookie("myCookies");
        myCookies["Username"] = Username.Text;
        myCookies["Useremail"] = Useremail.Text;
        myCookies.Expires = DateTime.Now.AddHours(1);
        Authenticate(Username.Text, Password.Text);
    }

    protected void Authenticate(string username, string password)
    {

        var appSettings = ConfigurationManager.AppSettings;

        var path = Server.MapPath("./Users.xml");

        var xml = new XmlDocument();
        xml.Load(path);
        var xnList = xml.SelectNodes("Users/User");
        foreach (XmlNode node in xnList)
        {
            var name = node["UserName"].InnerText;
            var pwd = DLLClassLibrary.DecryptionClass.Decrypt(node["Password"].InnerText);
            var role = node["Role"].InnerText;
            var fname = node["FirstName"].InnerText;
            var lname = node["LastName"].InnerText;
            var emailUser = node["Email"].InnerText;
            if (name == username && pwd == password)
            {
                Session["FirstName"] = fname;
                Session["LastName"] = lname;
                Session["UserEmail"] = emailUser;
                switch (role)
                {
                    case "Admin":
                        Session["Role"] = "Admin";
                        Server.Transfer("Admin_1.aspx");
                        break;

                    case "Manager":
                        Session["Role"] = "Manager";
                        Server.Transfer("LandingPage.aspx");
                        break;

                    case "Staff":
                        Session["Role"] = "Staff";
                        Server.Transfer("Staff.aspx");
                        break;

                    case "Member":
                        Session["Role"] = "Member";
                        Server.Transfer("Member.aspx");
                        break;
                }

            }
        }

        StoredUseremail.Text = "Could not authenticate ";
    }



}