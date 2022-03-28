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
    public class CReglasNegociosCitas
    {
        CDatosCitas oDatosCita = new CDatosCitas();
        
        public DataSet consultar_Cita(CEntidadCitas oCitas)
        {
            return oDatosCita.consultarCita(oCitas);
        }

        public bool guardarCita(CEntidadCitas ocitas)
        {
            return oDatosCita.guardarCita(ocitas);
        }
    }
}
