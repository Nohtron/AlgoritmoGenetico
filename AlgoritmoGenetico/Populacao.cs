using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    public class Populacao
    {
        public int size { get; set; }
        public int elitismo { get; set; }
        public float fitnessSum { get; set; }
        public float taxaDeMutacao { get; set; }
        public int geracao { get; set; }
        public float bestFitness { get; set; }
        public Random random { get; set; }
        public Individuo individuo { get; set; }
        public List<Individuo> individuos { get; set; }
        public Individuo bestIndividuo { get; set; }

        public Populacao()
        {
            this.geracao = 1;
        }

        public Populacao(int size, Random random, Individuo individuo, int elitismo, bool criarPrimeirosIndividuos)
        {
            this.geracao = 1;
            this.elitismo = elitismo;
            this.individuo = individuo;
            individuos = new List<Individuo>();

            for (int i = 0; i < size; i++)
            {
                individuos.Add(new Individuo(random, criarPrimeirosIndividuos));
            }
        }

        public void ProximaGeracao()
        {
            Populacao novaPopulacao = new Populacao(this.size, this.random, this.individuo, this.elitismo, false);

            avaliarIndividuos();
            individuos.Sort(this.individuo.comparar);

            novaPopulacao.individuos.Clear();

            for (int i = 0; i < individuos.Count; i++)
            {
                if (i < elitismo)
                {
                    novaPopulacao.individuos.Add(individuos[i]);
                }
                else
                {
                    Individuo ascendente1 = escolherAscendente();
                    Individuo ascendente2 = escolherAscendente();

                    Individuo child = ascendente1.reproductionFunction(ascendente2);

                    novaPopulacao.individuos.Add(child);
                }
            }

            this.geracao++;
            this.individuos = novaPopulacao.individuos;

        }

        private Individuo escolherAscendente()
        {
            double randomNumber = random.NextDouble() * fitnessSum;

            for (int i = 0; i < individuos.Count; i++)
            {
                if (randomNumber < individuos[i].fitness)
                {
                    return individuos[i];
                }

                randomNumber -= individuos[i].fitness;
            }

            return null;
        }

        private void avaliarIndividuos()
        {
            fitnessSum = 0;
            Individuo bestIndividuo = this.individuos[0];

            for (int i = 0; i < this.individuos.Count; i++)
            {
                fitnessSum += this.individuos[i].fitness;

                if (individuos[i].fitness > bestIndividuo.fitness)
                {
                    bestIndividuo = individuos[i];
                }
            }

            this.bestIndividuo = bestIndividuo;
        }
    }
}
