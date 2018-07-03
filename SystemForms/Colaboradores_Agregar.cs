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
using System.Globalization;

namespace SystemForms
{
    public partial class Colaboradores_Agregar : UserControl
    {
        Colaboradores_Control parent;
        Colaborador colaborador;
        DateTime date;
        public Colaboradores_Agregar(Colaboradores_Control parent)
        {
            InitializeComponent();
            this.parent = parent;

            date = new DateTime(DateTime.Now.Year, 01, 01);
            llenar_cb_año(date);
            llenar_cb_mes(date);
            llenar_cb_dia(date, 31);
            llenar_cb_civil();
            llenar_cb_nacionalidad();
            llenar_cb_departamento();
            llenar_cb_horario();
            llenar_cb_entidad();
            llenar_cb_parentesco();
        }

        public void llenar_cb_dia(DateTime date, Int32 dias)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            for (int i = 0; i < dias; i++)
            {
                dt.Rows.Add(i + 1, date.AddDays(i).Day);
            }

            cb_dia.ValueMember = "Id";
            cb_dia.DisplayMember = "Nombre";
            cb_dia.DataSource = dt;

        }
        public void llenar_cb_mes(DateTime date)
        {

            cb_dia.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            for (int i = 0; i < 12; i++)
            {
                dt.Rows.Add(i + 1, date.AddMonths(i).ToString("MMMM", CultureInfo.CreateSpecificCulture("es-ES")));
            }

            cb_mes.ValueMember = "Id";
            cb_mes.DisplayMember = "Nombre";
            cb_mes.DataSource = dt;

        }
        public void llenar_cb_año(DateTime date)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            for (int i = 0; i >= -80; i--)
            {
                dt.Rows.Add(date.AddYears(i).Year, date.AddYears(i).Year);
            }

            cb_año.ValueMember = "Id";
            cb_año.DisplayMember = "Nombre";
            cb_año.DataSource = dt;

        }
        public void llenar_cb_civil() {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            dt.Rows.Add("Soltero", "Soltero");
            dt.Rows.Add("Casado", "Casado");
            dt.Rows.Add("Divorciado", "Divorciado");
            dt.Rows.Add("Unión Libre", "Unión Libre");
            dt.Rows.Add("Otro", "Otro");

            cb_civil.ValueMember = "Id";
            cb_civil.DisplayMember = "Nombre";
            cb_civil.DataSource = dt;
        }
        public void llenar_cb_nacionalidad() {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            dt.Rows.Add("Costarricense", "Costarricense");
            dt.Rows.Add("Estadounidense", "Estadounidense");
            dt.Rows.Add("Guatemalteco", "Guatemalteco");
            dt.Rows.Add("Hondureño", "Hondureño");
            dt.Rows.Add("Mexicano", "Mexicano");
            dt.Rows.Add("Nicaragüense", "Nicaragüense");
            dt.Rows.Add("Salvadoreño", "Salvadoreño");
            dt.Rows.Add("Panameño", "Panameño");
            dt.Rows.Add("Otro", "Otro");

            cb_nacionalidad.ValueMember = "Id";
            cb_nacionalidad.DisplayMember = "Nombre";
            cb_nacionalidad.DataSource = dt;

        }
        public void llenar_cb_departamento() {

            List<Departamento> departamentos = new Departamento().obtener_lista_activos();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            foreach (Departamento d in departamentos)
            {
                dt.Rows.Add(d.Id, d.Nombre);
            }

            cb_departamento.ValueMember = "Id";
            cb_departamento.DisplayMember = "Nombre";
            cb_departamento.DataSource = dt;
        }
        public void llenar_cb_horario() {

            List<Horario> horarios = new Horario().obtener_lista_activos();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            foreach (Horario h in horarios)
            {
                dt.Rows.Add(h.Id, h.Nombre_Horario);
            }

            cb_horario.ValueMember = "Id";
            cb_horario.DisplayMember = "Nombre";
            cb_horario.DataSource = dt;
        }
        public void llenar_cb_entidad() {


            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            dt.Rows.Add("BCR", "BCR");
            dt.Rows.Add("BAC", "BAC");
            dt.Rows.Add("Banco Popular", "Banco Popular");
            dt.Rows.Add("Scotiabank", "Scotiabank");
            dt.Rows.Add("Banco Nacional", "Banco Nacional");
            dt.Rows.Add("Coocique", "Coocique");
            dt.Rows.Add("Otro", "Otro");

            cb_entidad.ValueMember = "Id";
            cb_entidad.DisplayMember = "Nombre";
            cb_entidad.DataSource = dt;
        }
        public void llenar_cb_planilla()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            
            dt.Rows.Add(14, "Quincenal");
            dt.Rows.Add(30, "Mensual");

            cb_planillas.ValueMember = "Id";
            cb_planillas.DisplayMember = "Nombre";
            cb_planillas.DataSource = dt;
        }

        public void llenar_cb_parentesco()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            dt.Rows.Add("Padre", "Padre");
            dt.Rows.Add("Madre", "Madre");
            dt.Rows.Add("Hermano", "Hermano");
            dt.Rows.Add("Hermana", "Hermana");
            dt.Rows.Add("Hijo", "Hijo");
            dt.Rows.Add("Hija", "Hija");
            dt.Rows.Add("Abuelo", "Abuelo");
            dt.Rows.Add("Abuela", "Abuela");
            dt.Rows.Add("Otro", "Otro");

            cb_parentesco.ValueMember = "Id";
            cb_parentesco.DisplayMember = "Nombre";
            cb_parentesco.DataSource = dt;
        }
        public Colaboradores_Agregar(Colaborador colaborador, Colaboradores_Control parent)
        {
            InitializeComponent();
            this.colaborador = colaborador;
            this.parent = parent;

            date = new DateTime(2018, 01, 01);
            llenar_cb_año(date);
            llenar_cb_mes(date);
            llenar_cb_dia(date, 31);
            llenar_cb_civil();
            llenar_cb_nacionalidad();
            llenar_cb_departamento();
            llenar_cb_horario();
            llenar_cb_entidad();
            llenar_cb_parentesco();
            llenar_cb_planilla();
            
            setear_datos();

        }

        public Boolean agregar_sys()
        {
            if (pn_validacion.BackColor == Color.LimeGreen || pn_validacion.BackColor == Color.White)
            {
                BusinessLogic.Colaborador colaborador = obtener_datos();
                if (colaborador.agregar())
                {
                    MessageBox.Show("Colaborador agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                MessageBox.Show("La cédula ya existe en el sistema", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

        public Boolean editar_sys()
        {
            if (pn_validacion.BackColor == Color.LimeGreen || pn_validacion.BackColor == Color.White)
            {
                Colaborador colaborador = obtener_datos();
                colaborador.Id = this.colaborador.Id;
                List<Int32> lista = validar_cambios(colaborador);
                if (lista.Count == 0)
                {
                    return true;
                }
                else if (colaborador.editar(lista))
                {
                    MessageBox.Show("Colaborador editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                MessageBox.Show("La cédula ya existe en el sistema", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

        public Colaborador obtener_datos()
        {
            Int32 departamento = cb_departamento.SelectedIndex == -1 ? 1 : Int32.Parse(cb_departamento.SelectedValue.ToString());
            Int32 horario = cb_horario.SelectedIndex == -1 ? 1 : Int32.Parse(cb_horario.SelectedValue.ToString());
            String nombre = tb_nombre.Text.Equals("") ? "No disponible" : tb_nombre.Text;
            String apellido = tb_apellido.Text.Equals("") ? "No disponible" : tb_apellido.Text;
            String segundo = tb_seg_apellido.Text.Equals("") ? "No disponible" : tb_seg_apellido.Text;
            Int32 cedula = tb_cedula.Text.Equals("") ? 0 : Int32.Parse(tb_cedula.Text);
            Int32 telefono = tb_telefono.Text.Equals("") ? 0 : Int32.Parse(tb_telefono.Text);
            String direccion = tb_direccion.Text.Equals("") ? "No disponible" : tb_direccion.Text;

            DateTime fecha;
            if (cb_año.SelectedIndex == -1 || cb_mes.SelectedIndex == -1 || cb_dia.SelectedIndex == -1)
            {
                fecha = DateTime.Now;
            } else {
                fecha = new DateTime(Int32.Parse(cb_año.SelectedValue.ToString()), Int32.Parse(cb_mes.SelectedValue.ToString()), Int32.Parse(cb_dia.SelectedValue.ToString()));
            }

            String civil = cb_civil.SelectedIndex == -1 ? "No disponible" : cb_civil.SelectedValue.ToString();
            String nacionalidad = cb_nacionalidad.SelectedIndex == -1 ? "No disponible" : cb_nacionalidad.SelectedValue.ToString();
            String cuenta = tb_cuenta.Text.Equals("") ? "No disponible" : tb_cuenta.Text;
            String entidad = cb_entidad.SelectedIndex == -1 ? "No disponible" : cb_entidad.SelectedValue.ToString();
            Decimal precio = tb_precio.Text.Equals("") ? 0 : Decimal.Parse(Convert.ToString(tb_precio.Tag));
            Int32 planilla = cb_planillas.SelectedIndex == -1 ? 1 : Int32.Parse(cb_planillas.SelectedValue.ToString());
            String fnombre = tb_fnombre.Text.Equals("") ? "No disponible" : tb_fnombre.Text;
            Int32 ftelefono = tb_ftelefono.Text.Equals("") ? 0 : Int32.Parse(tb_ftelefono.Text);
            String parentesco = cb_parentesco.SelectedIndex == -1 ? "No disponible" : cb_parentesco.SelectedValue.ToString();
            String fdireccion = tb_fdireccion.Text.Equals("") ? "No disponible" : tb_fdireccion.Text;
            Boolean estado = rb_activo.Checked ? true : false;
            
            //Revisar datos por defecto
            return new Colaborador(0, departamento, horario, nombre, apellido, segundo, cedula, telefono, direccion, fecha, civil, cuenta, entidad, nacionalidad, precio
                , ftelefono, parentesco, fdireccion, estado, fnombre, planilla);
        }

        public void setear_datos()
        {
            //Setear el selected index
            cb_departamento.SelectedValue = colaborador.Id_departamento;
            cb_horario.SelectedValue = colaborador.Id_horario;

            tb_nombre.Text = colaborador.Nombre;
            tb_apellido.Text = colaborador.Apellido;
            tb_seg_apellido.Text = colaborador.Segundo_apellido;
            tb_cedula.Text = colaborador.Cedula.ToString();
            tb_telefono.Text = colaborador.Telefono.ToString();
            tb_direccion.Text = colaborador.Direccion;
            
            cb_mes.SelectedValue = colaborador.Fecha.Month;
            cb_año.SelectedValue = colaborador.Fecha.Year;
            cb_dia.SelectedValue = colaborador.Fecha.Day;

            if (!colaborador.Estado_civil.Equals("No disponible"))
            {
                cb_civil.SelectedValue = colaborador.Estado_civil;
            }

            if (!colaborador.Nacionalidad.Equals("No disponible"))
            {
                cb_nacionalidad.SelectedValue = colaborador.Nacionalidad;
            }

            tb_cuenta.Text = colaborador.Cuenta;

            if (!colaborador.Entidad.Equals("No disponible"))
            {
                cb_entidad.SelectedValue = colaborador.Entidad;
            }

            tb_precio.Tag = colaborador.Precio.ToString();
            tb_precio.Text = colaborador.Precio.ToString("C");
            cb_planillas.SelectedValue = colaborador.Tipo_planilla;

            tb_fnombre.Text = colaborador.FNombre;
            tb_ftelefono.Text = colaborador.FTelefono.ToString();

            if (!colaborador.Parentesco.Equals("No disponible"))
            {
                cb_parentesco.SelectedValue = colaborador.Parentesco;
            }

            tb_fdireccion.Text = colaborador.FDireccion;
            rb_activo.Checked = colaborador.Estado;
        }

        public List<Int32> validar_cambios(Colaborador nuevo)
        {
            List<Int32> lista = new List<Int32>();
            if(nuevo.Id_departamento != this.colaborador.Id_departamento)
            {
                lista.Add(0);
            }
            if(nuevo.Id_horario != this.colaborador.Id_horario)
            {
                lista.Add(1);
            }
            if (!nuevo.Nombre.Equals(this.colaborador.Nombre))
            {
                lista.Add(2);
            }
            if (!nuevo.Apellido.Equals(this.colaborador.Apellido))
            {
                lista.Add(3);
            }
            if (!nuevo.Segundo_apellido.Equals(this.colaborador.Segundo_apellido))
            {
                lista.Add(4);
            }
            if (nuevo.Cedula != this.colaborador.Cedula)
            {
                lista.Add(5);
            }
            if (nuevo.Telefono != this.colaborador.Telefono)
            {
                lista.Add(6);
            }
            if (!nuevo.Direccion.Equals(this.colaborador.Direccion))
            {
                lista.Add(7);
            }
            if (nuevo.Fecha.Date != this.colaborador.Fecha.Date)
            {
                lista.Add(8);
            }
            if (!nuevo.Estado_civil.Equals(this.colaborador.Estado_civil))
            {
                lista.Add(9);
            }
            if (!nuevo.Cuenta.Equals(this.colaborador.Cuenta))
            {
                lista.Add(10);
            }
            if (!nuevo.Entidad.Equals(this.colaborador.Entidad))
            {
                lista.Add(11);
            }
            if (!nuevo.Nacionalidad.Equals(this.colaborador.Nacionalidad))
            {
                lista.Add(12);
            }
            if (nuevo.Precio != this.colaborador.Precio)
            {
                lista.Add(13);
            }
            if (nuevo.FTelefono != this.colaborador.FTelefono)
            {
                lista.Add(14);
            }
            if (!nuevo.Parentesco.Equals(this.colaborador.Parentesco))
            {
                lista.Add(15);
            }
            if (!nuevo.FDireccion.Equals(this.colaborador.FDireccion))
            {
                lista.Add(16);
            }
            if (nuevo.Estado != this.colaborador.Estado)
            {
                lista.Add(17);
            }
            if (!nuevo.FNombre.Equals(this.colaborador.FNombre))
            {
                lista.Add(18);
            }
            if (nuevo.Tipo_planilla != this.colaborador.Tipo_planilla)
            {
                lista.Add(19);
            }
            return lista;
        }

        private void bt_sig_1_Click(object sender, EventArgs e)
        {
            tb_colaborador.SelectedTab = tp_2;
        }

        private void bt_sig_2_Click(object sender, EventArgs e)
        {
            tb_colaborador.SelectedTab = tp_3;

        }

        private void bt_atras_3_Click(object sender, EventArgs e)
        {
            tb_colaborador.SelectedTab = tp_2;

        }

        private void bt_atras_2_Click(object sender, EventArgs e)
        {
            tb_colaborador.SelectedTab = tp_1;

        }

        private void cb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mes.SelectedIndex != -1)
            {
                llenar_cb_dia(date, DateTime.DaysInMonth(Int32.Parse(cb_año.SelectedValue.ToString()), Int32.Parse(cb_mes.SelectedValue.ToString())));
            }
        }

        private void cb_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mes.SelectedIndex != -1)
            {
                llenar_cb_dia(date, DateTime.DaysInMonth(Int32.Parse(cb_año.SelectedValue.ToString()), Int32.Parse(cb_mes.SelectedValue.ToString())));

            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

        }

        private void tb_precio_Enter(object sender, EventArgs e)
        {
            tb_precio.Text = Convert.ToString(tb_precio.Tag);
        }

        private void tb_precio_Leave(object sender, EventArgs e)
        {
            if (!tb_precio.Text.Equals(""))
            {
                try
                {
                    Decimal precio = Decimal.Parse(tb_precio.Text);
                    tb_precio.Tag = precio;
                    tb_precio.Text = precio.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El precio no posee un formato válido", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_precio.Focus();
                }
            }
           
        }

        private void tb_cedula_TextChanged(object sender, EventArgs e)
        {
            if (tb_cedula.Text.Equals(""))
            {
                pn_validacion.BackColor = Color.White;
            }
            else if (colaborador != null && colaborador.Cedula == Int32.Parse(tb_cedula.Text))
            {
                pn_validacion.BackColor = Color.LimeGreen;
            }
            else { 

                if (!parent.buscar_cedula(tb_cedula.Text))
                {
                    pn_validacion.BackColor = Color.LimeGreen;
                }
                else
                {
                    pn_validacion.BackColor = Color.Red;
                }
            }
        }

        private void tb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void tb_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_ftelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (e.KeyChar == 8 || e.KeyChar.Equals(',') || e.KeyChar.Equals('.')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bt_guardar_Click_1(object sender, EventArgs e)
        {
            if(colaborador == null)
            {
                if (agregar_sys())
                {
                    parent.listar();
                }
            }
            else
            {
                if (editar_sys())
                {
                    parent.listar();
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            parent.cancelar();
        }
    }
}
