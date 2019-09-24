using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Medicamento_Service
    {
        public IList<Medicamento> traerMedicamentos()
        {
            IList<Medicamento> lista = new List<Medicamento>();

            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader lector;

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT ID_MEDICAMENTO, NOMBRE FROM MEDICAMENTO";
                cm.Connection = cn;

                cn.Open();

                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    Medicamento aux = new Medicamento();
                    aux.ID_Medicamento1 = lector.GetInt32(0);
                    aux.Nombre1 = lector.GetString(1);
                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cm.Dispose();

            }






             
        }

        public void CargarMedicamento(Medicamento nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_CARGAR_MEDICAMENTO";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@NOMBRE", nuevo.Nombre1);

                cn.Open();
                cm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cm.Dispose();

            }
        }

        public void ModificarMedic(Medicamento medicamentos)
        {

        }
    }

}

