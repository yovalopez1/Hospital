using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaReglasNegocio
{
    public class CReglaNegociosMedico
    {
        CDatosMedico oDatosMedico = new CDatosMedico();

        public DataSet consultarNombreMedico(CEntidadMedicos ocitas)
        {
            return oDatosMedico.ConsultarMedico(ocitas);
        }
        public bool Guardar_Medico(CEntidadMedicos ocitas)
        {
            return oDatosMedico.Guardar_Medico(ocitas);
        }
    }
}
