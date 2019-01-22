using System;
using ArtistServiceReference;
using CardReference;
using System.Xml;

public partial class Member : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Session["Role"].ToString().Equals("Member"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
        MemberName.Text = Session["FirstName"].ToString();
        ticketPrice.ForeColor = System.Drawing.Color.White;
        Message.ForeColor = System.Drawing.Color.White;
        pincode.ForeColor = System.Drawing.Color.White;
    }

    protected void GoToBookPage(object sender, EventArgs e)
    {
        Session["BandChosen"] = ListofBands.SelectedValue;
        Session["DateOfEvent"] = "12/18/2014";
        Server.Transfer("BookTickets.aspx");
    }

    protected void GetDirections(object sender, EventArgs e)
    {
        Directions.Visible = true;
        var directionClient = new Service1Client();
        Directions.Text = directionClient.getDirections(YourZipCode.Text, "85281");
    }
    protected void ListofBands_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArtistDetails.Visible = true;
        var artistService = new ArtistInfoServiceClient();
        ArtistDetails.Text = artistService.GetInfoAboutTheBand(ListofBands.SelectedValue);

        var path = Server.MapPath("./Events.xml");
        var band = ListofBands.SelectedValue;
        var xml = new XmlDocument();
        xml.Load(path);

        var xnList = xml.SelectNodes("Events/Event");

        foreach (XmlNode node in xnList)
        {
            var bandinXml = node["BandName"].InnerText;
            var hall = node["HallName"].InnerText;
            var date = node["Date"].InnerText;

            if (band == bandinXml)
            {
                Hall.Text = hall;
                DateOfEvent.Text = date;
                Session["HallName"] = hall;
                Session["DateOfEvent"] = date;
                return;
            }
        }
    }
}