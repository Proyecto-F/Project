using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Sistema_de_Ingreso
{
    class Lista
    {
        //Creacion de la Lista de Usuarios
        List<Usuarios> Lusuarios { set; get; }

       public Lista()
        {
            Lusuarios = new List<Usuarios>();
        }

        //Creacion del métodod Agregar para la lista
        public void Agregar(Usuarios usuarios)
        {
            Lusuarios.Add(usuarios);
        }
    }
}
