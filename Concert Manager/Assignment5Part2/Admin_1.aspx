<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_1.aspx.cs" Inherits="Admin_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Concert.jpg)">
    <form id="form1" runat="server" style="text-align: center; font-family: Copperplate Gothic; color: black; font-weight: bold">
        <div>
            <h1>Welcome Admin,</h1>
            <p>&nbsp;</p>
            <p>You can register managers and staff by filling out the form below :-</p>
            <br />
            <br />
            <br />
            <p>
                <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Username: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p>
                Email: 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="Email"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" TextMode="Password" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Select Role:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="126px">
                <asp:ListItem>Manager</asp:ListItem>
                <asp:ListItem>Staff</asp:ListItem>
            </asp:DropDownList>
            </p>
            <p>
                &nbsp;
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Register" Width="92px" OnClick="Button1_Click" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Log Out" OnClick="Button2_Click" />
            </p>

            <asp:Label runat="server" ID="Message"></asp:Label>

        </div>
    </form>
</body>
</html>
