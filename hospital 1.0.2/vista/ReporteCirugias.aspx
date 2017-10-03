<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/logica/ReporteCirugias.aspx.cs" Inherits="vista_ReporteCirugias" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <CR:CrystalReportViewer ID="CRV_Cirugia" runat="server" AutoDataBind="true" />
    <div>
    
        <CR:CrystalReportSource ID="CRS_Cirugia" runat="server">
               <Report FileName="~\Reportes\Cirugias.rpt">
               </Report>
        </CR:CrystalReportSource>
    
    </div>
    </form>
</body>
</html>
