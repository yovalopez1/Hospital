
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
    public class CDatosPaciente
    {
        CConexion oConexion = new CConexion();
        SqlCommand OCommand = new SqlCommand();


        public DataSet ConsultarPaciente(CEntidadPacientes ocitas)
        {
            try
            {
                OCommand.Connection = oConexion.conectar("BDHospital");
                OCommand.CommandType = CommandType.StoredProcedure;
                OCommand.CommandText = "sp_consultar_paciente";
                OCommand.Parameters.Add("@pId_paciente", ocitas.Id_paciente);
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
        public bool Guardar_Paciente(CEntidadPacientes ocitas)
        {
            try
            {
                OCommand.Connection = oConexion.conectar("BDHospital");
                OCommand.CommandType = CommandType.StoredProcedure;
                OCommand.CommandText = "sp_guardar_paciente";
                OCommand.Parameters.Add("@pId_paciente", ocitas.Id_paciente);
                OCommand.Parameters.Add("@ptip_doc ", ocitas.Tip_documento);
                OCommand.Parameters.Add("@pnom_paciente", ocitas.Nom_paciente);
                OCommand.Parameters.Add("@pdir_paciente", ocitas.Dir_paciente);
                OCommand.Parameters.Add("@ptel_paciente", ocitas.Tel_paciente);
                OCommand.Parameters.Add("@pcel_paciente", ocitas.Cel_paciente);
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