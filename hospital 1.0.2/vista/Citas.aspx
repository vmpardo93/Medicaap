<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="710px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
            <asp:BoundField DataField="hora_ini_cita" HeaderText="Hora de inicio" />
            <asp:BoundField DataField="hora_fin_cita" HeaderText="Hora de fin" />
            <asp:BoundField DataField="diagnostico" HeaderText="Diagnostico" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre doctor" />
            <asp:BoundField DataField="apellido" HeaderText="Apellido doctor" />
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
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="buscarcitasD" TypeName="Data.DAOcitas">
    <SelectParameters>
        <asp:Parameter Name="fecha" Type="DateTime" />
    </SelectParameters>
</asp:ObjectDataSource>
</asp:Content>