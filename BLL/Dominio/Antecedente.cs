using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Antecedente
    {
        private Int32 ID_Antecedente;
        private Int32 ID_Paciente;
        private Int32 ID_Grupo_Sanguineo;
        private Decimal Peso;
        private Decimal Altura;

        public int ID_Antecedente1
        {
            get { return ID_Antecedente; }
            set { ID_Antecedente = value; }
        }

        public int ID_Paciente1
        {
            get { return ID_Paciente; }
            set { ID_Paciente = value; }
        }
        public int ID_Grupo_Sanguineo1
        {
            get { return ID_Grupo_Sanguineo; }
            set { ID_Grupo_Sanguineo = value; }
        }
        public Decimal Peso1
        {
            get { return Peso; }
            set { Peso = value; }
        }
        public Decimal Altura1
        {
            get { return Altura; }
            set { Altura = value; }
        }
    }
}
