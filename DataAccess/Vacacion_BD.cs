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
    public class Vacacion_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean agregar_vacacion(Vacacion_TO vacacion_to)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO VACACIONES VALUES(@Id_Colaborador, @Fecha_Salida, @Fecha_Regreso, @Dias, @Salario, @Transferencia, @Estado)", conex);
                query.Parameters.AddWithValue("@Id_Colaborador", vacacion_to.Id_Colaborador);
                query.Parameters.AddWithValue("@Fecha_Salida", vacacion_to.Fecha_Salida);
                query.Parameters.AddWithValue("@Fecha_Regreso", vacacion_to.Fecha_Regreso);
                query.Parameters.AddWithValue("@Dias", vacacion_to.Numero_Dias);
                query.Parameters.AddWithValue("@Salario", vacacion_to.Salario);
                query.Parameters.AddWithValue("@Transferencia", vacacion_to.Transferencia);
                query.Parameters.AddWithValue("@Estado", vacacion_to.Estado);
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


        public List<Vacacion_TO> obtener_lista()
        {
            List<Vacacion_TO> lista = new List<Vacacion_TO>();
            Vacacion_TO vacacion_to;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM VACACIONES", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        vacacion_to = new Vacacion_TO();
                        vacacion_to.Id = reader.GetInt32(0);
                        vacacion_to.Id_Colaborador = reader.GetInt32(1);
                        vacacion_to.Fecha_Salida = reader.GetDateTime(2);
                        vacacion_to.Fecha_Regreso = reader.GetDateTime(3);
                        vacacion_to.Numero_Dias = reader.GetInt32(4);
                        vacacion_to.Salario = reader.GetDecimal(5);
                        vacacion_to.Transferencia = reader.GetString(6);
                        vacacion_to.Estado = reader.GetBoolean(7);
                        lista.Add(vacacion_to);
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

        public Boolean eliminar_vacacion(Vacacion_TO vacacion_to)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE VACACIONES SET estado_vacaciones = @Estado WHERE id_vacaciones = @Id", conex);
                query.Parameters.AddWithValue("@Estado", vacacion_to.Estado);
                query.Parameters.AddWithValue("@Id", vacacion_to.Id);

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

        public Boolean editar_vacacion(Vacacion_TO vacacion_to, List<Int32> lista)
        {
            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@Id", vacacion_to.Id);
                query.Parameters.AddWithValue("@Fecha_Salida", vacacion_to.Fecha_Salida);
                query.Parameters.AddWithValue("@Fecha_Regreso", vacacion_to.Fecha_Regreso);
                query.Parameters.AddWithValue("@Dias", vacacion_to.Numero_Dias);
                query.Parameters.AddWithValue("@Salario", vacacion_to.Salario);
                query.Parameters.AddWithValue("@Estado", vacacion_to.Estado);

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
            String mega_query = "UPDATE VACACIONES SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    mega_query += "fecha_salida = @Fecha_Salida,";
                }
                if (x == 1)
                {
                    mega_query += "fecha_regreso = @Fecha_Regreso,";
                }
                if (x == 2)
                {
                    mega_query += "numero_dias = @Dias,";
                }
                if (x == 3)
                {
                    mega_query += "salario_vacaciones = @Salario,";
                }
                if (x == 4)
                {
                    mega_query += "estado_vacaciones = @Estado,";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_vacaciones = @Id";
            return mega_query;
        }

        public List<Vacacion_TO> obtener_lista_fechas(DateTime fecha_inicio, DateTime fecha_fin)
        {
            List<Vacacion_TO> lista = new List<Vacacion_TO>();
            Vacacion_TO vacacion_to;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM VACACIONES  WHERE estado_vacaciones = 1 AND (fecha_salida BETWEEN @Fecha_Inicio AND @Fecha_Fin)", conex);
                query.Parameters.AddWithValue("@Fecha_Inicio", fecha_inicio);
                query.Parameters.AddWithValue("@Fecha_Fin", fecha_fin);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        vacacion_to = new Vacacion_TO();
                        vacacion_to.Id = reader.GetInt32(0);
                        vacacion_to.Id_Colaborador = reader.GetInt32(1);
                        vacacion_to.Fecha_Salida = reader.GetDateTime(2);
                        vacacion_to.Fecha_Regreso = reader.GetDateTime(3);
                        vacacion_to.Numero_Dias = reader.GetInt32(4);
                        vacacion_to.Salario = reader.GetDecimal(5);
                        vacacion_to.Transferencia = reader.GetString(6);
                        vacacion_to.Estado = reader.GetBoolean(7);
                        lista.Add(vacacion_to);
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
