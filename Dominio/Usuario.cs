using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Dominio
{
    public class Usuario
    {
        private Int32 ID_Ususario;
        private string NombreUsuario;
        private string Contraseña;
        private Int32 ID_Empleado;
        private Int32 ID_Categoria;
        private bool Eliminado;

        public int ID_Ususario1 { get => ID_Ususario; set => ID_Ususario = value; }
        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public int ID_Empleado1 { get => ID_Empleado; set => ID_Empleado = value; }
        public int ID_Categoria1 { get => ID_Categoria; set => ID_Categoria = value; }
        public bool Eliminado1 { get => Eliminado; set => Eliminado = value; }

        //public bool Buscar()
        //{
        //    try
        //    {
        //        bool Resultado = false;
        //        this.sql = string.Format(@"select U.ID_USUARIO,U.NOMBRE_USUARIO,U.CONTRASEÑA,U.ID_EMPLEADO,E.ID_CATEGORIA from USUARIO AS U INNER JOIN EMPLEADO AS E ON U.ID_EMPLEADO=E.ID_EMPLEADO where U.NOMBRE_USUARIO='{0}' AND U.CONTRASEÑA='{1}'AND U.ELIMINADO=0", this.NombreUsuario1, this.Contraseña1);
        //        this.cm = new SqlCommand(this.sql, this.cn);
        //        this.cn.Open();
        //        SqlDataReader Reg = null;
        //        Reg = this.cm.ExecuteReader();

        //        if (Reg.Read())
        //        {
        //            ID_Ususario1 = Reg.GetInt32(0);
        //            NombreUsuario1 = Reg.GetString(1);
        //            Resultado = true;
        //            this.mensaje = " Bienvenido " + NombreUsuario1;

        //        }
        //        else
        //        {
        //            this.mensaje = "Verifique los datos ";
        //        }

        //        this.cn.Close();
        //        return Resultado;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.mensaje = "error";
        //        return false;
        //    }



        //}



    }
}
