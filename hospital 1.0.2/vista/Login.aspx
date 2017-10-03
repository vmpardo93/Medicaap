<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/logica/Login.aspx.cs" Inherits="vista_Login" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Login</title>
<meta name="plantilla" content="una plantilla para mis futuras paginas"/>
<meta name="viewport" content="widt=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../bootstrap/css/estilo.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 100%;
        }
        .auto-style2 {
            width: 60%;
        }
        .auto-style3 {
            width: 204px;
            height: 219px;
        }
        .auto-style4 {
            height: 219px;
        }
        .auto-style5 {
            width: 204px;
            height: 90px;
        }
        .auto-style6 {
            height: 60%;
        }
    </style>
</head>

<body >
<div class="loginVic">
    <form id="form1" runat="server">
    <div class="container">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:ImageButton ID="IB_HomeLogin" runat="server" ImageUrl="~\images\home.jpg" OnClick="IB_HomeLogin_Click" Width="103px" />
                </td>
                <td class="auto-style4">
                    </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <div class="nombre_login" ><h3 id="LB_UserName">Username</h3></div>
                    <asp:TextBox ID="TB_username" runat="server" MaxLength="15" ValidationGroup="1" placeholder="username" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_UserName" runat="server" ControlToValidate="TB_username" Display="Dynamic" ErrorMessage="Caracteres no validos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$" ValidationGroup="1"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <div class="nombre_login" ><h3 id="LB_Clave">Contraseña</h3></div>
                    <asp:TextBox ID="TB_Clave" runat="server" MaxLength="15" TextMode="Password" ValidationGroup="1" placeholder="password" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_Clave" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_Clave" runat="server" Display="Dynamic" ErrorMessage="Caracteres no validos" ValidationExpression="^[0-9a-zA-Z ñÑáéíóúÁÉÍÓÚ ]+$" ControlToValidate="TB_Clave" ValidationGroup="1"></asp:RegularExpressionValidator>
                </td>
            </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                        <td>
                            <div class="nombre_login"> 
                                <asp:Button ID="B_Entrar" runat="server" Text="Entrar" OnClick="B_Entrar_Click" ValidationGroup="1" class="btn btn-primary"  />
                                <asp:Button ID="B_Registro" runat="server" Text="Registrarse" OnClick="B_Registro_Click" ValidationGroup="2" class="btn btn-primary" />
                            </div>   
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </div>
  </body>

</html>
