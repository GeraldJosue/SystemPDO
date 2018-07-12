 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SystemForms
{
    public partial class Horarios_Agregar : UserControl
    {
        Horario horario;
        public Horarios_Agregar()
        {
            InitializeComponent();
            //formato_dtpickers();
            rb_activo.Checked = true;
            //formato_dtpickers();
        }

        public Horarios_Agregar(Horario horario)
        {
            InitializeComponent();
            //formato_dtpickers();
            //formato_dtpickers();
            rb_activo.Checked = true;
            this.horario = horario;
            setear_datos();
        }

        //Setea los datos del horario en los componentes del form
        private void setear_datos()
        {
            tb_nombre.Text = horario.Nombre_Horario;
            dt_hora_inicio.Text = horario.Hora_Inicio.ToString();
            dt_hora_fin.Text = horario.Hora_Fin.ToString();
            if(horario.Estado)
            {
                rb_activo.Checked = horario.Estado;
            } else
            {
                rb_inactivo.Checked = horario.Estado;
            }
        }

        //Da formato de hora a los datetimepickers
        public void formato_dtpickers ()
        {
            dt_hora_inicio.Format = DateTimePickerFormat.Custom;
            dt_hora_inicio.ShowUpDown = true;
            dt_hora_inicio.CustomFormat = "h:mm tt";
            dt_hora_inicio.Value = DateTime.Parse("00:00");

            dt_hora_fin.Format = DateTimePickerFormat.Custom;
            dt_hora_fin.ShowUpDown = true;
            dt_hora_fin.CustomFormat = "h:mm tt";
            dt_hora_fin.Value = DateTime.Parse("23:59");
        }

        //Muestra mensaje de confirmnacion si el horario fue agregado con exito ó mensaje de error en el caso contrario.
        public Boolean agregar_sys()
        {
            BusinessLogic.Horario horario = obtener_datos();
            if (horario.agregar())
            {
                MessageBox.Show("Horario agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Boolean editar_sys()
        {
            BusinessLogic.Horario horario = obtener_datos();
            horario.Id = this.horario.Id;
            List<Int32> lista = validar_cambios(horario);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (horario.editar(lista))
            {
                MessageBox.Show("Horario editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al editar el horario", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private List<Int32> validar_cambios(Horario horario)
        {
            List<Int32> lista = new List<Int32>();
   
            if(!horario.Nombre_Horario.Equals(this.horario.Nombre_Horario))
            {
                lista.Add(0);
            }
            if(horario.Hora_Inicio != this.horario.Hora_Inicio)
            {
                lista.Add(1);
            }
            if(horario.Hora_Fin != this.horario.Hora_Fin)
            {
                lista.Add(2);
            }
            if(horario.Estado != this.horario.Estado)
            {
                lista.Add(3);
            }
            if(horario.Horas != this.horario.Horas)
            {
                lista.Add(4);
            }
            return lista;
        }

        //Obtiene los datos(valores) de los componentes del form 
        public Horario obtener_datos()
        {
            String nombre = tb_nombre.Text.Equals("") ? "No disponible" : tb_nombre.Text;
            DateTime hora_inicio = dt_hora_inicio.Value;
            DateTime hora_fin = dt_hora_fin.Value;
            Decimal horas = hora_fin.Hour - hora_inicio.Hour; 
            Boolean estado = rb_activo.Checked ? true : rb_inactivo.Checked ? false : true;
            return new Horario(0, nombre, hora_inicio, hora_fin, estado, --horas);
        }


    }
}
