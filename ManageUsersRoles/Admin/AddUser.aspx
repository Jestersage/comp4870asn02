<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Admin_AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <br />
    <br />
    <div>
        <div style="float: left; padding-right: 50px;">
            <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="User" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <asp:Label Text="User Name: " ID="lblUserName" runat="server" />
            <asp:TextBox ID="tbUserName" runat="server" />
            <br />
            <br />
            <asp:Label Text="Password: " ID="lblPassword" runat="server" />
            <asp:TextBox ID="tbPassword" runat="server" />
            <br />
            <br />
            <asp:Button Text="Add" ID="btnAdd" runat="server" OnClick="btnAdd_Click" />
            <br />
            <br />
            <asp:Label Text="" ID="lblMsg" runat="server" />
        </div>
    </div>
</asp:Content>

