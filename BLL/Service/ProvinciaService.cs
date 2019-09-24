using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class ProvinciaService
    {
        public IList<Provincia> traerProvincias()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Provincia> lista = new List<Provincia>();

            try
            {
                accesoDatos.setearComandoText("select IDPROVINCIA,NOMBRE from PROVINCIA");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Provincia Pro = new Provincia();
                    Pro.ID_Provincia1 = accesoDatos.Lector.GetInt32(0);
                    Pro.N_Provincia1 = accesoDatos.Lector.GetString(1);
                    lista.Add(Pro);
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
