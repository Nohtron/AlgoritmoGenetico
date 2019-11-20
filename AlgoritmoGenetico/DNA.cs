using System;
using System.Collections.Generic;

namespace AlgoritmoGenetico
{

    public class DNA
    {
        public List<Gene> genes { get;  set; }
        public int size { get;  set; }
        public Random random { get; set; }

        public DNA(Random random, bool criarGenes)
        {
            this.random = random;         

            for (int i = 0; i < size; i++)
            {
                genes[i] = genes[i].getRandomGene();;
            }
        }

        public DNA()
        {

        }

    }
}