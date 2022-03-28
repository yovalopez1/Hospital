<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="citas.aspx.cs" Inherits="Hospital.citas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario_Citas</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <h1>Formulario Cita</h1>
        </nav>
        <div class="container">
            <div>
                <label for="codigo" id="lblCodigo">Codigo de la Cita</label><br />
                <asp:TextBox ID="txtCodigo" CssClass="form-control-sm" runat="server"></asp:TextBox><br />
                <asp:Label ID="lblMensaje" runat="server" Text="Label" ></asp:Label><br />
            </div>
            <div>
                <label for="fecha" id="lblFecha">Fecha</label><br />
                <asp:TextBox ID="txtFecha" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            </div>
            <div>
                <label for="hora" id="lblHora">Hora de la Cita</label><br />
                <asp:TextBox ID="txtHora" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            </div>
            <div>
                <asp:Label ID="lblnombrePaciente" runat="server" Text=""></asp:Label><br />
                <Label for="idPaciente" id="lblIdPaciente">Documento del Paciente</Label><br />
                <asp:TextBox ID="txtIdPaciente" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
                <asp:Button ID="btnConsultarPaciente" CssClass="btn btn-primary" runat="server" Text="Consultar" OnClick="btnConsultarPaciente_Click"/>
            </div>
            <div>
                <asp:Label ID="lblnombreMedico" runat="server" Text=""></asp:Label><br />
                <label for="idMedico" id="lblIdMedico">Documento del Medico</label><br />
                <asp:TextBox ID="txtIdMedico" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
                <asp:Button ID="btnConsultarMedico" CssClass="btn btn-primary" runat="server" Text="Consultar" OnClick="btnConsultarMedico_Click"/>
            </div>
            <div>
                <label for="valorCita" id="lblValorCita">Valor del la Cita</label><br />
                <asp:TextBox ID="txtValorCita" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            </div>
            <div>
                <label for="Diacnostico" id="lblDiacnostico">Diacnostico del paciente</label><br />
                <asp:TextBox ID="txtDiacnostico" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            </div>
            <div>
                <label for="nombreAcompañante" id="lblNombreAcompañante">Nombre del Acompañante</label><br />
                <asp:TextBox ID="txtNombreAcompañante" CssClass="form-control-sm" runat="server" Enabled="False"></asp:TextBox><br />
            </div>
            <div>
                <label for="activo" id="lblActivo">Activo</label><br />
                <input type="radio" id="rdSi">
                <label for="si" id="lblSi">Si</label>
                <input type="radio" id="inNo">
                <label for="no" id="lblNo">No</label><br />
                <input type="checkbox" id="cbCondiciones">
                <label for="Condiciones" id="lblCondiciones">He leido y acepto las politicas de privacidad</label><br />
            </div>
            <div class="botones">
                <asp:Button ID="btnConsultar" CssClass="btn btn-primary" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                <asp:Button ID="btnenviar" CssClass="btn btn-primary" runat="server" Text="Enviar" OnClick="btnEnviar_Click" Enabled="False"/>
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Enabled="False" />
                <asp:Button ID="btnLimpiar" CssClass="btn btn-primary" runat="server" Text="Limpiar" Enabled="False" OnClick="btnLimpiar_Click" />
            </div>
            

        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
