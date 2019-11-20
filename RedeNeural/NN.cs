using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeural
{
    public class NN
    {
        private int quantidadeDeEntradas { get; set; }
        private int quantidadeDeNeuroniosNoHiddenLayer { get; set; }
        private int quantidadeDeSaidas { get; set; }

        public double[,] entrada { get; private set; }
        public double[,] pesosEntrada { get; private set; }
        public double[,] Hidden { get; private set; }
        public double[,] pesosSaida { get; private set; }
        public double[,] saida { get; private set; }
        private Random random;

        public NN(int quantidadeDeEntradas, int quantidadeDeNeuroniosNoHiddenLayer, int quantidadeDeSaidas, bool inicializarPesosEntrada = true)
        {
            // Quantidade de entrada deve ser usado para criar os pesos de entrada-hidden
            // pois assim a matriz de multiplicação ocorre corretamente e os dois possuem a mesmo tamanho
            //      [ w11   w12   w13   wb1 ]            [ e1 ]
            // W =  [ w21   w22   w23   wb2 ]   inputs = [ e2 ]
            //      [ w31   w32   w33   wb3 ]            [ e3 ]
            //                                           [ 1  ]
            // 
            // O 1 se refere ao valor do bias, pois tendo o peso do Bias, esse peso será o próprio bias

            random = new Random();

            this.quantidadeDeEntradas = quantidadeDeEntradas;
            this.quantidadeDeNeuroniosNoHiddenLayer = quantidadeDeNeuroniosNoHiddenLayer;
            this.quantidadeDeSaidas = quantidadeDeSaidas;

            entrada = new double[quantidadeDeEntradas + 1, 1];
            pesosEntrada = new double[quantidadeDeNeuroniosNoHiddenLayer, quantidadeDeEntradas + 1];
            Hidden = new double[quantidadeDeNeuroniosNoHiddenLayer, 1];
            pesosSaida = new double[quantidadeDeNeuroniosNoHiddenLayer, quantidadeDeSaidas];
            saida = new double[quantidadeDeSaidas, 1];


            if (inicializarPesosEntrada)
            {
                for (int i = 0; i < quantidadeDeNeuroniosNoHiddenLayer; i++)
                {
                    for (int j = 0; j < quantidadeDeEntradas + 1; j++)
                    {
                        pesosEntrada[i, j] = random.NextDouble() * 10;
                    }
                        
                }

            }

        }

        public double[,] feedForward()
        {
            // Input x Weight + bias and activate

            //Hidden = pesosEntrada x entradas;
            //Hidden[j,1] = pesosEntrada[1,j] x entrada[j, 1];

            for (int i =0; i< Hidden.GetLength(1); i++)
            {
                for (int j = 0; j< entrada.GetLength(1); j++)
                {
                    Hidden[i, 1] += pesosEntrada[i, j] * entrada[j, 1]; 
                }
            }


            return saida;
        }
        

        public List<string> getPrettyPrintMatrix(double[,] matrix)
        {
            List<string> matrizEmLista= new List<string>(matrix.GetLength(0));

            for (int linha = 0; linha < matrix.GetLength(0); linha++)
            {
                string linhaTemporaria = "";
                linhaTemporaria += "[";

                for (int coluna = 0; coluna < matrix.GetLength(1); coluna++)
                {
                    linhaTemporaria += " " + matrix[linha, coluna].ToString("0.00") + " ";
                }

                linhaTemporaria += "]\n";

                matrizEmLista.Add(linhaTemporaria);
            }
            return matrizEmLista;

        }
                       
    }
}
