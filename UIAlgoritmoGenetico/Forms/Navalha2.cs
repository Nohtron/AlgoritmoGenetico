using System;
using System.Windows.Forms;
using AlgoritmoGenetico2;

namespace UIAlgoritmoGenetico.Forms
{
    public partial class Navalha2 : Form
    {
        GuideLinecs navalha;
        FormHome formHome;

        public Navalha2(FormHome formHome)
        {
            this.formHome = formHome;
            InitializeComponent();
            navalha = new GuideLinecs();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            navalha.revestimentoVisado = float.Parse(textBoxTarget.Text, System.Globalization.NumberStyles.Float);
            navalha.tamanhoDaPopulacao = int.Parse(textBoxTamanhoPopulacao.Text);
            navalha.elitismo = int.Parse(textBoxElitismo.Text);
            navalha.taxaDeMutacao = float.Parse(textBoxTaxaDeMutacao.Text) / 100;

            navalha.velocidadeMaxima = float.Parse(textBoxVelocidadeLimiteMaximo.Text, System.Globalization.NumberStyles.Float);
            navalha.velocidadeMinima = float.Parse(textBoxVelocidadeLimiteMinimo.Text, System.Globalization.NumberStyles.Float);

            navalha.pressaoMaxima = float.Parse(textBoxPressaoLimiteMaximo.Text, System.Globalization.NumberStyles.Float);
            navalha.pressaoMinima = float.Parse(textBoxPressaoLimiteMinimo.Text, System.Globalization.NumberStyles.Float);

            navalha.distanciaMaxima = float.Parse(textBoxDistanciaLimiteMaximo.Text, System.Globalization.NumberStyles.Float);
            navalha.distanciaMinima = float.Parse(textBoxDistanciaLimiteMinimo.Text, System.Globalization.NumberStyles.Float);

            navalha.kMinima = float.Parse(textBoxLimiteMinimoK.Text, System.Globalization.NumberStyles.Float);
            navalha.kMaxima = float.Parse(textBoxLimiteMaximoK.Text, System.Globalization.NumberStyles.Float);

            navalha.aMinima = float.Parse(textBoxLimiteMinimoA.Text,System.Globalization.NumberStyles.Float);
            navalha.aMaxima = float.Parse(textBoxLimiteMaximoA.Text);

            navalha.bMinima= float.Parse(textBoxLimiteMinimoB.Text, System.Globalization.NumberStyles.Float);
            navalha.bMaxima = float.Parse(textBoxLimiteMaximoB.Text, System.Globalization.NumberStyles.Float);

            navalha.cMinima = float.Parse(textBoxLimiteMinimoC.Text, System.Globalization.NumberStyles.Float);
            navalha.cMaxima = float.Parse(textBoxLimiteMaximoC.Text, System.Globalization.NumberStyles.Float);



            navalha.start();
            //timer1.Enabled = true;

            UpdateTexts();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.fitness == 1)
            {
                timer1.Enabled = false;
            }

            navalha.proximaGeracao();

            UpdateTexts();
        }

        private void UpdateTexts()
        {
            textBoxGeracao.Text = navalha.populacaoNavalha.geracao.ToString();

            textBoxMelhorIndividuoVelocidade.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[0].ToString();
            textBoxMelhorIndividuoPressao.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[1].ToString();
            textBoxMelhorIndividuoDistancia.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[2].ToString();
            textBoxMelhorIndividuoFitness.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.fitness.ToString();

            textBoxMelhorIndividuoTarget.Text = navalha.calcularRevestimentoVisado(navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes).ToString();

            textBoxMelhorIndividuoK.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[3].ToString();
            textBoxMelhorIndividuoA.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[4].ToString();
            textBoxMelhorIndividuoB.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[5].ToString();
            textBoxMelhorIndividuoC.Text = navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes.genes[6].ToString();

            textBoxPresetPressaoCalc.Text = navalha.calcularPresetDePressao(navalha.populacaoNavalha.melhorIndividuoDeTodasAsGeracoes).ToString();

            listBoxPopulacao.DataSource = navalha.getPopulacao();

        }

        private void Navalha2_FormClosing(object sender, FormClosingEventArgs e)
        {
            formHome.Show();
        }

        private void buttonProximaGeracao_Click(object sender, EventArgs e)
        {
            navalha.proximaGeracao();

            UpdateTexts();
        }

        private void buttonEvoluir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
