<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterDoctores.master" AutoEventWireup="true" CodeFile="~/logica/hojavida.aspx.cs" Inherits="hojavida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 352px;
    }
        .auto-style3 {
            width: 352px;
            height: 17px;
        }
        .auto-style4 {
            
            width: 0px;
        }
        .auto-style5 {
            width: 130px;
            height: 17px;
        }
        .auto-style7 {
            width: 0px;
        }
        .auto-style9 {
            height: 19px;
            width: 130px;
        }
        .auto-style10 {
            width: 0px;
            height: 33px;
        }
        .auto-style11 {
            width: 0px;
            height: 33px;
        }
        .auto-style12 {
            height: 33px;
            width: 130px;
        }
        .auto-style14 {
            height: 42px;
            width: 130px;
        }
        .auto-style15 {
            width: 0px;
            height: 42px;
        }
        .auto-style16 {
            width: 0px;
            height: 37px;
        }
        .auto-style17 {
            height: 37px;
            width: 130px;
        }
        .auto-style18 {
            width: 0px;
            height: 37px;
        }
        .auto-style19 {
            width: 352px;
            height: 45px;
        }
        .auto-style20 {
            height: 45px;
            width: 130px;
        }
        .auto-style21 {
            width: 0px;
            height: 45px;
        }
        .auto-style22 {
            width: 352px;
            height: 44px;
        }
        .auto-style23 {
            height: 44px;
            width: 130px;
        }
        .auto-style24 {
            width: 0px;
            height: 44px;
        }
        .auto-style25 {
            width: 352px;
            height: 42px;
        }
        .auto-style26 {
            width: 131px;
        }
        .auto-style27 {
            height: 33px;
            width: 131px;
        }
        .auto-style28 {
            height: 42px;
            width: 131px;
        }
        .auto-style29 {
            height: 37px;
            width: 131px;
        }
        .auto-style30 {
            height: 45px;
            width: 131px;
        }
        .auto-style31 {
            height: 44px;
            width: 131px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="Label1" runat="server" Text="Perfil profesional"></asp:Label>
        </td>
        <td class="auto-style26" >
            <asp:TextBox ID="TB_perfil" runat="server" TextMode="MultiLine" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_perfil" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_perfil" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11">
            </td>
        <td class="auto-style12" >
            <asp:Label ID="Label2" runat="server" Text="Bachillerato"></asp:Label>
        </td>
        <td class="auto-style27" >
            <asp:TextBox ID="TB_bachiller" runat="server" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_bachiller" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_bachiller" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style10">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style25">
            </td>
        <td class="auto-style14" >
            <asp:Label ID="Label3" runat="server" Text="Universidad"></asp:Label>
        </td>
        <td class="auto-style28" >
            <asp:TextBox ID="TB_universidad" runat="server" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_universidad" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_universidad" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style15">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style16">
            </td>
        <td class="auto-style17" >
            <asp:Label ID="Label4" runat="server" Text="Otros Estudios"></asp:Label>
        </td>
        <td class="auto-style29" >
            <asp:TextBox ID="TB_estudios" runat="server" TextMode="MultiLine" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style18">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style25">
            </td>
        <td class="auto-style14" >
            <asp:Label ID="Label6" runat="server" Text="Fellows"></asp:Label>
        </td>
        <td class="auto-style28">
            <asp:TextBox ID="TB_fellows" runat="server" TextMode="MultiLine" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_fellows" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TB_fellows" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style15">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style19">
            </td>
        <td class="auto-style20" >
            <asp:Label ID="Label7" runat="server" Text="Idiomas"></asp:Label>
        </td>
        <td class="auto-style30" >
            <asp:TextBox ID="TB_idiomas" runat="server" TextMode="MultiLine" MaxLength="30"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_idiomas" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_idiomas" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style21">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style22">
            </td>
        <td class="auto-style23" >
            <asp:Label ID="Label8" runat="server" Text="Experiencia"></asp:Label>
        </td>
        <td class="auto-style31" >
            <asp:TextBox ID="TB_experiencia" runat="server" TextMode="MultiLine" MaxLength="30"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TB_experiencia" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_experiencia" Display="Dynamic" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style24">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style9">
            <asp:Button ID="BT_enviar" runat="server" OnClick="BT_enviar_Click" Text="Enviar" />
        </td>
        <td class="auto-style26" >
            &nbsp;</td>
        <td class="auto-style7">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

