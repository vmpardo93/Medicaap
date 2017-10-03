<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterAdminVic.master" AutoEventWireup="true" CodeFile="~/logica/RegistroDocAdmon.aspx.cs" Inherits="vista_RegistroDocAdmon" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style21 {
            width: 100%;
        }
        .auto-style22 {
            width: 117px;
        }
        .auto-style23 {
            width: 117px;
            height: 31px;
        }
        .auto-style24 {
            height: 31px;
        }
        .auto-style25 {
            width: 117px;
            height: 28px;
        }
        .auto-style26 {
            height: 28px;
        }
        .auto-style27 {
            width: 117px;
            height: 33px;
        }
        .auto-style28 {
            height: 33px;
        }
        .auto-style29 {
            width: 117px;
            height: 35px;
        }
        .auto-style30 {
            height: 35px;
        }
        .auto-style31 {
            width: 117px;
            height: 36px;
        }
        .auto-style32 {
            height: 36px;
        }
        .auto-style33 {
            width: 117px;
            height: 41px;
        }
        .auto-style34 {
            height: 41px;
        }
        .auto-style35 {
            width: 117px;
            height: 40px;
        }
        .auto-style36 {
            height: 40px;
        }
    .auto-style37 {
        width: 352px;
        height: 31px;
    }
    .auto-style38 {
        width: 352px;
        height: 28px;
    }
    .auto-style39 {
        width: 352px;
    }
    .auto-style40 {
        width: 352px;
        height: 33px;
    }
    .auto-style41 {
        width: 352px;
        height: 35px;
    }
    .auto-style42 {
        width: 352px;
        height: 36px;
    }
    .auto-style43 {
        width: 352px;
        height: 41px;
    }
    .auto-style44 {
        width: 352px;
        height: 40px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style21">
        <tr>
            <td class="auto-style37">
                &nbsp;</td>
            <td class="auto-style23">
                <asp:Label ID="Label6" runat="server" Text="Username"></asp:Label>
            </td>
            <td class="auto-style24">
                <asp:TextBox ID="TB_username" runat="server" MaxLength="20" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style38">
                &nbsp;</td>
            <td class="auto-style25">
                <asp:Label ID="Label8" runat="server" Text="Clave"></asp:Label>
            </td>
            <td class="auto-style26">
                <asp:TextBox ID="TB_clave" runat="server" TextMode="Password" MaxLength="20" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style39">
                &nbsp;</td>
            <td class="auto-style22">
                <asp:Label ID="Label9" runat="server" Text="Confirmar Clave"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_conclave" runat="server" TextMode="Password" MaxLength="20" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_clave" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TB_clave" ControlToValidate="TB_conclave" ErrorMessage="Las contraseñas no coinciden"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style40">
                &nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td class="auto-style28">
                <asp:TextBox ID="TB_nombre" runat="server" MaxLength="20" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_UserName" runat="server" ControlToValidate="TB_nombre" Display="Dynamic" ErrorMessage="Caracteres no validos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style41">
                &nbsp;</td>
            <td class="auto-style29">
                <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_apellido" runat="server" MaxLength="20" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_UserName0" runat="server" ControlToValidate="TB_apellido" Display="Dynamic" ErrorMessage="Caracteres no validos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style42">
                &nbsp;</td>
            <td class="auto-style31">
                <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
            </td>
            <td class="auto-style32">
                <asp:TextBox ID="TB_edad" runat="server" MaxLength="2" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_edad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TB_edad" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style42">
                &nbsp;</td>
            <td class="auto-style31">
                <asp:Label ID="Label4" runat="server" Text="Estudios"></asp:Label>
            </td>
            <td class="auto-style32">
                <asp:TextBox ID="TB_estudios" runat="server" MaxLength="30" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TB_estudios" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TB_estudios" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style33">
                <asp:Label ID="Label5" runat="server" Text="Especialidad"></asp:Label>
            </td>
            <td class="auto-style34">
                <asp:TextBox ID="TB_especialidad" runat="server" MaxLength="30" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TB_especialidad" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="TB_especialidad" ErrorMessage="Solo letras" ValidationExpression="[A-Za-z  ñÑáéíóúÁÉÍÓÚ]*" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style39">
                </td>
            <td class="auto-style22">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style33">
                <asp:Label ID="Label11" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style34">
                <asp:TextBox ID="TB_correo" runat="server" AutoCompleteType="Email" Rows="20" ValidationGroup="2" MaxLength="40"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="TB_correo" Display="Dynamic" ErrorMessage="Digite un correo electronico valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style33">
                <asp:Label ID="Label12" runat="server" Text="Documento"></asp:Label>
            </td>
            <td class="auto-style34">
                <asp:TextBox ID="TB_documento" runat="server" MaxLength="10" ValidationGroup="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TB_documento" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="TB_documento" ErrorMessage="Solo numeros" ValidationExpression="^[0-9]+$" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style44">
                &nbsp;</td>
            <td class="auto-style35">
                <asp:Label ID="Label7" runat="server" Text="Foto"></asp:Label>
            </td>
            <td class="auto-style36">
                <asp:FileUpload ID="FU_foto" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="FU_foto" Display="Dynamic" ErrorMessage="Imagen Requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RV_Imagen" runat="server" Display="Dynamic" ErrorMessage="Por favor suba una imagen de formato valido" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$" ControlToValidate="FU_foto"></asp:RegularExpressionValidator>
            </td>
        </tr>
         <tr>
            <td class="auto-style39">
                &nbsp;</td>
            <td>
                <asp:Button ID="BRegistrar" runat="server" Text="Registrar" OnClick="B_enviar_Click" ValidationGroup="2" />
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

