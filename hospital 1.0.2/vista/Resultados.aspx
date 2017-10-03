<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Usuario.master" AutoEventWireup="true" CodeFile="~/logica/Resultados.aspx.cs" Inherits="vista_Resultados" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div><h2 class="text-center">
        <asp:Button ID="B_citas" runat="server" CssClass="btn-primary" Text="Citas" OnClick="B_citas_Click" />
        <asp:Button ID="B_medicamentos" runat="server" CssClass="btn-primary" Text="medica" OnClick="B_medicamentos_Click" />
        <asp:Button ID="B_alergias" runat="server" CssClass="btn-primary" Text="Alergias" OnClick="B_alergias_Click" />
        <asp:Button ID="B_cirugias" runat="server" CssClass="btn-primary" Text="Cirugias" OnClick="B_cirugias_Click" />
        </h2>
        <p>
            &nbsp;</p></div>
</asp:Content>

