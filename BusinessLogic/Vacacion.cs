using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace BusinessLogic
{
    public  class Vacacion
    {
        public Int32 Id { get; set; }
        public Int32 Id_Colaborador { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Regreso { get; set; }
        public Int32 Numero_Dias { get; set; }
        public Decimal Salario { get; set; }
        public String Transferencia { get; set; }
        public Boolean Estado { get; set; }

        const int AÑO = 365;

        public Vacacion() { }

        public Vacacion(int id, int id_Colaborador, DateTime fecha_Salida, DateTime fecha_Regreso, int numero_Dias, Decimal salario, string transferencia, bool estado)
        {
            Id = id;
            Id_Colaborador = id_Colaborador;
            Fecha_Salida = fecha_Salida;
            Fecha_Regreso = fecha_Regreso;
            Numero_Dias = numero_Dias;
            Salario = salario;
            Transferencia = transferencia;
            Estado = estado;
        }

        public List<Vacacion> obtener_lista()
        {
            List<Vacacion> lista = new List<Vacacion>();
            List<Vacacion_TO> lista_TO = new Vacacion_BD().obtener_lista();
            foreach (Vacacion_TO x in lista_TO)
            {
                lista.Add(new Vacacion(x.Id, x.Id_Colaborador, x.Fecha_Salida, x.Fecha_Regreso, x.Numero_Dias, x.Salario, x.Transferencia, x.Estado));
            }
            return lista;
        }

        public List<Vacacion> obtener_lista_fechas(DateTime inicio, DateTime fin)
        {
            List<Vacacion> lista = new List<Vacacion>();
            List<Vacacion_TO> lista_TO = new Vacacion_BD().obtener_lista_fechas(inicio, fin);
            foreach (Vacacion_TO x in lista_TO)
            {
                lista.Add(new Vacacion(x.Id, x.Id_Colaborador, x.Fecha_Salida, x.Fecha_Regreso, x.Numero_Dias, x.Salario, x.Transferencia, x.Estado));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Vacacion_TO vacacion = new Vacacion_TO();
            vacacion.Id = this.Id;
            vacacion.Estado = this.Estado;
            return new Vacacion_BD().eliminar_vacacion(vacacion);
        }

        public Boolean agregar()
        {
            Vacacion_TO vacacion_to = new Vacacion_TO();
            vacacion_to.Id = this.Id;
            vacacion_to.Id_Colaborador = this.Id_Colaborador;
            vacacion_to.Fecha_Salida = this.Fecha_Salida;
            vacacion_to.Fecha_Regreso = this.Fecha_Regreso;
            vacacion_to.Numero_Dias = this.Numero_Dias;
            vacacion_to.Salario = this.Salario;
            vacacion_to.Transferencia = this.Transferencia;
            vacacion_to.Estado = this.Estado;
            return new Vacacion_BD().agregar_vacacion(vacacion_to);
        }

        public Boolean editar(List<Int32> lista)
        {
            Vacacion_TO vacacion_to = new Vacacion_TO();
            vacacion_to.Id = this.Id;
            vacacion_to.Id_Colaborador = this.Id_Colaborador;
            vacacion_to.Fecha_Salida = this.Fecha_Salida;
            vacacion_to.Fecha_Regreso = this.Fecha_Regreso;
            vacacion_to.Numero_Dias = this.Numero_Dias;
            vacacion_to.Salario = this.Salario;
            vacacion_to.Transferencia = this.Transferencia;
            vacacion_to.Estado = this.Estado;
            return new Vacacion_BD().editar_vacacion(vacacion_to, lista);
        }

        public Boolean tiene_vacaciones(Colaborador colaborador)
        {
            DateTime primer_registro = colaborador.obtener_primer_registro();
            TimeSpan cant_dias_vacaciones = DateTime.Today - primer_registro;
            if (cant_dias_vacaciones.Days >= AÑO)
            {
                return true;
            }
            return false;
        }

        public Int32 total_cant_dias_vacaciones(Colaborador colaborador)
        {
            int cant_dias_vacaciones = 14;
            if (tiene_vacaciones(colaborador))
            {
                DateTime primer_registro = colaborador.obtener_primer_registro();
                DateTime año_vacaciones = primer_registro.AddDays(365);
                TimeSpan temp = DateTime.Today - año_vacaciones;
                cant_dias_vacaciones += Convert.ToInt32(temp.Days / 30);
            }
            return cant_dias_vacaciones;
        }

        public Decimal monto_dia(Colaborador colaborador)
        {
            Decimal precio_hora = colaborador.obtener_precio_hora().Precio;
            Horario horario = new Horario().obtener_horario_colaborador(colaborador);
            int horas_horario = horario.Hora_Fin.Hour - horario.Hora_Inicio.Hour;
            Decimal monto_dia = precio_hora * horas_horario;

            return monto_dia;
        }
    }
}
