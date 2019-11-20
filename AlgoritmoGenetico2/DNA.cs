using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico2
{
 public   class DNA : IComparable<DNA>
    {
        public Random random { get; set; }
        public List<Gene> genes { get; set; }
        public float fitness { get; set; }
        public Func<int,float> fitnessFunction { get; set; }
        //public Func<string> printFunction { get; set; }

        public DNA(List<Gene> genes, Func<int,float> fitnessFunction)
        {
            this.genes = genes;
            this.fitnessFunction = fitnessFunction;
            //this.printFunction = printFunction;
        }

        public DNA(List<Gene> genes, Random random, Func<int,float> fitnessFunction, bool iniciarDNA = true)
        {
            this.random = random;
            this.fitnessFunction = fitnessFunction;
            //this.printFunction = printFunction;

            this.genes = new List<Gene>(genes.Count);

            for (int i = 0; i < genes.Count; i++)
            {
                Gene geneTemporario = new Gene(random, genes[i].getRandomGene, iniciarDNA);

                this.genes.Add(geneTemporario);
            }

        }

        public void calcularFitness(int i)
        {
            this.fitness = this.fitnessFunction(i);
        }

        public int CompareTo(DNA outroDNA)
        {
            return outroDNA.fitness.CompareTo(this.fitness);
        }

        public override string ToString()
        {
            string dnaString = null;

            for (int i = 0; i< this.genes.Count; i++)
            {
                dnaString += this.genes[i].ToString();
            }
            return dnaString;
           // return this.genes[0].ToString() + ' ' + this.genes[1].ToString() + ' ' + this.genes[2].ToString();
        }

        public DNA Clone()
        {
            DNA dnaClone = new DNA(this.genes, this.random, this.fitnessFunction, false);

            dnaClone.fitness = this.fitness;

            for (int i = 0; i < genes.Count; i++)
            {
                dnaClone.genes[i] = this.genes[i].Clone();
            }

            return dnaClone;
        }
    }
}
