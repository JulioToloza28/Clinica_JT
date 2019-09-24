using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Alergia
    {
        private Int32 ID_Alergia;
        private string Nombre;
        private bool eliminado;

        public Int32 ID_Alergia1
        {
            get { return ID_Alergia; }
            set { ID_Alergia = value; }
        }

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
