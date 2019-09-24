using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class LocalidadService
    {

        public IList<Localidad> traerLocalidades(Int32 prov)
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Localidad> lista = new List<Localidad>();

            try
            {
                accesoDatos.setearComandoText("Select IDLOCALIDAD,NOMBRE From LOCALIDAD where IDPROVINCIA ="+ prov);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Localidad loc = new Localidad();
                    loc.ID_Localidad1 = accesoDatos.Lector.GetInt32(0);
                    loc.N_Localidad1 = accesoDatos.Lector.GetString(1);
                    lista.Add(loc);
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
