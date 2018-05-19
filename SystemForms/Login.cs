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
    public partial class Login : UserControl
    {
       
        public Login()
        {
            InitializeComponent();
            
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            if (new Usuario(0, tb_usuario.Text, tb_contraseña.Text).validar())
            {
                MainForm parent = (MainForm)this.FindForm();
                parent.enable_disable(true, Color.Firebrick);
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectos", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
