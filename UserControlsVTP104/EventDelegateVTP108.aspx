<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventDelegateVTP108.aspx.cs" Inherits="UserControlsVTP104.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserControlDesign</title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Date of Birth<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <asp:ImageButton ID="imgBtn" src="/images/Calendar-Icon.png" runat="server" CssClass="auto-style1" Height="26px" OnClick="imgBtn_Click" /><br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Button ID="btnSelectDate" runat="server" Text="Button" OnClick="btnSelectDate_Click" />
        </div>
        <br />
        <div>
            <uc1:CalendarUserControl runat="server" ID="CalendarUserControl" OnDateSelected="CalendarUserControl_DateSelected" />
        </div>
    </form>
</body>
</html>
