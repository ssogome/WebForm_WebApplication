<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <br /><br /><br /><br />

        <div>           
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">                    
                </asp:DropDownList>                         
                <asp:Label ID="Label2" ForeColor="Red" runat="server" Text="Your selection"></asp:Label>
        </div>
    <br /><br />
        <div>           
            <asp:TextBox ID="TextBox1" runat="server">Enter Integer#1</asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server">Enter Integer#2</asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SubstractButton" />
            <asp:Label ID="Label1" ForeColor="Red"  runat="server" Text="SubstractResult"></asp:Label>
           
        </div>       

</asp:Content>
