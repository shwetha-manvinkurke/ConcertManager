<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Member.aspx.cs" Inherits="Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Concert.jpg)">
    <form id="form1" runat="server" style="text-align: center; font-family: Copperplate Gothic; color: black; font-weight: bold">
        <div>
            <div style="font-size: 40px">
                Welcome
                <asp:Label runat="server" ID="MemberName"></asp:Label>
            </div>
            <br />
            <br />
            <div>
                Choose a Band:
          <asp:DropDownList runat="server" ID="ListofBands">
              <asp:ListItem>Linkin Park</asp:ListItem>
              <asp:ListItem>One Republic</asp:ListItem>
              <asp:ListItem>Taylor Swift</asp:ListItem>
              <asp:ListItem>Fray</asp:ListItem>
              <asp:ListItem>Adele</asp:ListItem>
              <asp:ListItem>Katy Perry</asp:ListItem>
              <asp:ListItem>Aerosmith</asp:ListItem>
              <asp:ListItem>One Direction</asp:ListItem>
              <asp:ListItem>Eminem</asp:ListItem>
          </asp:DropDownList>
                <asp:Button runat="server" Text="OK" OnClick="ListofBands_SelectedIndexChanged" />
                <p>
                    Date of the Event:
                    <asp:Label runat="server" ID="DateOfEvent" Text="12/18/2014"></asp:Label><br />
                    <br />
                    Hall Number: <asp:Label runat="server" ID="Hall" Text="8"></asp:Label>
                </p>
                <div>
                    <asp:TextBox Visible="False" runat="server" ID="ArtistDetails" TextMode="MultiLine" Height="200px" Width="800px"></asp:TextBox>
                </div>
            </div>
            &nbsp;<div>
                <asp:Label ID="ticketPrice" runat="server" Text="The price of each ticket is 225 dollars."></asp:Label>
                <br />
                <br />
                <asp:Button runat="server" Text="Book" OnClick="GoToBookPage" /><br />
                <br />
            </div>

            <asp:Label runat="server" ID="Message"></asp:Label><br />
            <br />
            <asp:Label ID="pincode" runat="server" Text="Enter the zipcode of your source:"></asp:Label>
            :
            <asp:TextBox runat="server" ID="YourZipCode"></asp:TextBox><br />
            <br />
            <asp:Button runat="server" Text="GetDirections" OnClick="GetDirections" /><br />
            <br />
            <asp:TextBox runat="server" Visible="False" ID="Directions" TextMode="MultiLine" Height="200px" Width="400px"></asp:TextBox><br />
            <br />
        </div>
    </form>
</body>
</html>
