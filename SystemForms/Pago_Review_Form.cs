using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SystemForms
{
    public partial class Pago_Review_Form : Form
    {
        Pago pago;
        Pago_Review parent;
        public Pago_Review_Form(Pago pago, Pago_Review parent)
        {
            InitializeComponent();
            this.pago = pago;
            this.parent = parent;
            setear_datos();
        }

        public void setear_datos()
        {
            lb_nombre.Text = pago.Id_colaborador.ToString();
            nud_horas.Value = pago.HorasLaboradas;
            nud_extras.Value = pago.HorasExtra;

            tb_bono.Tag = pago.Bono.ToString();
            tb_bono.Text = pago.Bono.ToString("C");

            tb_bruto.Tag = pago.SalarioBruto.ToString();
            tb_bruto.Text = pago.SalarioBruto.ToString("C");

            tb_rebajo.Tag = pago.Rebajo.ToString();
            tb_rebajo.Text = pago.Rebajo.ToString("C");

            tb_neto.Tag = pago.SalarioNeto.ToString();
            tb_neto.Text = pago.SalarioNeto.ToString("C");
        
            tb_transferencia.Text = pago.TransferenciaPago;

            rb_activo.Checked = pago.EstadoPago;
            rb_inactivo.Checked = !pago.EstadoPago;
        }

        public void recalcular_salarios()
        {
            Decimal bruto = Convert.ToDecimal(pago.SalarioBruto) + Convert.ToDecimal(tb_bono.Tag) - Convert.ToDecimal(tb_rebajo.Tag);
            tb_bruto.Tag = bruto;
            tb_bruto.Text = bruto.ToString("C");
            Decimal neto = Convert.ToDecimal(tb_bruto.Tag) - (Convert.ToDecimal(tb_bruto.Tag) * Convert.ToDecimal(0.1));
            tb_neto.Tag = neto;
            tb_neto.Text = neto.ToString("C");
        }

        private void tb_bono_Enter(object sender, EventArgs e)
        {
            tb_bono.Text = Convert.ToString(tb_bono.Tag);
        }

        private void tb_bono_Leave(object sender, EventArgs e)
        {
            if (!tb_bono.Text.Equals(""))
            {
                try
                {
                    Decimal precio = Convert.ToDecimal(tb_bono.Text);
                    tb_bono.Tag = precio;
                    tb_bono.Text = precio.ToString("C");
                    recalcular_salarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El bono no posee un formato válido", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_bono.Focus();
                }
            }
        }

        private void tb_bono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_bruto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_bruto_Leave(object sender, EventArgs e)
        {
            if (!tb_bruto.Text.Equals(""))
            {
                try
                {
                    Decimal precio = Decimal.Parse(tb_bruto.Text);
                    tb_bruto.Tag = precio;
                    tb_bruto.Text = precio.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El salario bruto no posee un formato válido", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_bruto.Focus();
                }
            }
        }

        private void tb_bruto_Enter(object sender, EventArgs e)
        {
            tb_bruto.Text = Convert.ToString(tb_bruto.Tag);
        }

        private void tb_rebajo_Enter(object sender, EventArgs e)
        {
            tb_rebajo.Text = Convert.ToString(tb_rebajo.Tag);
        }

        private void tb_rebajo_Leave(object sender, EventArgs e)
        {
            if (!tb_rebajo.Text.Equals(""))
            {
                try
                {
                    Decimal precio = Decimal.Parse(tb_rebajo.Text);
                    tb_rebajo.Tag = precio;
                    tb_rebajo.Text = precio.ToString("C");
                    recalcular_salarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El rebajo no posee un formato válido", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_rebajo.Focus();
                }
            }
        }

        private void tb_rebajo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_neto_Enter(object sender, EventArgs e)
        {
            tb_neto.Text = Convert.ToString(tb_neto.Tag);
        }

        private void tb_neto_Leave(object sender, EventArgs e)
        {
            if (!tb_neto.Text.Equals(""))
            {
                try
                {
                    Decimal precio = Decimal.Parse(tb_neto.Text);
                    tb_neto.Tag = precio;
                    tb_neto.Text = precio.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El rebajo no posee un formato válido", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_neto.Focus();
                }
            }
        }

        private void tb_neto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            pago.TransferenciaPago = tb_transferencia.Text;
            pago.Bono = Convert.ToDecimal(tb_bono.Tag); 
            pago.Rebajo = Convert.ToDecimal(tb_rebajo.Tag);
            pago.SalarioBruto = Convert.ToDecimal(tb_bruto.Tag);
            pago.SalarioNeto = Convert.ToDecimal(tb_neto.Tag);
            pago.EstadoPago = rb_activo.Checked;
            parent.salvar_cambios(pago);
            this.Close();
        }
    }
}
