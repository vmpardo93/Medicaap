<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" AutoEventWireup="true" CodeFile="~/logica/CancelarCitas.aspx.cs" Inherits="vista_CancelarCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style6 {
        width: 100%;
    }
    .auto-style7 {
        height: 68px;
    }
    .auto-style8 {
        height: 108px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7"></td>
        <td class="auto-style7">
            <asp:GridView ID="GV_CancelarCita" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_cita" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="hora_ini_cita" HeaderText="Hora de inicio" />
                    <asp:BoundField DataField="hora_fin_cita" HeaderText="Hora de fin" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                    <asp:CommandField SelectText="Cancelar" ShowSelectButton="True" />
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
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="mostrarCitasSeparadas" TypeName="Logica.Lpacientes">
                <SelectParameters>
                    <asp:SessionParameter DefaultValue="0" Name="id_user" SessionField="id_user" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
        <td class="auto-style7"></td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
    </tr>
</table>
</asp:Content>

