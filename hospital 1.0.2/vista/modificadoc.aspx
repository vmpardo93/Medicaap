<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/modificadoc.aspx.cs" Inherits="modificadoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4"  GridLines="Horizontal" AutoGenerateColumns="False" DataKeyNames="IdUsuario" DataSourceID="OBS_doctor" AllowPaging="True" OnRowUpdating="GridView1_RowUpdating1">
        <Columns>
            <asp:TemplateField HeaderText="Username">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_username" runat="server" MaxLength="20" Text='<%# Bind("Username") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Clave">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_clave" runat="server" MaxLength="20" Text='<%# Bind("Clave") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="Solo numeros y letras" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Clave") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_nombre" runat="server" MaxLength="20" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Apellido">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_apellido" runat="server" MaxLength="20" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edad">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_edad" runat="server" MaxLength="2" Text='<%# Bind("Edad") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TB_edad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo personas entre 18-99" MaximumValue="99" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Edad") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Estudios">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_estucios" runat="server" MaxLength="30" Text='<%# Bind("Estudios") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_estucios" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_estucios" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Estudios") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Especialidad">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_especialidad" runat="server" Text='<%# Bind("Especialidad") %>' MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_especialidad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_especialidad" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Especialidad") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Documento">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_documento" runat="server" MaxLength="10" Text='<%# Bind("Documento") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("Documento") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Correo">
                <EditItemTemplate>
                    <asp:TextBox ID="TB_correo" runat="server" MaxLength="30" Text='<%# Bind("Correo") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="Digite un correo electronico valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("Correo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Foto">
                <EditItemTemplate>
                              <asp:Label ID="Label1" runat="server" Text='<%# Eval("Imagen") %>' Visible="False"></asp:Label>
                              <asp:FileUpload ID="Imagen" runat="server" />
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ErrorMessage="Por favor seleccione una imagen" ForeColor="Red" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$" ControlToValidate="Imagen"></asp:RegularExpressionValidator>
                          </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("Imagen") %>' Height="83px" ImageUrl='<%# Eval("Imagen") %>' Width="77px" />
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
    <asp:ObjectDataSource ID="OBS_doctor" runat="server" SelectMethod="obtenerdoc" TypeName="Logica.LDoctor" UpdateMethod="modificardoctor">
        <SelectParameters>
            <asp:SessionParameter Name="id" SessionField="id_user" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Clave" Type="String" />
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Edad" Type="String" />
            <asp:Parameter Name="Estudios" Type="String" />
            <asp:Parameter Name="Especialidad" Type="String" />
            <asp:Parameter Name="Imagen" Type="String" />
            <asp:Parameter Name="IdUsuario" Type="Int32" />
            <asp:Parameter Name="Estado" Type="String" />
            <asp:Parameter Name="Documento" Type="String" />
            <asp:Parameter Name="Correo" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

