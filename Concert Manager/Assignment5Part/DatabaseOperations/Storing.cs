using System;
using System.Xml;
using System.Configuration;


namespace DatabaseOperations
{
    public class Storing
    {
        public void StoreData(string username, string password, string role, string fname, string lname, string email)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var path = appSettings["XmlPath"];

            
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

    }
}
