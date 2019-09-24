using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Paciente:Persona
    {
        private Int32 ID_Paciente;
        private string Obs;
        private string GrupoSan;
        private Int32 InicialesEmp;
        private int Edad;
        public bool Eliminado { get; set; }
        public Antecedente Antecedente { get; set; }
        public List<Alergia> Lista_Alergias { get; set; }
        public List<Medicamento> Lista_Medicamentos { get; set; }

    

        public int ID_Paciente1
        {
            get { return ID_Paciente; }
            set { ID_Paciente = value; }
        }
        public string Obs1
        {
            get { return Obs; }
            set { Obs = value; }
        }
        public string GrupoSan1
        {
            get { return GrupoSan; }
            set { GrupoSan = value; }
        }
        public Int32 InicialesEmp1
        {
            get { return InicialesEmp; }
            set { InicialesEmp = value; }
        }
        public int Edad1
        {
            get { return Edad; }
            set { Edad = value; }
        }
      

        
    }
}
