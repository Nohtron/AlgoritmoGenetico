using System;
using System.Collections.Generic;

namespace UIAlgoritmoGenetico.Classes.GA
{

    public class AlgoritmoGenetico<T>
    {
        public List<Individuo<T>> Populacao { get; private set; }
        public int Geracao { get; private set; }
        public float MelhorAptidao { get; private set; }
        public T[] MelhorIndividuo { get; private set; }

        public float TaxaDeMutacao;

        public Random aleatorio;
        public float SomaDeAptidao;

        public AlgoritmoGenetico(int TamanhoDaPopulacao, int QuantidadeDeGenes, Random aleatorio, Func<T> getGeneAleatorio, Func<int, float> FuncaoDeAptidao, float nivelDeMutacao = 0.01f)
        {
            Geracao = 1;
            TaxaDeMutacao = nivelDeMutacao;
            Populacao = new List<Individuo<T>>();
            this.aleatorio = aleatorio;

            MelhorIndividuo = new T[QuantidadeDeGenes];


            for (int i = 0; i < TamanhoDaPopulacao; i++)
            {
                Populacao.Add(new Individuo<T>(QuantidadeDeGenes, aleatorio, getGeneAleatorio, FuncaoDeAptidao, deveCriarGenes: true));
            }

        }

        public void NovaGeracao()
        {
            if (Populacao.Count <= 0)
            {
                return;
            }

            CalculaAdaptacao();

            List<Individuo<T>> novaPopulacao = new List<Individuo<T>>();

            for (int i = 0; i < Populacao.Count; i++)
            {
                Individuo<T> ascendente1 = EscolherAscendente();
                Individuo<T> ascendente2 = EscolherAscendente();

                Individuo<T> descendente = ascendente1.ReproduzirCom(ascendente2);

                descendente.SofrerMutacao(TaxaDeMutacao);

                novaPopulacao.Add(descendente);
            }

            Populacao = novaPopulacao;

            Geracao++;

        }

        public void CalculaAdaptacao()
        {

            SomaDeAptidao = 0;

            Individuo<T> MelhorDNA = Populacao[0];

            for (int i = 0; i < Populacao.Count; i++)
            {
                SomaDeAptidao += Populacao[i].CalcularAptidao(i);

                if (Populacao[i].Aptidao > MelhorDNA.Aptidao)
                {
                    MelhorDNA = Populacao[i];
                }
            }

            MelhorAptidao = MelhorDNA.Aptidao;
            MelhorDNA.Genes.CopyTo(MelhorIndividuo, 0);
        }

        // Usando o código do Kryzarel, mas tem o código de seleção do "CodeBulet" (eu acho) que é mais interessante
        public Individuo<T> EscolherAscendente()
        {
            double AptidaoDeCorteAleatorio = aleatorio.NextDouble() * SomaDeAptidao;

            for (int i = 0; i < Populacao.Count; i++)
            {
                if (AptidaoDeCorteAleatorio < Populacao[i].Aptidao)
                {
                    return Populacao[i];
                }

                AptidaoDeCorteAleatorio -= Populacao[i].Aptidao;
            }

            return null;
        }
    }

}