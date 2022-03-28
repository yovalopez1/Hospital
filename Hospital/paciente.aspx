<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paciente.aspx.cs" Inherits="Hospital.paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario_Paciente</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <h1>Formulario Paciente</h1>
        </nav>
        <div class="container">
            <label for="lblIdPaciente" id="lblIdMedico">Documento del Medico</label><br />
            <asp:TextBox ID="txtIdMedico" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            <label for="idPaciente" id="lblIdPaciente">Documento del Paciente</label><br>
            <input type="text" id="inIdPaciente"><br>
            <label for="tipoDocumento" id="lblTipoDocumento">Tipo de Documento</label><br>
            <input type="number" id="inTipoDocumento"><br>
            <label for="nombrePaciente" id="lblNombrePaciente">Nombre del Paciente</label><br>
            <input type="number" id="inNombrePaciente"><br>
            <label for="dirPaciente" id="lblDirPaciente">Direccion del Paciente</label><br>
            <input type="text" id="inDirPaciente"><br>
            <label for="telPaciente" id="lblTelPaciente">Telefono del Paciente</label><br>
            <input type="text" id="inTelPaciente"><br>
            <label for="celPaciente" id="lblCelPaciente">Celular del Paciente</label><br>
            <input type="text" id="inCelPaciente"><br>
            <label for="activo" id="lblActivo">Activo</label><br>
            <input type="radio" id="rdSi">
            <label for="si" id="lblSi">Si</label>
            <input type="radio" id="inNo">
            <label for="no" id="lblNo">No</label><br>
            <input type="checkbox" id="cbCondiciones">
            <label for="Condiciones" id="lblCondiciones">He leido y acepto las politicas de privacidad</label><br>
            <button type="button" class="btn btn-primary">Enviar</button>

        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
