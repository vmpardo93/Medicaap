<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/buscacita.aspx.cs" Inherits="buscacita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 207px;
        }
        .auto-style3 {
            width: 207px;
            height: 235px;
        }
        .auto-style4 {
            height: 235px;
        }
        .auto-style7 {
            width: 207px;
            height: 74px;
        }
        .auto-style8 {
            height: 74px;
            width: 176px;
        }
        .auto-style10 {
            width: 297px;
            height: 235px;
        }
        .auto-style11 {
            width: 297px;
            height: 74px;
        }
        .auto-style13 {
            width: 297px;
            height: 36px;
        }
        .auto-style14 {
            width: 207px;
            height: 36px;
        }
        .auto-style15 {
            height: 36px;
            width: 176px;
        }
        .auto-style16 {
            width: 297px;
            height: 59px;
        }
        .auto-style17 {
            width: 207px;
            height: 59px;
        }
        .auto-style18 {
            height: 59px;
            width: 176px;
        }
        .auto-style19 {
            width: 297px;
            height: 39px;
        }
        .auto-style20 {
            width: 207px;
            height: 39px;
        }
        .auto-style21 {
            height: 39px;
            width: 176px;
        }
        .auto-style22 {
            width: 297px;
            height: 48px;
        }
        .auto-style23 {
            width: 207px;
            height: 48px;
        }
        .auto-style24 {
            height: 48px;
            width: 176px;
        }
        .auto-style26 {
            height: 36px;
            width: 118px;
        }
        .auto-style27 {
            height: 59px;
            width: 118px;
        }
        .auto-style28 {
            height: 74px;
            width: 118px;
        }
        .auto-style29 {
            height: 48px;
            width: 118px;
        }
        .auto-style30 {
            height: 39px;
            width: 118px;
        }
        .auto-style32 {
            width: 176px;
        }
        .auto-style33 {
            width: 118px;
        }
        .auto-style38 {
            width: 60px;
            height: 1px;
        }
        .auto-style51 {
            width: 297px;
        }
        .auto-style53 {
            height: 36px;
            width: 90px;
        }
        .auto-style54 {
            height: 59px;
            width: 90px;
        }
        .auto-style55 {
            height: 74px;
            width: 90px;
        }
        .auto-style56 {
            height: 48px;
            width: 90px;
        }
        .auto-style59 {
            height: 39px;
            width: 90px;
        }
        .auto-style90 {
            width: 297px;
            height: 71px;
        }
        .auto-style91 {
            width: 207px;
            height: 71px;
        }
        .auto-style92 {
            height: 71px;
            width: 118px;
        }
        .auto-style93 {
            height: 71px;
            width: 90px;
        }
        .auto-style94 {
            height: 71px;
            width: 176px;
        }
        .auto-style95 {
            width: 297px;
            height: 61px;
        }
        .auto-style96 {
            width: 207px;
            height: 61px;
        }
        .auto-style97 {
            height: 61px;
            width: 118px;
        }
        .auto-style98 {
            height: 61px;
            width: 90px;
        }
        .auto-style99 {
            height: 61px;
            width: 176px;
        }
        .auto-style100 {
            width: 297px;
            height: 76px;
        }
        .auto-style101 {
            width: 207px;
            height: 76px;
        }
        .auto-style102 {
            height: 76px;
            width: 118px;
        }
        .auto-style103 {
            height: 76px;
            width: 90px;
        }
        .auto-style104 {
            height: 76px;
            width: 176px;
        }
        .auto-style110 {
            width: 44px;
        }
        .auto-style111 {
            height: 36px;
            width: 44px;
        }
        .auto-style112 {
            height: 59px;
            width: 44px;
        }
        .auto-style113 {
            height: 74px;
            width: 44px;
        }
        .auto-style114 {
            height: 71px;
            width: 44px;
        }
        .auto-style115 {
            height: 48px;
            width: 44px;
        }
        .auto-style118 {
            height: 39px;
            width: 44px;
        }
        .auto-style119 {
            height: 61px;
            width: 44px;
        }
        .auto-style120 {
            height: 76px;
            width: 44px;
        }
        .auto-style122 {
            width: 90px;
        }
        .auto-style124 {
            height: 235px;
            width: 176px;
        }
        .auto-style125 {
            width: 297px;
            height: 1px;
        }
        .auto-style126 {
            width: 207px;
            height: 1px;
        }
        .auto-style127 {
            width: 118px;
            height: 1px;
        }
        .auto-style129 {
            width: 90px;
            height: 1px;
        }
        .auto-style130 {
            width: 176px;
            height: 1px;
        }
        .auto-style131 {
            height: 1px;
        }
        .auto-style132 {
            width: 297px;
            height: 50px;
        }
        .auto-style133 {
            width: 207px;
            height: 50px;
        }
        .auto-style134 {
            height: 50px;
            width: 118px;
        }
        .auto-style135 {
            height: 50px;
            width: 44px;
        }
        .auto-style136 {
            height: 50px;
            width: 90px;
        }
        .auto-style137 {
            height: 50px;
            width: 176px;
        }
        .auto-style138 {
            width: 297px;
            height: 69px;
        }
        .auto-style139 {
            width: 207px;
            height: 69px;
        }
        .auto-style140 {
            height: 69px;
            width: 118px;
        }
        .auto-style141 {
            height: 69px;
            width: 44px;
        }
        .auto-style142 {
            height: 69px;
            width: 90px;
        }
        .auto-style143 {
            height: 69px;
            width: 176px;
        }
        .auto-style144 {
            width: 297px;
            height: 72px;
        }
        .auto-style145 {
            width: 207px;
            height: 72px;
        }
        .auto-style146 {
            width: 118px;
            height: 72px;
        }
        .auto-style147 {
            width: 44px;
            height: 72px;
        }
        .auto-style148 {
            width: 90px;
            height: 72px;
        }
        .auto-style149 {
            width: 176px;
            height: 72px;
        }
        .auto-style150 {
            width: 44px;
            height: 1px;
        }
        .auto-style151 {
            width: 297px;
            height: 15px;
        }
        .auto-style152 {
            width: 207px;
            height: 15px;
        }
        .auto-style153 {
            height: 15px;
            width: 118px;
        }
        .auto-style154 {
            height: 15px;
            width: 44px;
        }
        .auto-style155 {
            height: 15px;
            width: 90px;
        }
        .auto-style156 {
            height: 15px;
            width: 176px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="L_Nombre" runat="server" BackColor="White"></asp:Label>
    <table class="auto-style1">
        <tr>
            <td class="auto-style125"></td>
            <td class="auto-style126"></td>
            <td class="auto-style127">
                <asp:ObjectDataSource ID="ODS_buscacita" runat="server" SelectMethod="mostrarcitasdoctor" TypeName="Logica.Lcitas">
                    <SelectParameters>
                        <asp:SessionParameter Name="doctor_id" SessionField="id_user" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td class="auto-style150"></td>
            <td class="auto-style129">&nbsp;</td>
            <td class="auto-style130"></td>
            <td class="auto-style38"></td>
            <td class="auto-style131"></td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style4" colspan="3">
                <asp:GridView ID="GV_citasdoc" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="ODS_buscacita" GridLines="Horizontal" OnSelectedIndexChanged="GV_citasdocSelectedIndexChanged" DataKeyNames="IdCita">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="HoraInicio" HeaderText="Hora Inicio" />
                        <asp:BoundField DataField="HoraFin" HeaderText="Hora fin" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre paciente" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido paciente" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
            <td class="auto-style124">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;&nbsp;</td>
            <td class="auto-style14">
                <asp:Label ID="L_paciente" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Lnombre" runat="server"></asp:Label>
                <asp:Label ID="Lapellido" runat="server">       </asp:Label>
            </td>
            <td class="auto-style111"></td>
            <td class="auto-style53"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17">
                <asp:Label ID="L_diagnostico" runat="server" Text="Diagnostico"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:TextBox ID="LB_diagnostico" runat="server" Height="52px" TextMode="MultiLine" Width="158px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="LB_diagnostico" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_UserName" runat="server" ControlToValidate="LB_diagnostico" Display="Dynamic" ErrorMessage="Caracteres no validos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$" ValidationGroup="1" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style112">&nbsp;</td>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style7">
                <asp:Label ID="L_alergias" runat="server" Text="Alergias"></asp:Label>
            </td>
            <td class="auto-style28">
                <asp:DropDownList ID="DDL_alergias" runat="server" DataSourceID="ODS_alergias" DataValueField="id_alergia" Height="34px" Width="157px" DataTextField="nombre_alergia">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ODS_alergias" runat="server" SelectMethod="mostraralergias" TypeName="Data.DAOalergias"></asp:ObjectDataSource>
            </td>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style55">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style90"></td>
            <td class="auto-style91">
                <asp:Label ID="L_desalergias" runat="server" Text="Descripcion alergia"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:TextBox ID="LB_descripalergia" runat="server" Height="57px" TextMode="MultiLine" Width="166px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" ControlToValidate="LB_descripalergia" ErrorMessage="Solo letras" ValidationExpression="^[a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style114">
                &nbsp;</td>
            <td class="auto-style93">&nbsp;</td>
            <td class="auto-style94">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22"></td>
            <td class="auto-style23">
                <asp:Label ID="L_cirugia" runat="server" Text="Cirugia"></asp:Label>
            </td>
            <td class="auto-style29">
                <asp:TextBox ID="TB_cirugia" runat="server" Height="22px" Width="196px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_cirugia" ErrorMessage="Solo letras" ValidationExpression="^[a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style115"></td>
            <td class="auto-style56">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style132"></td>
            <td class="auto-style133">
                <asp:Label ID="L_descirugia" runat="server" Text="Descripcion cirugia"></asp:Label>
            </td>
            <td class="auto-style134">
                <asp:TextBox ID="LB_descripcion_cirugia" runat="server" Height="62px" TextMode="MultiLine" Width="167px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="LB_descripcion_cirugia" ErrorMessage="Solo letras" ValidationExpression="^[a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style135"></td>
            <td class="auto-style136"></td>
            <td class="auto-style137"></td>
        </tr>
        <tr>
            <td class="auto-style138">&nbsp;</td>
            <td class="auto-style139">
                <asp:Label ID="L_fecirugia" runat="server" Text="Fecha cirugia"></asp:Label>
            </td>
            <td class="auto-style140">
                <asp:TextBox ID="TB_fecha_cirugia" runat="server" Height="23px" MaxLength="10" Width="141px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" ControlToValidate="TB_fecha_cirugia" ErrorMessage="Solo fecha en formato dd/MM/yyyy " ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style141">
                <asp:Label ID="L_hora" runat="server" Text="Hora"></asp:Label>
            </td>
            <td class="auto-style142">
                <asp:DropDownList ID="DDL_horacirugia" runat="server" Height="19px" Width="118px">
                    <asp:ListItem></asp:ListItem>
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
                </asp:DropDownList>
            </td>
            <td class="auto-style143">
            </td>
        </tr>
        <tr>
            <td class="auto-style19"></td>
            <td class="auto-style20">
                <asp:Label ID="L_medicinas" runat="server" Text="Medicinas"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:DropDownList ID="DDL_medicina" runat="server" DataSourceID="ODS_medicinas" DataValueField="id_medicina" Height="34px" Width="157px" DataTextField="nombre_medicina">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ODS_medicinas" runat="server" SelectMethod="mostrarmedicinas" TypeName="Data.DAOmedicinas"></asp:ObjectDataSource>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DDL_medicina" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style118">
                &nbsp;</td>
            <td class="auto-style59">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style95"></td>
            <td class="auto-style96">
                <asp:Label ID="L_dosis" runat="server" Text="Dosis"></asp:Label>
            </td>
            <td class="auto-style97">
                <asp:TextBox ID="TB_dosis" runat="server" Height="22px" MaxLength="2" Width="124px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_dosis" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:Label ID="Label1" runat="server" Text="   AL DIA"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_dosis" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style119">
                &nbsp;</td>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style99">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style100"></td>
            <td class="auto-style101">
                <asp:Label ID="L_fefinme" runat="server" Text="Fecha fin medicina"></asp:Label>
            </td>
            <td class="auto-style102">
                <asp:TextBox ID="TB_fechafin" runat="server" Height="28px" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_fechafin" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_medicina" runat="server" ControlToValidate="TB_fechafin" ErrorMessage="Solo fecha en formato dd/MM/yyyy " ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style120">
                &nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style104">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style151"></td>
            <td class="auto-style152">
                </td>
            <td class="auto-style153">
                </td>
            <td class="auto-style154">
                </td>
            <td class="auto-style155"></td>
            <td class="auto-style156"></td>
        </tr>
        <tr>
            <td class="auto-style51">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="B_cargar" runat="server" OnClick="B_cargar_Click" Text="Cargar" Height="31px" Width="74px" />
            </td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style110">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style144"></td>
            <td class="auto-style145">
            </td>
            <td class="auto-style146"></td>
            <td class="auto-style147"></td>
            <td class="auto-style148"></td>
            <td class="auto-style149"></td>
        </tr>
    </table>
</asp:Content>

