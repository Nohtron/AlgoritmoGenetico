using RedeNeural;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAlgoritmoGenetico.Forms
{
    public partial class RedeNeuralForm : Form
    {
        FormHome formHome;
        NN brain;

        public RedeNeuralForm(FormHome formHome)
        {
            this.formHome = formHome;
            InitializeComponent();
        }

        private void RedeNeuralForm_Load(object sender, EventArgs e)
        {

        }

        private void RedeNeuralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome.Show();
        }

        private void buttonInicializar_Click(object sender, EventArgs e)
        {
            int numeroDeEntradas = int.Parse(textBoxEntradas.Text);
            int numeroDeHiddens = int.Parse(textBoxHiddens.Text);
            int numeroDeSaidas = int.Parse(textBoxSaidas.Text);

            brain = new NN(numeroDeEntradas, numeroDeHiddens, numeroDeSaidas);

            updateScreen();
        }

        private void updateScreen()
        {
            listBoxPesosDeEntrada.DataSource = brain.getPrettyPrintMatrix(brain.pesosEntrada);
            listBoxHiddenLayer.DataSource = brain.getPrettyPrintMatrix(brain.Hidden);
            listBoxSaida.DataSource = brain.getPrettyPrintMatrix(brain.saida);
            //listBoxEntradas.DataSource = entradas
        }
    }
}
