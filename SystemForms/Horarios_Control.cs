using System;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class Horarios_Control : UserControl
    {
        Horarios_Agregar nuevo_horario;
        Horarios_Lista lista_horarios;
        Boolean editar;
        public Horarios_Control()
        {
            InitializeComponent();
            formato_dtpickers();
            lista_horarios = new Horarios_Lista();
            lista_horarios.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_horarios);
            editar = false;
        }

        //Da formato de hora a los datetimepickers
        public void formato_dtpickers()
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

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            nuevo_horario = new Horarios_Agregar();
            nuevo_horario.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_horario);
            editar = false;
            pn_filtros.Enabled = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_horarios);
            pn_filtros.Enabled = true;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            nuevo_horario = new Horarios_Agregar(lista_horarios.obtener());
            nuevo_horario.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_horario);
            editar = true;
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (nuevo_horario.agregar_sys())
                {
                    lista_horarios.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_horarios);
                    pn_filtros.Enabled = true;
                }
            }
            else
            {
                if (nuevo_horario.editar_sys())
                {
                    lista_horarios.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_horarios);
                    pn_filtros.Enabled = true;
                }
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lista_horarios.eliminar_sys())
            {
                lista_horarios.obtener_lista_sys();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_horarios);
            pn_filtros.Enabled = true;
        }
    }
}
