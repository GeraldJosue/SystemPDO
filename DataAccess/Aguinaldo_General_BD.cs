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
    public class Aguinaldo_General_BD
    {

        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean eliminar(Aguinaldo_General_TO aguinaldo_general)
        {

            try
            {
                SqlCommand query = new SqlCommand("UPDATE AGUINALDO_GENERAL SET estado_general = @estado WHERE Id = @Id", conex);

                query.Parameters.AddWithValue("@Id", aguinaldo_general.Id);
                query.Parameters.AddWithValue("@estado", aguinaldo_general.Estado);

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

        public Boolean agregar(Aguinaldo_General_TO aguinaldo_general)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO AGUINALDO_GENERAL VALUES(@id, @fecha, @monto, @estado)", conex);

                query.Parameters.AddWithValue("@id", aguinaldo_general.Id);
                query.Parameters.AddWithValue("@fecha", aguinaldo_general.Fecha);
                query.Parameters.AddWithValue("@monto", aguinaldo_general.Monto);                
                query.Parameters.AddWithValue("@estado", aguinaldo_general.Estado);
                

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


        public Boolean editar(Aguinaldo_General_TO aguinaldo, List<Int32> lista)
        {

            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@id", aguinaldo.Id);               
                query.Parameters.AddWithValue("@fecha", aguinaldo.Fecha);
                query.Parameters.AddWithValue("@monto", aguinaldo.Monto);                
                query.Parameters.AddWithValue("@estado_general", aguinaldo.Estado);


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


        public List<Aguinaldo_General_TO> obtener_lista()
        {
            List<Aguinaldo_General_TO> lista = new List<Aguinaldo_General_TO>();
            Aguinaldo_General_TO aguinaldo;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM AGUINALDO_GENERAL", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aguinaldo = new Aguinaldo_General_TO();
                        aguinaldo.Id = reader.GetInt32(0);
                        aguinaldo.Fecha = reader.GetDateTime(1);
                        aguinaldo.Monto = reader.GetDecimal(2);                       
                        aguinaldo.Estado = reader.GetBoolean(3);
                        lista.Add(aguinaldo);
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
            String mega_query = "UPDATE AGUINALDO_GENERAL SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    mega_query += "Fecha = @fecha,";
                }
                else if (x == 1)
                {
                    mega_query += "Monto = @monto,";
                }               
                else if (x == 2)
                {
                    mega_query += "estado_general = @estado,";
                }
               
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE Id = @id";
            return mega_query;
        }



        public List<Aguinaldo_General_TO> obtener_lista_activos()
        {
            List<Aguinaldo_General_TO> lista = new List<Aguinaldo_General_TO>();
            Aguinaldo_General_TO aguinaldo;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM AGUINALDO_GENERAL WHERE estado_general = 1", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aguinaldo = new Aguinaldo_General_TO();
                        aguinaldo.Id = reader.GetInt32(0);                       
                        aguinaldo.Fecha = reader.GetDateTime(1);
                        aguinaldo.Monto = reader.GetDecimal(2);
                        aguinaldo.Estado = reader.GetBoolean(3);                       
                        lista.Add(aguinaldo);
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



    }
}
