using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BLL
{
    public class Paciente_service
    {
        public int CalcularEdad(DateTime Fech)
        {
            DateTime fecha = new DateTime();
            fecha = Fech;
            int Edad;
            int mes = fecha.Month;
            int año = fecha.Year;
            int dia = fecha.Day;
            Edad = DateTime.Today.Year - año;
            if (mes >= DateTime.Today.Month)
            {
                if (dia >= DateTime.Today.Day)
                {
                    return Edad - 1;
                }

            }
            return Edad;

        }
        public IList<Paciente> traerTodosPacientes()
        {
            //conexion
            SqlConnection conexion = new SqlConnection();
            //consulta
            SqlCommand comando = new SqlCommand();
            //lector
            SqlDataReader lector;
            //la lista que vamos a devolver
            IList<Paciente> lista = new List<Paciente>();

            try
            {

                conexion.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT P.ID_PACIENTE,P.NOMBRE,P.APELLIDO,P.DNI,P.FECHA_NAC,P.SEXO,P.DIRECCION,PV.NOMBRE,PV.IDPROVINCIA,L.NOMBRE,L.IDLOCALIDAD,L.IDPROVINCIA,P.TELEFONO,P.EMAIL,P.OBS,P.ID_EMPLEADO,A.ID_ANTECEDENTE,A.ID_PACIENTE,A.ALTURA,A.PESO,A.ID_GRUPO_S FROM PACIENTE AS P  INNER JOIN LOCALIDAD AS L ON P.IDLOCALIDAD=L.IDLOCALIDAD INNER JOIN PROVINCIA AS PV ON L.IDPROVINCIA=PV.IDPROVINCIA INNER JOIN ANTECEDENTE AS A ON P.ID_PACIENTE=A.ID_PACIENTE INNER JOIN EMPLEADO AS E ON P.ID_EMPLEADO=E.ID_EMPLEADO WHERE P.ELIMINADO=0 AND P.";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //Paciente aux = new Paciente();
                    //aux.ID_Paciente1 = conexion.Lector.GetInt32(0);
                    //aux.Nombre1 = conexion.Lector.GetString(1);
                    //aux.Apellido1 = conexion.Lector.GetString(2);
                    //aux.DNI1 = conexion.Lector.GetString(3);
                    //aux.Fecha_Nac1 = Convert.ToString(conexion.Lector.GetDateTime(4));
                    //aux.Edad1 = CalcularEdad(conexion.Lector.GetDateTime(4));
                    //aux.Sexo1 = conexion.Lector.GetBoolean(5);
                    //aux.Direccion1 = conexion.Lector.GetString(6);
                    //aux.Provincia = new Provincia() { N_Provincia1 = conexion.Lector.GetString(7), ID_Provincia1 = conexion.Lector.GetInt32(8) };
                    //aux.Localidad = new Localidad() { ID_Localidad1 = conexion.Lector.GetInt32(10), N_Localidad1 = conexion.Lector.GetString(9), ID_Provincia1 = conexion.Lector.GetInt32(11) };
                    //aux.Telefono1 = conexion.Lector.GetString(12);
                    //aux.Email1 = conexion.Lector.GetString(13);
                    //aux.Obs1 = conexion.Lector.GetString(14);
                    //aux.InicialesEmp1 = conexion.Lector.GetInt32(15);
                    //aux.Antecedente = new Antecedente() { ID_Antecedente1 = conexion.Lector.GetInt32(16), ID_Paciente1 = conexion.Lector.GetInt32(17), Altura1 = conexion.Lector.GetDecimal(18), Peso1 = conexion.Lector.GetDecimal(19), ID_Grupo_Sanguineo1 = conexion.Lector.GetInt32(20) };


                    //lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }

        }

        public void GuardarPaciente(Paciente Nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            Antecedente_Service Antecedente_S = new Antecedente_Service();
            Alergias_X_Paciente_Service Alergia_s = new Alergias_X_Paciente_Service();
            MedicamentoXpaciente_Service Medicamentos = new MedicamentoXpaciente_Service();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_AGREGAR_PACIENTE";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@NOMBRE", Nuevo.Nombre1);
                cm.Parameters.AddWithValue("@APELLIDO", Nuevo.Apellido1);
                cm.Parameters.AddWithValue("@DNI", Nuevo.DNI1);
                cm.Parameters.AddWithValue("@FECHA_NAC",Convert.ToDateTime(Nuevo.Fecha_Nac1));
                cm.Parameters.AddWithValue("@DIRECCION", Nuevo.Direccion1);
                cm.Parameters.AddWithValue("@IDLOCALIDAD", Nuevo.Localidad.ID_Localidad1);
                cm.Parameters.AddWithValue("@TELEFONO", Nuevo.Telefono1);
                cm.Parameters.AddWithValue("@EMAIL", Nuevo.Email1);
                cm.Parameters.AddWithValue("@SEXO", Nuevo.Sexo1);
                cm.Parameters.AddWithValue("@OBS", Nuevo.Obs1);
                cm.Parameters.AddWithValue("@ID_EMPLEADO", Nuevo.InicialesEmp1);
                cm.Parameters.AddWithValue("@ELIMINADO", Nuevo.Eliminado);

                cn.Open();
               


                Nuevo.ID_Paciente1 = Convert.ToInt32(cm.ExecuteScalar());
              

                Antecedente_S.GuardarAntecedente(Nuevo.ID_Paciente1, Nuevo);
                for (int i = 0; i < Nuevo.Lista_Alergias.Count; i++)
                {
                    Alergia_s.GuardarListaAlergias(Nuevo.ID_Paciente1, Nuevo.Lista_Alergias[i].ID_Alergia1, false);
                }
                for (int i = 0; i < Nuevo.Lista_Medicamentos.Count; i++)
                {
                  Medicamentos.GuardarListaMedicamento(Nuevo.ID_Paciente1, Nuevo.Lista_Medicamentos[i].ID_Medicamento1, false);
                }


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




        public IList<Paciente> BuscarPaciente(string campo, string clave,string dni)
        {
            try
            {
                IList<Paciente> Lista = new List<Paciente>();
                string consulta = "SELECT P.ID_PACIENTE,P.NOMBRE,P.APELLIDO,P.DNI,P.FECHA_NAC,P.SEXO,P.DIRECCION,PV.NOMBRE,PV.IDPROVINCIA,L.NOMBRE,L.IDLOCALIDAD,L.IDPROVINCIA,P.TELEFONO,P.EMAIL,P.OBS,P.ID_EMPLEADO,A.ID_ANTECEDENTE,A.ID_PACIENTE,A.ALTURA,A.PESO,A.ID_GRUPO_S FROM PACIENTE AS P  INNER JOIN LOCALIDAD AS L ON P.IDLOCALIDAD=L.IDLOCALIDAD INNER JOIN PROVINCIA AS PV ON L.IDPROVINCIA=PV.IDPROVINCIA INNER JOIN ANTECEDENTE AS A ON P.ID_PACIENTE=A.ID_PACIENTE INNER JOIN EMPLEADO AS E ON P.ID_EMPLEADO=E.ID_EMPLEADO WHERE P.ELIMINADO=0 AND P.";

                DataAccessLayer conexion = new DataAccessLayer();

                switch (campo)
                {
                    case "Nombre":
                        consulta = consulta + campo + " Like '%" + clave + "%'";
                        break;
                    case "Apellido":
                        consulta = consulta + campo + " Like '%" + clave + "%'";
                        break;
                    case "DNI":
                        consulta = consulta + campo + " Like '%" + dni + "%'";
                        break;
                }

                conexion.setearComandoText(consulta);
                conexion.abrirConexion();
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.ID_Paciente1 = conexion.Lector.GetInt32(0);
                    aux.Nombre1 = conexion.Lector.GetString(1);
                    aux.Apellido1 = conexion.Lector.GetString(2);
                    aux.DNI1 = conexion.Lector.GetString(3);
                    aux.Fecha_Nac1 = Convert.ToString(conexion.Lector.GetDateTime(4));
                    aux.Edad1 = CalcularEdad(conexion.Lector.GetDateTime(4));
                    aux.Sexo1 = conexion.Lector.GetBoolean(5);
                    aux.Direccion1 = conexion.Lector.GetString(6);
                    aux.Provincia = new Provincia() { N_Provincia1 = conexion.Lector.GetString(7), ID_Provincia1 = conexion.Lector.GetInt32(8) };
                    aux.Localidad = new Localidad() { ID_Localidad1 = conexion.Lector.GetInt32(10), N_Localidad1 = conexion.Lector.GetString(9), ID_Provincia1 = conexion.Lector.GetInt32(11) };
                    aux.Telefono1 = conexion.Lector.GetString(12);
                    aux.Email1 = conexion.Lector.GetString(13);
                    aux.Obs1 = conexion.Lector.GetString(14);
                    aux.InicialesEmp1 = conexion.Lector.GetInt32(15);
                    aux.Antecedente = new Antecedente() { ID_Antecedente1 = conexion.Lector.GetInt32(16), ID_Paciente1 = conexion.Lector.GetInt32(17), Altura1 = conexion.Lector.GetDecimal(18), Peso1 = conexion.Lector.GetDecimal(19), ID_Grupo_Sanguineo1 = conexion.Lector.GetInt32(20) };


                    Lista.Add(aux);
                }
                return Lista;
                            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ModificarPaciente(Paciente Nuevo,Int32 id_empleado)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            Antecedente_Service Antecedente_S = new Antecedente_Service();
            Alergias_X_Paciente_Service Alergia_s = new Alergias_X_Paciente_Service();
            MedicamentoXpaciente_Service Medicamentos = new MedicamentoXpaciente_Service();

            try
            {
                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Connection = cn;
                cm.CommandText = "SP_MODIFICAR_PACIENTE";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID_PACIENTE", Nuevo.ID_Paciente1);
                cm.Parameters.AddWithValue("@NOMBRE", Nuevo.Nombre1);
                cm.Parameters.AddWithValue("@APELLIDO", Nuevo.Apellido1);
                cm.Parameters.AddWithValue("@DNI", Nuevo.DNI1);
                cm.Parameters.AddWithValue("@FECHA_NAC", Convert.ToDateTime(Nuevo.Fecha_Nac1));
                cm.Parameters.AddWithValue("@DIRECCION", Nuevo.Direccion1);
                cm.Parameters.AddWithValue("@IDLOCALIDAD", Nuevo.Localidad.ID_Localidad1);
                cm.Parameters.AddWithValue("@TELEFONO", Nuevo.Telefono1);
                cm.Parameters.AddWithValue("@EMAIL", Nuevo.Email1);
                cm.Parameters.AddWithValue("@SEXO", Nuevo.Sexo1);
                cm.Parameters.AddWithValue("@OBS", Nuevo.Obs1);
                cm.Parameters.AddWithValue("@ID_EMPLEADO", id_empleado);
                cm.Parameters.AddWithValue("@ELIMINADO", Nuevo.Eliminado);

                cn.Open();
                cm.ExecuteNonQuery();
                
                Antecedente_S.ModificarAntecedente(Nuevo.Antecedente.ID_Paciente1, Nuevo.Antecedente.ID_Grupo_Sanguineo1,Nuevo.Antecedente.Peso1, Nuevo.Antecedente.Altura1);
                List<Medicamento_X> todos = new List<Medicamento_X>(); 
                todos=Medicamentos.TraerMedicamntos_P(Nuevo.ID_Paciente1);


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

        public void EliminarPaciente(Paciente Nuevo)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {

                cn.ConnectionString = "Data Source=LOCAL\\SQLEXPRESS;Initial Catalog=CLINICA_TOLOZA;Integrated Security=True";
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;

                cm.CommandText = "update PACIENTE Set ELIMINADO=1 Where ID_PACIENTE = " + Nuevo.ID_Paciente1;
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

        public Paciente BuscarPaciente(string dni)
        {
            try
            {
                Paciente aux = new Paciente();
                string consulta = "SELECT P.ID_PACIENTE,P.NOMBRE,P.APELLIDO,P.DNI,P.FECHA_NAC,P.SEXO,P.DIRECCION,PV.NOMBRE,PV.IDPROVINCIA,L.NOMBRE,L.IDLOCALIDAD,L.IDPROVINCIA,P.TELEFONO,P.EMAIL,P.OBS,P.ID_EMPLEADO,A.ID_ANTECEDENTE,A.ID_PACIENTE,A.ALTURA,A.PESO,A.ID_GRUPO_S FROM PACIENTE AS P  INNER JOIN LOCALIDAD AS L ON P.IDLOCALIDAD=L.IDLOCALIDAD INNER JOIN PROVINCIA AS PV ON L.IDPROVINCIA=PV.IDPROVINCIA INNER JOIN ANTECEDENTE AS A ON P.ID_PACIENTE=A.ID_PACIENTE INNER JOIN EMPLEADO AS E ON P.ID_EMPLEADO=E.ID_EMPLEADO WHERE P.ELIMINADO=0 AND P.";

                DataAccessLayer conexion = new DataAccessLayer();

               
                
                consulta = consulta + "DNI" + " Like '%" + dni + "%'";
                        
                

                conexion.setearComandoText(consulta);
                conexion.abrirConexion();
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {

                    aux.ID_Paciente1 = conexion.Lector.GetInt32(0);
                    aux.Nombre1 = conexion.Lector.GetString(1);
                    aux.Apellido1 = conexion.Lector.GetString(2);
                    aux.DNI1 = conexion.Lector.GetString(3);
                    aux.Fecha_Nac1 = Convert.ToString(conexion.Lector.GetDateTime(4));
                    aux.Edad1 = CalcularEdad(conexion.Lector.GetDateTime(4));
                    aux.Sexo1 = conexion.Lector.GetBoolean(5);
                    aux.Direccion1 = conexion.Lector.GetString(6);
                    aux.Provincia = new Provincia() { N_Provincia1 = conexion.Lector.GetString(7), ID_Provincia1 = conexion.Lector.GetInt32(8) };
                    aux.Localidad = new Localidad() { ID_Localidad1 = conexion.Lector.GetInt32(10), N_Localidad1 = conexion.Lector.GetString(9), ID_Provincia1 = conexion.Lector.GetInt32(11) };
                    aux.Telefono1 = conexion.Lector.GetString(13);
                    aux.Email1 = conexion.Lector.GetString(14);
                    aux.Obs1 = conexion.Lector.GetString(15);
                    aux.InicialesEmp1 = conexion.Lector.GetInt32(16);
                    aux.Antecedente = new Antecedente() { ID_Antecedente1 = conexion.Lector.GetInt32(17), ID_Paciente1 = conexion.Lector.GetInt32(18), Altura1 = conexion.Lector.GetDecimal(19), Peso1 = conexion.Lector.GetDecimal(20), ID_Grupo_Sanguineo1 = conexion.Lector.GetInt32(21) };




                }
                return aux;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Paciente BuscarPaciente(int id)
        {
            try
            {
                Paciente aux = new Paciente();
                string consulta = "SELECT P.ID_PACIENTE,P.NOMBRE,P.APELLIDO,P.DNI,P.FECHA_NAC,P.SEXO,P.DIRECCION,PV.NOMBRE,PV.IDPROVINCIA,L.NOMBRE,L.IDLOCALIDAD,L.IDPROVINCIA,P.TELEFONO,P.EMAIL,P.OBS,P.ID_EMPLEADO,A.ID_ANTECEDENTE,A.ID_PACIENTE,A.ALTURA,A.PESO,A.ID_GRUPO_S FROM PACIENTE AS P  INNER JOIN LOCALIDAD AS L ON P.IDLOCALIDAD=L.IDLOCALIDAD INNER JOIN PROVINCIA AS PV ON L.IDPROVINCIA=PV.IDPROVINCIA INNER JOIN ANTECEDENTE AS A ON P.ID_PACIENTE=A.ID_PACIENTE INNER JOIN EMPLEADO AS E ON P.ID_EMPLEADO=E.ID_EMPLEADO WHERE P.ELIMINADO=0 AND P.";

                DataAccessLayer conexion = new DataAccessLayer();



                consulta = consulta + "ID_PACIENTE" + " Like '%" + id + "%'";



                conexion.setearComandoText(consulta);
                conexion.abrirConexion();
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {

                    aux.ID_Paciente1 = conexion.Lector.GetInt32(0);
                    aux.Nombre1 = conexion.Lector.GetString(1);
                    aux.Apellido1 = conexion.Lector.GetString(2);
                    aux.DNI1 = conexion.Lector.GetString(3);
                    aux.Fecha_Nac1 = Convert.ToString(conexion.Lector.GetDateTime(4));
                    aux.Edad1 = CalcularEdad(conexion.Lector.GetDateTime(4));
                    aux.Sexo1 = conexion.Lector.GetBoolean(5);
                    aux.Direccion1 = conexion.Lector.GetString(6);
                    aux.Provincia = new Provincia() { N_Provincia1 = conexion.Lector.GetString(7), ID_Provincia1 = conexion.Lector.GetInt32(8) };
                    aux.Localidad = new Localidad() { ID_Localidad1 = conexion.Lector.GetInt32(10), N_Localidad1 = conexion.Lector.GetString(9), ID_Provincia1 = conexion.Lector.GetInt32(11) };
                    aux.Telefono1 = conexion.Lector.GetString(13);
                    aux.Email1 = conexion.Lector.GetString(14);
                    aux.Obs1 = conexion.Lector.GetString(15);
                    aux.InicialesEmp1 = conexion.Lector.GetInt32(16);
                    aux.Antecedente = new Antecedente() { ID_Antecedente1 = conexion.Lector.GetInt32(17), ID_Paciente1 = conexion.Lector.GetInt32(18), Altura1 = conexion.Lector.GetDecimal(19), Peso1 = conexion.Lector.GetDecimal(20), ID_Grupo_Sanguineo1 = conexion.Lector.GetInt32(21) };




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
    

