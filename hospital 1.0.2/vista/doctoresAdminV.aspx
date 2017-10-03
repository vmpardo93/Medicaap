<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterAdminVic.master" AutoEventWireup="true" CodeFile="~/logica/doctoresAdminV.aspx.cs" Inherits="vista_doctoresAdminV" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .contenedor-botones {
            text-align: center;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            width: 173px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenedor-botones">
              
              <table class="auto-style9">
                  <tr>
                      <td>&nbsp;</td>
                      <td class="auto-style10">&nbsp;</td>
                      <td>
              
              <asp:GridView ID="GV_Doctores" runat="server" AutoGenerateColumns="False" DataKeyNames="id_usuario" DataSourceID="ObjectDataSource1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowUpdating="GridView1_RowUpdating1" AllowPaging="True" style="margin-right: 6px; margin-top: 1px">
                  <Columns>
                      <asp:TemplateField HeaderText="Username" SortExpression="username">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_username" runat="server" MaxLength="20" Text='<%# Bind("username") %>'></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ControlToValidate="TB_username"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label1" runat="server" Text='<%# Bind("username") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Clave" SortExpression="clave">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_clave" runat="server" Text='<%# Bind("clave") %>' MaxLength="15"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="*" ControlToValidate="TB_clave"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="Solo numeros y letras" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label2" runat="server" Text='<%# Bind("clave") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Nombre" SortExpression="nombre">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_nombre" runat="server" MaxLength="30" Text='<%# Bind("nombre") %>'></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label3" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Apellido" SortExpression="apellido">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_apellido" runat="server" MaxLength="30" Text='<%# Bind("apellido") %>'></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label4" runat="server" Text='<%# Bind("apellido") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Edad">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_edad" runat="server" Text='<%# Bind("edad") %>' MaxLength="2"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TB_edad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                              <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo personas entre 18-99" MaximumValue="92" MinimumValue="18" Display="Dynamic" Type="Integer"></asp:RangeValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label5" runat="server" Text='<%# Bind("edad") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Estudios">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_estudios" runat="server" MaxLength="30" Text='<%# Bind("estudios") %>'></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label6" runat="server" Text='<%# Bind("estudios") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Especialidad">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_especilidad" runat="server" MaxLength="30" Text='<%# Bind("especialidad") %>'></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_especilidad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_especilidad" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label7" runat="server" Text='<%# Bind("especialidad") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Documento">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_documento" runat="server" MaxLength="10" Text='<%# Bind("documento") %>'></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label8" runat="server" Text='<%# Bind("documento") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Estado">
                          <EditItemTemplate>
                              <asp:DropDownList ID="DL_Estado" runat="server" Height="23px" Width="105px">
                                  <asp:ListItem Value="1">Activo</asp:ListItem>
                                  <asp:ListItem Value="0">Inactivo</asp:ListItem>
                              </asp:DropDownList>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label9" runat="server" Text='<%# Bind("estado") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Correo">
                          <EditItemTemplate>
                              <asp:TextBox ID="TB_correo" runat="server" MaxLength="40" Text='<%# Bind("correo") %>' TextMode="Email"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="Digite un correo electronico valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Label ID="Label10" runat="server" Text='<%# Bind("correo") %>'></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Foto">
                          <EditItemTemplate>
                              <asp:Label ID="Label11" runat="server" Text='<%# Eval("imagen") %>' Visible="False"></asp:Label>
                              <asp:FileUpload ID="Imagen" runat="server" />
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ErrorMessage="Por favor seleccione una imagen" ForeColor="Red" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$" ControlToValidate="Imagen"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imagen") %>' Height="61px" Width="61px" />
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
                      </td>
                      <td>&nbsp;</td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                      <td class="auto-style10">&nbsp;</td>
                      <td>
              <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="obtenerDoctores" TypeName="Data.DAOdoctores" UpdateMethod="modificardoctor">
                  <UpdateParameters>
                      <asp:Parameter Name="username" Type="String" />
                      <asp:Parameter Name="clave" Type="String" />
                      <asp:Parameter Name="nombre" Type="String" />
                      <asp:Parameter Name="apellido" Type="String" />
                      <asp:Parameter Name="edad" Type="String" />
                      <asp:Parameter Name="estudios" Type="String" />
                      <asp:Parameter Name="especialidad" Type="String" />
                      <asp:Parameter Name="imagen" Type="String" />
                      <asp:Parameter Name="id_usuario" Type="Int32" />
                      <asp:Parameter Name="estado" Type="String" />
                      <asp:Parameter Name="documento" Type="String" />
                      <asp:Parameter Name="correo" Type="String" />
                  </UpdateParameters>
              </asp:ObjectDataSource>
                      </td>
                      <td>&nbsp;</td>
                  </tr>
              </table>
        </div>
</asp:Content>

