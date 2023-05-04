﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Reflection;
using System.Globalization;

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
                datos.SetearConsulta("SELECT a.id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Id , m.Descripcion as Marca, c.Id, c.Descripcion as Categoria from ARTICULOS a INNER JOIN MARCAS m on a.IdMarca=m.Id INNER JOIN CATEGORIAS c on a.IdCategoria=c.Id ");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Articulos obj = new Articulos();
                    obj.id = (int)datos.Lector["ID"];
                    obj.Codigo = (string)datos.Lector["Codigo"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];
                    obj.Precio = (decimal)datos.Lector["Precio"];
                    /*if (!(datos.Lector["ImagenUrl"] is DBNull))
                        obj.Imagen2 = (string)datos.Lector["ImagenUrl"];
                    else
                        obj.Imagen2 = "";
                    */

                    obj.marca = new Marca();
                    obj.marca.Id = (int)datos.Lector["ID"];
                    obj.marca.Descripcion = (string)datos.Lector["Marca"];

                    obj.categoria = new Categoria();
                    obj.categoria.Id = (int)datos.Lector["ID"];
                    obj.categoria.Descripcion = (string)datos.Lector["Categoria"];

                   // obj.imagen = new Imagen();
                    //obj.imagen.URLImagen = (string)datos.Lector["ImagenUrl"];

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
        

        public List<Articulos> filtrado(string seleccion, string filtro)
        {
            List<Articulos> lista = new List<Articulos> ();
            Conexion datos = new Conexion();

            try
            {
                string consulta = "SELECT a.id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Id , m.Descripcion as Marca, c.Id, c.Descripcion as Categoria, i.ImagenUrl \r\nfrom ARTICULOS a INNER JOIN MARCAS m on a.IdMarca=m.Id INNER JOIN CATEGORIAS c on a.IdCategoria=c.Id inner join IMAGENES I on I.IdArticulo = a.Id where ";
                switch (seleccion)
                {
                    case "Nombre":
                        consulta += "a.Nombre like '%" + filtro + "%' ";
                        break;
                    case "Marca":
                        consulta += "m.Descripcion like '%" + filtro + "%' ";
                        break;
                    case "Categoria":
                        consulta += "c.Descripcion like '%" + filtro + "%' ";
                        break;
                }
                datos.SetearConsulta(consulta);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Articulos obj = new Articulos();
                    Articulos imglist = new Articulos();
                    obj.id = (int)datos.Lector["ID"];
                    obj.Codigo = (string)datos.Lector["Codigo"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];
                    obj.Precio = (decimal)datos.Lector["Precio"];

                    obj.marca = new Marca();
                    obj.marca.Id = (int)datos.Lector["ID"];
                    obj.marca.Descripcion = (string)datos.Lector["Marca"];

                    obj.categoria = new Categoria();
                    obj.categoria.Id = (int)datos.Lector["ID"];
                    obj.categoria.Descripcion = (string)datos.Lector["Categoria"];

                    //obj.imagen = new Imagen();
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        obj.Imagen2 = (string)datos.Lector["ImagenUrl"];
                    else
                        obj.Imagen2 = "";

                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Agregar(Articulos nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
                datos.Cerraconexion();

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

        
        public void modificar(Articulos art)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idmarca, Idcategoria = @idcategoria, Precio = @precio where id = @id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@desc", art.Descripcion);
                datos.setearParametro("@idmarca", art.marca.Id);
                datos.setearParametro("@idcategoria", art.categoria.Id);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@id", art.id);

                datos.ejecutarAccion();
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
        public List<Articulos> ListarRes()
        {
            List<Articulos> lista = new List<Articulos>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("SELECT a.id, a.Codigo, a.Nombre from ARTICULOS a INNER JOIN MARCAS m on a.IdMarca=m.Id INNER JOIN CATEGORIAS c on a.IdCategoria=c.Id ");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Articulos obj = new Articulos();
                    obj.id = (int)datos.Lector["ID"];
                    obj.Codigo = (string)datos.Lector["Codigo"];
                    obj.Nombre = (string)datos.Lector["Nombre"];

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
