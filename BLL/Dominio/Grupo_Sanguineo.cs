using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Grupo_Sanguineo
    {
        private Int32 ID_Grupo_Sanguineo;
        private string Nombre;

        public int ID_Grupo_Sanguineo1
        {
          get { return ID_Grupo_Sanguineo; }
          set { ID_Grupo_Sanguineo = value; }
        }
        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public override string ToString()
        {
            return Nombre1;
        }
    }
}
