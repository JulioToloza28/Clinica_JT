using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente:Empleado
    {
        private Int32 ID_Paciente;
        private string Obs;
        private string GrupoSan;
        private string InicialesEmp;
        private Int16 Edad;

        public int ID_Paciente1 { get => ID_Paciente; set => ID_Paciente = value; }
        public string Obs1 { get => Obs; set => Obs = value; }
        public string GrupoSan1 { get => GrupoSan; set => GrupoSan = value; }
        public string InicialesEmp1 { get => InicialesEmp; set => InicialesEmp = value; }
        public short Edad1 { get => Edad; set => Edad = value; }
    }
}
