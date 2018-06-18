using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class Registro
    {
        public Int32 Id { get; set; }
        public Int32 Id_Colaborador { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Desayuno { get; set; }
        public DateTime Almuerzo { get; set; }
        public DateTime Cafe { get; set; }
        public Decimal Horas { get; set; }
        public Decimal Extras { get; set; }
        public Boolean Estado { get; set; }
        public Boolean Proceso { get; set; }

        public Registro(Int32 id, Int32 id_colaborador, DateTime fecha, DateTime entrada, DateTime salida, DateTime desayuno, DateTime almuerzo, DateTime cafe,
            Decimal horas, Decimal extras, Boolean estado, Boolean proceso)
        {
            this.Id = id;
            this.Id_Colaborador = id_colaborador;
            this.Fecha = fecha;
            this.Entrada = entrada;
            this.Salida = salida;
            this.Desayuno = desayuno;
            this.Almuerzo = almuerzo;
            this.Cafe = cafe;
            this.Horas = horas;
            this.Extras = extras;
            this.Estado = estado;
            this.Proceso = proceso;
        }

        public Registro() { }

        public Boolean agregar()
        {
            Registro_TO registro = bl_to_to();
            return new Registro_BD().agregar(registro);
        }

        public Boolean editar(List<Int32> lista)
        {
            Registro_TO registro = bl_to_to();
            return new Registro_BD().editar(registro, lista);
        }

        public Boolean eliminar()
        {
            Registro_TO registro = new Registro_TO();
            registro.Id = this.Id;
            registro.Estado = this.Estado;
            return new Registro_BD().eliminar(registro);
        }
        public List<Registro> obtener_lista()
        {
            List<Registro> lista = new List<Registro>();
            List<Registro_TO> lista_to = new Registro_BD().obtener_registros();
            foreach(Registro_TO to in lista_to)
            {
                lista.Add(to_to_bl(to));
            }
            return lista;
        }
        public List<Registro> obtener_lista_fechas(DateTime inicio, DateTime fin)
        {
            List<Registro> lista = new List<Registro>();
            List<Registro_TO> lista_to = new Registro_BD().obtener_registros_fechas(inicio, fin);
            foreach (Registro_TO to in lista_to)
            {
                lista.Add(to_to_bl(to));
            }
            return lista;
        }

        public Registro_TO bl_to_to()
        {
            Registro_TO registro = new Registro_TO();
            registro.Id = this.Id;
            registro.Id_Colaborador = this.Id_Colaborador;
            registro.Fecha = this.Fecha;
            registro.Entrada = this.Entrada;
            registro.Salida = this.Salida;
            registro.Desayuno = this.Desayuno;
            registro.Almuerzo = this.Almuerzo;
            registro.Cafe = this.Cafe;
            registro.Horas = this.Horas;
            registro.Extras = this.Extras;
            registro.Estado = this.Estado;
            registro.Proceso = this.Proceso;

            return registro;
        }

        public Registro to_to_bl(Registro_TO to)
        {
            Registro registro = new Registro();
            registro.Id = to.Id;
            registro.Id_Colaborador = to.Id_Colaborador;
            registro.Fecha = to.Fecha;
            registro.Entrada = to.Entrada;
            registro.Salida = to.Salida;
            registro.Desayuno = to.Desayuno;
            registro.Almuerzo = to.Almuerzo;
            registro.Cafe = to.Cafe;
            registro.Horas = to.Horas;
            registro.Extras = to.Extras;
            registro.Estado = to.Estado;
            registro.Proceso = to.Proceso;

            return registro;
        }
    }
}
