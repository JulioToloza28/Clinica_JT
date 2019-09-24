using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PL
{
    public partial class FRM_CANCELAR : Form
    {
        int turnos;
        public FRM_CANCELAR()
        {
            InitializeComponent();
        }

        public FRM_CANCELAR(int id_turno)
        {
            InitializeComponent();
            turnos = id_turno;
        }

        private void FRM_CANCELAR_Load(object sender, EventArgs e)
        {
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }
    }
}
