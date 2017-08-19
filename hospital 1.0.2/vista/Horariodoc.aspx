<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/Horariodoc.aspx.cs" Inherits="Horariodoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 277px;
        }
        .auto-style3 {
            width: 120px;
        }
        .auto-style4 {
            width: 121px;
        }
        .auto-style5 {
            width: 277px;
            height: 171px;
        }
        .auto-style6 {
            width: 120px;
            height: 171px;
        }
        .auto-style7 {
            width: 121px;
            height: 171px;
        }
        .auto-style8 {
            height: 171px;
        }
        .auto-style9 {
            width: 277px;
            height: 20px;
        }
        .auto-style10 {
            width: 120px;
            height: 20px;
        }
        .auto-style11 {
            width: 121px;
            height: 20px;
        }
        .auto-style12 {
            height: 20px;
        }
        .auto-style13 {
            width: 277px;
            height: 22px;
        }
        .auto-style14 {
            width: 120px;
            height: 22px;
            font-weight: 700;
        }
        .auto-style15 {
            width: 121px;
            height: 22px;
            font-weight: 700;
        }
        .auto-style16 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Inicio"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Fin"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style5">
                <asp:Calendar ID="C_inicio" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnDayRender="render_day" PrevMonthText="">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <asp:Calendar ID="C_fin" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style9">
            </td>
            <td class="auto-style10">
            </td>
            <td class="auto-style11">
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">
                <asp:CheckBox ID="CB_lunes" runat="server" Text="Lunes" />
            </td>
            <td class="auto-style10">
                <asp:DropDownList ID="DDL_horainiciolunes" runat="server" Height="18px" Width="90px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="DDL_horafinlunes" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style9">
                <asp:CheckBox ID="CB_martes" runat="server" Text="Martes" />
            </td>
            <td id="horainiciomartes" class="auto-style10">
                <asp:DropDownList ID="DDL_horainiciomartes" runat="server" Height="18px" Width="90px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="horafinmartes" class="auto-style11">
                <asp:DropDownList ID="DDL_horafinmartes" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">
                <asp:CheckBox ID="CB_miercoles" runat="server" Text="Miercoles" />
            </td>
            <td id="horainiciomiercoles" class="auto-style3">
                <asp:DropDownList ID="DDL_horainiciomiercoles" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="horafinmiercoles" class="auto-style4">
                <asp:DropDownList ID="DDL_horafinmiercoles" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">
                <asp:CheckBox ID="CB_jueves" runat="server" Text="Jueves" />
            </td>
            <td id="horainiciojueves" class="auto-style3">
                <asp:DropDownList ID="DDL_horainiciojueves" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="horafinjueves" class="auto-style4">
                <asp:DropDownList ID="DDL_horafinjueves" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">
                <asp:CheckBox ID="CB_viernes" runat="server" Text="Viernes" />
            </td>
            <td id="horainicioviernes" class="auto-style3">
                <asp:DropDownList ID="DDL_horainicioviernes" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="horafinviernes" class="auto-style4">
                <asp:DropDownList ID="DDL_horafinviernes" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style13">
                <asp:CheckBox ID="CB_sabado" runat="server" Text="Sabado" />
            </td>
            <td id="horainiciosabado" class="auto-style14">
                <asp:DropDownList ID="DDL_horainiciosabado" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="horafinsabado" class="auto-style15">
                <asp:DropDownList ID="DDL_horafinsabado" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">
                <asp:CheckBox ID="CB_domingo" runat="server" Text="Domingo" />
            </td>
            <td id="horainiciosabado" class="auto-style14">
                <asp:DropDownList ID="DDL_horainiciodomingo" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="horafinsabado" class="auto-style15">
                <asp:DropDownList ID="DDL_horafindomingo" runat="server" Height="16px" Width="89px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>24:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">
                <asp:Button ID="B_cargar" runat="server" OnClick="B_cargar_Click" Text="Cargar" />
            </td>
            <td id="horainiciosabado" class="auto-style14">
                &nbsp;</td>
            <td id="horafinsabado" class="auto-style15">
                &nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
    </table>

   

</asp:Content>

