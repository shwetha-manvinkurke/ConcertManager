<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LandingPage.aspx.cs" Inherits="LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Concert.jpg)">
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" Text="Go to Manager Page" OnClick="GoToManager"/><br/><br/>
        <asp:Button runat="server" Text="Go to Staff Page" OnClick="GoToStaff"/><br/><br/>
    </div>
    </form>
</body>
</html>
