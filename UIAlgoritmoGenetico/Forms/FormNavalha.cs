using System;
using System.Windows.Forms;
using UIAlgoritmoGenetico.Classes;

namespace UIAlgoritmoGenetico.Forms
{
    public partial class FormNavalha : Form
    {
        private FormHome formHome;

        Navalha navalha = new Navalha();

        public FormNavalha(FormHome formHome)
        {
            this.formHome = formHome;
            InitializeComponent();
        }


        private void FormNavalha_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Passo 1 - Criar primeira geração (População Inicial)
            //      1.1 - Ter um DNA
            //          1.1.1 - Definir o tamanho do DNA
            //          1.1.2 - Definir como gerar os genes do DNA (valores individuais que compõem o DNA)
            //      1.2 - Definir o tamanho da população

            //Passo 2 - Criar a próxima geração (População seguinte à população atual)
            //      2.1 - Avaliar os individuos
            //          2.1.1 - Definir a função que avalia os melhores individuos (FitnessFunction)
            //          2.1.2 - Definir o elitismo (Quantidade dos melhores individuos a se repetirem na próxima geração)
            //      2.2 - Selecionar individuos para reprodução
            //          2.2.1 - Definir a função que escolhe individuo(s) para reprodução (ChooseParent)
            //      2.3 - Cruzar individuos selecionados
            //          2.3.1 - Definir a função de reprodução (CrossOver)
            //      2.4 - Aplicar mutação no novo individuo
            //          2.4.1 - Definir a taxa de mutação
            //          2.4.2 - Definir a função de mutação


            navalha.revestimentoVisado = float.Parse(textBoxTarget.Text);
            navalha.populationSize = int.Parse(textBoxTamanhoPopulacao.Text);
            navalha.elitism = int.Parse(textBoxElitismo.Text);
            navalha.mutationRate = float.Parse(textBoxTaxaDeMutacao.Text) / 100;
            navalha.velocidadeMaxima = float.Parse(textBoxVelocidadeLimiteMaximo.Text);
            navalha.velocidadeMinima = float.Parse(textBoxVelocidadeLimiteMinimo.Text);
            navalha.pressaoMaxima = float.Parse(textBoxPressaoLimiteMaximo.Text);
            navalha.pressaoMinima = float.Parse(textBoxPressaoLimiteMinimo.Text);
            navalha.distanciaMaxima = float.Parse(textBoxDistanciaLimiteMaximo.Text);
            navalha.distanciaMinima = float.Parse(textBoxDistanciaLimiteMinimo.Text);
            navalha.start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            navalha.goToNextGeneration();

            textBoxGeracao.Text = navalha.geracao;
            textBoxMelhorIndividuoFitness.Text = navalha.bestFitnessText;
            textBoxMelhorIndividuoVelocidade.Text = navalha.bestVelocidadeText;
            textBoxMelhorIndividuoDistancia.Text = navalha.bestDistanciaText;
            textBoxMelhorIndividuoPressao.Text = navalha.bestPressaoText;
            textBoxMelhorIndividuoTarget.Text = navalha.bestTargetText;

            textBoxMelhorIndividuoK.Text = navalha.bestKText;
            textBoxMelhorIndividuoA.Text = navalha.bestAText;
            textBoxMelhorIndividuoB.Text = navalha.bestBText;
            textBoxMelhorIndividuoC.Text = navalha.bestCText;

            listBoxPopulacao.DataSource = navalha.getPopulacao();

            //progressBar1.Value = (int)(testShakespeare.getBestFitness() * 100);

            if (float.Parse(navalha.bestFitnessText) > 0.99999)
            {
                timer1.Enabled = false;
                return;
            }
        }

        private void FormNavalha_Load(object sender, EventArgs e)
        {

        }
    }
}
