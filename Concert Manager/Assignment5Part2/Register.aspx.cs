using System;
using System.Configuration;
using System.IO;
using System.Xml;
using Recaptcha.Web;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Message.ForeColor = System.Drawing.Color.White;
    }

    async protected void RegisterNewUser(object sender, EventArgs e)
    {

        if (Password.Text != Reenter.Text)
        {
            Message.Text = "The passwords do not match. Re-enter the passwords.";
            Password.Text = "";
            Reenter.Text = "";
            return;
        }

        try
        {
            if (Useremail.Text == "" || Username.Text == "" || Password.Text == "" || Reenter.Text == "" || FirstName.Text == "" || LastName.Text == "")
            {
                Message.Text = "None of the values can be empty.";
                return;
            }


            var exists = CheckIfUserAlreadyExists(Useremail.Text);

            if (exists)
            {
                Message.Text = "You already have an account. Go back and login!";
                return;
            }

            if (String.IsNullOrEmpty(Recaptcha1.Response))
            {
                Message.Text = "Captcha cannot be empty.";
                return;
            }
            else
            {
                RecaptchaVerificationResult result = await Recaptcha1.VerifyTaskAsync();

                if (result == RecaptchaVerificationResult.Success)
                {
                    StoreData(Username.Text, Password.Text, "Member", FirstName.Text, LastName.Text, Useremail.Text);

                    Message.Text = "Registration complete.";
                    GoBack.Visible = true;
                    return;
                }
                else if (result == RecaptchaVerificationResult.IncorrectCaptchaSolution)
                {
                    Message.Text = "Incorrect captcha response.";
                }
                else
                {
                    Message.Text = "Some other problem with captcha.";
                }
            }

        }
        catch (Exception exception)
        {
            Message.Text = "Could not register. Try again." + exception;
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

    private bool CheckIfUserAlreadyExists(string useremail)
    {
        var exists = false;

        var path = Server.MapPath("./Users.xml");

        var xml = new XmlDocument();
        xml.Load(path);
        var xnList = xml.SelectNodes("Users/User");

        foreach (XmlNode node in xnList)
        {
            var email = node["Email"];

            if (email.InnerText == useremail)
            {
                exists = true;
            }
        }

        return exists;
    }

    protected void Redirect(object sender, EventArgs e)
    {
        Server.Transfer("LogIn.aspx");
    }
}