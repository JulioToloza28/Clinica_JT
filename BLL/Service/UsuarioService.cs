using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BLL
{
    public class UsuarioService
    {
        public string cadenaconexion;
        protected string sql;
        protected int resultado;
        protected SqlConnection cn;
        protected SqlCommand cm;
        protected string mensaje;

        public UsuarioService()
        {
            this.cadenaconexion = (@"Data Source=LOCAL\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True");
            this.cn = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }
        public void guardarUsuario(Usuario Nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {
                cn.ConnectionString = cadenaconexion;
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_AGREGAR_USUARIO";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@NOMBRE", Nuevo.NombreUsuario1);
                cm.Parameters.AddWithValue("@CONTRASEÑA", Nuevo.Contraseña1);
                cm.Parameters.AddWithValue("@ID_EMPLEADO", Nuevo.ID_Empleado1);
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
        
    }
}
