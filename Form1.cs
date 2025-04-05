using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Bu satır hep en üstte olmalı!

            if (!this.DesignMode)
            {
                // Tasarım modunda çalışmasın dediğin kodlar buraya
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Restoran yeniRestoran = new Restoran();

            yeniRestoran.restoranAdi = txtRestoranAdi.Text;
            yeniRestoran.sandalyeSayisi = int.Parse(txtSandalyeSayisi.Text);

            label3.Text = yeniRestoran.MesajYazdir();
        }
    }
}
