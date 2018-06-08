using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Configuracion
    {
        public Int32 Id { get; set; }
        public String Dia_Inicio { get; set; }
        public DateTime Semana_Inicio { get; set; }
        public Double Porcentaje_Seguro { get; set; }

        public Configuracion() { }

        public Configuracion(int id, string dia_Inicio, DateTime semana_Inicio, double porcentaje_Seguro)
        {
            Id = id;
            Dia_Inicio = dia_Inicio;
            Semana_Inicio = semana_Inicio;
            Porcentaje_Seguro = porcentaje_Seguro;
        }
    }
}
