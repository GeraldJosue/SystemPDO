using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Pago
    {

        public Int32 Id { get; set; }
        public Int32 IdColaborador { get; set; }
        public DateTime FechaPago { get; set; }
        public Decimal SalarioBruto { get; set; }
        public Decimal SalarioNeto { get; set; }
        public Decimal Rebajo { get; set; }
        public Decimal HorasLaboradas { get; set; }
        public Decimal HorasExtra { get; set; }
        public String TransferenciaPago { get; set; }
        public Boolean EstadoPago { get; set; }

        public Pago(Int32 id, Int32 idColaborador, DateTime fecha, Decimal salarioBruto, Decimal salarioNeto, Decimal rebajo, Decimal horasLaboradas, Decimal horasExtra, String transferencia, Boolean estado)
        {
            this.Id = id;
            this.IdColaborador = idColaborador;
            this.FechaPago = fecha;
            this.SalarioBruto = salarioBruto;
            this.SalarioNeto = salarioNeto;
            this.Rebajo = rebajo;
            this.HorasLaboradas = horasLaboradas;
            this.HorasExtra = horasExtra;
            this.TransferenciaPago = transferencia;
            this.EstadoPago = estado;
        }
        public Pago()
        {

        }

        public Boolean agregar()
        {
            Pago_TO pago = bl_to_to();
            return new Pago_BD().agregar(pago);
        }

        public Boolean editar(List<Int32> lista)
        {
            Pago_TO pago = bl_to_to();
            return new Pago_BD().editar(pago, lista);
        }

        public List<Pago> obtener_lista()
        {
            List<Pago> lista = new List<Pago>();
            List<Pago_TO> lista_TO = new Pago_BD().obtener_lista();
            foreach (Pago_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Pago_TO aguinaldo = new Pago_TO();
            aguinaldo.Id = this.Id;
            return new Pago_BD().eliminar(aguinaldo);
        }


        public Pago_TO bl_to_to()
        {
            Pago_TO pago = new Pago_TO();
            pago.Id = this.Id;
            pago.IdColaborador = this.IdColaborador;
            pago.FechaPago = this.FechaPago;
            pago.SalarioBruto = this.SalarioBruto;
            pago.SalarioNeto = this.SalarioNeto;
            pago.Rebajo = this.Rebajo;
            pago.HorasLaboradas = this.HorasLaboradas;
            pago.HorasExtra = this.HorasExtra;
            pago.TransferenciaPago = this.TransferenciaPago;
            pago.EstadoPago = this.EstadoPago;
            return pago;
        }


        public Pago to_to_bl(Pago_TO to)
        {
            Pago pago = new Pago();
            pago.Id = to.Id;
            pago.IdColaborador = to.IdColaborador;
            pago.FechaPago = to.FechaPago;
            pago.SalarioBruto = to.SalarioBruto;
            pago.SalarioNeto = to.SalarioNeto;
            pago.Rebajo = to.Rebajo;
            pago.HorasLaboradas = to.HorasLaboradas;
            pago.HorasExtra = to.HorasExtra;
            pago.TransferenciaPago = to.TransferenciaPago;
            pago.EstadoPago = to.EstadoPago;
            return pago;
        }

    }
}
