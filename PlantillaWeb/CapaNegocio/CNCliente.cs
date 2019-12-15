using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCliente
    {
        public IEnumerable<CECliente> listaCliente(string xml)
        {
            CDCliente cliente = new CDCliente();
            return cliente.listaCliente(xml);
        }
        public IEnumerable<CECliente> registraCliente(string xml)
        {
            CDCliente cliente = new CDCliente();
            return cliente.registraCliente(xml);
        }
    }
}
