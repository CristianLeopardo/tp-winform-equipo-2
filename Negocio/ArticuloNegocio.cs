using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulos> Listar()
        {
            List<Articulos> lista = new List<Articulos>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion as Marca, c.Descripcion as Categoria, i.ImagenUrl from ARTICULOS a INNER JOIN MARCAS m on a.IdMarca=m.Id INNER JOIN CATEGORIAS c on a.IdCategoria=c.Id inner join IMAGENES I on I.IdArticulo = a.Id");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Articulos obj = new Articulos();
                    obj.Codigo = (string)datos.Lector["Codigo"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];
                    obj.Precio = (decimal)datos.Lector["Precio"];

                    obj.marca = new Marca();
                    obj.marca.Descripcion = (string)datos.Lector["Marca"];

                    obj.categoria = new Categoria();
                    obj.categoria.Descripcion = (string)datos.Lector["Categoria"];

                    obj.imagen = new Imagen();
                    obj.imagen.URLImagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.Cerraconexion();
            }
        }
    }
}
