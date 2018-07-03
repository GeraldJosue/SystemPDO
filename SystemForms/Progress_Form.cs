using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class Progress_Form : Form
    {
        public Progress_Form()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
        }

        public void progreso(Int32 porcentaje)
        {
            lb_avance.Text = String.Format("Calculando: {0} % del total", porcentaje);
            progressBar1.Value = porcentaje;
        }
    }
}
