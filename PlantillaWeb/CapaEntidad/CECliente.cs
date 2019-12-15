using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string tipDoc { get; set; }
        public string numDoc { get; set; }
        public int activo { get; set; }
    }
}
