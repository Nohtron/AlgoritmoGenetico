using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmoGenetico;

namespace Problemas
{
    public class Shakespeare
    {
        public Gene geneChar;
        public DNA dna;
        public Individuo individuo;
        public Populacao populacao;
        public string target;// { get; set; }
        public Algoritmo algoritmo;
        public Random random;

        public Shakespeare(int dnaSize, int populacaoSize, int elitismo, float taxaDeMutacao, string target, Random random)
        {
            random = new Random();

            this.target = target;
            this.dna.size = dnaSize;

            geneChar = new Gene();
            geneChar.getRandomGene = this.getRandomChar();

            individuo = new Individuo();
            individuo.fitnessFunction = this.avaliarIndividuo(target);
            
            populacao = new Populacao();
            populacao.individuo = individuo;
            populacao.size = populacaoSize;
            populacao.elitismo = elitismo;
            populacao.taxaDeMutacao = taxaDeMutacao;
            populacao.random = populacao.random;

            for (int j = 0; j < populacaoSize; j++)
            {
                dna = new DNA();
                dna.size = dnaSize;

                for (int i = 0; i < dnaSize; i++)
                {
                    dna.genes[i] = geneChar.getRandomGene();
                }

                individuo.dna = dna;

                populacao.individuos.Add(individuo);
            }
        }

        public void evoluir()
        {
            populacao.ProximaGeracao();
        }

        public char getRandomChar()
        {
            string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ,.|!#$%&/()=?é0123456789áóã ";
            int i = random.Next(validCharacters.Length);
            return validCharacters[i];
        }

        public float avaliarIndividuo(string target)
        {
            float score = 0;

            for (int i = 0; i < individuo.dna.genes.Count; i++)
            {
                if (this.dna.genes[i].gene == target[i])
                {
                    score += 1;
                }
            }

            score /= target.Length;
            return score;
        }

    }
}
