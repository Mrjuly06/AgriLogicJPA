using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriLogic.Modelo_De_Clases
{
    public class Actividad
    {
        // Propiedades de la actividad agrícola
        public int ActividadID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Responsable { get; set; }
        public int TareaID { get; set; }
        public string DescripcionTarea { get; set; }
        public DateTime FechaProgramada { get; set; }
        public string EstadoTarea { get; set; }
    }

}
