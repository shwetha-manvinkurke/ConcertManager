<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Print_Ticket.aspx.cs" Inherits="Print_Ticket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Concert.jpg)">
    <form id="form1" runat="server" style="text-align: center; font-family: Copperplate Gothic; color: black; font-weight: bold">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Name" runat="server"></asp:Label><br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Band"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Band" runat="server" ></asp:Label><br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Hall Name:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="HallName" runat="server" ></asp:Label><br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Seat:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Seat" runat="server"></asp:Label><br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Date:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" TextMode="multiline" runat="server" Height="113px" Width="413px"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="en">English</asp:ListItem>
                <asp:ListItem Value="fr">French</asp:ListItem>
                <asp:ListItem Value="es">Spanish</asp:ListItem>
                <asp:ListItem Value="hi">Hindi</asp:ListItem>
                <asp:ListItem Value="ja">Japanese</asp:ListItem>
                <asp:ListItem Value="ur">Urdu</asp:ListItem>
                <asp:ListItem Value="it">Italian</asp:ListItem>
                <asp:ListItem Value="zh-CHS">Chinese</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Translate" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Email:"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Email" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Send Ticket to Mail" Width="148px" OnClick="Button2_Click" />
    </form>
</body>
</html>
