using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico2
{
 public   class GuideLinecs
    {
        public Random random;

        // Tipos possíveis de Genes
        public Gene geneVelocidade { get; set; }
        public Gene genePressao { get; set; }
        public Gene geneDistancia{ get; set; }
        public Gene geneK { get; set; }
        public Gene geneA { get; set; }
        public Gene geneB { get; set; }
        public Gene geneC { get; set; }

        // Limites para Validações de sorteio de Genes
        public float distanciaMinima { get; set; }
        public float distanciaMaxima { get; set; }
        public float pressaoMinima { get; set; }
        public float pressaoMaxima { get; set; }
        public float velocidadeMinima { get; set; }
        public float velocidadeMaxima { get; set; }

        public float kMinima { get; set; }
        public float kMaxima { get; set; }
        public float aMinima { get; set; }
        public float aMaxima { get; set; }
        public float bMinima { get; set; }
        public float bMaxima { get; set; }
        public float cMinima { get; set; }
        public float cMaxima { get; set; }

        // DNA modelo para a populacao
        public DNA navalhaDNA { get; set; }
        public int tamanhoDoDNA { get; set; }

        // Populacao a receber as gerações com base no DNA modelo
        public Populacao populacaoNavalha { get; set; }
        public int tamanhoDaPopulacao { get; set; }

        // Variáveis para a evolução do GA
        public float revestimentoVisado { get; set; } // Target
        public float taxaDeMutacao { get; set; }
        public int elitismo { get; set; }

        public GuideLinecs()
        {
            // Iniciando fonte de aleatoridade.
            random = new Random();

            // Iniciando a sequencia de genes do problema
            List<Gene> genesDaNavalha = new List<Gene>(tamanhoDoDNA);

            // Sequenciando os genes do problema
            genesDaNavalha.Add(new Gene(getRandomVelocidade));
            genesDaNavalha.Add(new Gene(getRandomPressao));
            genesDaNavalha.Add(new Gene(getRandomDistancia));
            genesDaNavalha.Add(new Gene(getRandomK));
            genesDaNavalha.Add(new Gene(getRandomA));
            genesDaNavalha.Add(new Gene(getRandomB));
            genesDaNavalha.Add(new Gene(getRandomC));

            // Iniciando o DNA do problema
            navalhaDNA = new DNA(genesDaNavalha, fitnessFunction);
        }

        private dynamic getRandomC()
        {
            return random.NextDouble() * (cMaxima - cMinima) + cMinima;
        }

        private dynamic getRandomB()
        {
            return random.NextDouble() * (bMaxima - bMinima) + bMinima;
        }

        private dynamic getRandomA()
        {
            return random.NextDouble() * (aMaxima - aMinima) + aMinima;
        }

        private dynamic getRandomK()
        {
            return random.NextDouble() * (kMaxima - kMinima) + kMinima;
        }

        public void start()
        {
            // Iniciando a população com a primeira geração
            populacaoNavalha = new Populacao(tamanhoDaPopulacao, navalhaDNA, elitismo);

            populacaoNavalha.classificarPopulacao();
        }

        public void proximaGeracao()
        {
            populacaoNavalha.evoluir();
            //populacaoNavalha.classificarPopulacao();
        }

        public List<DNA> getPopulacao()
        {
            return populacaoNavalha.individuos;
        }


        private DNA escolherAscendente()
        {
            double roletaDeFitness = random.NextDouble() * populacaoNavalha.fitnessDaPopulacao;

            for (int i = 0; i< populacaoNavalha.individuos.Count; i++)
            {
                if (roletaDeFitness < populacaoNavalha.individuos[i].fitness)
                {
                    return populacaoNavalha.individuos[i].Clone();
                }

                roletaDeFitness -= populacaoNavalha.individuos[i].fitness;
            }

            return null;
        }

        private float fitnessFunction(int posicaoDoIndividuoNaLista)
        {
            float pontuacao = 0;
            DNA dna = populacaoNavalha.individuos[posicaoDoIndividuoNaLista];

            double fatorDeImportanciaScore = 4.00 / 5.00;
            double fatorDeImportanciaVelocidade = 1.00 / 5.00;


            double revestimentoVisadoDoFitness = calcularRevestimentoVisado(dna);

            double delta = this.revestimentoVisado - revestimentoVisadoDoFitness;

            double potencia = -Math.Pow(delta, 2) / (2 * Math.Pow(this.revestimentoVisado, 2));

            pontuacao = (float)(Math.Exp(potencia) * fatorDeImportanciaScore);

            pontuacao += (1 - (velocidadeMaxima - dna.genes[0].valor) / velocidadeMaxima) * fatorDeImportanciaVelocidade;

            return pontuacao;

            // Velocidade Mais alta possível
            // Pressão média escala;
            // Distância menor possível;

            //float pontuacao = 0;

            //double pontuacao1 = 1 - (this.velocidadeMaxima - populacaoNavalha.individuos[posicaoDoIndividuoNaLista].genes[0].valor)/this.velocidadeMaxima;
            //double pontuacao2 = 1 - Math.Abs((this.pressaoMaxima/2 - populacaoNavalha.individuos[posicaoDoIndividuoNaLista].genes[1].valor)/(this.pressaoMaxima/2));
            //double pontuacao3 = 1 - (populacaoNavalha.individuos[posicaoDoIndividuoNaLista].genes[2].valor - this.distanciaMinima)/this.distanciaMaxima;

            //pontuacao = (float)pontuacao1 + (float)pontuacao2 + (float)pontuacao3;

            //pontuacao /= navalhaDNA.genes.Count;

            //return pontuacao;
        }

        public double calcularRevestimentoVisado(DNA dna)
        {
            double velocidade = dna.genes[0].valor;
            double pressao = dna.genes[1].valor;
            double distancia = dna.genes[2].valor;
            double K = dna.genes[3].valor;
            double a = dna.genes[4].valor;
            double b = dna.genes[5].valor;
            double c = dna.genes[6].valor;

            double numeradorParte1 = Math.Pow(velocidade, a);
            double numeradorParte2 = Math.Pow(distancia, b);
            double numeradorParte3 = K * numeradorParte1 * numeradorParte2;

            double revestimentoVisadoCalculado = 1 / Math.Pow((numeradorParte3 / pressao), (1 / c));


            if (double.IsNaN(revestimentoVisadoCalculado))
            {
                return 0;
            }
            else
            {
                return revestimentoVisadoCalculado;
            }
            
        }

        public double calcularPresetDePressao(DNA dna)
        {
            double velocidade = dna.genes[0].valor;
            double pressao = dna.genes[1].valor;
            double distancia = dna.genes[2].valor;
            double K = dna.genes[3].valor;
            double a = dna.genes[4].valor;
            double b = dna.genes[5].valor;
            double c = dna.genes[6].valor;

            double resultadoParcial1 = Math.Pow(velocidade, a);
            double resultadoParcial2 = Math.Pow(distancia, b);
            double resultadoParcial3 = Math.Pow(revestimentoVisado, c);

            return K * resultadoParcial1 * resultadoParcial2 * resultadoParcial3;

        }

        private dynamic getRandomDistancia()
        {
            return random.NextDouble() * (distanciaMaxima - distanciaMinima) + distanciaMinima;
        }

        private dynamic getRandomPressao()
        {
            return random.NextDouble() * (pressaoMaxima - pressaoMinima) + pressaoMinima;
        }

        public dynamic getRandomVelocidade()
        {
            return random.NextDouble()*(velocidadeMaxima-velocidadeMinima) + velocidadeMinima;
        }

    }
}
