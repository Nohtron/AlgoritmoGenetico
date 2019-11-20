using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico2
{
 public   class Gene
    {
        public Random random { get; set; }
        public dynamic valor { get; set; }
        public Func<dynamic> getRandomGene { get; set; }

        public Gene(Func<dynamic> getRandomGene)
        {
            this.getRandomGene = getRandomGene;
        }

        public Gene(Random random, Func<dynamic> getRandomGene, bool iniciarGene = true)
        {
            this.random = random;
            this.getRandomGene = getRandomGene;

            if (iniciarGene)
            {
                valor = getRandomGene();
            }
        }

        public override string ToString()
        {
            return valor.ToString();
            //return valor.ToString("000.00") + ' ';
        }

        public Gene Clone()
        {
            Gene geneClone = new Gene(this.random, this.getRandomGene, false);

            geneClone.valor = this.valor;

            return geneClone;
        }
    }
}
