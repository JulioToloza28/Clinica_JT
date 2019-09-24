using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BLL
{
    public class Alergias_X_Paciente_Service
    {
        public List<Alergia> TraerAlergias_P(Int32 id_Paciente)
        {
            List<Alergia> Lista = new List<Alergia>();

            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader lector;


            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT P.ID_ALERGIA,A.NOMBRE,P.ELIMINADO FROM ALERGIA AS A INNER JOIN ALERGIA_X_PACIENTE AS P ON A.ID_ALERGIA=P.ID_ALERGIA WHERE ELIMINADO=0 AND P.ID_PACIENTE= " + id_Paciente;
                cm.Connection = cn;

                cn.Open();

                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    Alergia aux = new Alergia();
                    aux.ID_Alergia1 = lector.GetInt32(0);
                    aux.Nombre1 = lector.GetString(1);
                    aux.Eliminado = lector.GetBoolean(2);

                    Lista.Add(aux);

                }
                return Lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void GuardarListaAlergias(Int32 ID_Paciente,Int32 ID_Alergia,Boolean eliminado)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_CARGAR_ALERGIAS_X";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_PACIENTE", ID_Paciente);
                cm.Parameters.AddWithValue("@ID_ALERGIA", ID_Alergia);
                cm.Parameters.AddWithValue("@ELIMINADO", eliminado);

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
