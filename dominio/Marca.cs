using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dominio
{
    public class Marca
    {
        public string descripcion { get; set; }

        public int idMarca { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
