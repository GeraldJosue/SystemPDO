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
    public class Departamento_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Departamento_TO solicitarDepartamento(Departamento_TO departamento)
        {

            try
            {

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }
                Departamento_TO departamento_to = new Departamento_TO();

                SqlCommand query = new SqlCommand("SELECT * FROM DEPARTAMENTO WHERE nombre_departamento = @nombre", conex);
                query.Parameters.AddWithValue("@nombre", departamento.Nombre);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    departamento_to.Id = reader.GetInt32(0);
                    departamento_to.Nombre = reader.GetString(1);
                    departamento_to.Estado = reader.GetBoolean(2);
                }
                return departamento_to;
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



        public Boolean eliminar(Departamento_TO departamento)
        {

            try
            {
                SqlCommand query = new SqlCommand("UPDATE DEPARTAMENTO SET estado_departamento = @estado WHERE id_departamento = @id", conex);
                query.Parameters.AddWithValue("@id", departamento.Id);
                query.Parameters.AddWithValue("@estado", departamento.Estado);

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

        public Boolean agregar(Departamento_TO departamento)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO DEPARTAMENTO VALUES(@nombre, @estado)", conex);

                query.Parameters.AddWithValue("@nombre", departamento.Nombre);               
                query.Parameters.AddWithValue("@estado", departamento.Estado);

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

        public Boolean editar(Departamento_TO departamento, List<Int32> lista)
        {

            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@id", departamento.Id);
                query.Parameters.AddWithValue("@nombre", departamento.Nombre);
                query.Parameters.AddWithValue("@estado", departamento.Estado);


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


        public List<Departamento_TO> obtener_lista()
        {
            List<Departamento_TO> lista = new List<Departamento_TO>();
            Departamento_TO departamento;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM DEPARTAMENTO", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        departamento = new Departamento_TO();
                        departamento.Id = reader.GetInt32(0);
                        departamento.Nombre = reader.GetString(1);
                        departamento.Estado = reader.GetBoolean(2);
                        lista.Add(departamento);
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
            String mega_query = "UPDATE DEPARTAMENTO SET ";
            foreach (Int32 x in lista)
            {
                if (x == 0)
                {
                    mega_query += "nombre_departamento = @nombre,";
                }
                else if (x == 1)
                {                    
                    mega_query += "estado_departamento = @estado,";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_departamento = @id";
            return mega_query;
        }


    }

}
