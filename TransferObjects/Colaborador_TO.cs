using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Colaborador_TO
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
        public Int32 Vacaciones { get; set; }
    }
}
