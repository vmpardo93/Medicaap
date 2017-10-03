<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" AutoEventWireup="true" CodeFile="~/logica/verdoctores.aspx.cs" Inherits="vista_verdoctores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GV_doctores" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODS_vertodosdoctores" ForeColor="#333333" GridLines="None" Width="631px" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Nombre">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="edad" HeaderText="Edad" />
            <asp:BoundField DataField="especialidad" HeaderText="Especialidad" />
            <asp:ImageField DataImageUrlField="imagen" HeaderText="Foto">
                <ControlStyle Height="100px" Width="100px" />
                <FooterStyle Height="100px" Width="100px" />
                <HeaderStyle Height="100px" Width="100px" />
                <ItemStyle Height="100px" Width="100px" />
            </asp:ImageField>
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
    <asp:ObjectDataSource ID="ODS_vertodosdoctores" runat="server" SelectMethod="vertodosdoctores" TypeName="DAO_doctores"></asp:ObjectDataSource>
</asp:Content>

