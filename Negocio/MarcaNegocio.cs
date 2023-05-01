using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select Id, Descripcion from MARCAS");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Marca obj = new Marca();
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
    }
}
