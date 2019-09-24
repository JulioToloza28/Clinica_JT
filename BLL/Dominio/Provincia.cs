using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Provincia
    {
        private Int32 ID_Provincia;
        private string N_Provincia;
     

        public int ID_Provincia1
        {
            get { return ID_Provincia; }
            set { ID_Provincia = value; }
        }
        public string N_Provincia1
        {
            get { return N_Provincia; }
            set { N_Provincia = value; }
        }

        public override string ToString()
        {
            return N_Provincia1;
        }
    }
}
