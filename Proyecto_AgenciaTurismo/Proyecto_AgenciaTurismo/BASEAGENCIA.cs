using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AgenciaTurismo
{
    public partial class BaseAgencia : Form
    {
        public BaseAgencia()
        {
            InitializeComponent();
        }

        private void btnLitoral_Click(object sender, EventArgs e)
        {
            REGIONLITORAL regionlitoral = new REGIONLITORAL();
            regionlitoral.Show();

            BaseAgencia baseAgencia = new BaseAgencia();
            baseAgencia.Close();

        }

        private void btnCosta_Click(object sender, EventArgs e)
        {
            REGIONCOSTA regioncosta = new REGIONCOSTA();

            regioncosta.Show();
            BaseAgencia baseAgencia = new BaseAgencia();
            baseAgencia.Close();


        }

        private void btnSierra_Click(object sender, EventArgs e)
        {
            REGIONSIERRA regionsierra = new REGIONSIERRA();

            regionsierra.Show();

            BaseAgencia baseAgencia = new BaseAgencia();
            baseAgencia.Close();

        }

        private void btnAmazonia_Click(object sender, EventArgs e)
        {
            REGIONAMAZONIA regionamazonica = new REGIONAMAZONIA();

            regionamazonica.Show();

            BaseAgencia baseAgencia = new BaseAgencia();
            baseAgencia.Close();

        }
    }
}
