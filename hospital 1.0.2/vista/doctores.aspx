<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterPage.master" AutoEventWireup="true" CodeFile="~/logica/doctores.aspx.cs" Inherits="doctores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <asp:DataList ID="DL_Doctores" runat="server" DataSourceID="ObjectDataSource1" OnItemCommand="DL_Doctores_ItemCommand" RepeatColumns="4" >
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("id_usuario") %>' Height="214px" ImageUrl='<%# Eval("imagen") %>' Width="222px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;<asp:Label ID="Label2" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
            &nbsp;<asp:Label ID="Label3" runat="server" Text='<%# Eval("apellido") %>'></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Especialidad:"></asp:Label>
            &nbsp;<asp:Label ID="Label5" runat="server" Text='<%# Eval("especialidad") %>'></asp:Label>
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="mostrarDoctoresPrincipal" TypeName="Data.DAOdoctores" ></asp:ObjectDataSource>
   
</asp:Content>

