using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class CDCliente
    {

        Conexion objConexion = new Conexion();
        List<CECliente> listCliente = new List<CECliente>();
        CECliente oCliente = null;

        public IEnumerable<CECliente> listaCliente(string xml)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spListaCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("xml", xml);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipDoc = dr.IsDBNull(dr.GetOrdinal("tipDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("tipDoc")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public IEnumerable<CECliente> registraCliente(string xml)
        {
            try
            {

                MySqlConnection cn = objConexion.conectar();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("spRegistraCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("xml", xml);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<CECliente>();
                        while (dr.Read())
                        {
                            oCliente = new CECliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "noData" : dr.GetString(dr.GetOrdinal("nombre")),
                                tipDoc = dr.IsDBNull(dr.GetOrdinal("tipDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("tipDoc")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numDoc = dr.IsDBNull(dr.GetOrdinal("numDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
