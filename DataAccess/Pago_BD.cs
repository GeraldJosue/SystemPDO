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
                query.Parameters.AddWithValue("@idColaborador", pago.IdColaborador);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pago_to.Id = reader.GetInt32(0);
                    pago_to.IdColaborador = reader.GetInt32(1);
                    pago_to.FechaPago = reader.GetDateTime(2);
                    pago_to.SalarioBruto = reader.GetDouble(3);
                    pago_to.SalarioNeto = reader.GetDouble(4);
                    pago_to.Rebajo = reader.GetDouble(5);
                    pago_to.HorasLaboradas = reader.GetDouble(6);
                    pago_to.HorasExtra = reader.GetDouble(7);
                    pago_to.TransferenciaPago = reader.GetString(8);
                    pago_to.EstadoPago = reader.GetBoolean(9);

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
                SqlCommand query = new SqlCommand("DELETE FROM PAGO WHERE id_pago = @id", conex);

                query.Parameters.AddWithValue("@id", pago.Id);


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
                SqlCommand query = new SqlCommand("INSERT INTO PAGO VALUES(@colaborador, @fecha, @salarioBruto, @salarioNeto, @rebajo, @horas, @horasExtra, @transferencia, @estado)", conex);
                query.Parameters.AddWithValue("@colaborador", pago.IdColaborador);
                query.Parameters.AddWithValue("@fecha", pago.FechaPago);
                query.Parameters.AddWithValue("@salarioBruto", pago.SalarioBruto);
                query.Parameters.AddWithValue("@salarioNeto", pago.SalarioNeto);
                query.Parameters.AddWithValue("@rebajo", pago.Rebajo);
                query.Parameters.AddWithValue("@horas", pago.HorasLaboradas);
                query.Parameters.AddWithValue("@horasExtra", pago.HorasExtra);
                query.Parameters.AddWithValue("@transferencia", pago.TransferenciaPago);
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

        public Boolean editar(Pago_TO pago, List<Int32> lista)
        {

            try
            {
                SqlCommand query = new SqlCommand(string_query(lista), conex);
                query.Parameters.AddWithValue("@id", pago.Id);
                query.Parameters.AddWithValue("@colaborador", pago.IdColaborador);
                query.Parameters.AddWithValue("@fecha", pago.FechaPago);
                query.Parameters.AddWithValue("@salarioBruto", pago.SalarioBruto);
                query.Parameters.AddWithValue("@salarioNeto", pago.SalarioNeto);
                query.Parameters.AddWithValue("@rebajo", pago.Rebajo);
                query.Parameters.AddWithValue("@horas", pago.HorasLaboradas);
                query.Parameters.AddWithValue("@horasExtra", pago.HorasExtra);
                query.Parameters.AddWithValue("@transferencia", pago.TransferenciaPago);
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
                        pago.IdColaborador = reader.GetInt32(1);
                        pago.FechaPago = reader.GetDateTime(2);
                        pago.SalarioBruto = reader.GetDouble(3);
                        pago.SalarioNeto = reader.GetDouble(4);
                        pago.Rebajo = reader.GetDouble(5);
                        pago.HorasLaboradas = reader.GetInt32(6);
                        pago.HorasExtra = reader.GetInt32(7);
                        pago.TransferenciaPago = reader.GetString(8);
                        pago.EstadoPago = reader.GetBoolean(9);
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
                    mega_query += "id_colaborador = @colaborador,";
                }
                else if (x == 1)
                {
                    mega_query += "fecha_pago = @fecha,";
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
                    mega_query += "rebajo = @rebajo,";
                }
                else if (x == 5)
                {
                    mega_query += "horas_laboradas_pagadas = @horas,";
                }
                else if (x == 6)
                {
                    mega_query += "horas_extras_pagadas = @horasExtra,";
                }
                else if (x == 7)
                {
                    mega_query += "transferencia_pago = @transferencia,";
                }
                else if (x == 8)
                {
                    mega_query += "estado_pago = @estado,";
                }
            }
            mega_query = mega_query.TrimEnd(',');
            mega_query += " WHERE id_pago = @id";
            return mega_query;
        }




    }

}
