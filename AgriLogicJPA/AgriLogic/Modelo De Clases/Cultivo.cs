using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriLogic.Modelo_De_Clases
{
  public class Cultivo
    {
        // Propiedades del cultivo
        public int CultivoID { get; set; }
        public string TipoCultivo { get; set; }
        public DateTime FechaSiembra { get; set; }
        public DateTime FechaCosecha { get; set; }
        public string RequisitosCultivo { get; set; }
    }

}
