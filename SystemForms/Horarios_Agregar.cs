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
    public partial class Horarios_Agregar : UserControl
    {
        public Horarios_Agregar()
        {
            InitializeComponent();
        }

        public void test()
        {
            MessageBox.Show("Test:" + tb_codigo.Text);
        }
    }
}
