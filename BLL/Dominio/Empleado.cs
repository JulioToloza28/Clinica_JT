using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Empleado : Persona
    {
        private Int32 ID_Empleado;
        private Int32 ID_Categoria;
        private bool Eliminado;
        public Usuario Usser { get; set; }
        public List<Especialidad> Lista_Especialidades { get; set; }
        public IList<Horario> ListaHorarios { get; set; }
        private String oTROS;



        public int ID_Empleado1
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }

        public int ID_Categoria1
        {
            get { return ID_Categoria; }
            set { ID_Categoria = value; }
        }

        public bool Eliminado1
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }

        public string OTROS { get => oTROS; set => oTROS = value; }
    }
}
    