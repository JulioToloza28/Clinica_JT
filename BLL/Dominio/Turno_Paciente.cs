using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno_Paciente
    {
        private Int32 ID_Turno;
        private Int32 ID_Paciente;
        private string Fecha;
        private TimeSpan Hora;
        private Int32 ID_Empleado;
        private Int32 ID_Medico;
        private Int32 ID_Estado;
        private string nombre_paciente;
        private string nombre_medico;
        private string Especialidad;
        private string Obs;
        private bool Eliminado;

        public int ID_Turno1
        {
            get { return ID_Turno; }
            set { ID_Turno = value; }
        }
        public int ID_Paciente1
        {
            get { return ID_Paciente; }
            set { ID_Paciente = value; }
        }
        public string Fecha1
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public TimeSpan Hora1
        {
            get { return Hora; }
            set { Hora = value; }
        }
        public int ID_Empleado1
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }
        public int ID_Medico1
        {
            get { return ID_Medico; }
            set { ID_Medico = value; }
        }
        public int ID_Estado1
        {
            get { return ID_Estado; }
            set { ID_Estado = value; }
        }
        public bool Eliminado1
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }

        public string Obs1
        {
            get { return Obs; }
            set { Obs = value; }
        }

        public string Nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
        public string Nombre_medico { get => nombre_medico; set => nombre_medico = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
    }
}
