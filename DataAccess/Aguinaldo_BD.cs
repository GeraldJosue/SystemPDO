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
    public class Aguinaldo_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Aguinaldo_TO solicitarAguinaldo(Aguinaldo_TO aguinaldo)
        {

            try
            {

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }
                Aguinaldo_TO aguinaldo_to = new Aguinaldo_TO();

                SqlCommand query = new SqlCommand("SELECT * FROM AGUINALDO WHERE id_colaborador = @idColaborador", conex);
                query.Parameters.AddWithValue("@idColaborador", aguinaldo.IdColaborador);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    aguinaldo_to.Id = reader.GetInt32(0);
                    aguinaldo_to.IdColaborador = reader.GetInt32(1);
                    aguinaldo_to.FechaAguinaldo = reader.GetDateTime(2);
                    aguinaldo_to.Salario = reader.GetDecimal(3);
                    aguinaldo_to.TransferenciaAguinaldo = reader.GetString(4);
                    aguinaldo_to.EstadoAguinaldo = reader.GetBoolean(5);
                }
                return aguinaldo_to;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }


        public Boolean eliminar(Aguinaldo_TO aguinaldo) {

            try
            {
                SqlCommand query = new SqlCommand("UPDATE AGUINALDO SET estado_aguinaldo = @estado WHERE id_aguinaldo = @Id", conex);
                
                query.Parameters.AddWithValue("@Id", aguinaldo.Id);
                query.Parameters.AddWithValue("@estado", aguinaldo.EstadoAguinaldo);

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

        public Boolean agregar(Aguinaldo_TO aguinaldo)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO AGUINALDO VALUES(@colaborador, @fecha, @salario, @transferencia, @estado)", conex);

                query.Parameters.AddWithValue("@colaborador", aguinaldo.IdColaborador);                
                query.Parameters.AddWithValue("@fecha", aguinaldo.FechaAguinaldo);
                query.Parameters.AddWithValue("@salario", aguinaldo.Salario);
                query.Parameters.AddWithValue("@transferencia", aguinaldo.TransferenciaAguinaldo);               
                query.Parameters.AddWithValue("@estado", aguinaldo.EstadoAguinaldo);

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

        public Boolean editar(Aguinaldo_TO aguinaldo, List<Int32> lista)
        {

            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@id", aguinaldo.Id);
                //query.Parameters.AddWithValue("@colaborador", aguinaldo.IdColaborador);
                query.Parameters.AddWithValue("@fecha", aguinaldo.FechaAguinaldo);
                query.Parameters.AddWithValue("@salario", aguinaldo.Salario);
                query.Parameters.AddWithValue("@transferencia", aguinaldo.TransferenciaAguinaldo);
                query.Parameters.AddWithValue("@estado", aguinaldo.EstadoAguinaldo);


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


        public List<Aguinaldo_TO> obtener_lista()
        {
            List<Aguinaldo_TO> lista = new List<Aguinaldo_TO>();
            Aguinaldo_TO aguinaldo;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM AGUINALDO", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                        
                        aguinaldo = new Aguinaldo_TO();
                        aguinaldo.Id = reader.GetInt32(0);
                        aguinaldo.IdColaborador = reader.GetInt32(1);
                        aguinaldo.FechaAguinaldo = reader.GetDateTime(2);
                        aguinaldo.Salario = reader.GetDecimal(3);
                        aguinaldo.TransferenciaAguinaldo = reader.GetString(4);
                        aguinaldo.EstadoAguinaldo = reader.GetBoolean(5);
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
            String mega_query = "UPDATE AGUINALDO SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    //mega_query += "id_colaborador = @colaborador,";
                    mega_query += "fecha_aguinaldo = @fecha,";
                }
                else if (x == 1)
                {
                    mega_query += "salario_aguinaldo = @salario,";
                }
                else if (x == 2)
                {
                    mega_query += "transferencia_aguinaldo = @transferencia,";
                }
                else if (x == 3)
                {
                    mega_query += "estado_aguinaldo = @estado,";
                }                
                //else if (x == 4)
                //{
                //    mega_query += "estado_aguinaldo = @estado,";
                //}
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_aguinaldo = @id";
            return mega_query;
        }

        public List<Adelanto_TO> obtener_lista_activos()
        {
            List<Adelanto_TO> lista = new List<Adelanto_TO>();
            Adelanto_TO adelanto;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM AGUINALDO WHERE estado_aguinaldo = 1", conex);

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

    }

}
