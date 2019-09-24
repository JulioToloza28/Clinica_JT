using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Medicamento_X
    {
        private Int32 ID_Medicamento_x;
        private Int32 ID_Paciente;
        private Int32 ID_Medicamento;
        private string N_Medicamento;
        private bool eliminado;

        public int ID_Medicamento_x1
        {
            get { return ID_Medicamento_x; }
            set { ID_Medicamento_x = value; }
        }
        public int ID_Paciente1
        {
            get { return ID_Paciente; }
            set { ID_Paciente = value; }
        }
        public int ID_Medicamento1
        {
            get { return ID_Medicamento; }
            set { ID_Medicamento = value; }
        }
        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public string N_Medicamento1
        {
            get { return N_Medicamento; }
            set { N_Medicamento = value; }
        }
    }
}
