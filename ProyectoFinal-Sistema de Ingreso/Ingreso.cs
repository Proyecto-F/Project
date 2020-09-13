using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Sistema_de_Ingreso
{
    public class Ingreso
    {
        List<Usuarios> usuarios = new List<Usuarios>();

        string u, c;
        public bool Usu(string cadena)
        {
            foreach(Usuarios usuario in usuarios)
            {
                if (usuario.Usuario == cadena)
                {
                    u = usuario.Usuario;
                }
            }
            if (u != "")
                return true;
            else
                return false;
        }
        public bool Contra(string cadena)
        {
            foreach (Usuarios usuario in usuarios)
            {
                if (usuario.Contraseña == cadena)
                {
                    c = usuario.Contraseña;
                }
            }
            if (c != "")
                return true;
            else
                return false;
        }
    }
}
