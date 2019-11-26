using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class frmHasilPerhitungan : Form
    {
        public frmHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void FrmHasil_OnPerhitungan(int index, int a, int b)
        {
            var hitung = new OperasiHitung();

            if(index == 0)
            {
                lstHasil.Items.Add(string.Format("Hasil penjumlahan : {0} + {1} = {2}", a, b, hitung.Penjumlahan(a, b)));
            }
            else if(index == 1)
            {
                lstHasil.Items.Add(string.Format("Hasil pengurangan : {0} - {1} = {2}", a, b, hitung.Pengurangan(a, b)));
            }
            else if (index == 2)
            {
                lstHasil.Items.Add(string.Format("Hasil perkalian : {0} * {1} = {2}", a, b, hitung.Perkalian(a, b)));
            }
            else
            {
                lstHasil.Items.Add(string.Format("Hasil pembagian : {0} / {1} = {2}", a, b, hitung.Pembagian(a, b)));
            }  
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            frmCalculator myForm = new frmCalculator();

            myForm.OnPerhitungan += FrmHasil_OnPerhitungan;
            myForm.ShowDialog();
        }
    }
}
