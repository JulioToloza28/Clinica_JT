using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Antecedente_Service
    {
        public IList<Antecedente> traerAntecedentes()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Antecedente> lista = new List<Antecedente>();

            try
            {
                accesoDatos.setearComandoText("SELECT ID_ANTECEDENTE,ID_PACIENTE,ID_GRUPO_S,PESO,ALTURA FROM ANTECEDENTE");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Antecedente AntecedenteC = new Antecedente();
                    AntecedenteC.ID_Paciente1 = accesoDatos.Lector.GetInt32(1);
                    AntecedenteC.ID_Grupo_Sanguineo1 = accesoDatos.Lector.GetInt32(2);
                    AntecedenteC.Peso1 = accesoDatos.Lector.GetDecimal(3);
                    AntecedenteC.Altura1 = accesoDatos.Lector.GetDecimal(4);    
                    lista.Add(AntecedenteC);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
        public void GuardarAntecedente(int id,Paciente Nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_AGREGAR_ANTECEDENTE";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_PACIENTE", id);
                cm.Parameters.AddWithValue("@ID_GRUPO_S", Nuevo.Antecedente.ID_Grupo_Sanguineo1);
                cm.Parameters.AddWithValue("@PESO", Nuevo.Antecedente.Peso1);
                cm.Parameters.AddWithValue("@ALTURA", Nuevo.Antecedente.Altura1);
               
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
        public void ModificarAntecedente(Int32 id_paciente,Int32 id_grupo_s,Decimal peso, Decimal altura)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_MODIFICAR_ANTECEDENTE";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_PACIENTE", id_paciente);
                cm.Parameters.AddWithValue("@ID_GRUPO_S", id_grupo_s);
                cm.Parameters.AddWithValue("@PESO", peso);
                cm.Parameters.AddWithValue("@ALTURA", altura);

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
