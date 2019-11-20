using AlgoritmoGenetico2;
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
    public partial class Shakespeare : Form
    {
        FormHome formHome;

        Random random;

        int tamanhoDaPopulação;
        int tamanhoDoDNA;
        int elitismo;
        Gene geneChar;
        List<Gene> genesShakespeare;
        DNA dnaShakespeare;
        Populacao populacaoShakespeare;

        public Shakespeare(FormHome formHome)
        {
            this.formHome = formHome;
            InitializeComponent();


        }

        private void Shakespeare_Load(object sender, EventArgs e)
        {

        }


        private float fitnessFunction(int indexDoIndividuo)
        {
            float score = 0;
            DNA dna = populacaoShakespeare.individuos[indexDoIndividuo];

            for (int i = 0; i < dna.genes.Count; i++)
            {
                if (dna.genes[i].valor == textBox1.Text.ToCharArray().ElementAt(i))
                {
                    score += 1;
                }
            }

            score /= textBox1.Text.Length;

            //score = (score * score - 1)/1 ;
            //score = (Mathf.Pow(2, score) - 1) / (2 - 1);

            return score;
        }

        private dynamic getRandomChar()
        {
            int i = random.Next(textBox5.Text.Length);
            return textBox5.Text.ToCharArray().ElementAt(i);
        }

        private void Shakespeare_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formHome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            populacaoShakespeare.evoluir();

            listBox1.DataSource = populacaoShakespeare.individuos;

            label1.Text = populacaoShakespeare.geracao.ToString();
            label2.Text = populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.ToString();
            label3.Text = populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.fitness.ToString();

            if (populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.fitness == 1)
            {
                timer1.Enabled = false;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populacaoShakespeare.evoluir();

            listBox1.DataSource = populacaoShakespeare.individuos;

            label1.Text = populacaoShakespeare.geracao.ToString();
            label2.Text = populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.ToString();
            label3.Text = populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.fitness.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            random = new Random();

            tamanhoDaPopulação = int.Parse(textBox2.Text);
            tamanhoDoDNA = textBox1.Text.Length;
            elitismo = int.Parse(textBox3.Text);

            geneChar = new Gene(getRandomChar);
            genesShakespeare = new List<Gene>(tamanhoDoDNA);

            for (int i = 0; i < tamanhoDoDNA; i++)
            {
                genesShakespeare.Add(new Gene(getRandomChar));
            }


            dnaShakespeare = new DNA(genesShakespeare, fitnessFunction);

            populacaoShakespeare = new Populacao(tamanhoDaPopulação, dnaShakespeare, elitismo);
            populacaoShakespeare.classificarPopulacao();

            listBox1.DataSource = populacaoShakespeare.individuos;

            label1.Text = populacaoShakespeare.geracao.ToString();
            label2.Text = populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.ToString();
            label3.Text = populacaoShakespeare.melhorIndividuoDeTodasAsGeracoes.fitness.ToString();
        }
    }
}
