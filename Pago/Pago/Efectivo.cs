using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pago
{
    public class Efectivo
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Cedula { set; get; }
        public int Telefono { set; get; }
        public int Valor { set; get; }

        public Efectivo()
        {
        }

        public Efectivo(string nombre, string apellido, int cedula, int telefono, int valor)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            Valor = valor;
        }
    }
}
