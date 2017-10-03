<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterPage.master" AutoEventWireup="true" CodeFile="~/logica/registro.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 177px;
        }
        .auto-style5 {
            width: 177px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
        .auto-style7 {
            width: 177px;
            height: 29px;
        }
        .auto-style8 {
            height: 29px;
        }
        .auto-style9 {
            width: 177px;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
        }
        .auto-style11 {
            width: 177px;
            height: 33px;
        }
        .auto-style12 {
            height: 33px;
        }
        .auto-style13 {
            width: 177px;
            height: 42px;
        }
        .auto-style14 {
            height: 42px;
        }
        .auto-style15 {
            width: 177px;
            height: 30px;
        }
        .auto-style16 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style5">Username</td>
            <td class="auto-style6">
                <asp:TextBox ID="TB_username" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_username" ErrorMessage="Solo letras" ValidationExpression="^[a-zA-Z ñÑáéíóúÁÉÍÓÚ]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">Clave</td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_clave" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">Confirmar clave</td>
            <td class="auto-style10">
                <asp:TextBox ID="TB_confclave" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_confclave" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TB_clave" ControlToValidate="TB_confclave" ErrorMessage="Las claves no coinciden" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">Nombre</td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_nombre" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TB_nombre" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style11">Apellido</td>
            <td class="auto-style12">
                <asp:TextBox ID="TB_apellido" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_apellido" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">Edad</td>
            <td class="auto-style14">
                <asp:TextBox ID="TB_edad" runat="server" MaxLength="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_edad" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">Tipo de sangre</td>
            <td class="auto-style8">
                <asp:DropDownList ID="DDL_tipo_sangre" runat="server" Height="19px" Width="63px">
                    <asp:ListItem Value="O+">O+</asp:ListItem>
                    <asp:ListItem Value="O-">O-</asp:ListItem>
                    <asp:ListItem Value="A+">A+</asp:ListItem>
                    <asp:ListItem Value="A-">A-</asp:ListItem>
                    <asp:ListItem Value="B+">B+</asp:ListItem>
                    <asp:ListItem Value="B-">B-</asp:ListItem>
                    <asp:ListItem Value="AB+">AB+</asp:ListItem>
                    <asp:ListItem Value="AB-">AB-</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="Correo"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_correo" runat="server" TextMode="Email" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" Display="Dynamic" ErrorMessage="Digite un correo electronico valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TB_correo" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="Label2" runat="server" Text="Documento"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_documento" runat="server" Width="124px" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="Solo nueros" ValidationExpression="^[0-9]+$" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style15">Foto</td>
            <td class="auto-style16">
                <asp:FileUpload ID="FU_foto" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style5">Fecha ultimo examen</td>
            <td class="auto-style6">
                <asp:TextBox ID="TB_examen" runat="server" TextMode="Date" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TB_examen" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="B_cargar" runat="server" OnClick="B_cargar_Click" Text="Registrar" />
            </td>
            <td>
            </td>
        </tr>
    </table>
    
    </asp:Content>

