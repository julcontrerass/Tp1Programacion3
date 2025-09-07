using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public string descripcion { get; set; }

        public int idCategoria { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
