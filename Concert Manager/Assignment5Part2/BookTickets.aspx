<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookTickets.aspx.cs" Inherits="BookTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background-image: url(Concert.jpg)">
    <form id="form1" runat="server" style="text-align: center; font-family: Copperplate Gothic; color: black; font-weight: bold">
    <div>
        <br />
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="Message"></asp:Label>
        <br/><br/>
        The total price is: <asp:Label runat="server" ID="TotalPrice"></asp:Label>
        <br />
        <br />
        Enter the card details here:
        <br/><br/>
        Card Number: <asp:TextBox runat="server" ID="CardNumber"></asp:TextBox><br/><br/>
        Name on Card: <asp:TextBox runat="server" ID="NameOnCard"></asp:TextBox><br/><br/>
        Expiration Date: <asp:TextBox runat="server" ID="ExpDate"></asp:TextBox><br/><br/>
        CVV: <asp:TextBox runat="server" ID="cvv"></asp:TextBox><br/><br/>
        <asp:Label runat="server" ID="ValidatedMessage"></asp:Label><br/><br/>
        <asp:Button runat="server" Text="Book" OnClick="Book"/><br/><br/>
        
    </div>
    </form>
</body>
</html>
