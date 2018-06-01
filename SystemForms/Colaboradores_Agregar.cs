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
    public partial class Colaboradores_Agregar : UserControl
    {
        BusinessLogic.Colaborador colaborador;
        public Colaboradores_Agregar()
        {
            InitializeComponent();
        }

        public Colaboradores_Agregar(BusinessLogic.Colaborador colaborador)
        {
            InitializeComponent();
            this.colaborador = colaborador;
            setear_datos();
        }

        public Boolean agregar_sys()
        {
            BusinessLogic.Colaborador colaborador = obtener_datos();
            if (colaborador.agregar())
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
            BusinessLogic.Colaborador colaborador = obtener_datos();
            colaborador.Id = this.colaborador.Id;
            List<Int32> lista = validar_cambios(colaborador);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (colaborador.editar(lista))
            {
                MessageBox.Show("Colaborador editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public BusinessLogic.Colaborador obtener_datos()
        {
            Int32 departamento = cb_departamento.SelectedIndex == -1 ? 1 : cb_departamento.SelectedIndex;
            Int32 horario = cb_horario.SelectedIndex == -1 ? 1 : cb_horario.SelectedIndex;
            String nombre = tb_nombre.Text.Equals("") ? "No disponible" : tb_nombre.Text;
            String apellido = tb_apellido.Text.Equals("") ? "No disponible" : tb_apellido.Text;
            String segundo = tb_seg_apellido.Text.Equals("") ? "No disponible" : tb_seg_apellido.Text;
            Int32 cedula = tb_cedula.Text.Equals("") ? 0 : Int32.Parse(tb_cedula.Text);
            Int32 telefono = tb_telefono.Text.Equals("") ? 0 : Int32.Parse(tb_telefono.Text);
            String direccion = tb_direccion.Text.Equals("") ? "No disponible" : tb_direccion.Text;
            DateTime fecha = dt_fecha.Value.Date;
            String civil = cb_civil.SelectedIndex == -1 ? "No disponible" : cb_civil.SelectedText;
            String nacionaliad = tb_nacionalidad.Text.Equals("") ? "No disponible" : tb_nacionalidad.Text;
            String cuenta = tb_cuenta.Text.Equals("") ? "No disponible" : tb_cuenta.Text;
            String entidad = tb_entidad.Text.Equals("") ? "No disponible" : tb_entidad.Text;
            Int32 precio = tb_precio.Text.Equals("") ? 0 : Int32.Parse(tb_precio.Text);
            Int32 ftelefono = tb_ftelefono.Text.Equals("") ? 0 : Int32.Parse(tb_ftelefono.Text);
            String parentesco = cb_parentesco.SelectedIndex == -1 ? "No disponible" : cb_parentesco.SelectedText;
            String fdireccion = tb_fdireccion.Text.Equals("") ? "No disponible" : tb_fdireccion.Text;
            Boolean estado = cb_estado.Checked ? true : false;
            
            //Revisar datos por defecto
            return new BusinessLogic.Colaborador(0, departamento, horario, nombre, apellido, segundo, cedula, telefono, direccion, fecha, civil, cuenta, entidad, nacionaliad, precio
                , ftelefono, parentesco, fdireccion, estado);
        }

        public void setear_datos()
        {
            //Setear el selected index
            //cb_departamento.SelectedIndex
            //cb_horario.SelectedIndex

            tb_nombre.Text = colaborador.Nombre;
            tb_apellido.Text = colaborador.Apellido;
            tb_seg_apellido.Text = colaborador.Segundo_apellido;
            tb_cedula.Text = colaborador.Cedula.ToString();
            tb_telefono.Text = colaborador.Telefono.ToString();
            tb_direccion.Text = colaborador.Direccion;
            dt_fecha.Value = colaborador.Fecha;
            //cb_civil.SelectedIndex =;
            tb_nacionalidad.Text = colaborador.Nacionalidad;
            tb_cuenta.Text = colaborador.Cuenta;
            tb_entidad.Text = colaborador.Entidad;
            tb_precio.Text = colaborador.Precio.ToString();
            tb_ftelefono.Text = colaborador.FTelefono.ToString();
            //cb_parentesco.SelectedIndex =;
            tb_fdireccion.Text = colaborador.FDireccion;
            cb_estado.Checked = colaborador.Estado;
        }

        public List<Int32> validar_cambios(BusinessLogic.Colaborador nuevo)
        {
            List<Int32> lista = new List<Int32>();
            if(nuevo.Id_departamento != this.colaborador.Id_departamento)
            {
                lista.Add(0);
            }
            if(nuevo.Id_horario != this.colaborador.Id_horario)
            {
                lista.Add(1);
            }
            if (!nuevo.Nombre.Equals(this.colaborador.Nombre))
            {
                lista.Add(2);
            }
            if (!nuevo.Apellido.Equals(this.colaborador.Apellido))
            {
                lista.Add(3);
            }
            if (!nuevo.Segundo_apellido.Equals(this.colaborador.Segundo_apellido))
            {
                lista.Add(4);
            }
            if (nuevo.Cedula != this.colaborador.Cedula)
            {
                lista.Add(5);
            }
            if (nuevo.Telefono != this.colaborador.Telefono)
            {
                lista.Add(6);
            }
            if (!nuevo.Direccion.Equals(this.colaborador.Direccion))
            {
                lista.Add(7);
            }
            if (nuevo.Fecha.Date != this.colaborador.Fecha.Date)
            {
                lista.Add(8);
            }
            if (!nuevo.Estado_civil.Equals(this.colaborador.Estado_civil))
            {
                lista.Add(9);
            }
            if (!nuevo.Cuenta.Equals(this.colaborador.Cuenta))
            {
                lista.Add(10);
            }
            if (!nuevo.Entidad.Equals(this.colaborador.Entidad))
            {
                lista.Add(11);
            }
            if (!nuevo.Nacionalidad.Equals(this.colaborador.Nacionalidad))
            {
                lista.Add(12);
            }
            if (nuevo.Precio != this.colaborador.Precio)
            {
                lista.Add(13);
            }
            if (nuevo.FTelefono != this.colaborador.FTelefono)
            {
                lista.Add(14);
            }
            if (!nuevo.Parentesco.Equals(this.colaborador.Parentesco))
            {
                lista.Add(15);
            }
            if (!nuevo.FDireccion.Equals(this.colaborador.FDireccion))
            {
                lista.Add(16);
            }
            if (nuevo.Estado != this.colaborador.Estado)
            {
                lista.Add(17);
            }
            return lista;
        }
    }
}
