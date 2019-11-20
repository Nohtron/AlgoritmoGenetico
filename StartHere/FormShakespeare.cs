using AlgoritmoGenetico;
using System;
using System.Windows.Forms;


namespace StartHere
{

    public partial class FormShakespeare : Form
    {
        private FormHome formHome;
        private Populacao populacaoTexto;
        private Algoritmo ag;
        private System.Random random;

        public FormShakespeare(FormHome formHome)
        {
            this.formHome = formHome;
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            textBox1.Text = "Insira sua frase aqui!";
            textBox2.Text = "200";
            textBox3.Text = "5";
            textBox4.Text = "1";

            random = new System.Random();
            populacaoTexto = new Populacao();
            ag = new Algoritmo(populacaoTexto, random);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            populacaoTexto.target = textBox1.Text;
            populacaoTexto.size = int.Parse(textBox2.Text);
            populacaoTexto.elitismo = int.Parse(textBox3.Text);
            populacaoTexto.taxaDeMutacao = float.Parse(textBox4.Text)/100;
            
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = ag.geracao.ToString();
            labelbestFitnessText.Text = ag.bestFitness.ToString();
            labelbestText.Text = ag.bestIndividuo.ToString();
            //listBox1.DataSource = populacaoTexto.individuos.ToString();

            progressBar1.Value = (int)(ag.bestFitness*100);

            if (ag.bestFitness == 1)
            {
                timer1.Enabled = false;
                return;
            }
        }

        private void formShakespeare_FormClose(object sender, FormClosedEventArgs e)
        {
            formHome.Show();
        }
    }
}
