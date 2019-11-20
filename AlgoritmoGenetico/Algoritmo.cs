using System;
using System.Collections.Generic;

namespace AlgoritmoGenetico
{
 public   class Algoritmo
    {
        private Populacao populacao { get; set; }


        public int elitismo;
        public float MutationRate;

        private Random random;
   
        private int dnaSize;

        public Algoritmo(Populacao populacao)
        {
            geracao = 1;
            this.populacao = populacao;
            this.random = populacao.random;

            bestIndividuo = new Individuo(random, false);

        }

    }
}