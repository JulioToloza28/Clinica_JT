using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        private Int32 ID_Localidad;
        private string N_Localidad;
        private Int32 ID_Provincia;

        public int ID_Localidad1 { get => ID_Localidad; set => ID_Localidad = value; }
        public string N_Localidad1 { get => N_Localidad; set => N_Localidad = value; }
        public int ID_Provincia1 { get => ID_Provincia; set => ID_Provincia = value; }
    }
}
