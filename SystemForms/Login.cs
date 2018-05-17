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
    public partial class Login : UserControl
    {
       
        public Login()
        {
            InitializeComponent();
            
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.FindForm();
            parent.enable_disable(true, Color.Firebrick);
        }
    }
}
