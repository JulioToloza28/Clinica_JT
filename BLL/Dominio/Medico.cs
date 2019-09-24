using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Medico:Empleado
    {
        private Int32 ID_Medico;
        private Int32 ID_Empleado;

        public int ID_Medico1
        {
            get { return ID_Medico; }
            set { ID_Medico = value; }
        }
        public int ID_Empleado1
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }
    }
}
