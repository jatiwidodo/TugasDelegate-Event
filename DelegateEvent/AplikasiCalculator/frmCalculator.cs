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
    public partial class frmCalculator : Form
    {
        public delegate void OperasiHitungEventHandler(int index, int a, int b);

        public event OperasiHitungEventHandler OnPerhitungan;

        public frmCalculator()
        {
            InitializeComponent();
            cbOperasi.Items.Add("Penjumlahan");
            cbOperasi.Items.Add("Pengurangan");
            cbOperasi.Items.Add("Perkalian");
            cbOperasi.Items.Add("Pembagian");
            cbOperasi.SelectedIndex = 0;
            cbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if(cbOperasi.SelectedIndex == 0)
            {
                OnPerhitungan(0, NilaiA, NilaiB);
            }
            else if(cbOperasi.SelectedIndex == 1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if (cbOperasi.SelectedIndex == 2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
        }
    }
}
