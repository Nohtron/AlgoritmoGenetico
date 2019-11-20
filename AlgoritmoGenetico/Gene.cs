using System;

namespace AlgoritmoGenetico
{
    public class Gene
    {
        public dynamic gene { get; set; }
        private Random random { get; set; }
        public dynamic getRandomGene { get; set; }

        public Gene()
        {

        }

        public Gene(Random random, bool criarGenes = true)
        {
            this.random = random;

            if (criarGenes)
            {
                this.gene = this.getRandomGene();
            }
        }

        public void Mutate(float mutationRate)
        {
            if (random.NextDouble() < mutationRate)
            {
                gene = getRandomGene();
            }
        }

    }
}
