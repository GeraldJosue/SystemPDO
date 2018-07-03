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
            tb_usuario.Focus();
            
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            if (new Usuario(0, tb_usuario.Text, tb_contraseña.Text).validar())
            {
                Pantalla_Principal parent = (Pantalla_Principal)this.FindForm();
                parent.inicio();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectos", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (new Usuario(0, tb_usuario.Text, tb_contraseña.Text).validar())
                {
                    Pantalla_Principal parent = (Pantalla_Principal)this.FindForm();
                    parent.inicio();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectos", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tb_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (new Usuario(0, tb_usuario.Text, tb_contraseña.Text).validar())
                {
                    Pantalla_Principal parent = (Pantalla_Principal)this.FindForm();
                    parent.inicio();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectos", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
