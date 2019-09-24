using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Alergia_Service
    {
        public IList<Alergia> TraerAlergias()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader lector;

            IList<Alergia> Lista = new List<Alergia>();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT ID_ALERGIA,NOMBRE FROM ALERGIA";
                cm.Connection = cn;

                cn.Open();
                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    Alergia aux = new Alergia();
                    aux.ID_Alergia1 = lector.GetInt32(0);
                    aux.Nombre1 = lector.GetString(1);

                    Lista.Add(aux);

                }
                return Lista;
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

        public void CargarAlergia(Alergia nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_CARGAR_ALERGIA";
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
    }
}
