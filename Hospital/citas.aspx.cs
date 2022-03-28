using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaReglasNegocio;
using CapaEntidad;
using CapaDatos;

namespace Hospital
{
    public partial class citas : System.Web.UI.Page
    {
        CEntidadCitas oEntidadCitas = new CEntidadCitas();
        CReglasNegociosCitas oReglasNegocioCitas = new CReglasNegociosCitas();

        CEntidadMedicos oMedicos = new CEntidadMedicos();
        CReglaNegociosMedico oReglaNegociosMedico = new CReglaNegociosMedico();

        CEntidadPacientes oPacientes = new CEntidadPacientes();
        CReglaNegociosPaciente oReglaNegociosPaciente = new CReglaNegociosPaciente();


        protected void limpar()
        {
            txtCodigo.Text = "";
            txtDiacnostico.Text = "";
            txtFecha.Text = "";
            txtHora.Text = "";
            txtIdMedico.Text = "";
            txtIdPaciente.Text = "";
            txtNombreAcompañante.Text = "";
            txtValorCita.Text = "";
        }

        protected void activar()
        {
            txtDiacnostico.Enabled = true;
            txtFecha.Enabled = true;
            txtHora.Enabled = true;
            txtIdMedico.Enabled = true;
            txtIdPaciente.Enabled = true;
            txtNombreAcompañante.Enabled = true;
            txtValorCita.Enabled = true;
            btnGuardar.Enabled = true;
            //lblActivo.Enabled = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                lblMensaje.Text = "No se ha dijitado codigo de la cita";
                txtCodigo.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oEntidadCitas.Cod_cita = txtCodigo.Text;
                ds = oReglasNegocioCitas.consultar_Cita(oEntidadCitas);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    lblMensaje.Text = "Cita disponible";
                    limpar();
                    txtFecha.Focus();
                    activar();

                }
                else
                {
                    txtFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                    txtHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                    txtIdPaciente.Text = ds.Tables[0].Rows[0]["Id_paciente"].ToString();
                    txtIdMedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                    txtValorCita.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                    txtDiacnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                    txtNombreAcompañante.Text = ds.Tables[0].Rows[0]["nom_acompanante"].ToString();
                    lblnombrePaciente.Text = ds.Tables[1].Rows[0]["nom_paciente"].ToString();
                    lblnombreMedico.Text = ds.Tables[2].Rows[0]["nom_medico"].ToString();
                }



            }
        }
        

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            oEntidadCitas.Cod_cita = txtCodigo.Text;
            oEntidadCitas.Fecha = Convert.ToDateTime(txtFecha.Text);
            oEntidadCitas.Hora = Convert.ToDateTime(txtHora.Text);
            oEntidadCitas.Id_paciente1 = txtIdPaciente.Text;
            oEntidadCitas.Id_medico = txtIdMedico.Text;
            oEntidadCitas.Valor = Convert.ToInt32(txtValorCita.Text);
            oEntidadCitas.Diagnostico = txtDiacnostico.Text;
            oEntidadCitas.Nom_acompanante = txtNombreAcompañante.Text;
            if (oReglasNegocioCitas.guardarCita(oEntidadCitas))
            {
                lblMensaje.Text = "Registro guardado exitosamente";
            }else
            {
                lblMensaje.Text = "Error ... al guardar el Registro";
            }

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            limpar();
            txtCodigo.Focus();

        }

        protected void btnConsultarPaciente_Click(object sender, EventArgs e)
        {
            if (txtIdPaciente.Text == "")
            {
                lblMensaje.Text = "No se ha dijitado codigo de la cita";
                txtIdPaciente.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oPacientes.Id_paciente = txtIdPaciente.Text;
                ds = oReglaNegociosPaciente.consultarNombrePaciente(oPacientes);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblnombrePaciente.Text = "Paciente no existente";
                    txtIdPaciente.Focus();
                }
                else
                {
                    lblnombrePaciente.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                }
            }
        }

        protected void btnConsultarMedico_Click(object sender, EventArgs e)
        {
            if (txtIdMedico.Text == "")
            {
                lblMensaje.Text = "No se ha dijitado codigo de la cita";
                txtIdMedico.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oMedicos.Id_medico = txtIdMedico.Text;
                ds = oReglaNegociosMedico.consultarNombreMedico(oMedicos);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblnombreMedico.Text = "Medico no existente";
                    txtIdMedico.Focus();
                }
                else
                {
                    lblnombreMedico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                }
            }
        }
    }
}