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
    public class CDatosMedico
    {
        CConexion oConexion = new CConexion();
        SqlCommand OCommand = new SqlCommand();
        public DataSet ConsultarMedico(CEntidadMedicos ocitas)
        {
            try
            {
                OCommand.Connection = oConexion.conectar("BDHospital");
                OCommand.CommandType = CommandType.StoredProcedure;
                OCommand.CommandText = "sp_consultar_medico";
                OCommand.Parameters.Add("@pid_medico", ocitas.Id_medico);
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

        public bool Guardar_Medico(CEntidadMedicos ocitas)
        {
            try
            {
                OCommand.Connection = oConexion.conectar("BDHospital");
                OCommand.CommandType = CommandType.StoredProcedure;
                OCommand.CommandText = "sp_guardar_medico";
                OCommand.Parameters.Add("@pid_medico", ocitas.Id_medico);
                OCommand.Parameters.Add("@pnom_medico", ocitas.Nom_medico);
                OCommand.Parameters.Add("@pespecialidad", ocitas.Especialidad);
                OCommand.Parameters.Add("@ptel_medico", ocitas.Tel_medico);
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
