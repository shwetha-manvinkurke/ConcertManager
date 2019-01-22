<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CalendarUserControl.ascx.cs" Inherits="CalendarUserControl" %>

&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="163px"></asp:TextBox>

&nbsp;&nbsp;

<asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/Calendar.png" OnClick="ImageButton1_Click" Width="32px" />

<br />
<br />

<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
    <OtherMonthDayStyle ForeColor="#CC9966" />
    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
    <SelectorStyle BackColor="#FFCC66" />
    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
</asp:Calendar>




