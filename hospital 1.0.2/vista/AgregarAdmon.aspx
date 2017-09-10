<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterAdminVic.master" AutoEventWireup="true" CodeFile="~/logica/AgregarAdmon.aspx.cs" Inherits="vista_AgregarAdmon" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style21 {
            width: 100%;
        }
        .auto-style22 {
            width: 266px;
        }
        .auto-style23 {
        width: 266px;
        height: 42px;
        text-align: center;
        font-weight: bold;
    }
        .auto-style24 {
            height: 42px;
        }
        .auto-style25 {
            width: 266px;
            height: 44px;
            text-align: center;
        font-weight: bold;
    }
        .auto-style26 {
            height: 44px;
        }
        .auto-style27 {
            height: 42px;
            width: 340px;
        }
        .auto-style28 {
            width: 266px;
            height: 18px;
        }
        .auto-style29 {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style21">
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:Label ID="Label1" runat="server" Text="Medicina" style="text-align: center"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:TextBox ID="TB_medicina" runat="server" MaxLength="20" ValidationGroup="1" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_medicina" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TB_medicina" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" Display="Dynamic" ForeColor="Red" ValidationGroup="1"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style24">
                <asp:Button ID="B_cargarmedicina" runat="server" CssClass="btn btn-primary" OnClick="B_cargarmedicina_Click" Text="Cargar medicina" UseSubmitBehavior="False" ValidationGroup="1" Width="159px" />
            </td>
            <td class="auto-style24"></td>
        </tr>
        <tr>
            <td class="auto-style25">
                <asp:Label ID="Label22" runat="server" Text="Alergia" style="text-align: center"></asp:Label>
            </td>
            <td class="auto-style26">
                <asp:TextBox ID="TB_alergia" runat="server" MaxLength="20" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_alergia" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="2"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_alergia" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" Display="Dynamic" ForeColor="Red" ValidationGroup="2"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style26">
                <asp:Button ID="B_CargarAlergia" runat="server" CssClass="btn btn-primary" OnClick="B_CargarAlergia_Click" Text="Cargar Alergia" ValidationGroup="2" />
            </td>
            <td class="auto-style26"></td>
        </tr>
        <tr>
            <td class="auto-style23">
                &nbsp;</td>
            <td class="auto-style24">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODSmostrarmedicina" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="nombre_medicina" HeaderText="Medicinas" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODSmostrarmedicina" runat="server" SelectMethod="mostrarmedicinasAdmon" TypeName="Data.DAOmedicinas"></asp:ObjectDataSource>
            </td>
            <td class="auto-style24">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODSmostraralergias" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="nombre_alergia" HeaderText="Alergias" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODSmostraralergias" runat="server" SelectMethod="mostraralergiasAdmon" TypeName="Data.DAOalergias"></asp:ObjectDataSource>
            </td>
            <td class="auto-style24"></td>
        </tr>
        <tr>
            <td class="auto-style28">
                </td>
            <td>
                <asp:GridView ID="GV_parametriza" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODS_parametriza" ForeColor="#333333" GridLines="None" DataKeyNames="id_paremetrizacion" OnRowUpdating="updating">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Duracion citas">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDL_duracion" runat="server" Height="19px" Width="118px">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>00:20:00</asp:ListItem>
                                    <asp:ListItem>00:30:00</asp:ListItem>
                                    <asp:ListItem>00:40:00</asp:ListItem>
                                    <asp:ListItem>00:50:00</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DDL_duracion" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("duracion_citas") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hora Inicio Actividades">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDL_horainicio" runat="server" Height="19px" Width="118px">
                                    <asp:ListItem></asp:ListItem>
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
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DDL_horainicio" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("hora_inicio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hora Fin Actividades">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDL_horafin" runat="server" Height="19px" Width="118px">
                                    <asp:ListItem></asp:ListItem>
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
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DDL_horafin" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("hora_fin") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_parametriza" runat="server" SelectMethod="mostrarparametrizacion" TypeName="Data.DAOparametriza" UpdateMethod="editarparametrizacion">
                    <UpdateParameters>
                        <asp:Parameter Name="duracion_citas" Type="String" />
                        <asp:Parameter Name="hora_inicio" Type="String" />
                        <asp:Parameter Name="hora_fin" Type="String" />
                        <asp:Parameter Name="id_paremetrizacion" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td colspan="2" class="auto-style29">&nbsp;</td>
            <td class="auto-style29"></td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

