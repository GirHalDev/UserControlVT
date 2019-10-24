<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingUserControlVTP105.aspx.cs" Inherits="UserControlsVTP104.WebForm2" %>

<%--<%@ Register Src="~/CalendarUserControl.ascx" TagPrefix="uc1" TagName="CalendarUserControl" %>--%>
<%--After drag and drop of UserControl for the calendar the above directive created--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Date of Birth:<uc1:CalendarUserControl runat="server" ID="CalendarUserControl" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
