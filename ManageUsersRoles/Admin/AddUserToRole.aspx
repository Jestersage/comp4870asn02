<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddUserToRole.aspx.cs" Inherits="Admin_AddUserToRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <br />
        <br />
        <div style="float: left; padding-right: 50px;">
            <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="User" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
        <div style="float: left; padding-left: 50px;">
            <asp:GridView ID="gvRoles" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Role" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
        <div style="clear: both; background-color: lightgray; width: 30%; padding-left: 20px;">
            <br />
            <br />
            <asp:Label Text="User: " ID="lblUserName" runat="server" />
            <asp:DropDownList ID="ddlUsers" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Label Text="Role: " ID="lblRole" runat="server" />
            <asp:DropDownList ID="ddlRoles" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Button Text="Add To Role" ID="btnAdd2Role" runat="server" OnClick="btnAdd2Role_Click" />
            <br />
            <br />
            <asp:Label Text="" ID="lblMsg" runat="server" />
        </div>
    </div>
</asp:Content>

