using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Horario_service
    {
        public IList<Horario> TraerHorarios()
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Horario> lista = new List<Horario>();
            try
            {
                accesoDatos.setearComandoText("SELECT ID_HORARIO,ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS FROM HORA_IE");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Horario HorarioM = new Horario();
                    HorarioM.ID_Horario1 = accesoDatos.Lector.GetInt32(0);
                    HorarioM.ID_Empleado1 = accesoDatos.Lector.GetInt32(1);
                    HorarioM.Desde1 = accesoDatos.Lector.GetTimeSpan(2);
                    HorarioM.Hasta1 = accesoDatos.Lector.GetTimeSpan(3);
                    HorarioM.Dia1 = accesoDatos.Lector.GetString(4);
                    lista.Add(HorarioM);
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
        public IList<Horario> BuscarHorario(Int32 Id_Empleado)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            try
            {
                accesoDatos.setearComandoText("SELECT ID_HORARIO,ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS FROM HORA_IE  where ID_EMPLEADO= "+Id_Empleado);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
               
                IList<Horario> lista = new List<Horario>();

                while (accesoDatos.Lector.Read())
                {
                    Horario hora = new Horario();
                    hora.ID_Horario1 = accesoDatos.Lector.GetInt32(0);
                    hora.ID_Empleado1 = accesoDatos.Lector.GetInt32(1);
                    hora.Desde1 = accesoDatos.Lector.GetTimeSpan(2);
                    hora.Hasta1 = accesoDatos.Lector.GetTimeSpan(3);
                    hora.Dia1 = accesoDatos.Lector.GetString(4);
                    lista.Add(hora);
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
        public IList<Horario> BuscarHorario(Int32 Id_Empleado,string Dia)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            try
            {
                accesoDatos.setearComandoText("SELECT ID_HORARIO,ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS FROM HORA_IE  where ID_EMPLEADO= " + Id_Empleado +" and DIAS LIKE '%"+Dia+"%'" );
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();

                IList<Horario> lista = new List<Horario>();

                while (accesoDatos.Lector.Read())
                {
                    Horario hora = new Horario();
                    hora.ID_Horario1 = accesoDatos.Lector.GetInt32(0);
                    hora.ID_Empleado1 = accesoDatos.Lector.GetInt32(1);
                    hora.Desde1 = accesoDatos.Lector.GetTimeSpan(2);
                    hora.Hasta1 = accesoDatos.Lector.GetTimeSpan(3);
                    hora.Dia1 = accesoDatos.Lector.GetString(4);
                    lista.Add(hora);
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
        public void GuerdarHorarios(Horario nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_HORARIO_MEDICO";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("ID_EMPLEADO", nuevo.ID_Empleado1);
                cm.Parameters.AddWithValue("@HORA_D", nuevo.Desde1);
                cm.Parameters.AddWithValue("@HORA_H", nuevo.Hasta1);
                cm.Parameters.AddWithValue("@DIAS", nuevo.Dia1);

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
