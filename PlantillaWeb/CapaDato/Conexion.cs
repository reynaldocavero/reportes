using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class Conexion
    {
        MySqlConnection cn = null;
        public MySqlConnection conectar()
        {
            cn = new MySqlConnection("server=localhost;port=3306;database=promart;user=root;password=");
            return cn;
        }
    }
}
