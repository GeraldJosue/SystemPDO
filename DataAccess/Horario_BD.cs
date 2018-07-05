using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace DataAccess
{
    public class Horario_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean agregar(Horario_TO horario)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO HORARIO VALUES(@Nombre, @Hora_Inicio, @Hora_Fin, @Estado, @Horario)", conex);
                query.Parameters.AddWithValue("@Nombre", horario.Nombre_Horario);
                query.Parameters.AddWithValue("@Hora_Inicio", horario.Hora_Inicio);
                query.Parameters.AddWithValue("@Hora_Fin", horario.Hora_Fin);
                query.Parameters.AddWithValue("@Estado", horario.Estado);
                query.Parameters.AddWithValue("@Horario", horario.Horas);
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


        public List<Horario_TO> obtener_lista_activos()
        {
            List<Horario_TO> lista = new List<Horario_TO>();
            Horario_TO horario;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM HORARIO WHERE estado_horario = 1", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        horario = new Horario_TO();
                        horario.Id = reader.GetInt32(0);
                        horario.Nombre_Horario = reader.GetString(1);
                        horario.Hora_Inicio = reader.GetDateTime(2);
                        horario.Hora_Fin = reader.GetDateTime(3);
                        horario.Estado = reader.GetBoolean(4);
                        horario.Horas = reader.GetDecimal(5);
                        lista.Add(horario);
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

        public List<Horario_TO> obtener_lista()
        {
            List<Horario_TO> lista = new List<Horario_TO>();
            Horario_TO horario;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM HORARIO", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        horario = new Horario_TO();
                        horario.Id = reader.GetInt32(0);
                        horario.Nombre_Horario = reader.GetString(1);
                        horario.Hora_Inicio = reader.GetDateTime(2);
                        horario.Hora_Fin = reader.GetDateTime(3);
                        horario.Estado = reader.GetBoolean(4);
                        horario.Horas = reader.GetDecimal(5);
                        lista.Add(horario);
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

        public Boolean eliminar_horario(Horario_TO horario)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE HORARIO SET estado_horario = @Estado WHERE id_horario = @Id", conex);
                query.Parameters.AddWithValue("@Estado", horario.Estado);
                query.Parameters.AddWithValue("@Id", horario.Id);

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

        public Boolean editar(Horario_TO horario, List<Int32> lista)
        {
            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@Id", horario.Id);
                query.Parameters.AddWithValue("@Nombre", horario.Nombre_Horario);
                query.Parameters.AddWithValue("@Hora_Inicio", horario.Hora_Inicio);
                query.Parameters.AddWithValue("@Hora_Fin", horario.Hora_Fin);
                query.Parameters.AddWithValue("@Estado", horario.Estado);
                query.Parameters.AddWithValue("@Horas", horario.Horas);

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

        private String string_query(List<Int32> lista)
        {
            String mega_query = "UPDATE HORARIO SET ";
            foreach(Int32 x in lista)
            {
                if(x == 0)
                {
                    mega_query += "nombre_horario = @Nombre";
                }
                if(x == 1)
                {
                    mega_query += "hora_inicio = @Hora_Inicio";
                }
                if(x == 2)
                {
                    mega_query += "hora_fin = @Hora_Fin";
                }
                if(x == 3)
                {
                    mega_query += "estado_horario = @Estado";
                }
                if(x == 3)
                {
                    mega_query += "horas_totales = @Horas";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_horario = @Id";
            return mega_query;
        }

        public Horario_TO obtener_horario_colaborador(int id_colaborador)
        {
            Horario_TO horario_TO = new Horario_TO();
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM HORARIO INNER JOIN COLABORADOR ON HORARIO.id_horario = COLABORADOR.id_horario WHERE COLABORADOR.id_colaborador = @Id_Colaborador", conex);
                query.Parameters.AddWithValue("@Id_Colaborador", id_colaborador);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        horario_TO.Id = reader.GetInt32(0);
                        horario_TO.Nombre_Horario = reader.GetString(1);
                        horario_TO.Hora_Inicio = reader.GetDateTime(2);
                        horario_TO.Hora_Fin = reader.GetDateTime(3);
                        horario_TO.Estado = reader.GetBoolean(4);
                        horario_TO.Horas = reader.GetDecimal(5);
                    }
                }
                return horario_TO;
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
    }
}
