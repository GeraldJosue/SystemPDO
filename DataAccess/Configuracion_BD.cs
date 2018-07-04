using System;
using System.Data;
using System.Data.SqlClient;
using TransferObjects;

namespace DataAccess
{
    public class Configuracion_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Boolean guardar(Configuracion_TO configuracion_to)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE CONFIGURACION SET porcentaje_seguro = @Porcent_Seguro, porcentaje_hora_extra = @Porcent_Hora_Extra WHERE id_configuracion = @Id", conex);
                query.Parameters.AddWithValue("@Porcent_Seguro", configuracion_to.Porcentaje_Seguro);
                query.Parameters.AddWithValue("@Porcent_Hora_Extra", configuracion_to.Porcentaje_Hora_Extra);
                query.Parameters.AddWithValue("@Id", configuracion_to.Id);
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

        public Configuracion_TO obtener_Configuracion()
        {
            Configuracion_TO configuracion_to = new Configuracion_TO();
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM CONFIGURACION", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        configuracion_to.Id = reader.GetInt32(0);
                        configuracion_to.Porcentaje_Seguro = reader.GetDecimal(1);
                        configuracion_to.Porcentaje_Hora_Extra = reader.GetDecimal(2);
                    }
                    return configuracion_to;
                }
                else
                {
                    return null;
                }
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
