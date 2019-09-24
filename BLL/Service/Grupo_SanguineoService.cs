using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Grupo_SanguineoService
    {

        public IList<Grupo_Sanguineo> traerTipoDeSangre()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Grupo_Sanguineo> lista = new List<Grupo_Sanguineo>();

            try
            {
                accesoDatos.setearComandoText("SELECT ID_GRUPO_SANGUINEO,NOMBRE FROM GRUPO_SANGUINEO");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Grupo_Sanguineo SANGRE = new Grupo_Sanguineo();
                    SANGRE.ID_Grupo_Sanguineo1 = accesoDatos.Lector.GetInt32(0);
                    SANGRE.Nombre1 = accesoDatos.Lector.GetString(1);
                    lista.Add(SANGRE);
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
