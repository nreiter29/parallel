using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResistanceCalculation
{
    // programming is cool!
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SeriesCircuit seriesCircuit = new SeriesCircuit()
            { 
                ResistorOne = double.Parse(tbxResistorOne.Text),
                ResistorTwo = double.Parse(tbxResistorTwo.Text)
            };

            ParallelCircuit parallelCircuit = new ParallelCircuit() {
                ResistorOne = double.Parse(tbxResistorOne.Text),
                ResistorTwo = double.Parse(tbxResistorTwo.Text)
            };

            lblTotalSeries.Text = seriesCircuit.GetTotalResistance().ToString() + " Ω";
            lblTotalParallel.Text = parallelCircuit.GetTotalResistance().ToString() + " Ω";

        }
    }
}
