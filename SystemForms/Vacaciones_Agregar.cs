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
    public partial class Vacaciones_Agregar : UserControl
    {
        Vacacion vacacion;
        List<Colaborador> lista_colaboradores;
        Colaborador colaborador;
        public Vacaciones_Agregar()
        {
            InitializeComponent();
            llenar_cb_colaboradores();
        }

        private void llenar_cb_colaboradores()
        {
            colaborador = new Colaborador();
            lista_colaboradores = colaborador.obtener_lista();
            cb_colaborador.DataSource = llenar_dt_colaboradores();
            cb_colaborador.DisplayMember = "Nombre Completo";
            cb_colaborador.ValueMember = "Id";
        }

        private DataTable llenar_dt_colaboradores()
        {
            DataTable dt_colaboradores = new DataTable();
            dt_colaboradores.Columns.Add("Id");
            dt_colaboradores.Columns.Add("Nombre Completo");
            foreach(Colaborador x in lista_colaboradores)
            {
                dt_colaboradores.Rows.Add(x.Id, x.Nombre + " " + x.Apellido + " " + x.Segundo_apellido);
            }
            return dt_colaboradores;
        }

        public Vacaciones_Agregar(Vacacion vacacion)
        {
            InitializeComponent();
            this.vacacion = vacacion;
            setear_datos();
        }

        //Setea los datos de la vacacion en los componentes del form
        private void setear_datos()
        {
            //tb_nombre.Text = vacacion.Nombre_Horario;
            //dt_hora_inicio.Text = vacacion.Hora_Inicio.ToString();
            //dt_hora_fin.Text = vacacion.Hora_Fin.ToString();
            //if (vacacion.Estado)
            //{
            //    rb_activo.Checked = vacacion.Estado;
            //}
            //else
            //{
            //    rb_inactivo.Checked = vacacion.Estado;
            //}
        }

        //Muestra mensaje de confirmnacion si la vacacion fue agregado con exito ó mensaje de error en el caso contrario.
        public Boolean agregar_sys()
        {
            BusinessLogic.Vacacion vacacion = obtener_datos();
            if (vacacion.agregar())
            {
                MessageBox.Show("La vacación fue agregada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            BusinessLogic.Vacacion vacacion = obtener_datos();
            vacacion.Id = this.vacacion.Id;
            List<Int32> lista = validar_cambios(vacacion);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (vacacion.editar(lista))
            {
                MessageBox.Show("Vacacion editada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al editar el horario", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Vacacion obtener_datos()
        {
            throw new NotImplementedException();
        }

        private List<int> validar_cambios(Vacacion vacacion)
        {
            throw new NotImplementedException();
        }

    }
}
