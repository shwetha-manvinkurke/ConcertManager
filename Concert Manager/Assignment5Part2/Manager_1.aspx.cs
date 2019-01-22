using System;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Manager_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["Role"].ToString().Equals("Manager"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
    }
    protected void CreateEvent(object sender, EventArgs e)
    {
        var appSettings = ConfigurationManager.AppSettings;
        var path = Server.MapPath("./Events.xml");
        //var path = appSettings["EventsPath"];
        var bandName = DropDownList1.SelectedValue;
        var hallName = DropDownList2.SelectedValue;
        var box = (TextBox)calendarControl1.FindControl("TextBox1");
        var date = box.Text;
        var doc = new XmlDocument();
        doc.Load(path);
        try
        {
            lock (doc)
            {
                var root = doc.DocumentElement;
                var newEvent = doc.CreateElement("Event");
                var newBandName = doc.CreateElement("BandName");
                newBandName.InnerText = bandName;
                var newHall = doc.CreateElement("HallName");
                newHall.InnerText = hallName;
                var newDate = doc.CreateElement("Date");
                newDate.InnerText = date;
                newEvent.AppendChild(newBandName);
                newEvent.AppendChild(newHall);
                newEvent.AppendChild(newDate);
                root.AppendChild(newEvent);
                doc.Save(path);
                Message.Text = "Event created successfully!";
                return;
                
            }
        }
        catch (Exception)
        {
            Message.Text = "Could not create event";
        }
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("LogIn.aspx");
    }
}