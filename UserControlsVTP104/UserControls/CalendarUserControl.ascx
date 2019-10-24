<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarUserControl.ascx.cs" Inherits="UserControlsVTP104.CalendarUserControl" %>
<%--Creating a UserControl to avoid repeating a long code to create the functionality user designed and avoid testing too--%>
<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <asp:ImageButton ID="imgBtn" src="/images/Calendar-Icon.png" runat="server" CssClass="auto-style1" Height="26px" OnClick="imgBtn_Click" /><br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>