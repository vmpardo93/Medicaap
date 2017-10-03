<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/editarhojavida.aspx.cs" Inherits="editarhojavida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenedor-botones">
     </div>
     <asp:GridView ID="GV_hojavida" runat="server" CellPadding="4" DataKeyNames="id_doctor" DataSourceID="ODS_dochojavida" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" ForeColor="#333333">
         <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:TemplateField HeaderText="Perfil profesional">
            <EditItemTemplate>
                <asp:TextBox ID="TB_perfil" runat="server" Text='<%# Bind("perfil_profesional") %>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_perfil" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_perfil" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("perfil_profesional") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bachiller">
            <EditItemTemplate>
                <asp:TextBox ID="TB_bachiller" runat="server" Text='<%# Bind("bachiller") %>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFR_bachiller" runat="server" ControlToValidate="TB_bachiller" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_bachiller" runat="server" ControlToValidate="TB_bachiller" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("bachiller") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Universidad">
            <EditItemTemplate>
                <asp:TextBox ID="TB_universidad" runat="server" Text='<%# Bind("universidad") %>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_universidad" runat="server" ControlToValidate="TB_universidad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_universidad" runat="server" ControlToValidate="TB_universidad" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("universidad") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Otros estudios">
            <EditItemTemplate>
                <asp:TextBox ID="TB_estudios" runat="server" Text='<%# Bind("otros_estudios") %>'></asp:TextBox>
                <asp:RegularExpressionValidator ID="REV_estudios" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RFV_otro" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("otros_estudios") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Fellows">
            <EditItemTemplate>
                <asp:TextBox ID="TB_fellows" runat="server" Text='<%# Bind("fellows") %>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_fellow" runat="server" ControlToValidate="TB_fellows" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_fellows" runat="server" ControlToValidate="TB_fellows" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("fellows") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Idiomas">
            <EditItemTemplate>
                <asp:TextBox ID="TB_idiomas" runat="server" Text='<%# Bind("idiomas") %>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_idiomas" runat="server" ControlToValidate="TB_idiomas" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_idiomas" runat="server" ControlToValidate="TB_idiomas" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Bind("idiomas") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Experiencia">
            <EditItemTemplate>
                <asp:TextBox ID="TB_experiencia" runat="server" Text='<%# Bind("experiencia") %>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_expe" runat="server" ControlToValidate="TB_experiencia" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_experiencia" runat="server" ControlToValidate="TB_experiencia" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*"></asp:RegularExpressionValidator>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server" Text='<%# Bind("experiencia") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
         <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
    <asp:ObjectDataSource ID="ODS_dochojavida" runat="server" SelectMethod="buscarhojavida" TypeName="Data.DAOhojavida" UpdateMethod="modificarhojavida">
        <SelectParameters>
            <asp:SessionParameter Name="encap" SessionField="id_user" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="perfil_profesional" Type="String" />
            <asp:Parameter Name="bachiller" Type="String" />
            <asp:Parameter Name="universidad" Type="String" />
            <asp:Parameter Name="otros_estudios" Type="String" />
            <asp:Parameter Name="fellows" Type="String" />
            <asp:Parameter Name="idiomas" Type="String" />
            <asp:Parameter Name="experiencia" Type="String" />
            <asp:Parameter Name="id_doctor" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

