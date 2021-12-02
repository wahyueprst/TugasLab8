using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator08
{
    public partial class Calculator : Form
    {
        public delegate void EventHandler(Kalkulator calc);
        public event EventHandler OnCalc;

        private Kalkulator calc;
        public Calculator()
        {
            InitializeComponent();
            cmbOP.SelectedIndex = 0;
        }

        public Calculator(string title) : this()
        {
            this.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc = new Kalkulator();
            int a = Convert.ToInt32(NilaiA.Text);
            int b = Convert.ToInt32(NilaiB.Text);

                if (cmbOP.Text == "Penjumlahan")
                    calc.Hasilnya = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, a + b);

                if (cmbOP.Text == "Pengurangan")
                    calc.Hasilnya = string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, a - b);

                if (cmbOP.Text == "Perkalian")
                    calc.Hasilnya = string.Format("Hasil Perkalian {0} x {1} = {2}", a, b, a * b);

                if (cmbOP.Text == "Pembagian")
                 calc.Hasilnya = string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, a / b);


            OnCalc(calc);
            NilaiA.Clear();
            NilaiB.Clear();
            NilaiA.Focus();
        }
    }
}
