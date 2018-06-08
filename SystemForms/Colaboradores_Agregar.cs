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
        Colaborador colaborador;
        DateTime date;
        Boolean error_cedula;
        Boolean carga_inicial;
        Boolean valido;
        Colaboradores_Control parent;

        public Colaboradores_Agregar(Colaboradores_Control parent)
        {
            InitializeComponent();

            error_cedula = false;
            carga_inicial = false;
            valido = false;

            date = new DateTime(DateTime.Now.Year, 01, 01);

            this.parent = parent;
            llenar_cb_año(date);
            llenar_cb_mes(date);
            llenar_cb_dia(date, 31);
            llenar_cb_civil();
            llenar_cb_nacionalidad();
            //llenar_cb_departamento();
            //llenar_cb_horario();
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
                dt.Rows.Add(i+1, date.AddDays(i).Day);
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
                dt.Rows.Add(i+1, date.AddMonths(i).ToString("MMMM", CultureInfo.CreateSpecificCulture("es-ES")));
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
        public void llenar_cb_departamento() { }
        public void llenar_cb_horario() { }
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
            dt.Rows.Add("Otro","Otro");

            cb_entidad.ValueMember = "Id";
            cb_entidad.DisplayMember = "Nombre";
            cb_entidad.DataSource = dt;
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

            error_cedula = false;
            carga_inicial = false;
            valido = false;

            date = new DateTime(2018, 01, 01);

            this.parent = parent;
            
            llenar_cb_año(date);
            llenar_cb_mes(date);
            llenar_cb_dia(date, 31);
            llenar_cb_civil();
            llenar_cb_nacionalidad();
            //llenar_cb_departamento();
            //llenar_cb_horario();
            llenar_cb_entidad();
            llenar_cb_parentesco();

            setear_datos();
        }

        public Boolean agregar_sys()
        {
            if (valido)
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
            }
            else
            {
                MessageBox.Show("La cédula ya existe", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Boolean editar_sys()
        {
            if (valido)
            {
                BusinessLogic.Colaborador colaborador = obtener_datos();
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
            }else
            {
                MessageBox.Show("La cédula ya existe", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public Colaborador obtener_datos()
        { 
            Int32 departamento = cb_departamento.SelectedIndex == -1 ? 1 : cb_departamento.SelectedIndex;
            Int32 horario = cb_horario.SelectedIndex == -1 ? 1 : cb_horario.SelectedIndex;
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
            Int32 precio = tb_precio.Text.Equals("") ? 0 : Int32.Parse(tb_precio.Text);
            Int32 ftelefono = tb_ftelefono.Text.Equals("") ? 0 : Int32.Parse(tb_ftelefono.Text);
            String parentesco = cb_parentesco.SelectedIndex == -1 ? "No disponible" : cb_parentesco.SelectedValue.ToString();
            String fdireccion = tb_fdireccion.Text.Equals("") ? "No disponible" : tb_fdireccion.Text;
            Boolean estado = rb_activo.Checked ? true : false;
            
            //Revisar datos por defecto
            return new Colaborador(0, departamento, horario, nombre, apellido, segundo, cedula, telefono, direccion, fecha, civil, cuenta, entidad, nacionalidad, precio
                , ftelefono, parentesco, fdireccion, estado);
        }

        public void setear_datos()
        {
            //Setear el selected index
            //cb_departamento.SelectedIndex
            //cb_horario.SelectedIndex

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

            tb_precio.Text = colaborador.Precio.ToString();
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

        private void tb_cedula_TextChanged(object sender, EventArgs e)
        {
           
                if (colaborador == null)
                {
                    carga_inicial = true;
                    if (parent.buscar_cedula(tb_cedula.Text))
                    {
                        error_cedula = true;
                    }
                    else
                    {
                        error_cedula = false;
                    }
                    panel4.Refresh();
                } else if (colaborador.Cedula.ToString().Equals(tb_cedula.Text))
                {
                    carga_inicial = true;
                    error_cedula = false;
                    panel4.Refresh();
                } else
                {
                    carga_inicial = true;
                    if (parent.buscar_cedula(tb_cedula.Text))
                    {
                        error_cedula = true;
                    }
                    else
                    {
                        error_cedula = false;
                    }
                    panel4.Refresh();
                }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
            if (!carga_inicial)
            {

            }
            else if (error_cedula)
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                valido = false;
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, Color.LimeGreen, ButtonBorderStyle.Solid);
                valido = true;
            }
           
        }

        private void tb_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void tb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
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
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
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
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
