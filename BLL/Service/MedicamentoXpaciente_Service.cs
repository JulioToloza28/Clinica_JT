using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class MedicamentoXpaciente_Service
    {
        public List<Medicamento_X> TraerMedicamntos_P(Int32 id_Paciente)
        {
            List<Medicamento_X> Lista = new List<Medicamento_X>();

            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader lector;


            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT P.ID_MEDICAMENTO_X_PACIENTE,P.ID_MEDICAMENTO,M.NOMBRE,P.ElIMINADO FROM MEDICAMENTO AS M INNER JOIN MEDICAMENTO_X_PACIENTE AS P ON M.ID_MEDICAMENTO=P.ID_MEDICAMENTO WHERE ELIMINADO=0 AND P.ID_PACIENTE= " + id_Paciente;
                cm.Connection = cn;

                cn.Open();

                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    Medicamento_X aux = new Medicamento_X();
                    aux.ID_Medicamento_x1 = lector.GetInt32(0);
                    aux.ID_Medicamento1 = lector.GetInt32(1);
                    aux.N_Medicamento1 = lector.GetString(2);
                    aux.Eliminado = lector.GetBoolean(3);

                    Lista.Add(aux);

                }
                return Lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void GuardarListaMedicamento(Int32 ID_Paciente, Int32 ID_Medicamento, Boolean eliminado)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_CARGAR_MEDICAMENTO_X";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_PACIENTE", ID_Paciente);
                cm.Parameters.AddWithValue("@ID_MEDICAMENTO", ID_Medicamento);
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

        public void ModificarLista(Int32 id_medicamento, Int32 ID_Paciente, Int32 ID_Medicamento, Boolean eliminado)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_MODIFICAR_MEDICAMENTO_X";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_MEDICAMNTO_X_PACIENTE", id_medicamento);
                cm.Parameters.AddWithValue("@ID_PACIENTE", ID_Paciente);
                cm.Parameters.AddWithValue("@ID_MEDICAMENTO", ID_Medicamento);
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
