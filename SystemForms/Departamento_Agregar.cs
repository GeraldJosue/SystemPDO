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
    public partial class Departamento_Agregar : UserControl
    {

        Departamento departamento;
        public Departamento_Agregar()
        {
            InitializeComponent();
        }

        public Departamento_Agregar(Departamento departamento)
        {
            InitializeComponent();
            this.departamento = departamento;
            setear_datos();
        }

        public void setear_datos()
        {
            tb_nombre.Text = departamento.Nombre;            
            rb_activo.Checked = departamento.Estado;
            rb_inactivo.Checked = departamento.Estado;
        }

        public Boolean agregar_sys()
        {
           Departamento departamento = obtener_datos();
            if (departamento.agregar())
            {
                MessageBox.Show("Colaborador agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Departamento departamento = obtener_datos();
            departamento.Id = this.departamento.Id;
            List<Int32> lista = validar_cambios(departamento);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (departamento.editar(lista))
            {
                MessageBox.Show("Departamento editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        public Departamento obtener_datos()
        {            
            String nombre = tb_nombre.Text.Equals("") ? "No disponible" : tb_nombre.Text;          
            Boolean estado = rb_activo.Checked ? true : false;

            //Revisar datos por defecto
            return new Departamento(0, nombre, estado);
        }

        public List<Int32> validar_cambios(Departamento nuevo)
        {
            List<Int32> lista = new List<Int32>();            
            if (!nuevo.Nombre.Equals(this.departamento.Nombre))
            {
                lista.Add(0);
            }            
            if (nuevo.Estado != this.departamento.Estado)
            {
                lista.Add(1);
            }
            return lista;
        }

    }
}
