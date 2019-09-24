using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Medicamento
    {
        private Int32 ID_Medicamento;
        private string Nombre;

        public Int32 ID_Medicamento1
        {
            get { return ID_Medicamento; }
            set { ID_Medicamento = value; }
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
