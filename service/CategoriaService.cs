using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace service
{
    public class CategoriaService
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDb datos = new AccesoDb();
            try
            {
                datos.setearConsulta("SELECT id, Descripcion FROM CATEGORIAS ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.idCategoria = (int)datos.Lector["Id"];
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
