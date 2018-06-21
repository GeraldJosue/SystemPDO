using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class Colaborador
    {
        public Int32 Id { get; set; }
        public Int32 Id_departamento { get; set; }
        public Int32 Id_horario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Segundo_apellido { get; set; }
        public Int32 Cedula { get; set; }
        public Int32 Telefono { get; set; }
        public String Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public String Estado_civil { get; set; }
        public String Cuenta { get; set; }
        public String Entidad { get; set; }
        public String Nacionalidad { get; set; }
        public Decimal Precio { get; set; }
        public Int32 FTelefono { get; set; }
        public String Parentesco { get; set; }
        public String FDireccion { get; set; }
        public Boolean Estado { get; set; }
        public String FNombre { get; set; }
        public Int32 Tipo_planilla { get; set; }


        public Colaborador(Int32 id, Int32 departamento, Int32 horario, String nombre, String apellido, String segundo, Int32 cedula, Int32 telefono
            , String direccion, DateTime fecha, String civil, String cuenta, String entidad, String nacionalidad, Decimal precio, Int32 ftelefono
            , String parentesco, String fdireccion, Boolean estado, String fnombre, Int32 tipo)
        {
            this.Id = id;
            this.Id_departamento = departamento;
            this.Id_horario = horario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Segundo_apellido = segundo;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Fecha = fecha;
            this.Estado_civil = civil;
            this.Cuenta = cuenta;
            this.Entidad = entidad;
            this.Nacionalidad = nacionalidad;
            this.Precio = precio;
            this.FTelefono = ftelefono;
            this.Parentesco = parentesco;
            this.FDireccion = fdireccion;
            this.Estado = estado;
            this.FNombre = fnombre;
            this.Tipo_planilla = tipo;
        }

        public Colaborador() {}

        public Boolean agregar()
        {
            Colaborador_TO colaborador = bl_to_to();
            return new Colaborador_BD().agregar(colaborador);
        }

        public Boolean editar(List<Int32> lista)
        {
            Colaborador_TO colaborador = bl_to_to();
            return new Colaborador_BD().editar(colaborador, lista);
        }

        public List<Colaborador> obtener_lista()
        {
            List<Colaborador> lista = new List<Colaborador>();
            List<Colaborador_TO> lista_TO = new Colaborador_BD().obtener_lista();
            foreach(Colaborador_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public List<Colaborador> obtener_lista_activos()
        {
            List<Colaborador> lista = new List<Colaborador>();
            List<Colaborador_TO> lista_TO = new Colaborador_BD().obtener_lista_activos();
            foreach (Colaborador_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Colaborador_TO colaborador = new Colaborador_TO();
            colaborador.Id = this.Id;
            colaborador.Estado = this.Estado;
            return new Colaborador_BD().eliminar(colaborador);
        }

        public Colaborador_TO bl_to_to()
        {
            Colaborador_TO colaborador = new Colaborador_TO();
            colaborador.Id = this.Id;
            colaborador.Id_departamento = this.Id_departamento;
            colaborador.Id_horario = this.Id_horario;
            colaborador.Nombre = this.Nombre;
            colaborador.Apellido = this.Apellido;
            colaborador.Segundo_apellido = this.Segundo_apellido;
            colaborador.Cedula = this.Cedula;
            colaborador.Telefono = this.Telefono;
            colaborador.Direccion = this.Direccion;
            colaborador.Fecha = this.Fecha;
            colaborador.Estado_civil = this.Estado_civil;
            colaborador.Cuenta = this.Cuenta;
            colaborador.Entidad = this.Entidad;
            colaborador.Nacionalidad = this.Nacionalidad;
            colaborador.Precio = this.Precio;
            colaborador.FTelefono = this.FTelefono;
            colaborador.Parentesco = this.Parentesco;
            colaborador.FDireccion = this.FDireccion;
            colaborador.Estado = this.Estado;
            colaborador.FNombre = this.FNombre;
            colaborador.Tipo_planilla = this.Tipo_planilla;
            return colaborador;
        }
        public Colaborador to_to_bl(Colaborador_TO to)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = to.Id;
            colaborador.Id_departamento = to.Id_departamento;
            colaborador.Id_horario = to.Id_horario;
            colaborador.Nombre = to.Nombre;
            colaborador.Apellido = to.Apellido;
            colaborador.Segundo_apellido = to.Segundo_apellido;
            colaborador.Cedula = to.Cedula;
            colaborador.Telefono = to.Telefono;
            colaborador.Direccion = to.Direccion;
            colaborador.Fecha = to.Fecha;
            colaborador.Estado_civil = to.Estado_civil;
            colaborador.Cuenta = to.Cuenta;
            colaborador.Entidad = to.Entidad;
            colaborador.Nacionalidad = to.Nacionalidad;
            colaborador.Precio = to.Precio;
            colaborador.FTelefono = to.FTelefono;
            colaborador.Parentesco = to.Parentesco;
            colaborador.FDireccion = to.FDireccion;
            colaborador.Estado = to.Estado;
            colaborador.FNombre = to.FNombre;
            colaborador.Tipo_planilla = to.Tipo_planilla;
            return colaborador;
        }
    }
}
