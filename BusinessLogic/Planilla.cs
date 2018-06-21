using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Planilla
    {
        public Int32 Id { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public Decimal Total { get; set; }
        public Int32 Tipo { get; set; }
        public Boolean Estado { get; set; }

        public Planilla(Int32 id, DateTime inicio, DateTime fin, Decimal total, Int32 tipo, Boolean estado)
        {
            this.Id = id;
            this.Fecha_inicio = inicio;
            this.Fecha_fin = fin;
            this.Total = total;
            this.Tipo = tipo;
            this.Estado = estado;
        }

        public Planilla() {

       }

        public Boolean agregar()
        {
            Planilla_TO planilla = bl_to_to();
            return new Planilla_BD().agregar(planilla);
        }

        public List<Planilla> obtener_lista()
        {
            List<Planilla_TO> lista = new Planilla_BD().obtener_lista();
            List<Planilla> planillas = new List<Planilla>();
            foreach(Planilla_TO to in lista)
            {
                planillas.Add(to_to_bl(to));
            }
            return planillas;
        }

        public List<Planilla> obtener_lista_activos()
        {
            List<Planilla_TO> lista = new Planilla_BD().obtener_lista_activos();
            List<Planilla> planillas = new List<Planilla>();
            foreach (Planilla_TO to in lista)
            {
                planillas.Add(to_to_bl(to));
            }
            return planillas;
        }

        public Planilla_TO bl_to_to()
        {
            Planilla_TO planilla = new Planilla_TO();
            planilla.Id = this.Id;
            planilla.Fecha_inicio = this.Fecha_inicio;
            planilla.Fecha_fin = this.Fecha_fin;
            planilla.Total = this.Total;
            planilla.Tipo = this.Tipo;
            planilla.Estado = this.Estado;
            return planilla;
        }


        public Planilla to_to_bl(Planilla_TO to)
        {
            Planilla planilla = new Planilla();
            planilla.Id = to.Id;
            planilla.Fecha_inicio = to.Fecha_inicio;
            planilla.Fecha_fin = to.Fecha_fin;
            planilla.Total = to.Total;
            planilla.Tipo = to.Tipo;
            planilla.Estado = to.Estado;
            return planilla;
        }

    }
}
