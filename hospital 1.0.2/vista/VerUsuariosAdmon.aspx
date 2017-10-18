<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterAdminVic.master" AutoEventWireup="true" CodeFile="~/logica/VerUsuariosAdmon.aspx.cs" Inherits="vista_VerUsuariosAdmon" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GV_usuariosAdmon" runat="server" Width="878px" AutoGenerateColumns="False" DataKeyNames="IdUsuario" DataSourceID="ODSpacientesad" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="Clave" HeaderText="Contraseña" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="Edad" HeaderText="Edad" />
            <asp:BoundField DataField="TipoDeSangre" HeaderText="Tipo de sangre" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" />
            <asp:BoundField DataField="Documento" HeaderText="Documento" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
    <asp:ObjectDataSource ID="ODSpacientesad" runat="server" SelectMethod="allusuarios" TypeName="DataPersis.DAOpacientes"></asp:ObjectDataSource>
</asp:Content>

