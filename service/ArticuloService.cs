using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace service
{
    public class ArticuloService
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDb datos = new AccesoDb();
            try
            {
                datos.setearConsulta("select A.Id , codigo, nombre, A.descripcion, precio , M.id idMarca , M.Descripcion descripcionMarca , C.id idCategoria, C.Descripcion descripcionCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C Where M.id = A.id And C.id = A.id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.precio = Math.Round((decimal)datos.Lector["Precio"], 2);

                    aux.Marca = new Marca();
                    aux.Marca.idMarca = (int)datos.Lector["idMarca"];
                    aux.Marca.descripcion = (string)datos.Lector["descripcionMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.idCategoria = (int)datos.Lector["idCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["descripcionCategoria"];


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

        public void agregar(Articulo nuevo)
        {
            AccesoDb datos = new AccesoDb();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio) VALUES (@codigo, @nombre, @descripcion, @precio)");
                datos.setearParametro("@codigo", nuevo.codigo);
                datos.setearParametro("@nombre", nuevo.nombre);
                datos.setearParametro("@descripcion", nuevo.descripcion);
                datos.setearParametro("@precio", nuevo.precio);
                //datos.setearParametro("@idMarca", nuevo.idMarca);
                //datos.setearParametro("@idCategoria", nuevo.idCategoria);
                datos.ejecutarAccion();
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

        public void modificar(Articulo articulo)
        {
            AccesoDb datos = new AccesoDb();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, Precio = @precio WHERE Id = @id");
                datos.setearParametro("@codigo", articulo.codigo);
                datos.setearParametro("@nombre", articulo.nombre);
                datos.setearParametro("@descripcion", articulo.descripcion);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@id", articulo.id);
                datos.ejecutarLectura();
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

        public void eliminar(int id)
        {

            AccesoDb datos = new AccesoDb();

            try
            {

                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");

                datos.setearParametro("@id", id);
                datos.ejecutarLectura();
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
