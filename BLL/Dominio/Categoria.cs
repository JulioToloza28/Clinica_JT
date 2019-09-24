using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Categoria
    {
        private Int32 ID_Categoria;
        private string Nombre;

        public Int32 ID_Categorias
        {
            get { return ID_Categoria; }
            set { ID_Categoria = value; }
        }
        public string Nombres
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
    }
}
