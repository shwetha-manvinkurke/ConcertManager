using System;
using CardReference;
using MailReference;


public partial class BookTickets : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["Role"].ToString().Equals("Member"))
        {
            Session.Abandon();
            Response.Redirect("LogIn.aspx");
        }
        Message.Text = "Hello " + Session["FirstName"] + ". You are here to book tickets for " + Session["BandChosen"];
        var price = 225;
        TotalPrice.Text = price.ToString();
    }

    protected void Book(object sender, EventArgs e)
    {
        if (NameOnCard.Text == "" || ExpDate.Text == "" )
        {
            ValidatedMessage.Text = "Please enter the correct input. Name and ExpDate cannot be null.";
            return;
        }


        
        var cardClient = new Service1Client();
        var validated = cardClient.validateCreditCard(CardNumber.Text, cvv.Text);

        if (validated.Contains("False"))
        {
            ValidatedMessage.Text = "Sorry, the card could not be validated. Try again.";
            return;
        }

        Server.Transfer("Print_Ticket.aspx");
    }

    
}