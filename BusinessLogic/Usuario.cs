using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Usuario
    {

        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Contraseña { get; set; }

        public Usuario() { }

        public Usuario(Int32 id, String nombre, String contraseña)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
        }
        //Valida que la contraseña corresponda a los credenciales
        public Boolean validar()
        {
            Usuario_TO usuario = new Usuario_TO();
            usuario.Id = this.Id;
            usuario.Nombre = this.Nombre;
            usuario.Contraseña = this.Contraseña;

            Usuario_TO usuario_bd = new Usuario_BD().validar(usuario);

            if (usuario_bd.Id != 0)
            {
                SHA256 sha256 = SHA256Managed.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(this.Contraseña);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder result = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    result.Append(hash[i].ToString("X2"));
                }

                if (usuario_bd.Contraseña.Equals(result.ToString()))
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }

    }

  
}
