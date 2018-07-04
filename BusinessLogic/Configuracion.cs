using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace BusinessLogic
{
    public class Configuracion
    {
        public Int32 Id { get; set; }
        public Decimal Porcentaje_Seguro { get; set; }
        public Decimal Porcentaje_Hora_Extra { get; set; }

        public Configuracion() { }

        public Configuracion(int id, decimal porcentaje_Seguro, decimal porcentaje_hora_extra)
        {
            Id = id;
            Porcentaje_Seguro = porcentaje_Seguro;
            Porcentaje_Hora_Extra = porcentaje_hora_extra;
        }

        public bool guardar_configuracion()
        {
            Configuracion_TO configuracion_TO = new Configuracion_TO();
            configuracion_TO.Id = this.Id;
            configuracion_TO.Porcentaje_Seguro = this.Porcentaje_Seguro;
            configuracion_TO.Porcentaje_Hora_Extra = this.Porcentaje_Hora_Extra;

            return new Configuracion_BD().guardar(configuracion_TO);
        }

        public Configuracion obtener_Configuracion()
        {
            Configuracion_TO configuracion_TO = new Configuracion_BD().obtener_Configuracion();
            this.Id = configuracion_TO.Id;
            this.Porcentaje_Seguro = configuracion_TO.Porcentaje_Seguro;
            this.Porcentaje_Hora_Extra = configuracion_TO.Porcentaje_Hora_Extra;
            
            return this;
        }
    }
}
