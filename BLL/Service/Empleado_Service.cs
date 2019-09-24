using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BLL
{
    public class Empleado_Service
    {
        int u = 0;
        public IList<Empleado> traerEmpleados()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Empleado> lista = new List<Empleado>();

            try
            {
                accesoDatos.setearComandoText("select ID_EMPLEADO,ID_CATEGORIA,NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,ELIMINADO from EMPLEADO ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Empleado Empleado = new Empleado();
                    Empleado.ID_Empleado1= accesoDatos.Lector.GetInt32(0);
                    Empleado.ID_Categoria1 = accesoDatos.Lector.GetInt32(1);
                    Empleado.Nombre1 = accesoDatos.Lector.GetString(2);
                    Empleado.Apellido1 = accesoDatos.Lector.GetString(3);
                    Empleado.DNI1 = accesoDatos.Lector.GetString(4);
                    Empleado.Fecha_Nac1 = accesoDatos.Lector.GetString(5);
                    Empleado.Direccion1 = accesoDatos.Lector.GetString(6);
                    Empleado.Localidad.ID_Localidad1= accesoDatos.Lector.GetInt32(7);
                    Empleado.Telefono1 = accesoDatos.Lector.GetString(8);
                    Empleado.Email1 = accesoDatos.Lector.GetString(9);
                    Empleado.Sexo1 = accesoDatos.Lector.GetBoolean(10);
                    Empleado.Eliminado1 = accesoDatos.Lector.GetBoolean(11);


                    lista.Add(Empleado);
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

        public IList<Empleado> buscarMedicoXec(Int32 ID_Categoria,Int32 ID_Especialidad)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Empleado> lista = new List<Empleado>();

            try
            {
                accesoDatos.setearComandoText("select M.ID_EMPLEADO,M.ID_CATEGORIA,M.NOMBRE,M.APELLIDO,M.DNI,M.FECHA_NAC,M.DIRECCION,M.TELEFONO,M.EMAIL,M.SEXO,M.ELIMINADO,EM.ID_ESPECIALIDAD from empleado AS M INNER JOIN ESPECIALIDAD_X_M AS EM ON M.ID_EMPLEADO=EM.ID_EMPLEADO where M.ELIMINADO=0 AND ID_CATEGORIA=" + ID_Categoria +"AND ID_ESPECIALIDAD="+ ID_Especialidad);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Empleado Medico = new Empleado();
                    Medico.ID_Empleado1 = accesoDatos.Lector.GetInt32(0);
                    Medico.ID_Categoria1 = accesoDatos.Lector.GetInt32(1);
                    Medico.Nombre1 = accesoDatos.Lector.GetString(2);
                    Medico.Apellido1 = accesoDatos.Lector.GetString(3);
                    Medico.DNI1 = accesoDatos.Lector.GetString(4);
                    Medico.Fecha_Nac1 =Convert.ToString(accesoDatos.Lector.GetDateTime(5));
                    Medico.Direccion1 = accesoDatos.Lector.GetString(6);
                    Medico.Telefono1 = accesoDatos.Lector.GetString(7);
                    Medico.Email1 = accesoDatos.Lector.GetString(8);
                    Medico.Sexo1 = accesoDatos.Lector.GetBoolean(9);
                    Medico.Eliminado1 = accesoDatos.Lector.GetBoolean(10);
                    
                   
                    lista.Add(Medico);
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

        public Empleado BuscarEmpleado(Int32 id)
        {
            try
            {
                Empleado aux = new Empleado();
                DataAccessLayer cn = new DataAccessLayer();

                string consulta = "select * from empleado where ELIMINADO=0 and ID_EMPLEADO="+ id;

                cn.setearComandoText(consulta);
                cn.abrirConexion();
                cn.ejecutarQuery();

                while (cn.Lector.Read())
                {
                    aux.ID_Empleado1 = cn.Lector.GetInt32(0);
                    aux.ID_Categoria1 = cn.Lector.GetInt32(1);
                    aux.Nombre1 = cn.Lector.GetString(2);
                    aux.Apellido1 = cn.Lector.GetString(3);
                    aux.DNI1 = cn.Lector.GetString(4);
                    aux.Fecha_Nac1 =Convert.ToString(cn.Lector.GetDateTime(5));
                    aux.Direccion1 = cn.Lector.GetString(6);
                    aux.Localidad = new Localidad() { ID_Localidad1 = cn.Lector.GetInt32(7) };
                    aux.Telefono1 = cn.Lector.GetString(8);
                    aux.Email1 = cn.Lector.GetString(9);
                    aux.Sexo1 = cn.Lector.GetBoolean(10);
                    aux.Eliminado1 = cn.Lector.GetBoolean(11);


                }
                return aux;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void GuardarMedico(Empleado Nuevo)
        {

            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            Horario_service horarios = new Horario_service();
            UsuarioService usuario = new UsuarioService();
            Horario h = new Horario();
            Especialidad_service EspecialidadX_med = new Especialidad_service();
            EspecialidadXMed esM = new EspecialidadXMed();
            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_AGREGAR_EMPLEADO";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_CATEGORIA", Nuevo.ID_Categoria1);
                cm.Parameters.AddWithValue("@NOMBRE", Nuevo.Nombre1);
                cm.Parameters.AddWithValue("@APELLIDO", Nuevo.Apellido1);
                cm.Parameters.AddWithValue("@DNI", Nuevo.DNI1);
                cm.Parameters.AddWithValue("@FECHA_NAC",Convert.ToDateTime( Nuevo.Fecha_Nac1));
                cm.Parameters.AddWithValue("@DIRECCION", Nuevo.Direccion1);
                cm.Parameters.AddWithValue("@IDLOCALIDAD", Nuevo.Localidad.ID_Localidad1);
                cm.Parameters.AddWithValue("@TELEFONO", Nuevo.Telefono1);
                cm.Parameters.AddWithValue("@EMAIL", Nuevo.Email1);
                cm.Parameters.AddWithValue("@SEXO", Nuevo.Sexo1);
                cm.Parameters.AddWithValue("@ELIMINADO", Nuevo.Eliminado1);

                cn.Open();

                Nuevo.ID_Empleado1 = Convert.ToInt32(cm.ExecuteScalar());
                Nuevo.Usser.ID_Empleado1= Nuevo.ID_Empleado1;
                
                for (int i = 0; i < Nuevo.ListaHorarios.Count; i++)
                {
                    Nuevo.ListaHorarios[i].ID_Empleado1= Nuevo.ID_Empleado1;
                    //horarios.GuerdarHorarios(Nuevo.ListaHorarios);
                }
                
                for (int j = 0; j < Nuevo.ListaHorarios.Count; j++)
                {

                    h = Nuevo.ListaHorarios[j];
                    string dia = h.Dia1;
                    horarios.GuerdarHorarios(h);
                    
                }
                for (int x = 0; x < Nuevo.Lista_Especialidades.Count; x++)
                {
                    esM.ID_Empleado1 = Nuevo.ID_Empleado1;
                    esM.ID_Especilaidad1 = Nuevo.Lista_Especialidades[x].ID_Especialidad1;
                    esM.Eliminado1 = false;
                    EspecialidadX_med.guardarEspecialidadXMed(esM);
                }
                usuario.guardarUsuario(Nuevo.Usser);      



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

        public IList<Empleado> buscarMedicoXec(string campo,string clave)
        {
            DataAccessLayer accesoDatos = new DataAccessLayer();
           

            try
            {
                IList<Empleado> lista = new List<Empleado>();
                string consulta = "select M.ID_EMPLEADO,M.ID_CATEGORIA,M.NOMBRE,M.APELLIDO,M.DNI,M.FECHA_NAC,M.DIRECCION,M.TELEFONO,M.EMAIL,M.SEXO,M.ELIMINADO,EM.ID_ESPECIALIDAD,E.NOMBRE from empleado AS M INNER JOIN ESPECIALIDAD_X_M AS EM ON M.ID_EMPLEADO=EM.ID_EMPLEADO INNER JOIN ESPECIALIDAD AS E ON E.ID_ESPECIALIDAD=EM.ID_ESPECIALIDAD where M.ELIMINADO=0 AND ";
                

                switch (campo)
                {
                    case "Nombre":
                        consulta = consulta + "M." + campo + " Like '%" + clave + "%'";
                        break;
                    case "Apellido":
                        consulta = consulta + "M." + campo + " Like '%" + clave + "%'";
                        break;
                    case "Especialidad":
                        consulta = consulta + "E.NOMBRE" + " Like '%" + clave + "%'";
                        break;
                }

                accesoDatos.setearComandoText(consulta);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();


                while (accesoDatos.Lector.Read())
                {
                
                    Empleado Medico = new Empleado();
                    Medico.ID_Empleado1 = accesoDatos.Lector.GetInt32(0);
                    Medico.ID_Categoria1 = accesoDatos.Lector.GetInt32(1);
                    Medico.Nombre1 = accesoDatos.Lector.GetString(2);
                    Medico.Apellido1 = accesoDatos.Lector.GetString(3);
                    Medico.DNI1 = accesoDatos.Lector.GetString(4);
                    Medico.Fecha_Nac1 = Convert.ToString(accesoDatos.Lector.GetDateTime(5));
                    Medico.Direccion1 = accesoDatos.Lector.GetString(6);
                    Medico.Telefono1 = accesoDatos.Lector.GetString(7);
                    Medico.Email1 = accesoDatos.Lector.GetString(8);
                    Medico.Sexo1 = accesoDatos.Lector.GetBoolean(9);
                    Medico.Eliminado1 = accesoDatos.Lector.GetBoolean(10);
               
        
    


                    lista.Add(Medico);
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

        public void eliminarMedico(int id_empleado)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_eliminar";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_EMPLEADO", id_empleado);
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

        public Empleado BuscarEmpleado(Empleado aux1)
        {
            try
            {
                Empleado aux = new Empleado();
                DataAccessLayer cn = new DataAccessLayer();
                Horario_service horarios = new Horario_service();
                Especialidad_service espec = new Especialidad_service();
                IList<Horario> hora = new List<Horario>();
                IList<Especialidad> ESPECIALIDADES = new List<Especialidad>();

                string consulta = "select E.ID_EMPLEADO,E.ID_CATEGORIA,E.NOMBRE,E.APELLIDO,E.DNI,E.FECHA_NAC,E.DIRECCION,E.IDLOCALIDAD,P.IDPROVINCIA,E.TELEFONO,E.EMAIL,E.SEXO,E.ELIMINADO from empleado AS E INNER JOIN LOCALIDAD AS L ON L.IDLOCALIDAD=E.IDLOCALIDAD INNER JOIN PROVINCIA AS P ON P.IDPROVINCIA=L.IDPROVINCIA where ELIMINADO=0 and ID_EMPLEADO=" + aux1.ID_Empleado1;

                cn.setearComandoText(consulta);
                cn.abrirConexion();
                cn.ejecutarQuery();

                while (cn.Lector.Read())
                {
                    aux.ID_Empleado1 = cn.Lector.GetInt32(0);
                    aux.ID_Categoria1 = cn.Lector.GetInt32(1);
                    aux.Nombre1 = cn.Lector.GetString(2);
                    aux.Apellido1 = cn.Lector.GetString(3);
                    aux.DNI1 = cn.Lector.GetString(4);
                    aux.Fecha_Nac1 = Convert.ToString(cn.Lector.GetDateTime(5));
                    aux.Direccion1 = cn.Lector.GetString(6);
                    aux.Localidad = new Localidad() { ID_Localidad1 = cn.Lector.GetInt32(7) };
                    aux.Provincia = new Provincia() { ID_Provincia1 = cn.Lector.GetInt32(8) };
                    aux.Telefono1 = cn.Lector.GetString(9);
                    aux.Email1 = cn.Lector.GetString(10);
                    aux.Sexo1 = cn.Lector.GetBoolean(11);
                    aux.Eliminado1 = cn.Lector.GetBoolean(12);
                    


                }
                ESPECIALIDADES=espec.traerEspecialidades(aux1.ID_Empleado1);
                hora = horarios.BuscarHorario(aux1.ID_Empleado1);
                for (int x=0;x < hora.Count;x++)
                {
                    Horario h = new Horario();
                    h = hora[x];
                    aux.ListaHorarios.Add(h);

                }
                for (int x = 0; x < ESPECIALIDADES.Count; x++)
                {

                    aux.Lista_Especialidades.Add(ESPECIALIDADES[x]);

                }




                return aux;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
