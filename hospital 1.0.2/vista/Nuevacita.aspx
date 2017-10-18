<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" AutoEventWireup="true" CodeFile="~/logica/Nuevacita.aspx.cs" Inherits="vista_Nuevacita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            height: 407px;
    }
        .auto-style10 {
            height: 82px;
            text-align: center;
        }
        .auto-style12 {
            height: 107px;
            text-align: center;
        }
        .auto-style20 {
            background-color: #5bc0de;
            width: 58%;
            text-align: center;
        }
    .auto-style23 {
        height: 143px;
        text-align: center;
    }
    .auto-style24 {
        height: 20px;
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h2 class="jumbotron">Nueva cita</h2>
    </div>
    
    <table class="auto-style9">

        <tr>
            <td class="auto-style20" id="L_tipocita"><strong>Buscar fecha</strong></td>
            <td class="auto-style10">
                <asp:Panel ID="Panel1" runat="server">
                    <asp:Calendar ID="C_Ncita" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                        <DayStyle BackColor="#CCCCCC" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td id="L_Fechacita" class="auto-style20"><strong>Citas&nbsp;
                </strong>
                <br />
            </td>
            <td class="auto-style12">
                <asp:GridView ID="GV_CitasDisponibles" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdCita" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GV_CitasDisponibles_SelectedIndexChanged" AllowPaging="True" PageSize="5" OnPageIndexChanging="GV_CitasDisponibles_PageIndexChanging">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Tipo" HeaderText="tipo cita" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre doc" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido doc" />
                        <asp:BoundField DataField="HoraInicio" HeaderText="Fecha de inicio" />
                        <asp:BoundField DataField="HoraFin" HeaderText="Fecha fin de cita" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerSettings PageButtonCount="5" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td id="L_Horacita" class="auto-style20" rowspan="2">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

