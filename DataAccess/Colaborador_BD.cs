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
    public class Colaborador_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean agregar(Colaborador_TO colaborador)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO COLABORADOR VALUES(@Departamento, @Horario, @Nombre, @Apellido, @Segundo, @Cedula, @Telefono, "
                    + "@Direccion, @Fecha, @Civil, @Cuenta, @Entidad, @Nacionalidad, @Precio, @FTelefono, @Parentesco, @FDireccion, @FEstado, @FNombre, @Tipo)", conex);
               
                query.Parameters.AddWithValue("@Departamento", colaborador.Id_departamento);
                query.Parameters.AddWithValue("@Horario", colaborador.Id_horario);
                query.Parameters.AddWithValue("@Nombre", colaborador.Nombre);
                query.Parameters.AddWithValue("@Apellido", colaborador.Apellido);
                query.Parameters.AddWithValue("@Segundo", colaborador.Segundo_apellido);
                query.Parameters.AddWithValue("@Cedula", colaborador.Cedula);
                query.Parameters.AddWithValue("@Telefono", colaborador.Telefono);
                query.Parameters.AddWithValue("@Direccion", colaborador.Direccion);
                query.Parameters.AddWithValue("@Fecha", colaborador.Fecha);
                query.Parameters.AddWithValue("@Civil", colaborador.Estado_civil);
                query.Parameters.AddWithValue("@Cuenta", colaborador.Cuenta);
                query.Parameters.AddWithValue("@Entidad", colaborador.Entidad);
                query.Parameters.AddWithValue("@Nacionalidad", colaborador.Nacionalidad);
                query.Parameters.AddWithValue("@Precio", colaborador.Precio);
                query.Parameters.AddWithValue("@FTelefono", colaborador.FTelefono);
                query.Parameters.AddWithValue("@Parentesco", colaborador.Parentesco);
                query.Parameters.AddWithValue("@FDireccion", colaborador.FDireccion);
                query.Parameters.AddWithValue("@FEstado", colaborador.Estado);
                query.Parameters.AddWithValue("@FNombre", colaborador.FNombre);
                query.Parameters.AddWithValue("@Tipo", colaborador.Tipo_planilla);

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

        public List<Colaborador_TO> obtener_lista()
        {
            List<Colaborador_TO> lista = new List<Colaborador_TO>();
            Colaborador_TO colaborador;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM COLABORADOR", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //JOIN Departamento y Horario
                        //Get a todos los atributos
                        colaborador = new Colaborador_TO();
                        colaborador.Id = reader.GetInt32(0);
                        colaborador.Id_departamento = reader.GetInt32(1);
                        colaborador.Id_horario = reader.GetInt32(2);
                        colaborador.Nombre = reader.GetString(3);
                        colaborador.Apellido = reader.GetString(4);
                        colaborador.Segundo_apellido = reader.GetString(5);
                        colaborador.Cedula = reader.GetInt32(6);
                        colaborador.Telefono = reader.GetInt32(7);
                        colaborador.Direccion = reader.GetString(8);
                        colaborador.Fecha = reader.GetDateTime(9);
                        colaborador.Estado_civil = reader.GetString(10);
                        colaborador.Cuenta = reader.GetString(11);
                        colaborador.Entidad = reader.GetString(12);
                        colaborador.Nacionalidad = reader.GetString(13);
                        colaborador.Precio = reader.GetDecimal(14);
                        colaborador.FTelefono = reader.GetInt32(15);
                        colaborador.Parentesco = reader.GetString(16);
                        colaborador.FDireccion = reader.GetString(17);
                        colaborador.Estado = reader.GetBoolean(18);
                        colaborador.FNombre = reader.GetString(19);
                        colaborador.Tipo_planilla = reader.GetInt32(20);
                        lista.Add(colaborador);
                    }
                    return lista;
                } else
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

        public List<Colaborador_TO> obtener_lista_activos()
        {
            List<Colaborador_TO> lista = new List<Colaborador_TO>();
            Colaborador_TO colaborador;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM COLABORADOR WHERE estado_colaborador = 1", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //JOIN Departamento y Horario
                        colaborador = new Colaborador_TO();
                        colaborador.Id = reader.GetInt32(0);
                        colaborador.Id_departamento = reader.GetInt32(1);
                        colaborador.Id_horario = reader.GetInt32(2);
                        colaborador.Nombre = reader.GetString(3);
                        colaborador.Apellido = reader.GetString(4);
                        colaborador.Segundo_apellido = reader.GetString(5);
                        colaborador.Cedula = reader.GetInt32(6);
                        colaborador.Telefono = reader.GetInt32(7);
                        colaborador.Direccion = reader.GetString(8);
                        colaborador.Fecha = reader.GetDateTime(9);
                        colaborador.Estado_civil = reader.GetString(10);
                        colaborador.Cuenta = reader.GetString(11);
                        colaborador.Entidad = reader.GetString(12);
                        colaborador.Nacionalidad = reader.GetString(13);
                        colaborador.Precio = reader.GetDecimal(14);
                        colaborador.FTelefono = reader.GetInt32(15);
                        colaborador.Parentesco = reader.GetString(16);
                        colaborador.FDireccion = reader.GetString(17);
                        colaborador.Estado = reader.GetBoolean(18);
                        colaborador.FNombre = reader.GetString(19);
                        colaborador.Tipo_planilla = reader.GetInt32(20);
                        lista.Add(colaborador);
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

        public Boolean editar(Colaborador_TO colaborador, List<Int32> lista)
        {
            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@Id", colaborador.Id);
                //query.Parameters.AddWithValue("@Departamento", colaborador.Id_departamento);
                query.Parameters.AddWithValue("@Departamento", 1);
                //query.Parameters.AddWithValue("@Horario", colaborador.Id_horario);
                query.Parameters.AddWithValue("@Horario", 1);
                query.Parameters.AddWithValue("@Nombre", colaborador.Nombre);
                query.Parameters.AddWithValue("@Apellido", colaborador.Apellido);
                query.Parameters.AddWithValue("@Segundo", colaborador.Segundo_apellido);
                query.Parameters.AddWithValue("@Cedula", colaborador.Cedula);
                query.Parameters.AddWithValue("@Telefono", colaborador.Telefono);
                query.Parameters.AddWithValue("@Direccion", colaborador.Direccion);
                query.Parameters.AddWithValue("@Fecha", colaborador.Fecha);
                query.Parameters.AddWithValue("@Civil", colaborador.Estado_civil);
                query.Parameters.AddWithValue("@Cuenta", colaborador.Cuenta);
                query.Parameters.AddWithValue("@Entidad", colaborador.Entidad);
                query.Parameters.AddWithValue("@Nacionalidad", colaborador.Nacionalidad);
                query.Parameters.AddWithValue("@Precio", colaborador.Precio);
                query.Parameters.AddWithValue("@FTelefono", colaborador.FTelefono);
                query.Parameters.AddWithValue("@Parentesco", colaborador.Parentesco);
                query.Parameters.AddWithValue("@FDireccion", colaborador.FDireccion);
                query.Parameters.AddWithValue("@Estado", colaborador.Estado);
                query.Parameters.AddWithValue("@FNombre", colaborador.FNombre);
                query.Parameters.AddWithValue("@Tipo", colaborador.Tipo_planilla);

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

        public Boolean eliminar(Colaborador_TO colaborador)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE COLABORADOR SET estado_colaborador = @Estado WHERE id_colaborador = @Id", conex);
                query.Parameters.AddWithValue("@Estado", colaborador.Estado);
                query.Parameters.AddWithValue("@Id", colaborador.Id);

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

        public String string_query(List<Int32> lista)
        {
            String mega_query = "UPDATE COLABORADOR SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    mega_query += "id_departamento = @Departamento,";
                }
                else if (x == 1)
                {
                    mega_query += "id_horario = @Horario,";
                }
                else if (x == 2)
                {
                    mega_query += "nombre_colaborador = @Nombre,";
                }
                else if (x == 3)
                {
                    mega_query += "primer_apellido = @Apellido,";
                }
                else if (x == 4)
                {
                    mega_query += "segundo_apellido = @Segundo,";
                }
                else if (x == 5)
                {
                    mega_query += "cedula = @Cedula,";
                }
                else if (x == 6)
                {
                    mega_query += "telefono = @Telefono,";
                }
                else if (x == 7)
                {
                    mega_query += "direccion = @Direccion,";
                }
                else if (x == 8)
                {
                    mega_query += "fecha_nacimiento = @Fecha,";
                }
                else if (x == 9)
                {
                    mega_query += "estado_civil = @Civil,";
                }
                else if (x == 10)
                {
                    mega_query += "cuenta_bancaria = @Cuenta,";
                }
                else if (x == 11)
                {
                    mega_query += "entidad_bancaria = @Entidad,";
                }
                else if (x == 12)
                {
                    mega_query += "nacionalidad = @Nacionalidad,";
                }
                else if (x == 13)
                {
                    mega_query += "precio_hora = @Precio,";
                }
                else if (x == 14)
                {
                    mega_query += "telefono_familiar = @FTelefono,";
                }
                else if (x == 15)
                {
                    mega_query += "parentesco = @Parentesco,";
                }
                else if (x == 16)
                {
                    mega_query += "direccion_familiar = @FDireccion,";
                }
                else if (x == 17)
                {
                    mega_query += "estado_colaborador = @Estado,";
                }
                else if (x == 18)
                {
                    mega_query += "nombre_familiar = @FNombre,";
                }
                else if (x == 19)
                {
                    mega_query += "tipo_planilla = @Tipo,";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_colaborador = @Id";
            return mega_query;
        }

        public DateTime obtener_primer_registro (int id_colaborador)
        {
            DateTime primer_registro = new DateTime();
            try
            {
                SqlCommand query = new SqlCommand("SELECT MIN(fecha_registro) FROM REGISTRO INNER JOIN COLABORADOR ON REGISTRO.id_colaborador = COLABORADOR.id_colaborador WHERE COLABORADOR.id_colaborador = @Id_Colaborador", conex);
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
                        primer_registro = reader.GetDateTime(0);
                    }   
                }
                return primer_registro;

            }
            catch (Exception ex)
            {
                return primer_registro;
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public Colaborador_TO obtener_precio_hora(int id_coloborador)
        {
            Colaborador_TO colaborador_TO = new Colaborador_TO();
            try
            {
                SqlCommand query = new SqlCommand("SELECT precio_hora FROM COLABORADOR WHERE id_colaborador = @Id_Colaborador", conex);
                query.Parameters.AddWithValue("@Id_Colaborador", id_coloborador);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        colaborador_TO.Precio = reader.GetDecimal(0);
                    }
                }
                return colaborador_TO;

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

        public Colaborador_TO obtener_nombre(int id_coloborador)
        {
            Colaborador_TO colaborador_TO = new Colaborador_TO();
            try
            {
                SqlCommand query = new SqlCommand("SELECT nombre_colaborador, primer_apellido, segundo_apellido FROM COLABORADOR WHERE id_colaborador = @Id_Colaborador", conex);
                query.Parameters.AddWithValue("@Id_Colaborador", id_coloborador);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        colaborador_TO.Nombre = reader.GetString(0);
                        colaborador_TO.Apellido = reader.GetString(1);
                        colaborador_TO.Segundo_apellido = reader.GetString(2);
                    }
                }
                return colaborador_TO;

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
