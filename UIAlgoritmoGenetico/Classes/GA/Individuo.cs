using System;
using System.Collections.Generic;

namespace UIAlgoritmoGenetico.Classes.GA
{

    public class Individuo<T>
    {
        public T[] Genes { get; private set; }
        public float Aptidao { get; private set; }
        public Func<T> GetGeneAleatorio;
        public Func<int, float> FuncaoDeAptidao;


        public Random aleatorio;

        public Individuo(int QuantidadeDeGenes, Random aleatorio, Func<T> getGeneAleatorio, Func<int, float> FuncaoDeAptidao, bool deveCriarGenes = true)
        {
            Genes = new T[QuantidadeDeGenes];
            this.GetGeneAleatorio = getGeneAleatorio;
            this.FuncaoDeAptidao = FuncaoDeAptidao;

            if (deveCriarGenes)
            {
                for (int i = 0; i < Genes.Length; i++)
                {
                    Genes[i] = getGeneAleatorio();
                }

            }

        }

        public float CalcularAptidao(int index)
        {
            Aptidao = FuncaoDeAptidao(index);
            return Aptidao;
        }

        public Individuo<T> ReproduzirCom(Individuo<T> outroIndividuo)
        {
            Individuo<T> descendente = new Individuo<T>(Genes.Length, aleatorio, GetGeneAleatorio, FuncaoDeAptidao, deveCriarGenes: false);

            for (int i = 0; i < Genes.Length; i++)
            {
                descendente.Genes[i] = aleatorio.NextDouble() < 0.5 ? Genes[i] : outroIndividuo.Genes[i];
            }

            return descendente;
        }

        public void SofrerMutacao(float TaxaDeMutacao)
        {
            for (int i = 0; i < Genes.Length; i++)
            {
                if (aleatorio.NextDouble() < TaxaDeMutacao)
                {
                    Genes[i] = GetGeneAleatorio();
                }

            }
        }

    }

}