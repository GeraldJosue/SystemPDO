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
    public class Pago_BD
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.stringconex);

        public Pago_TO solicitarPago(Pago_TO pago)
        {

            try
            {

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }
                Pago_TO pago_to = new Pago_TO();

                SqlCommand query = new SqlCommand("SELECT * FROM PAGO WHERE id_colaborador = @idColaborador", conex);
                query.Parameters.AddWithValue("@idColaborador", pago.Id_colaborador);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pago_to.Id = reader.GetInt32(0);
                    pago_to.Id_colaborador = reader.GetInt32(1);
                    pago_to.FechaPago = reader.GetDateTime(2);
                    pago_to.SalarioBruto = reader.GetDecimal(3);
                    pago_to.SalarioNeto = reader.GetDecimal(4);
                    pago_to.Rebajo = reader.GetDecimal(5);
                    pago_to.HorasLaboradas = reader.GetDecimal(6);
                    pago_to.HorasExtra = reader.GetDecimal(7);
                    pago_to.TransferenciaPago = reader.GetString(8);
                    pago_to.EstadoPago = reader.GetBoolean(9);
                    pago_to.Bono = reader.GetDecimal(10);
                    pago_to.ProcesoPago = reader.GetBoolean(11);
                    pago_to.Vacaciones = reader.GetDecimal(12);
                    pago_to.Aguinaldo = reader.GetDecimal(13);
                    pago_to.Adelanto = reader.GetDecimal(14);
                    pago_to.Seguro = reader.GetDecimal(15);
                    pago_to.Id_planilla = reader.GetInt32(16);
                }
                return pago_to;
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
        
    
        public Boolean eliminar(Pago_TO pago)
        {

            try
            {
                SqlCommand query = new SqlCommand("UPDATE PAGO SET estado_pago = @estado WHERE id_pago = @id", conex);

                query.Parameters.AddWithValue("@id", pago.Id);
                query.Parameters.AddWithValue("@estado", pago.EstadoPago);

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

        public Boolean agregar(Pago_TO pago)
        {

            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO PAGO VALUES(@colaborador, @fecha, @salarioBruto, @salarioNeto, @rebajo, @horas, @horasExtra, @transferencia, @estado, @bono, @proceso, @vacaciones, @aguinaldo, @adelanto, @seguro, @planilla)", conex);
                query.Parameters.AddWithValue("@colaborador", pago.Id_colaborador);
                query.Parameters.AddWithValue("@fecha", pago.FechaPago);
                query.Parameters.AddWithValue("@salarioBruto", pago.SalarioBruto);
                query.Parameters.AddWithValue("@salarioNeto", pago.SalarioNeto);
                query.Parameters.AddWithValue("@rebajo", pago.Rebajo);
                query.Parameters.AddWithValue("@horas", pago.HorasLaboradas);
                query.Parameters.AddWithValue("@horasExtra", pago.HorasExtra);
                query.Parameters.AddWithValue("@transferencia", pago.TransferenciaPago);
                query.Parameters.AddWithValue("@estado", pago.EstadoPago);
                query.Parameters.AddWithValue("@bono", pago.Bono);
                query.Parameters.AddWithValue("@proceso", pago.ProcesoPago);
                query.Parameters.AddWithValue("@vacaciones", pago.Vacaciones);
                query.Parameters.AddWithValue("@aguinaldo", pago.Aguinaldo);
                query.Parameters.AddWithValue("@adelanto", pago.Adelanto);
                query.Parameters.AddWithValue("@seguro", pago.Seguro);
                query.Parameters.AddWithValue("@planilla", pago.Id_planilla);

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

        public Boolean editar(Pago_TO pago, List<Int32> lista)
        {

            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@id", pago.Id);
                query.Parameters.AddWithValue("@salarioBruto", pago.SalarioBruto);
                query.Parameters.AddWithValue("@salarioNeto", pago.SalarioNeto);
                query.Parameters.AddWithValue("@rebajo", pago.Rebajo);
                query.Parameters.AddWithValue("@transferencia", pago.TransferenciaPago);
                query.Parameters.AddWithValue("@estado", pago.EstadoPago);
                query.Parameters.AddWithValue("@bono", pago.Bono);
                query.Parameters.AddWithValue("@proceso", pago.ProcesoPago);
                query.Parameters.AddWithValue("@vacaciones", pago.Vacaciones);
                query.Parameters.AddWithValue("@aguinaldo", pago.Aguinaldo);
                query.Parameters.AddWithValue("@adelanto", pago.Adelanto);
                query.Parameters.AddWithValue("@seguro", pago.Seguro);
                query.Parameters.AddWithValue("@planilla", pago.Id_planilla);


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


        public List<Pago_TO> obtener_lista()
        {
            List<Pago_TO> lista = new List<Pago_TO>();
            Pago_TO pago;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM PAGO", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pago = new Pago_TO();
                        pago.Id = reader.GetInt32(0);
                        pago.Id_colaborador = reader.GetInt32(1);
                        pago.FechaPago = reader.GetDateTime(2);
                        pago.SalarioBruto = reader.GetDecimal(3);
                        pago.SalarioNeto = reader.GetDecimal(4);
                        pago.Rebajo = reader.GetDecimal(5);
                        pago.HorasLaboradas = reader.GetDecimal(6);
                        pago.HorasExtra = reader.GetDecimal(7);
                        pago.TransferenciaPago = reader.GetString(8);
                        pago.EstadoPago = reader.GetBoolean(9);
                        pago.Bono = reader.GetDecimal(10);
                        pago.ProcesoPago = reader.GetBoolean(11);
                        pago.Vacaciones = reader.GetDecimal(12);
                        pago.Aguinaldo = reader.GetDecimal(13);
                        pago.Adelanto = reader.GetDecimal(14);
                        pago.Seguro = reader.GetDecimal(15);
                        pago.Id_planilla = reader.GetInt32(16);
                        lista.Add(pago);
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

        public List<Pago_TO> obtener_lista_por_planilla(Int32 id_planilla)
        {
            List<Pago_TO> lista = new List<Pago_TO>();
            Pago_TO pago;
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM PAGO WHERE id_planilla = @Id", conex);
                query.Parameters.AddWithValue("@Id", id_planilla);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pago = new Pago_TO();
                        pago.Id = reader.GetInt32(0);
                        pago.Id_colaborador = reader.GetInt32(1);
                        pago.FechaPago = reader.GetDateTime(2);
                        pago.SalarioBruto = reader.GetDecimal(3);
                        pago.SalarioNeto = reader.GetDecimal(4);
                        pago.Rebajo = reader.GetDecimal(5);
                        pago.HorasLaboradas = reader.GetDecimal(6);
                        pago.HorasExtra = reader.GetDecimal(7);
                        pago.TransferenciaPago = reader.GetString(8);
                        pago.EstadoPago = reader.GetBoolean(9);
                        pago.Bono = reader.GetDecimal(10);
                        pago.ProcesoPago = reader.GetBoolean(11);
                        pago.Vacaciones = reader.GetDecimal(12);
                        pago.Aguinaldo = reader.GetDecimal(13);
                        pago.Adelanto = reader.GetDecimal(14);
                        pago.Seguro = reader.GetDecimal(15);
                        pago.Id_planilla = reader.GetInt32(16);
                        lista.Add(pago);
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
            String mega_query = "UPDATE PAGO SET ";
            foreach (Int32 x in lista)
            {
                
                if (x == 0)
                {
                    mega_query += "bono_pago = @bono,";
                }
                else if (x == 1)
                {
                    mega_query += "rebajo = @rebajo,";
                }
                else if (x == 2)
                {
                    mega_query += "salario_bruto = @salarioBruto,";
                }
                else if (x == 3)
                {
                    mega_query += "salario_neto = @salarioNeto,";
                }
                else if (x == 4)
                {
                    mega_query += "transferencia_pago = @transferencia,";
                }
                else if (x == 5)
                {
                    mega_query += "estado_pago = @estado,";
                }
                else if (x == 6)
                {
                    mega_query += "proceso_pago = @proceso,";
                }
                else if (x == 7)
                {
                    mega_query += "vacaciones = @vacaciones,";
                }
                else if (x == 8)
                {
                    mega_query += "aguinaldo = @aguinaldo,";
                }
                else if (x == 9)
                {
                    mega_query += "adelanto = @adelanto,";
                }
                else if (x == 10)
                {
                    mega_query += "seguro = @seguro,";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_pago = @id";
            return mega_query;
        }




    }

}
