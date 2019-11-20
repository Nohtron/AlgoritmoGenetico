using System;
using System.Windows.Forms;
using UIAlgoritmoGenetico.Forms;

namespace UIAlgoritmoGenetico
{

    public partial class FormShakespeare : Form
    {
        private FormHome formHome;

        TestShakespeare testShakespeare = new TestShakespeare();

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


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            testShakespeare.targetString = textBox1.Text;
            testShakespeare.populationSize = int.Parse(textBox2.Text);
            testShakespeare.elitism = int.Parse(textBox3.Text);
            testShakespeare.mutationRate = float.Parse(textBox4.Text)/100;
            testShakespeare.Start();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            testShakespeare.Update();

            label1.Text = testShakespeare.numGenerationsText;
            labelbestFitnessText.Text = testShakespeare.getBestFitness().ToString();
            labelbestText.Text = testShakespeare.bestText;
            listBox1.DataSource = testShakespeare.getPopulacao();

            progressBar1.Value = (int)(testShakespeare.getBestFitness()*100);

            if (testShakespeare.getBestFitness() == 1)
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
