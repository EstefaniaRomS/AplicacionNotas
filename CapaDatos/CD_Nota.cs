using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Nota
    {
        public List<Nota> Listar()
        {
            List<Nota> lista = new List<Nota>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdNota,TituloNota,ContenidoNota from nota");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Nota()
                            {
                                IdNota = Convert.ToInt32(dr["IdNota"]),
                                TituloNota = dr["TituloNota"].ToString(),
                                ContenidoNota = dr["ContenidoNota"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Nota>();
                }
            }
            return lista;
        }
        public static void Registrar(Nota obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARNOTA", oconexion);

                    cmd.Parameters.AddWithValue("IdNota", obj.IdNota);
                    cmd.Parameters.AddWithValue("TituloNota", obj.TituloNota);
                    cmd.Parameters.AddWithValue("ContenidoNota", obj.ContenidoNota);

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
            }
        }
        public static void Eliminar(Nota obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARNOTA", oconexion);

                    cmd.Parameters.AddWithValue("IdNota", obj.IdNota);

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
 }

