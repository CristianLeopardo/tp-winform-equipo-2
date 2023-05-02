using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarMarcas()
        {
            List<Categoria> lista = new List<Categoria>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Categoria obj = new Categoria();
                    obj.Id = (int)datos.Lector["Id"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];

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
        public void AgregarCategoria(Categoria categoria)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.SetearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                conexion.setearParametro("@Descripcion", categoria.Descripcion);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerraconexion();
            }
        }
    }
}
