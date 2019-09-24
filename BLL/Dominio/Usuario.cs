using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace BLL
{
    public class Usuario : UsuarioService
    {
        private Int32 ID_Ususario;
        private string NombreUsuario;
        private string Contraseña;
        private Int32 ID_Empleado;
        private String Categoria;
        private bool Eliminado;

        public int ID_Ususario1
        {
            get { return ID_Ususario; }
            set { ID_Ususario = value; }
        }

        public string NombreUsuario1
        {
            get { return NombreUsuario; }
            set { NombreUsuario = value; }
        }
        public string Contraseña1
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }
        public int ID_Empleado1
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }
        public string Categoria1
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
        public bool Eliminado1
        {
            get { return Eliminado; }
            set { Eliminado = value; }
        }

        public bool Buscar()
        {
            try
            {
                bool Resultado = false;
                this.sql = string.Format(@"select U.ID_USUARIO,U.NOMBRE_USUARIO,U.CONTRASEÑA,U.ID_EMPLEADO,C.NOMBRE from USUARIO AS U INNER JOIN EMPLEADO AS E ON U.ID_EMPLEADO=E.ID_EMPLEADO INNER JOIN CATEGORIA AS C ON E.ID_CATEGORIA=C.ID_CATEGORIA  where U.NOMBRE_USUARIO='{0}' AND U.CONTRASEÑA='{1}'AND U.ELIMINADO=0", this.NombreUsuario1, this.Contraseña1);
                this.cm = new SqlCommand(this.sql, this.cn);
                this.cn.Open();
                SqlDataReader Reg = null;
                Reg = this.cm.ExecuteReader();

                if (Reg.Read())
                {
                    ID_Ususario1 = Reg.GetInt32(0);
                    NombreUsuario1 = Reg.GetString(1);
                    Contraseña1 = Reg.GetString(2);
                    ID_Empleado1 = Reg.GetInt32(3);
                    Categoria1 = Reg.GetString(4);
                    Resultado = true;
                }
                else
                {
                    this.mensaje = "Verifique los datos ";
                }

                this.cn.Close();
                return Resultado;
            }
            catch (Exception ex)
            {
                this.mensaje = "Mensaje "+ex.Message;
                return false;
            }



        }
        
    }
}
