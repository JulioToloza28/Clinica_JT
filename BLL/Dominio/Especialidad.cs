using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Especialidad
    {
        private Int32 ID_Especialidad;
        private string Nombre;
        

        public int ID_Especialidad1
        {
            get { return ID_Especialidad; }
            set { ID_Especialidad = value; }

        }
        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}

