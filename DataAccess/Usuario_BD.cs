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
    public class Usuario_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Usuario_TO validar(Usuario_TO usuario)
        {

            try
            {

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }
                Usuario_TO usuario_to = new Usuario_TO();

                SqlCommand query = new SqlCommand("SELECT * FROM USUARIO WHERE nombre_usuario = @nombre", conex);
                query.Parameters.AddWithValue("@nombre", usuario.Nombre);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    usuario_to.Id = reader.GetInt32(0);
                    usuario_to.Contraseña = reader.GetString(2);
                }
                return usuario_to;
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
