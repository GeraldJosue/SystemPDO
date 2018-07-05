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
    public partial class Registros_Agregar : UserControl
    {
        Registros_Control parent;
        List<Departamento> departamentos;
        List<Colaborador> colaboradores;
        Colaborador colaborador;
        List<Horario> horarios;
        Horario horario;
        Registro registro;
        DateTimePicker dtp_generico;
        Progress_Form avance;

        public Registros_Agregar(Registros_Control parent)
        {
            InitializeComponent();
            dtp_generico = new DateTimePicker();
            dtp_generico.Visible = false;
            this.parent = parent;
            departamentos = new Departamento().obtener_lista_activos();
            colaboradores = new Colaborador().obtener_lista_activos();
            horarios = new Horario().obtener_lista_activos();
            llenar_cb_colaboradores();
            llenar_cb_departamentos();
            //iniciar_controles();
            //calcular_horas();

            //llenar_tabla();
        }

        public Registros_Agregar(Registro registro, Colaborador colaborador, Horario horario, Registros_Control parent)
        {
            InitializeComponent();
            dtp_generico = new DateTimePicker();
            dtp_generico.Visible = false;
            this.parent = parent;

            this.registro = registro;
            this.colaborador = colaborador;
            this.horario = horario;

            //horarios = new Horario().obtener_lista_activos();
            //setear_horario_edicion();

            llenar_tabla_edicion();
        }

        public Boolean agregar_sys(DataGridViewRow row)
        {
            //if (pn_validacion.BackColor == Color.LimeGreen)
            //{
            Registro registro = obtener_datos(row);
            registro.Id_Colaborador = colaborador.Id;
            if (registro.agregar())
            {
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
            Registro registro = obtener_datos(dg_registros.Rows[0]);
            registro.Id = this.registro.Id;
            registro.Id_Colaborador = this.registro.Id_Colaborador;
            List<Int32> lista = validar_cambios(registro);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (registro.editar(lista))
            {
                MessageBox.Show("Registro editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Registro obtener_datos(DataGridViewRow row)
        {

            //Int32 id = Int32.Parse(cb_colaborador.SelectedValue.ToString());
            DateTime fecha = DateTime.Parse(row.Cells["fecha"].Value.ToString());
            DateTime entrada = DateTime.Parse(row.Cells["entrada"].Value.ToString());
            DateTime salida = DateTime.Parse(row.Cells["salida"].Value.ToString());
            DateTime desayuno = DateTime.Parse(row.Cells["desayuno"].Value.ToString());
            DateTime almuerzo = DateTime.Parse(row.Cells["almuerzo"].Value.ToString());
            DateTime cafe = DateTime.Parse(row.Cells["cafe"].Value.ToString());
            Decimal horas = Decimal.Parse(row.Cells["horas_laboradas"].Value.ToString());
            Decimal extras = Decimal.Parse(row.Cells["horas_extras"].Value.ToString());

            return new Registro(0, 0, fecha, entrada, salida, desayuno, almuerzo, cafe, horas, extras, true, true);

        }

        public List<Int32> validar_cambios(Registro nuevo)
        {
            List<Int32> lista = new List<Int32>();
            if (nuevo.Id_Colaborador != this.registro.Id_Colaborador)
            {
                lista.Add(0);
            }
            if (nuevo.Fecha.Date != this.registro.Fecha.Date)
            {
                lista.Add(1);
            }
            if (nuevo.Entrada.TimeOfDay != this.registro.Entrada.TimeOfDay)
            {
                lista.Add(2);
            }
            if (nuevo.Salida.TimeOfDay != this.registro.Salida.TimeOfDay)
            {
                lista.Add(3);
            }
            if (nuevo.Desayuno.TimeOfDay != this.registro.Desayuno.TimeOfDay)
            {
                lista.Add(4);
            }
            if (nuevo.Cafe.TimeOfDay != this.registro.Cafe.TimeOfDay)
            {
                lista.Add(5);
            }
            if (nuevo.Almuerzo.TimeOfDay != this.registro.Almuerzo.TimeOfDay)
            {
                lista.Add(6);
            }
            if (nuevo.Horas != this.registro.Horas)
            {
                lista.Add(7);
            }
            if (nuevo.Extras != this.registro.Extras)
            {
                lista.Add(8);
            }
            if (nuevo.Estado != this.registro.Estado)
            {
                lista.Add(9);
            }
            if (nuevo.Proceso != this.registro.Proceso)
            {
                lista.Add(10);
            }
            return lista;
        }

        public void limpiar_controles()
        {
        }

        public void llenar_cb_colaboradores()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            foreach (Colaborador c in colaboradores)
            {
                dt.Rows.Add(c.Id, c.Nombre + " " + c.Apellido);
            }

            cb_colaborador.ValueMember = "Id";
            cb_colaborador.DisplayMember = "Nombre";
            cb_colaborador.DataSource = dt;
        }
        public void llenar_cb_departamentos()
        {
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

        private void cb_colaborador_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Colaborador c in colaboradores)
            {
                if (c.Id == Int32.Parse(cb_colaborador.SelectedValue.ToString()))
                {
                    foreach (Horario h in horarios)
                    {
                        if (c.Id_horario == h.Id)
                        {
                            horario = h;
                        }
                    }
                }
            }
            lb_colaborador.Text = "Colaborador: " + cb_colaborador.Text;
        }

        public void llenar_tabla()
        {
            dg_registros.Rows.Clear();
            horario = setear_horario();
            DateTime date = dt_inicio.Value.Date;
            Int32 flag = 0;
            while (DateTime.Compare(dt_fin.Value.Date, date.AddDays(flag)) >= 0)
            {
                dg_registros.Rows.Add(true, date.AddDays(flag++).ToLongDateString(), horario.Hora_Inicio.ToShortTimeString(), horario.Hora_Fin.ToShortTimeString(), horario.Horas, 0, date.AddHours(horario.Hora_Inicio.Hour + 2).ToShortTimeString(), date.AddHours(12).ToShortTimeString(), date.AddHours(horario.Hora_Fin.Hour - 2).ToShortTimeString()); 
            }
            dg_horas_totales.Rows.Clear();
            dg_horas_totales.Rows.Add(0, 0);
            calcular_horas();
        }

        public void llenar_tabla_edicion()
        {
            dt_inicio.Enabled = false;
            dt_fin.Enabled = false;
            cb_colaborador.Enabled = false;
            cb_departamento.Enabled = false;
           
            dg_registros.Rows.Add(true, registro.Fecha.ToLongDateString(), registro.Entrada.ToShortTimeString(), registro.Salida.ToShortTimeString(), registro.Horas, registro.Extras, registro.Desayuno.ToShortTimeString(), registro.Almuerzo.ToShortTimeString(), registro.Cafe.ToShortTimeString());
            dg_horas_totales.Rows.Clear();
            dg_horas_totales.Rows.Add(0, 0);
            calcular_horas();
        }

        public Horario setear_horario()
        {
            foreach (Colaborador c in colaboradores)
            {
                if (c.Id == Int32.Parse(cb_colaborador.SelectedValue.ToString()))
                {
                    foreach (Horario h in horarios)
                    {
                        if (c.Id_horario == h.Id)
                        {
                            return h;
                        }
                    }
                }
            }
            return null;
        }

        public Horario setear_horario_edicion()
        {

            foreach (Horario h in horarios)
            {
                if (registro.Id_Colaborador == h.Id)
                {
                    return h;
                }
            }
            return null;
        }

        private void dg_registros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
            {
                
                //Initialized a new DateTimePicker Control  
                dtp_generico = new DateTimePicker();
                dtp_generico.Value = DateTime.Parse(dg_registros.CurrentCell.Value.ToString());
                //Adding DateTimePicker control into DataGridView   
                dg_registros.Controls.Add(dtp_generico);

                // Setting the format (i.e. 2014-10-10)  
                dtp_generico.Format = DateTimePickerFormat.Time;
                dtp_generico.ShowUpDown = true;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dg_registros.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                dtp_generico.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                dtp_generico.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                //dtp_generico.CloseUp += new EventHandler(dtp_generico_OnTextChange);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                dtp_generico.TextChanged += new EventHandler(dtp_generico_OnTextChange);

                // Now make it visible  
                dtp_generico.Visible = true;
            }
        }

        private void dtp_generico_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dg_registros.CurrentCell.Value = dtp_generico.Value.ToShortTimeString();
        }

        private void dg_registros_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtp_generico.Visible = false;
            recalcular_horas(DateTime.Parse(dg_registros.Rows[e.RowIndex].Cells["entrada"].Value.ToString()), DateTime.Parse(dg_registros.Rows[e.RowIndex].Cells["salida"].Value.ToString()), e);
        }

        public void calcular_horas()
        {
            Decimal horas = 0;
            Decimal extras = 0;
            foreach(DataGridViewRow row in dg_registros.Rows)
            {
                if (Convert.ToBoolean(row.Cells["review"].Value))
                {
                    horas += Convert.ToDecimal(row.Cells["horas_laboradas"].Value.ToString());
                    extras += Convert.ToDecimal(row.Cells["horas_extras"].Value.ToString());
                }
            }
            dg_horas_totales.Rows[0].Cells["horas_totales"].Value = horas;
            dg_horas_totales.Rows[0].Cells["extras_totales"].Value = extras;
        }

        public void recalcular_horas(DateTime entrada, DateTime salida, DataGridViewCellEventArgs e)
        {
            Decimal horas = salida.Hour - entrada.Hour;

            if(salida.Hour > 12 && entrada.Hour < 12)
            {
                --horas;
            }
            if (horas > horario.Horas) {

                dg_registros.Rows[e.RowIndex].Cells["horas_laboradas"].Value = horario.Horas;
                dg_registros.Rows[e.RowIndex].Cells["horas_extras"].Value = horas - horario.Horas;

            } else
            {
                dg_registros.Rows[e.RowIndex].Cells["horas_laboradas"].Value = horas;
                dg_registros.Rows[e.RowIndex].Cells["horas_extras"].Value = 0;
            }
            calcular_horas();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (registro == null)
            {
                colaborador = new Colaborador();
                colaborador.Id = Int32.Parse(cb_colaborador.SelectedValue.ToString());
                bgw_registros.RunWorkerAsync();
                avance = new Progress_Form();
                avance.ShowDialog();
            } else
            {
                if (editar_sys())
                {
                    parent.cancelar_button();
                } else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            parent.cancelar_button();
        }

        private void bgw_registros_DoWork(object sender, DoWorkEventArgs e)
        {
            Int32 flag = 0;
            Int32 avance = 0;
            String f = dg_horas_totales.Rows[0].Cells["horas_totales"].Value.ToString();
            foreach (DataGridViewRow row in dg_registros.Rows)
            {
                if (Convert.ToBoolean(row.Cells["review"].Value)){
                    agregar_sys(row);
                    avance = ((++flag) * 100) / dg_registros.Rows.Count;
                    bgw_registros.ReportProgress(avance);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void bgw_registros_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            avance.progreso(e.ProgressPercentage);
        }

        private void bgw_registros_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            avance.Close();
            parent.cancelar_button();
        }

        private void dg_registros_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Convert.ToBoolean(dg_registros.Rows[e.RowIndex].Cells["review"].Value);
                calcular_horas();
            }
            
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void dt_fin_ValueChanged(object sender, EventArgs e)
        {
            llenar_tabla();
        }
    }
}
