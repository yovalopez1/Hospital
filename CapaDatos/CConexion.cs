using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class CConexion
    {
        public SqlConnection conectar(String cnx)
        {
            try
            {
                SqlConnection oConectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oConectar.Open();
                return oConectar;
            }catch (Exception err)
            {
                throw new Exception(err.Message);//solo si no se conecta a la db sale este error
            }
        }
    }
}
