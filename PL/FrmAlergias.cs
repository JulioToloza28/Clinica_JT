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
    public partial class FrmAlergias : Form
    {
        
        
        public FrmAlergias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grbCargaDe.Text == "Ingrese Alergia")
                {
                    Alergia_Service alerg_ser = new Alergia_Service();
                    Alergia alergias = new Alergia();
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Debe completar el campo");
                        txtNombre.Focus();
                    }
                    else
                    {
                        // FALTA VERIFICAR QUE NO SE REPITA
                        alergias.Nombre1 = txtNombre.Text.Trim();
                        alerg_ser.CargarAlergia(alergias);
                        MessageBox.Show("Se cargo con exito");
                        this.Dispose();

                    }
                }
                else if (grbCargaDe.Text == "Ingrese Medicamento")
                {
                    Medicamento_Service Medicament_Ser = new Medicamento_Service();
                    Medicamento Medicament = new Medicamento();
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Debe completar el campo");
                        txtNombre.Focus();
                    }
                    else
                    {
                        // FALTA VERIFICAR QUE NO SE REPITA
                        Medicament.Nombre1 = txtNombre.Text.Trim();
                        Medicament_Ser.CargarMedicamento(Medicament);
                        MessageBox.Show("Se cargo con exito");
                        this.Dispose();
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;

        }

        private void FrmAlergias_Load(object sender, EventArgs e)
        {
            if (this.Text == "Cargar Alergia")
            {
                grbCargaDe.Text = "Ingrese Alergia";
            }
            else
            {
                grbCargaDe.Text = "Ingrese Medicamento";
            }
        }

        private void FrmAlergias_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}
