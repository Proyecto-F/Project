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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
         //Inicio del recorrido de panel de imagenes
            timer.Enabled = true;
            timer.Start();
        }
        
        //Panel de imagenes de muestra
        private void timer_Tick(object sender, EventArgs e)
        {
            for(int i=1; i<=12; i++)
            {
                if (i == 1)
                    ptbPresentacion.Image = pictureBox1.Image;
                if (i == 2)
                    ptbPresentacion.Image = pictureBox2.Image;
                if (i == 3)
                    ptbPresentacion.Image = pictureBox3.Image;
                if (i == 4)
                    ptbPresentacion.Image = pictureBox4.Image;
                if (i == 5)
                    ptbPresentacion.Image = pictureBox5.Image;
                if (i == 6)
                    ptbPresentacion.Image = pictureBox6.Image;
                if (i == 7)
                    ptbPresentacion.Image = pictureBox7.Image;
                if (i == 8)
                    ptbPresentacion.Image = pictureBox8.Image;
                if (i == 9)
                    ptbPresentacion.Image = pictureBox9.Image;
                if (i == 10)
                    ptbPresentacion.Image = pictureBox10.Image;
                if (i == 11)
                    ptbPresentacion.Image = pictureBox11.Image;
                if (i == 12)
                {
                    ptbPresentacion.Image = pictureBox12.Image;
                    i = 1;
                }
            }

        }

        //Paso a Registrar y cierre del la pantalla principal
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            Principal principal = new Principal();
            principal.Close();
            registrar.Show();
        }

        //Paso a Ingresar y cierre del la pantalla principal
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            Principal principal = new Principal();
            principal.Close();
            ingresar.Show();
        }
    }
}
