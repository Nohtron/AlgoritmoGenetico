using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAlgoritmoGenetico.Classes.EnglishAG;

namespace UIAlgoritmoGenetico.Classes
{
    class Navalha
    {

        // Limites para Validações de sorteio de Genes
        public float distanciaMinima { get; set; }
        public float distanciaMaxima { get; set; }
        public float pressaoMinima { get; set; }
        public float pressaoMaxima { get; set; }
        public float velocidadeMinima { get; set; }
        public float velocidadeMaxima { get; set; }

        // Target
        public float revestimentoVisado { get; set; }

        // Presets da Navalha
        public float presetDistanciaNavalha { get; set; }
        public float presetPressaoNavalha { get; set; }
        public float presetVelocidadeDaLinha { get; set; }

        // Variáveis para o AG
        public int populationSize;// = 200;
        public float mutationRate;// = 0.01f;
        public int elitism;// = 5;

        // Variáveis para exibição em tela
        public string bestVelocidadeText;
        public string bestPressaoText;
        public string bestDistanciaText;
        public string bestFitnessText;
        public string bestKText;
        public string bestAText;
        public string bestBText;
        public string bestCText;
        public string bestTargetText;
        public string geracao;

        public List<string> getPopulacao()
        {
            List<string> temporaria = new List<string>();

            for (int i = 0; i < ga.Population.Count; i++)
            {
                temporaria.Add(ga.Population[i].ToString());
            }

            return temporaria;
        }

        // Pelos genes serem valores numericos o tipo escolhido aqui é o float
        private GeneticAlgorithm<float> ga;
        private System.Random random;

        public Navalha(float distanciaMinima, float distanciaMaxima, float pressaoMinima, float pressaoMaxima, float revestimentoObjetivado, int populationSize, float mutationRate, int elitism)
        {
            this.velocidadeMinima = velocidadeMinima;
            this.velocidadeMaxima = velocidadeMaxima;
            this.distanciaMinima = distanciaMinima;
            this.distanciaMaxima = distanciaMaxima;
            this.pressaoMinima = pressaoMinima;
            this.pressaoMaxima = pressaoMaxima;
            this.revestimentoVisado = revestimentoObjetivado;
            this.populationSize = populationSize;
            this.mutationRate = mutationRate;
            this.elitism = elitism;
        }

        public Navalha()
        {

        }

        public void start()
        {
            random = new System.Random();
            ga = new GeneticAlgorithm<float>(populationSize, 7, random, getRandomGene, FitnessFunction, elitism, mutationRate);

        }

        public void goToNextGeneration()
        {
            ga.NewGeneration();

            UpdateTexts();
        }

        private float FitnessFunction(int index)
        {
            float score = 0;
            DNA<float> dna = ga.Population[index];

            float velocidade    = dna.Genes[0];
            float pressao       = dna.Genes[1];
            float distancia     = dna.Genes[2];
            float K             = dna.Genes[3];
            float a             = dna.Genes[4];
            float b             = dna.Genes[5];
            float c             = dna.Genes[6];


            double revestimentoVisadoDoFitness = calcularRevestimentoVisado(velocidade, pressao, distancia, K, a, b, c);

            double delta = this.revestimentoVisado - revestimentoVisadoDoFitness;

            double potencia = -Math.Pow(delta, 2) / (2 * Math.Pow(this.revestimentoVisado, 2));

            score = (float)Math.Exp(potencia);

            score += 1 - (velocidadeMaxima - velocidade) / velocidadeMaxima;

            //float revestimentoVisadoIndividuo = Math.Pow((((float)(Math.Pow(velocidade, a)) * (float)(Math.Pow(distancia, b))) / pressao), 1/c) ;

            //score += 1 - (velocidadeMaxima - ga.Population[index].Genes[0]) / velocidadeMaxima;
            //score += 1 - Math.Abs((this.pressaoMaxima / 2 - ga.Population[index].Genes[1]) / (this.pressaoMaxima / 2));
            //score += 1 - (ga.Population[index].Genes[2] - this.distanciaMinima) / this.distanciaMaxima;

            //score /= dna.Genes.Length;
            return score/2;
        }

        private double calcularRevestimentoVisado(float velocidade, float pressao, float distancia, float K, float a, float b, float c)
        {
            double numeradorParte1 = Math.Pow(velocidade, a);
            double numeradorParte2 = Math.Pow(distancia, b);
            double numeradorParte3 = K * numeradorParte1 * numeradorParte2;

            double revestimentoVisadoCalculado = 1 / Math.Pow((numeradorParte3 / pressao), (1 / c));

            return revestimentoVisadoCalculado;
        }

        private float getRandomGene()
        {
            float temp = (float)random.NextDouble() * 200;
            return temp;
        }

        public void UpdateTexts()
        {
            bestVelocidadeText = ga.BestGenes[0].ToString();
            bestPressaoText = ga.BestGenes[1].ToString();
            bestDistanciaText = ga.BestGenes[2].ToString();

            bestKText = ga.BestGenes[3].ToString();
            bestAText = ga.BestGenes[4].ToString();
            bestBText = ga.BestGenes[5].ToString();
            bestCText = ga.BestGenes[6].ToString();

            bestTargetText = calcularRevestimentoVisado(ga.BestGenes[0], ga.BestGenes[1], ga.BestGenes[2], ga.BestGenes[3], ga.BestGenes[4], ga.BestGenes[5], ga.BestGenes[6]).ToString();

            bestFitnessText = ga.BestFitness.ToString();
            geracao = ga.Generation.ToString();

    }

    }
}