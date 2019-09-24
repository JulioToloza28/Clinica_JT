using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Turno_Service
    {
        public IList<Turno_Paciente> BuscarTurnos(Int32 ID_Medico,Int32 Dia, Int32 Mes, Int32 Anio)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Turno_Paciente> listaT = new List<Turno_Paciente>();
            try
            {
                accesoDatos.setearComandoText("SELECT  ID_TURNO,ID_PACIENTE,FECHA,HORA,ID_EMPLEADO,ID_MEDICO,ID_ESTADO,OBSERVACION,ELIMINADO FROM TURNO where ID_MEDICO= "+ID_Medico+ " and FECHA= convert(date,'" + Dia+"/"+Mes+"/"+Anio+ "',105) " + "and ELIMINADO=0");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Turno_Paciente Nuevo = new Turno_Paciente();
                    Nuevo.ID_Turno1 = accesoDatos.Lector.GetInt32(0);
                    Nuevo.ID_Paciente1 = accesoDatos.Lector.GetInt32(1);
                    Nuevo.Fecha1 =Convert.ToString(accesoDatos.Lector.GetDateTime(2));
                    Nuevo.Hora1 = accesoDatos.Lector.GetTimeSpan(3);
                    Nuevo.ID_Empleado1 = accesoDatos.Lector.GetInt32(4);
                    Nuevo.ID_Medico1 = accesoDatos.Lector.GetInt32(5);
                    Nuevo.ID_Estado1 = accesoDatos.Lector.GetInt32(6);
                    Nuevo.Obs1 = accesoDatos.Lector.GetString(7);
                    Nuevo.Eliminado1 = accesoDatos.Lector.GetBoolean(8);
                    listaT.Add(Nuevo);

                }
                return listaT;
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
        public void GuardarTurnos(Turno_Paciente nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_AGREGAR_TURNO";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_PACIENTE", nuevo.ID_Paciente1);
                cm.Parameters.AddWithValue("@FECHA",Convert.ToDateTime(nuevo.Fecha1));
                cm.Parameters.AddWithValue("@HORA", nuevo.Hora1);
                cm.Parameters.AddWithValue("@ID_EMPLEADO", nuevo.ID_Empleado1);
                cm.Parameters.AddWithValue("@ID_MEDICO", nuevo.ID_Medico1);
                cm.Parameters.AddWithValue("@ID_ESTADO", nuevo.ID_Estado1);
                cm.Parameters.AddWithValue("@OBSERVACION", nuevo.Obs1);
                cm.Parameters.AddWithValue("@ELIMINADO", nuevo.Eliminado1);

                


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
        public IList<Turno_Paciente> Visualizarturnos(Int32 Dia, Int32 Mes, Int32 Anio)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Turno_Paciente> listaT = new List<Turno_Paciente>();
            try
            {
                accesoDatos.setearComandoText("SELECT T.HORA,P.NOMBRE+' '+P.APELLIDO AS 'PACIENTE',M.NOMBRE+' '+M.APELLIDO AS 'MEDICO',E.NOMBRE AS 'ESPECIALIDAD'   FROM TURNO AS T INNER JOIN PACIENTE AS P ON P.ID_PACIENTE=T.ID_PACIENTE INNER JOIN ESPECIALIDAD_X_M AS EXM ON EXM.ID_EMPLEADO=T.ID_MEDICO INNER JOIN ESPECIALIDAD AS E ON E.ID_ESPECIALIDAD=EXM.ID_ESPECIALIDAD INNER JOIN EMPLEADO AS M ON M.ID_EMPLEADO=T.ID_MEDICO WHERE T.FECHA=convert(date,'" + Dia + "/" + Mes + "/" + Anio + "',105) and T.ELIMINADO=0 order by t.hora asc");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Turno_Paciente Nuevo = new Turno_Paciente();
                    Nuevo.Hora1 = accesoDatos.Lector.GetTimeSpan(0);
                    Nuevo.Nombre_paciente = accesoDatos.Lector.GetString(1);
                    Nuevo.Nombre_medico = accesoDatos.Lector.GetString(2);
                    Nuevo.Especialidad1 = accesoDatos.Lector.GetString(3);
                    listaT.Add(Nuevo);

                }
                return listaT;
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
        public IList<Turno_Paciente> buscarpor(string dni)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Turno_Paciente> listaT = new List<Turno_Paciente>();
            try
            {
                accesoDatos.setearComandoText("SELECT T.FECHA ,T.HORA,P.NOMBRE+' '+P.APELLIDO AS 'PACIENTE',M.NOMBRE+' '+M.APELLIDO AS 'MEDICO',E.NOMBRE AS 'ESPECIALIDAD',P.ID_PACIENTE   FROM TURNO AS T INNER JOIN PACIENTE AS P ON P.ID_PACIENTE=T.ID_PACIENTE INNER JOIN ESPECIALIDAD_X_M AS EXM ON EXM.ID_EMPLEADO=T.ID_MEDICO INNER JOIN ESPECIALIDAD AS E ON E.ID_ESPECIALIDAD=EXM.ID_ESPECIALIDAD INNER JOIN EMPLEADO AS M ON M.ID_EMPLEADO=T.ID_MEDICO WHERE P.DNI like'%" + dni+"%' and FECHA >= GETDATE() order by t.hora asc");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Turno_Paciente Nuevo = new Turno_Paciente();
                    Nuevo.Fecha1 =Convert.ToString(accesoDatos.Lector.GetDateTime(0));
                    Nuevo.Hora1 = accesoDatos.Lector.GetTimeSpan(1);
                    Nuevo.Nombre_paciente = accesoDatos.Lector.GetString(2);
                    Nuevo.Nombre_medico = accesoDatos.Lector.GetString(3);
                    Nuevo.Especialidad1 = accesoDatos.Lector.GetString(4);
                    Nuevo.ID_Paciente1 = accesoDatos.Lector.GetInt32(5);
                    listaT.Add(Nuevo);

                }
                return listaT;
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
        public IList<Turno_Paciente> Buscar_turnoPor(string campo,string clave,string dni)
        {
            try
            {
                IList<Turno_Paciente> Lista = new List<Turno_Paciente>();
                string consulta = "SELECT T.FECHA ,T.HORA,P.NOMBRE+' '+P.APELLIDO AS 'PACIENTE',M.NOMBRE+' '+M.APELLIDO AS 'MEDICO',E.NOMBRE AS 'ESPECIALIDAD',P.ID_PACIENTE   FROM TURNO AS T INNER JOIN PACIENTE AS P ON P.ID_PACIENTE=T.ID_PACIENTE INNER JOIN ESPECIALIDAD_X_M AS EXM ON EXM.ID_EMPLEADO=T.ID_MEDICO INNER JOIN ESPECIALIDAD AS E ON E.ID_ESPECIALIDAD=EXM.ID_ESPECIALIDAD INNER JOIN EMPLEADO AS M ON M.ID_EMPLEADO=T.ID_MEDICO WHERE P.";
                string fin = "and FECHA >= GETDATE() order by t.hora asc";
                DataAccessLayer conexion = new DataAccessLayer();

                switch (campo)
                {
                    case "Nombre":
                        consulta = consulta + campo + " Like '%" + clave + "%'"+fin;
                        break;
                    case "Apellido":
                        consulta = consulta + campo + " Like '%" + clave + "%'" + fin;
                        break;
                    case "DNI":
                        consulta = consulta + campo + " Like '%" + dni + "%'" + fin;
                        break;
                }

                conexion.setearComandoText(consulta);
                conexion.abrirConexion();
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {
                    Turno_Paciente Nuevo = new Turno_Paciente();
                    Nuevo.Fecha1 = Convert.ToString(conexion.Lector.GetDateTime(0));
                    Nuevo.Hora1 = conexion.Lector.GetTimeSpan(1);
                    Nuevo.Nombre_paciente = conexion.Lector.GetString(2);
                    Nuevo.Nombre_medico = conexion.Lector.GetString(3);
                    Nuevo.Especialidad1 =conexion.Lector.GetString(4);
                    Nuevo.ID_Paciente1 = conexion.Lector.GetInt32(5);
                    Lista.Add(Nuevo);
                    
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
