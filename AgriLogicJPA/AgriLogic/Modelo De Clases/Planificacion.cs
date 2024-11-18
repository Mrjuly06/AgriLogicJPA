using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriLogic.Modelo_De_Clases
{
    public class Planificacion
    {
 
        public int ActividadID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Responsable { get; set; }
        public int TareaID { get; set; }
        public string DescripcionTarea { get; set; }
        public DateTime FechaProgramada { get; set; }
        public string EstadoTarea { get; set; }
        public int PlanificacionID { get; set; }
        public string TipoPlanificacion { get; set; }
        public string CondicionesClimaticas { get; set; }
        public string CondicionesDelSuelo { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }

}
