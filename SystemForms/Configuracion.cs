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
            num_porcent_seguro.Value = configuracion.Porcentaje_Seguro;
            num_porcent_hora_extra.Value = configuracion.Porcentaje_Hora_Extra;
             
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            Decimal porcent_seguro = num_porcent_seguro.Text == string.Empty ? Decimal.Parse("0,0") : num_porcent_seguro.Value;
            Decimal porcent_hora_extra = num_porcent_hora_extra.Text == string.Empty ? Decimal.Parse("0,0") : num_porcent_hora_extra.Value;

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
