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
    public class CReglaNegociosPaciente
    {
        CDatosPaciente oDatosPaciente = new CDatosPaciente();
        public DataSet consultarNombrePaciente(CEntidadPacientes ocitas)
        {
            return oDatosPaciente.ConsultarPaciente(ocitas);
        }

        public bool Guardar_Pacientes(CEntidadPacientes ocitas)
        {
            return oDatosPaciente.Guardar_Paciente(ocitas);
        }
    }
}
