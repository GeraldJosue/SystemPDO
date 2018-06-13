using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data;

namespace DataAccess
{
    public class Registro_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean agregar(Registro_TO registro)
        {
            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO REGISTRO VALUES (@id_col, @fecha, @entrada, @salida, @desayuno, @cafe, @almuerzo, @horas, @extras, @estado, @proceso)", conex);
                query.Parameters.AddWithValue("@id_col", registro.Id_Colaborador);
                query.Parameters.AddWithValue("@fecha", registro.Fecha);
                query.Parameters.AddWithValue("@entrada", registro.Entrada);
                query.Parameters.AddWithValue("@salida", registro.Salida);
                query.Parameters.AddWithValue("@desayuno", registro.Desayuno);
                query.Parameters.AddWithValue("@cafe", registro.Cafe);
                query.Parameters.AddWithValue("@almuerzo", registro.Almuerzo);
                query.Parameters.AddWithValue("@horas", registro.Horas);
                query.Parameters.AddWithValue("@extras", registro.Extras);
                query.Parameters.AddWithValue("@estado", registro.Estado);
                query.Parameters.AddWithValue("@proceso", registro.Proceso);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                return true;

            }
            catch(Exception ex)
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

        public Boolean eliminar(Registro_TO registro)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE REGISTRO SET estado_registro = @estado WHERE id_registro = @Id", conex);
                query.Parameters.AddWithValue("@Id", registro.Id);
                query.Parameters.AddWithValue("@estado", registro.Estado);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
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
        public Boolean editar(Registro_TO registro, List<Int32> lista)
        {
            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@Id", registro.Id);
                query.Parameters.AddWithValue("@id_col", registro.Id_Colaborador);
                query.Parameters.AddWithValue("@fecha", registro.Fecha);
                query.Parameters.AddWithValue("@entrada", registro.Entrada);
                query.Parameters.AddWithValue("@salida", registro.Salida);
                query.Parameters.AddWithValue("@desayuno", registro.Desayuno);
                query.Parameters.AddWithValue("@cafe", registro.Cafe);
                query.Parameters.AddWithValue("@almuerzo", registro.Almuerzo);
                query.Parameters.AddWithValue("@horas", registro.Horas);
                query.Parameters.AddWithValue("@extras", registro.Extras);
                query.Parameters.AddWithValue("@estado", registro.Estado);
                query.Parameters.AddWithValue("@proceso", registro.Proceso);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
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
        public List<Registro_TO> obtener_registros()
        {
            List<Registro_TO> lista = new List<Registro_TO>();
            Registro_TO registro;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM REGISTRO", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        registro = new Registro_TO();
                        registro.Id = reader.GetInt32(0);
                        registro.Id_Colaborador = reader.GetInt32(1);
                        registro.Fecha = reader.GetDateTime(2);
                        registro.Entrada = reader.GetDateTime(3);
                        registro.Salida = reader.GetDateTime(4);
                        registro.Desayuno = reader.GetDateTime(5);
                        registro.Cafe = reader.GetDateTime(6);
                        registro.Almuerzo = reader.GetDateTime(7);
                        registro.Horas = reader.GetDecimal(8);
                        registro.Extras = reader.GetDecimal(9);
                        registro.Estado = reader.GetBoolean(10);
                        registro.Proceso = reader.GetBoolean(11);

                        lista.Add(registro);
                    }
                    return lista;
                } else
                {
                    return lista;
                }

            }
            catch(Exception ex)
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
            String mega_query = "UPDATE REGISTRO SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    mega_query += "id_colaborador = @id_col,";
                }
                else if (x == 1)
                {
                    mega_query += "fecha_registro = @fecha,";
                }
                else if (x == 2)
                {
                    mega_query += "marca_entrada = @entrada,";
                }
                else if (x == 3)
                {
                    mega_query += "marca_salida = @salida,";
                }
                else if (x == 4)
                {
                    mega_query += "marca_desayuno = @desayuno,";
                }
                else if (x == 5)
                {
                    mega_query += "marca_cafe = @cafe,";
                }
                else if (x == 6)
                {
                    mega_query += "marca_almuerzo = @almuerzo,";
                }
                else if (x == 7)
                {
                    mega_query += "horas_laboradas = @horas,";
                }
                else if (x == 8)
                {
                    mega_query += "horas_extras = @extras,";
                }
                else if (x == 9)
                {
                    mega_query += "estado_registro = @estado,";
                }
                else if (x == 10)
                {
                    mega_query += "proceso_registro = @proceso,";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_registro = @Id";
            return mega_query;
        }
    }
}
