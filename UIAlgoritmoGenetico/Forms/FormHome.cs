using System;
using System.Windows.Forms;
using RedeNeural;

namespace UIAlgoritmoGenetico.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonShakespeare_Click(object sender, EventArgs e)
        {
            FormShakespeare formShakespeare = new FormShakespeare(this);
            formShakespeare.Show();

            this.Hide();
        }

        private void buttonNavalha_Click(object sender, EventArgs e)
        {
            FormNavalha formNavalha = new FormNavalha(this);
            formNavalha.Show();

            this.Hide();

        }

        private void buttonNavalha2_Click(object sender, EventArgs e)
        {
            Navalha2 formNavalha2 = new Navalha2(this);
            formNavalha2.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shakespeare shakespeare = new Shakespeare(this);
            shakespeare.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Caixeiro caixeiro = new Caixeiro(this);
            caixeiro.Show();

            this.Hide();
        }

        private void gatoJPG_Click(object sender, EventArgs e)
        {
            Gatinho gatinho = new Gatinho(this);
            gatinho.Show();

            this.Hide();
        }

        private void buttonRedeNeural_Click(object sender, EventArgs e)
        {
            RedeNeuralForm redeNeuralForm = new RedeNeuralForm(this);
            redeNeuralForm.Show();

            this.Hide();

            //NN brain = new NN(2, 2, 1);
        }
    }
}
