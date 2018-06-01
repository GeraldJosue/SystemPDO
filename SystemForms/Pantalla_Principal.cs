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
    public partial class Pantalla_Principal : Form
    {
        private Login login;
        private Home home;

        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.Dock = DockStyle.Fill;
            pn_principal.Controls.Add(login);
        }

        public void inicio()
        {
            home = new Home();
            home.Dock = DockStyle.Fill;
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(home);
        }
    }
}
