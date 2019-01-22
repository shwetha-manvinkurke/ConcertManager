<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manager_1.aspx.cs" Inherits="Manager_1" %>

<%@ Register TagPrefix="gp" TagName="Calendar"
    Src="CalendarUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Concert.jpg)">
    <form id="form1" runat="server">
        <div>
            <h1>Welcome Manager,</h1>
            <br />
            <br />
            Select the band:
        
        <asp:DropDownList ID="DropDownList1" runat="server">
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

            <br />
            <br />
            Select the Hall Number:
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
            <br />
            <br />
            Date of the Band Event:
            <gp:Calendar ID="calendarControl1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create Event" OnClick="CreateEvent" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Log Out" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label runat="server" ID="Message"></asp:Label>
        </div>
    </form>
</body>
</html>
