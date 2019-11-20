using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    public class Individuo
    {
        public DNA dna { get; set; }
        public float fitness { get; set; }
        public dynamic fitnessFunction { get; set; }
        public dynamic reproductionFunction { get; set; }
        public Random random { get; set; }

        public Individuo()
        {

        }

        public Individuo(Random random, bool criarDNA)
        {
            this.random = random;
            this.dna = new DNA(random, criarDNA);
            this.reproductionFunction = reproductionFunction;
        }

        internal int comparar(Individuo x, Individuo y)
        {
            if (x.fitness > y.fitness)
            {
                return -1;
            }
            else if (x.fitness < y.fitness)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        internal void sofrerMutacao(object mutationRate)
        {
            throw new NotImplementedException();
        }

        override
        public string ToString()
        {
            string textoSaida = "";

            foreach (var gene in this.dna.genes)
            {
                textoSaida += gene.ToString();
            }

            return textoSaida;
        }

    }
}
