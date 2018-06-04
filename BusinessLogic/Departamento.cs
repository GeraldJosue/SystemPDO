using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Departamento
    {

        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public Boolean Estado { get; set; }

        public Departamento()
        {

        }

        public Departamento(Int32 id, String nombre, Boolean estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = estado;
        }


        public Boolean agregar()
        {
            Departamento_TO departamento = bl_to_to();
            return new Departamento_BD().agregar(departamento);
        }

        public Boolean editar(List<Int32> lista)
        {
            Departamento_TO departamento = bl_to_to();
            return new Departamento_BD().editar(departamento, lista);
        }

        public List<Departamento> obtener_lista()
        {
            List<Departamento> lista = new List<Departamento>();
            List<Departamento_TO> lista_TO = new Departamento_BD().obtener_lista();
            foreach (Departamento_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Departamento_TO departamento = new Departamento_TO();
            departamento.Id = this.Id;
            departamento.Estado = this.Estado;
            return new Departamento_BD().eliminar(departamento);
        }


        public Departamento_TO bl_to_to()
        {
            Departamento_TO departamento = new Departamento_TO();
            departamento.Id = this.Id;
            departamento.Nombre = this.Nombre;            
            departamento.Estado = this.Estado;
            return departamento;
        }


        public Departamento to_to_bl(Departamento_TO to)
        {
            Departamento departamento = new Departamento();
            departamento.Id = to.Id;
            departamento.Nombre = to.Nombre;            
            departamento.Estado = to.Estado;
            return departamento;
        }


    }
}