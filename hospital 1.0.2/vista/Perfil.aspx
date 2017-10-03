<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" AutoEventWireup="true" CodeFile="~/logica/Perfil.aspx.cs" Inherits="vista_Perfil" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <asp:GridView ID="GV_Perfil" runat="server" DataSourceID="Perfil" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id_usuario" Width="642px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="NOMBRE">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("nombre") %>' MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_NombreG" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REV_NombreG" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Caracteres invalidos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="APELLIDO">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("apellido") %>' MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_ApellidoG" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REV_ApellidG" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Caracteres invalidos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("apellido") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CLAVE">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("clave") %>' MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_ClaveG" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REV_ClaveG" runat="server" ControlToValidate="TextBox2" ErrorMessage="Caracter invalido" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("clave") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EDAD">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("edad") %>' MaxLength="3"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_EdadG" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REV_EdadG" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Caracteres invalidos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$" ForeColor="Red"></asp:RegularExpressionValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="    solo numeros" ForeColor="Red" ControlToValidate="TextBox3" Display="Dynamic" ValidationExpression="^\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("edad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
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
        <asp:ObjectDataSource ID="Perfil" runat="server" SelectMethod="obtenerUsuarioId" TypeName="Logica.Lpacientes" UpdateMethod="modificarUsuario">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id_user" SessionField="id_user" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="id_user" Type="Int32" />
                <asp:Parameter Name="id_usuario" Type="Int32" />
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellido" Type="String" />
                <asp:Parameter Name="clave" Type="String" />
                <asp:Parameter Name="edad" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    
    </asp:Content>

