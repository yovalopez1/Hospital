using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CDatosCitas
    {
        CConexion oConexion = new CConexion();
        SqlCommand OCommand = new SqlCommand();

        public DataSet consultarCita(CEntidadCitas ocitas)
        {
            try
            {
                OCommand.Connection = oConexion.conectar("BDHospital");
                OCommand.CommandType = CommandType.StoredProcedure;
                OCommand.CommandText = "sp_consultar_citas";
                OCommand.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                SqlDataAdapter da = new SqlDataAdapter(OCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        } 

        public bool guardarCita(CEntidadCitas ocitas)
        {
            try
            {
                OCommand.Connection = oConexion.conectar("BDHospital");
                OCommand.CommandType = CommandType.StoredProcedure;
                OCommand.CommandText = "sp_guardar_citas";
                OCommand.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                OCommand.Parameters.Add("@pfecha", ocitas.Fecha);
                OCommand.Parameters.Add("@phora", ocitas.Hora);
                OCommand.Parameters.Add("@Id_paciente", ocitas.Id_paciente1);
                OCommand.Parameters.Add("@id_medico", ocitas.Id_medico);
                OCommand.Parameters.Add("@valor",ocitas.Valor);
                OCommand.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                OCommand.Parameters.Add("@nom_acompanante", ocitas.Nom_acompanante);
                OCommand.ExecuteNonQuery();
                return true;    
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
