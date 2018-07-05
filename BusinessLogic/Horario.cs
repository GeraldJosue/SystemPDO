using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace BusinessLogic
{
    public class Horario
    {
        public Int32 Id { get; set; }
        public String Nombre_Horario { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Fin { get; set; }
        public Boolean Estado { get; set; }
        public Decimal Horas { get; set; }

        public Horario() { }

        public Horario(int id, string nombre_Horario, DateTime horario_Inicio, DateTime horario_Fin, bool estado, Decimal horas)
        {
            this.Id = id;
            this.Nombre_Horario = nombre_Horario;
            this.Hora_Inicio = horario_Inicio;
            this.Hora_Fin = horario_Fin;
            this.Estado = estado;
            this.Horas = horas;
        }

        public List<Horario> obtener_lista()
        {
            List<Horario> lista = new List<Horario>();
            List<Horario_TO> lista_TO = new Horario_BD().obtener_lista();
            foreach (Horario_TO x in lista_TO)
            {
                lista.Add(new Horario(x.Id, x.Nombre_Horario, x.Hora_Inicio,x.Hora_Fin,x.Estado, x.Horas));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Horario_TO horario = new Horario_TO();
            horario.Id = this.Id;
            horario.Estado = this.Estado;
            return new Horario_BD().eliminar_horario(horario);
        }

        public Boolean agregar()
        {
            Horario_TO horario = new Horario_TO();
            horario.Id = this.Id;
            horario.Nombre_Horario = this.Nombre_Horario;
            horario.Hora_Inicio = this.Hora_Inicio;
            horario.Hora_Fin = this.Hora_Fin;
            horario.Estado = this.Estado;
            horario.Horas = this.Horas;
            return new Horario_BD().agregar(horario);
        }

        public Boolean editar(List<Int32> lista)
        {
            Horario_TO horario_to = new Horario_TO();
            horario_to.Id = this.Id;
            horario_to.Nombre_Horario = this.Nombre_Horario;
            horario_to.Hora_Inicio = this.Hora_Inicio;
            horario_to.Hora_Fin = this.Hora_Fin;
            horario_to.Estado = this.Estado;
            horario_to.Horas = this.Horas;
            return new Horario_BD().editar(horario_to, lista);
        }

        public List<Horario> obtener_lista_activos()
        {
            List<Horario> lista_activos = new List<Horario>();
            List<Horario_TO> lista_TO = new Horario_BD().obtener_lista_activos();
            foreach (Horario_TO x in lista_TO)
            {
                lista_activos.Add(new Horario(x.Id, x.Nombre_Horario, x.Hora_Inicio, x.Hora_Fin, x.Estado, x.Horas));
            }
            return lista_activos;
        }

        public Horario obtener_horario_colaborador(Colaborador colaborador)
        {
            Horario_TO horario_TO = new Horario_BD().obtener_horario_colaborador(colaborador.Id);
            this.Id = horario_TO.Id;
            this.Nombre_Horario = horario_TO.Nombre_Horario;
            this.Hora_Inicio = horario_TO.Hora_Inicio;
            this.Hora_Fin = horario_TO.Hora_Fin;
            this.Estado = horario_TO.Estado;
            this.Horas = horario_TO.Horas;
            return this;
        }
    }
}
