using System;
using System.Collections.Generic;

namespace AlgoritmoGenetico2
{
    public   class Populacao
    {
        public List<DNA> individuos { get; set; }
        public DNA melhorIndividuoDeTodasAsGeracoes { get; set; }
        //public Func<DNA> escolherAscendente { get; set; }
        //public Func<DNA> funcaoDeReproducao { get; set; }
        public Func<Gene> funcaoDeMutacao { get; set; }
        public Random random { get; set; }
        public dynamic target { get; set; }
        public float fitnessDaPopulacao { get; set; }
        public int elitismo { get; set; }
        public int geracao { get; set; }
        public float taxaDeMutacao { get; set; }

        public Populacao(int tamanhoDaPopulacao, DNA dna, int elitismo)
        {
            random = new Random();
            this.geracao = 1;
            this.elitismo = elitismo;

            individuos = new List<DNA>(tamanhoDaPopulacao);

            for (int i = 0; i < tamanhoDaPopulacao; i++)
            {
                individuos.Add(new DNA(dna.genes, random, dna.fitnessFunction));
                
            }

            //classificarPopulacao();

            melhorIndividuoDeTodasAsGeracoes = new DNA(dna.genes, random, dna.fitnessFunction);
            melhorIndividuoDeTodasAsGeracoes.fitness = 0;

        }

        public void classificarPopulacao()
        {
            fitnessDaPopulacao = 0;

            for (int i = 0; i < individuos.Count; i++)
            {
                individuos[i].calcularFitness(i);
                fitnessDaPopulacao += individuos[i].fitness;
            }

            individuos.Sort();

            if (melhorIndividuoDeTodasAsGeracoes.fitness < individuos[0].fitness)
            {
                melhorIndividuoDeTodasAsGeracoes = null;
                melhorIndividuoDeTodasAsGeracoes = individuos[0].Clone();

            }

        }

        public void evoluir()
        {

            List<DNA> novosIndividuos = new List<DNA>(individuos.Count);

            for (int i = 0; i < individuos.Count; i++)
            {
                if(i < elitismo)
                {
                    novosIndividuos.Add(individuos[i].Clone());
                }
                else
                {
                    novosIndividuos.Add(this.funcaoDeReproducao());
                }

            }
            this.individuos.Clear();
            this.individuos = novosIndividuos;
            classificarPopulacao();

            this.geracao++;

        }

        public DNA funcaoDeReproducao()
        {
            DNA novoDNA = new DNA(individuos[0].genes, random, individuos[0].fitnessFunction, false);

            DNA ascendente1 = escolherAscendente();
            DNA ascendente2 = escolherAscendente();

            for (int i = 0; i < individuos[0].genes.Count; i++)
            {
                novoDNA.genes[i].valor = random.NextDouble() < 0.5 ? ascendente1.genes[i].valor : ascendente2.genes[i].valor;

                if (random.NextDouble() < 0.01)
                {
                    novoDNA.genes[i].valor = novoDNA.genes[i].getRandomGene();
                }
            }
            return novoDNA;
        }

        private DNA escolherAscendente()
        {
            float roletaDeFitness = (float)random.NextDouble() * this.fitnessDaPopulacao;
            float roletaDeFitnessSave = roletaDeFitness;

            for (int i = 0; i < this.individuos.Count; i++)
            {
                if (roletaDeFitness < this.individuos[i].fitness)
                {
                    return this.individuos[i].Clone();
                }

                roletaDeFitness -= this.individuos[i].fitness;
            }

            return escolherAscendente();
        }
    }
}
