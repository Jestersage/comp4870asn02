<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <br /> <br />
        <asp:HyperLink ID="hlAddUsers" runat="server" NavigateUrl="~/Admin/AddUser.aspx">Add Users</asp:HyperLink>
        <br /> <br />
        <asp:HyperLink ID="hlAddRoles" runat="server" NavigateUrl="~/Admin/AddRole.aspx">Add Roles</asp:HyperLink>
        <br /> <br />
        <asp:HyperLink ID="hlAddUsersToRoles" runat="server" NavigateUrl="~/Admin/AddUserToRole.aspx">Add Users To Roles</asp:HyperLink>
        <br /> <br />
    </div>
</asp:Content>

