<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" CodeFile="~/logica/Citas.aspx.cs" Inherits="vista_Citas"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ODS_citasuser" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="710px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
            <asp:BoundField DataField="HoraInicio" HeaderText="Hora de inicio" />
            <asp:BoundField DataField="HoraFin" HeaderText="Hora de fin" />
            <asp:BoundField DataField="Diagnostico" HeaderText="Diagnostico" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre doctor" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido doctor" />
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
    <asp:ObjectDataSource ID="ODS_citasuser" runat="server" SelectMethod="buscarcitaid" TypeName="Logica.Lcitas">
        <SelectParameters>
            <asp:SessionParameter Name="id_user" SessionField="id_user" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="buscarcitaid" TypeName="Logica.Lpacientes">
    <SelectParameters>
        <asp:SessionParameter DefaultValue="0" Name="id_user" SessionField="id_user" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
</asp:Content>