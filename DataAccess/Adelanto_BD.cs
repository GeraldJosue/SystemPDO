using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TransferObjects;
using System.Data;

namespace DataAccess
{
    public class Adelanto_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        
        public Boolean eliminar(Adelanto_TO adelanto)
        {

            try
            {
                SqlCommand query = new SqlCommand("UPDATE ADELANTO SET estado_adelanto = @estado WHERE id_adelanto = @id", conex);
                query.Parameters.AddWithValue("@id", adelanto.Id);
                query.Parameters.AddWithValue("@estado", adelanto.Estado);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

        }

        public Boolean agregar(Adelanto_TO adelanto)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO ADELANTO VALUES(@Colaborador, @fecha, @monto, @estado)", conex);
                query.Parameters.AddWithValue("@Colaborador", adelanto.IdColaborador);
                query.Parameters.AddWithValue("@fecha", adelanto.Fecha);
                query.Parameters.AddWithValue("@monto", adelanto.Monto);
                query.Parameters.AddWithValue("@estado", adelanto.Estado);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

        }

        public Boolean editar(Adelanto_TO adelanto, List<Int32> lista)
        {

            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@id", adelanto.Id);
                query.Parameters.AddWithValue("@colaborador", adelanto.IdColaborador);
                query.Parameters.AddWithValue("@fecha", adelanto.Fecha);
                query.Parameters.AddWithValue("@monto", adelanto.Monto);
                query.Parameters.AddWithValue("@estado", adelanto.Estado);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }


        public List<Adelanto_TO> obtener_lista()
        {
            List< Adelanto_TO> lista = new List<Adelanto_TO>();
            Adelanto_TO adelanto;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM ADELANTO", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        adelanto = new Adelanto_TO();
                        adelanto.Id = reader.GetInt32(0);
                        adelanto.IdColaborador = reader.GetInt32(1);
                        adelanto.Fecha = reader.GetDateTime(2);
                        adelanto.Monto = reader.GetDecimal(3);
                        adelanto.Estado = reader.GetBoolean(4);
                        lista.Add(adelanto);
                    }
                    return lista;
                }
                else
                {
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return lista;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public List<Adelanto_TO> obtener_lista_activos()
        {
            List<Adelanto_TO> lista = new List<Adelanto_TO>();
            Adelanto_TO adelanto;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM AGUINALDO where estado_adelanto = 1", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        adelanto = new Adelanto_TO();
                        adelanto.Id = reader.GetInt32(0);
                        adelanto.IdColaborador = reader.GetInt32(1);
                        adelanto.Fecha = reader.GetDateTime(2);
                        adelanto.Monto = reader.GetDecimal(3);
                        adelanto.Estado = reader.GetBoolean(4);
                        lista.Add(adelanto);
                    }
                    return lista;
                }
                else
                {
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return lista;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }


        public List<Adelanto_TO> obtener_lista_fechas(DateTime fecha_inicio, DateTime fecha_fin)
        {
            List<Adelanto_TO> lista = new List<Adelanto_TO>();
            Adelanto_TO adelanto;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM ADELANTO WHERE estado_adelanto = 1 AND fecha_adelanto BETWEEN @inicio AND @fin", conex);
                query.Parameters.AddWithValue("@inicio", fecha_inicio);
                query.Parameters.AddWithValue("@fin", fecha_fin);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        adelanto = new Adelanto_TO();
                        adelanto.Id = reader.GetInt32(0);
                        adelanto.IdColaborador = reader.GetInt32(1);
                        adelanto.Fecha = reader.GetDateTime(2);
                        adelanto.Monto = reader.GetDecimal(3);
                        adelanto.Estado = reader.GetBoolean(4);
                        lista.Add(adelanto);
                    }
                    return lista;
                }
                else
                {
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return lista;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public String string_query(List<Int32> lista)
        {
            String mega_query = "UPDATE ADELANTO SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    mega_query += "id_colaborador = @colaborador,";
                }
                else if (x == 1)
                {
                    mega_query += "fecha_adelanto = @fecha,";
                }
                else if (x == 2)
                {
                    mega_query += "monto_adelanto = @monto,";
                }
                else if (x == 3)
                {
                    mega_query += "estado_adelanto = @estado,";
                }
            }            
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_adelanto = @id";
            return mega_query;
        }


    }
}

