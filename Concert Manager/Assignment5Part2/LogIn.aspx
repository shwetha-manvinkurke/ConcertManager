<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Concert.jpg)">
   
    <form id="form1" runat="server" style="text-align: center; font-family: Copperplate Gothic; color: black; font-weight: bold">
        <div style="font-size: 40px">
            <b>Welcome to Concert Manager!</b><br/>
            <br />
            <br />
            <br />
            <br/>
        </div>
        
    <div style="text-align: center" >
        Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Username" runat="server" ></asp:TextBox><br/>
        <br />
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Useremail" runat="server" Visible="false" Text ="gaurav91pandey@gmail.com"></asp:TextBox><br/>
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Password" TextMode="Password"/><br/><br/>
        
        <%--<div>
            
            Enter what you see here: <asp:TextBox runat="server" ID="CaptchaText"></asp:TextBox>
        </div>
        --%>

        <asp:Button runat="server" Text="Submit" OnClick="StoreCookie"/><br/><br/>
    </div>
        
    <div>
        New User? <a href = "Register.aspx">Register here</a>
    </div>
     
        <div style="text-align: center">
            <asp:Label ID="StoredUsername" runat="server"></asp:Label><br/><br/>
            <asp:Label ID="StoredUseremail" runat="server"></asp:Label><br/><br/>
        </div>
    
        <div>
            <asp:Label runat="server" ID="Message"></asp:Label>
        </div>
    </form>
</body>
</html>
