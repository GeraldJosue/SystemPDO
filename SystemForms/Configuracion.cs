using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class Configuracion : UserControl
    {
        BusinessLogic.Configuracion configuracion;
        public Configuracion()
        {
            InitializeComponent();
            setear_Datos();
        }

        private void setear_Datos()
        {
            configuracion = new BusinessLogic.Configuracion().obtener_Configuracion();
            tb_porcent_seguro.Text = configuracion.Porcentaje_Seguro.ToString();
            tb_porcent_hora_extra.Text = configuracion.Porcentaje_Hora_Extra.ToString();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            Decimal porcent_seguro = tb_porcent_seguro.Text == string.Empty ? Decimal.Parse("0") : Decimal.Parse(tb_porcent_seguro.Text);
            Decimal porcent_hora_extra = tb_porcent_hora_extra.Text == string.Empty ? Decimal.Parse("0") : Decimal.Parse(tb_porcent_hora_extra.Text);

            if (new BusinessLogic.Configuracion(1, porcent_seguro, porcent_hora_extra).guardar_configuracion())
            {
                MessageBox.Show("Configuración guardada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
