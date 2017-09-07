<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/modificadoc.aspx.cs" Inherits="modificadoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4"  GridLines="Horizontal" AutoGenerateColumns="False" DataKeyNames="id_usuario" DataSourceID="OBS_doctor" AllowPaging="True" OnRowUpdating="GridView1_RowUpdating1">
        <Columns>
            <asp:TemplateField HeaderText="Username">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_username" runat="server" MaxLength="20" Text='<%# Bind("username") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("username") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Clave">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_clave" runat="server" MaxLength="20" Text='<%# Bind("clave") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="Solo numeros y letras" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("clave") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_nombre" runat="server" MaxLength="20" Text='<%# Bind("nombre") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Apellido">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_apellido" runat="server" MaxLength="20" Text='<%# Bind("apellido") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("apellido") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edad">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_edad" runat="server" MaxLength="2" Text='<%# Bind("edad") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TB_edad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo personas entre 18-99" MaximumValue="99" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("edad") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Estudios">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_estucios" runat="server" MaxLength="30" Text='<%# Bind("estudios") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_estucios" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_estucios" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("estudios") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Especialidad">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_especialidad" runat="server" Text='<%# Bind("especialidad") %>' MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_especialidad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_especialidad" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
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
            <asp:TemplateField HeaderText="Correo">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_correo" runat="server" MaxLength="30" Text='<%# Bind("correo") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="Digite un correo electronico valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("correo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Foto">
                <EditItemTemplate>
                              <asp:Label ID="Label1" runat="server" Text='<%# Eval("imagen") %>' Visible="False"></asp:Label>
                              <asp:FileUpload ID="Imagen" runat="server" />
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ErrorMessage="Por favor seleccione una imagen" ForeColor="Red" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$" ControlToValidate="Imagen"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("imagen") %>' Height="83px" ImageUrl='<%# Eval("imagen") %>' Width="77px" />
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
    <asp:ObjectDataSource ID="OBS_doctor" runat="server" SelectMethod="obtenerdoc" TypeName="Data.DAOdoctores" UpdateMethod="modificardoctordoc">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="0" Name="id" SessionField="id_user" Type="String" />
        </SelectParameters>
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
            <asp:Parameter Name="id_user" Type="Int32" />
            <asp:Parameter Name="documento" Type="String" />
            <asp:Parameter Name="correo" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

