using System;
using System.Configuration;
using System.IO;
using System.Xml;

public partial class Staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Role"].ToString().Equals("Admin") || Session["Role"].ToString().Equals("Member"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
    }

    protected void AddMember(object sender, EventArgs e)
    {
        var username = Username.Text;
        var password = Password.Text;
        var role = "Member";
        var fname = FirstName.Text;
        var lname = LastName.Text;
        var email = Useremail.Text;

        try
        {
            StoreData(username, password, role, fname, lname, email);
            Message.Text = "Member successfully added";
            return;
        }

        catch (Exception)
        {
            Message.Text = "Error storing";
        }
        
    }


    public void StoreData(string username, string password, string role, string fname, string lname, string email)
    {
        var appSettings = ConfigurationManager.AppSettings;
        //var path = appSettings["XmlPath"];

        var localPath = Path.Combine(Directory.GetCurrentDirectory(), "Users.xml");
        var path = Server.MapPath("./Users.xml");

        var doc = new XmlDocument();
        doc.Load(path);

        lock (doc)
        {
            var encryptedPassword = DLLClassLibrary.EncryptionClass.Encrypt(password);

            var root = doc.DocumentElement;

            var newUser = doc.CreateElement("User");
            var newUserName = doc.CreateElement("UserName");
            newUserName.InnerText = username;
            var newUserPassword = doc.CreateElement("Password");
            newUserPassword.InnerText = encryptedPassword;
            var newUserRole = doc.CreateElement("Role");
            newUserRole.InnerText = role;
            var newUserFName = doc.CreateElement("FirstName");
            newUserFName.InnerText = fname;
            var newUserLName = doc.CreateElement("LastName");
            newUserLName.InnerText = lname;
            var newUseremail = doc.CreateElement("Email");
            newUseremail.InnerText = email;
            newUser.AppendChild(newUserName);
            newUser.AppendChild(newUserPassword);
            newUser.AppendChild(newUserRole);
            newUser.AppendChild(newUserFName);
            newUser.AppendChild(newUserLName);
            newUser.AppendChild(newUseremail);
            root.AppendChild(newUser);
            doc.Save(path);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("LogIn.aspx");
    }
}