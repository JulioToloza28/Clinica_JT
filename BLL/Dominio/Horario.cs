using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Horario
    {
        private Int32 ID_Horario;
        private Int32 ID_Empleado;
        private TimeSpan Desde;
        private TimeSpan Hasta;
        private string Dia;

        public int ID_Horario1
        {
            get { return ID_Horario; }
            set { ID_Horario = value; }
        }
        public int ID_Empleado1
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }
        public TimeSpan Desde1
        {
            get { return Desde; }
            set { Desde = value; }
        }
        public TimeSpan Hasta1
        {
            get { return Hasta; }
            set { Hasta = value; }
        }
        public string Dia1
        {
            get { return Dia; }
            set { Dia = value; }
        }
    }
}
