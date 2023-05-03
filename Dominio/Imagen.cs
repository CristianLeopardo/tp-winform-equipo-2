using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Id { get; set; }

        public string URLImagen { get; set; }

        //public static explicit operator Imagen(string v)
        //{
        //    throw new NotImplementedException();
        //}
        public override string ToString()
        {
            return URLImagen;
        }
    }
}
