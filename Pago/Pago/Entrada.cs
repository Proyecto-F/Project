using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pago
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            PagoTarjeta pagoTarjeta = new PagoTarjeta();
            pagoTarjeta.Show();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            PagoEfectivo pagoEfectivo = new PagoEfectivo();
            pagoEfectivo.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR UTILIZAR NUESTRO SERVICIO VUELVA PRONTO");
        }
    }
}
