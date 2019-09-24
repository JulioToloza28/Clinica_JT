using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EspecialidadXMed
    {
        private Int32 ID_Empleado;
        private Int32 ID_Especilaidad;
        private bool Eliminado;

        public int ID_Empleado1
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }
        public int ID_Especilaidad1
        {
            get { return ID_Especilaidad; }
            set { ID_Especilaidad = value; }
        }
        public bool Eliminado1
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }
    }
}
