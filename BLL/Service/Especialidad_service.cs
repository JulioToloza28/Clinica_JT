using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Especialidad_service
    {
        public IList<Especialidad> traerEspecialidades()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Especialidad> lista = new List<Especialidad>();

            try
            {
                accesoDatos.setearComandoText("Select ID_ESPECIALIDAD,NOMBRE From ESPECIALIDAD");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Especialidad ES = new Especialidad();
                    ES.ID_Especialidad1 = accesoDatos.Lector.GetInt32(0);
                    ES.Nombre1 = accesoDatos.Lector.GetString(1);
                    lista.Add(ES);
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
        public void guardarEspecialidadXMed(EspecialidadXMed Nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_AGREGAR_ESPECIALIDADxMEDICO";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_EMPLEADO", Nuevo.ID_Empleado1);
                cm.Parameters.AddWithValue("@ID_ESPECIALIDAD", Nuevo.ID_Especilaidad1);
                cm.Parameters.AddWithValue("@ELIMINADO", Nuevo.Eliminado1);

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

        public IList<Especialidad> traerEspecialidades(int ID_EMPLEADO)
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Especialidad> lista = new List<Especialidad>();

            try
            {
                accesoDatos.setearComandoText("select E.ID_ESPECIALIDAD,E.NOMBRE from ESPECIALIDAD AS E INNER JOIN ESPECIALIDAD_X_M AS EXM ON EXM.ID_ESPECIALIDAD=E.ID_ESPECIALIDAD WHERE  ID_EMPLEADO=" + ID_EMPLEADO);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Especialidad ES = new Especialidad();
                    ES.ID_Especialidad1 = accesoDatos.Lector.GetInt32(0);
                    ES.Nombre1 = accesoDatos.Lector.GetString(1);
                    lista.Add(ES);
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
    }
}
