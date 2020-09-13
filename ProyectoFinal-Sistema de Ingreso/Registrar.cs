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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
        //Inicialización de lista y objetos
        Usuarios usuarios = new Usuarios();
        Lista lista= new Lista();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //Registro de datos personales
            usuarios.Nombres = txtNombres.Text;
            usuarios.Apellidos = txtApellidos.Text;
            usuarios.Edad = Convert.ToInt16(mtxtEdad.Text);
            usuarios.Id = mtxtId.Text;
            usuarios.Nacionalidad = txtNacionalidad.Text;
            usuarios.Genero = cmbGenero.Text;

            //Registro de contacto del usuario
            usuarios.NTelefono = mtxtNTelefono.Text;
            usuarios.Direccion = txtDireccion.Text;
            usuarios.Email = txtEmail.Text;

            //Creación del Usuario y contraseña
            usuarios.Usuario = mtxtUsuario.Text;
            usuarios.Contraseña = mtxtContraseña.Text;

            //Adición al listado de Usuarios
            lista.Agregar(usuarios);

            //Regreso a la pagina Principal y cierre del Registro
            Principal principal = new Principal();
            Registrar registrar = new Registrar();
            registrar.Close();
            principal.Show();
        }
    }
}
