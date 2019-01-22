using System;
using System.Configuration;
using System.Xml;

public partial class Admin_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["Role"].ToString().Equals("Admin"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
        Message.ForeColor = System.Drawing.Color.White;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var firstname = TextBox1.Text;
        var lastname = TextBox2.Text;
        var username = TextBox3.Text;
        var password = DLLClassLibrary.EncryptionClass.Encrypt(TextBox4.Text);

        if (firstname == "" || lastname == "" || username == "" || password == "")
        {
            Message.Text = "The values cannot be empty";
            return;
        }



        var role = DropDownList1.SelectedValue;
        var appSettings = ConfigurationManager.AppSettings;
        //var path = appSettings["XmlPath"];
        var path = Server.MapPath("./Users.xml");
        var doc = new XmlDocument();
        doc.Load(path);

        try
        {
            lock (doc)
            {
                var root = doc.DocumentElement;
                var newUser = doc.CreateElement("User");
                var newFirstName = doc.CreateElement("FirstName");
                newFirstName.InnerText = firstname;
                var newLastName = doc.CreateElement("LastName");
                newLastName.InnerText = lastname;
                var newUserName = doc.CreateElement("UserName");
                newUserName.InnerText = username;
                var newPassword = doc.CreateElement("Password");
                newPassword.InnerText = password;
                var newRole = doc.CreateElement("Role");
                newRole.InnerText = role;
                var newuserEmail = doc.CreateElement("Email");
                newuserEmail.InnerText = Email.Text;
                newUser.AppendChild(newFirstName);
                newUser.AppendChild(newLastName);
                newUser.AppendChild(newUserName);
                newUser.AppendChild(newPassword);
                newUser.AppendChild(newRole);
                newUser.AppendChild(newuserEmail);
                root.AppendChild(newUser);




                doc.Save(path);
                Message.Text = DropDownList1.SelectedValue + " created successfully!";

                
            }
        }
        catch (Exception)
        {
            Message.Text =  "Could not create Manager";
        }
        
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("LogIn.aspx");
    }
}