using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Sistema_de_Ingreso
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }
        //Inicio de listas y objetos
        Usuarios usuarios = new Usuarios();
        Lista lista = new Lista();
        Ingreso ingreso = new Ingreso();
        
        //Recepcion del proceso de busqueda de Usuario y Contraseña
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool usu, contra;
            usu = ingreso.Usu(mtxtUsuario.Text);
            contra = ingreso.Contra(mtxtContraseña.Text);
        }
    }
}
