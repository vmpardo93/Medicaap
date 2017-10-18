<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/verhorariot.aspx.cs" Inherits="verhorariot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 456px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="GV_horario" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="ODS_verhorario" GridLines="Horizontal" DataKeyNames="IdUsuario" Height="245px" Width="524px" OnRowUpdating="gv_updating">
                    <Columns>
                        <asp:TemplateField HeaderText="Dia">
                            <EditItemTemplate>
                                <asp:Label ID="L_dia" runat="server" Text='<%# Bind("Dia") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Dia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hora inicio">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDL_horainicio" runat="server" Height="18px" Width="90px">
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
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("HoraInicio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hora fin">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDL_horafin" runat="server" Height="16px" Width="89px">
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
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("HoraFin") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
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
                <asp:ObjectDataSource ID="ODS_verhorario" runat="server" SelectMethod="mostrarhorario" TypeName="Logica.Lhorario" UpdateMethod="editarhorario">
                    <SelectParameters>
                        <asp:SessionParameter Name="DoctorId" SessionField="id_user" Type="String" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="DoctorId" Type="String" />
                        <asp:Parameter Name="HoraInicio" Type="String" />
                        <asp:Parameter Name="HoraFin" Type="String" />
                        <asp:Parameter Name="Dia" Type="String" />
                        <asp:Parameter Name="IdUsuario" Type="String" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

