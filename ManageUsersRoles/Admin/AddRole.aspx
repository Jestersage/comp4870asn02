<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddRole.aspx.cs" Inherits="Admin_AddRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <br />
        <br />
        <div style="float: left; padding-right: 50px;">
            <asp:GridView ID="gvRoles" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Role" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <asp:Label Text="Role: " ID="lblRole" runat="server" />
            <asp:TextBox ID="tbRole" runat="server" />
            <br />
            <br />
            <asp:Button Text="Add" ID="btnAdd" runat="server" OnClick="btnAdd_Click" />
            <br />
            <br />
            <asp:Label Text="" ID="lblMsg" runat="server" />
        </div>
    </div>
</asp:Content>

