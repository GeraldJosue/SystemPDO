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
    public class Planilla_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean agregar(Planilla_TO planilla)
        {
            try
            {

                SqlCommand query = new SqlCommand("INSERT INTO PLANILLA VALUES(@Id, @Inicio, @Fin, @Total, @Tipo, @Estado)", conex);
                query.Parameters.AddWithValue("@Id", planilla.Id);
                query.Parameters.AddWithValue("Inicio", planilla.Fecha_inicio);
                query.Parameters.AddWithValue("Fin", planilla.Fecha_fin);
                query.Parameters.AddWithValue("Total", planilla.Total);
                query.Parameters.AddWithValue("Tipo", planilla.Tipo);
                query.Parameters.AddWithValue("Estado", planilla.Estado);

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
                if (conex.State != ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public Boolean eliminar(Planilla_TO planilla)
        {

            try
            {
                SqlCommand query = new SqlCommand("UPDATE PLANILLA SET estado_planilla = @estado WHERE id_planilla = @id", conex);

                query.Parameters.AddWithValue("@id", planilla.Id);
                query.Parameters.AddWithValue("@estado", planilla.Estado);

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
        public List<Planilla_TO> obtener_lista()
        {
            List<Planilla_TO> lista = new List<Planilla_TO>();
            Planilla_TO planilla;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM PLANILLA", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        planilla = new Planilla_TO();
                        planilla.Id = reader.GetInt32(0);
                        planilla.Fecha_inicio = reader.GetDateTime(1);
                        planilla.Fecha_fin = reader.GetDateTime(2);
                        planilla.Total = reader.GetDecimal(3);
                        planilla.Tipo = reader.GetInt32(4);
                        planilla.Estado = reader.GetBoolean(5);
                        lista.Add(planilla);
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
                if(conex.State != ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public List<Planilla_TO> obtener_lista_activos()
        {
            List<Planilla_TO> lista = new List<Planilla_TO>();
            Planilla_TO planilla;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM PLANILLA WHERE estado_planilla = 1", conex);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        planilla = new Planilla_TO();
                        planilla.Id = reader.GetInt32(0);
                        planilla.Fecha_inicio = reader.GetDateTime(1);
                        planilla.Fecha_fin = reader.GetDateTime(2);
                        planilla.Total = reader.GetDecimal(3);
                        planilla.Tipo = reader.GetInt32(4);
                        planilla.Estado = reader.GetBoolean(5);
                        lista.Add(planilla);
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
                if (conex.State != ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public Boolean set_total(Planilla_TO planilla)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE PLANILLA SET total_planilla = @total WHERE id_planilla = @id", conex);

                query.Parameters.AddWithValue("@id", planilla.Id);
                query.Parameters.AddWithValue("@total", planilla.Total);

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
    }
}
