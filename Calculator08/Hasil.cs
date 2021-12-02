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
    public partial class Hasil : Form
    {
        private List<Kalkulator> listDariHasil = new List<Kalkulator>();
        public Hasil()
        {
            InitializeComponent();
            Initialisasilv();
        }

        private void Initialisasilv()
        {
            lvHasil.View = View.Details;


            lvHasil.Columns.Add("", 10, HorizontalAlignment.Left);
            lvHasil.Columns.Add("", 200, HorizontalAlignment.Left);
        }
        private void FrmCalc_OnCalculated (Kalkulator calc)
        {
            listDariHasil.Add(calc);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(calc.Hasilnya);

            lvHasil.Items.Add(item);
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator("Calculator");
            calculator.OnCalc += FrmCalc_OnCalculated;
            calculator.ShowDialog();
        }
    }
}
