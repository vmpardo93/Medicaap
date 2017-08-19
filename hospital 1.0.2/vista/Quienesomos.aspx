<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterPage.master" AutoEventWireup="true" CodeFile="~/logica/Quienesomos.aspx.cs" Inherits="vista_Quienesomos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../bootstrap/css/estilo.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="main container">
          <article class="post clearfix">
              <a href="#" class="thumb pull-left">
                <img class="img-thumbnail"src="../images/hospital.jpg" alt="alistamiento de pedidos"/>
                <h2 class="post-tittle">Quienes somos</h2>
                <p><span class="post-fecha">30 de enero del 2016</span> por <span class="post-autor">Victor Pardo</span></p>
                            <p class="post-contenido text-justify">
                                Somos un hospital  cuyo objetivo prinsipal es prestar un servicio eficiente 
                                y bueno para nuestros usuarios utilizando tambien las herramientas digitales 
                                a nuestro favor para agilizar ciertos procedimientos y asi hacer de este un 
                                mejor servicio.
                            </p>
                            
               </a>
            </article>
        <article class="post clearfix">
              <a href="#" class="thumb pull-left">
                <img class="img-thumbnail"src="../images/medicos.jpg" alt="alistamiento de pedidos"/>
                <h2 class="post-tittle">Historia</h2>
                <p><span class="post-fecha">25 de mayo del 2016</span> por <span class="post-autor">Victor Pardo</span></p>
                            <p class="post-contenido text-justify">
                                Somos un hospital que comenzo desde el 2017 como un proyecto de ing de software
                                al aplicarse la plataforma en la vida diaria surgio medicaap
                            </p>
                            
               </a>
            </article>
    </section>
</asp:Content>

