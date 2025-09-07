using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace service
{
    public class MarcaService
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDb datos = new AccesoDb();
            try
            {
                datos.setearConsulta("SELECT id, Descripcion FROM MARCAS ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.id = (int)datos.Lector["Id"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Marca> Filtrar(int id)
        {
            List<Marca> lista = new List<Marca>();
            AccesoDb datos = new AccesoDb();
            try
            {
                datos.setearConsulta("SELECT id, Descripcion FROM MARCAS WHERE id = @id ");
                datos.setearParametro("@id", id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.id = (int)datos.Lector["Id"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



    }
}
