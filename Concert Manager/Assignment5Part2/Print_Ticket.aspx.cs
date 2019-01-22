using System;
using MailReference;
using TranslationServiceReference;

public partial class Print_Ticket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["Role"].ToString().Equals("Member"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
        var seat = new Random();
        var seatNo = seat.Next(10000);
        Email.Text = Session["UserEmail"].ToString();

        Name.Text = Session["FirstName"] + " " + Session["LastName"];
        Band.Text = Session["BandChosen"].ToString();
        HallName.Text = Session["HallName"] == null ? "8" : Session["HallName"].ToString();
        Label10.Text = Session["DateOfEvent"].ToString();
        Seat.Text = seatNo.ToString();


        var r = new Random();
        Int32 ticketNo = r.Next(10000);
        TextBox1.Text = "Your Ticket Number is: " + ticketNo + ". Thank you for using our concert management system. You are attending " + Band.Text + "'s concert in Hall: " + HallName.Text + ". Your seat number is " + Seat.Text + ". Have a great day!";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var myClient = new Service1Client();
        TextBox1.Text = myClient.bingTranslate(TextBox1.Text, DropDownList1.SelectedValue);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        var myClient1 = new Service1Client();
        var myClient2 = new MailServiceClient();
        string content = myClient1.bingTranslate(TextBox1.Text, DropDownList1.SelectedValue);
        myClient2.MailConfirmationToCustomer(Email.Text, content);
        Session.Abandon();
        Response.Redirect("LogIn.aspx");
        Session.Abandon();
    }
}