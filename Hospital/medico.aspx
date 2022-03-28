<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medico.aspx.cs" Inherits="Hospital.medico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario_Medico</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <h1>Formulario Medico</h1>
        </nav>
        <div class="container">
            <label for="idMedico" id="lblIdMedico">Documento del Medico</label><br />
            <asp:TextBox ID="txtIdMedico" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            <asp:Label ID="lblnombreMedico" runat="server" Text="">Nombre del Medico</asp:Label><br />
            <asp:TextBox ID="txtNombreMedico" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            <asp:Label ID="lblEspecialidad" runat="server" Text="">Especialidad</asp:Label><br />
            <asp:TextBox ID="txtEspecialidad" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            <asp:Label ID="lblTelMedico" runat="server" Text="">Telefono del Medico</asp:Label><br />
            <asp:TextBox ID="txtIdPaciente" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            <label for="activo" id="lblActivo">Activo</label><br>
            <input type="radio" id="rdSi">
            <label for="si" id="lblSi">Si</label>
            <input type="radio" id="inNo">
            <label for="no" id="lblNo">No</label><br>
            <input type="checkbox" id="cbCondiciones">
            <label for="Condiciones" id="lblCondiciones">He leido y acepto las politicas de privacidad</label><br>
            <div class="botones">
                <asp:Button ID="btnConsultar" CssClass="btn btn-primary" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                <asp:Button ID="btnenviar" CssClass="btn btn-primary" runat="server" Text="Enviar" OnClick="btnEnviar_Click" Enabled="False"/>
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Enabled="False" />
                <asp:Button ID="btnLimpiar" CssClass="btn btn-primary" runat="server" Text="Limpiar" Enabled="False" OnClick="btnLimpiar_Click" />
            </div>

        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
