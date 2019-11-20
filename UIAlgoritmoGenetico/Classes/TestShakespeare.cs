using System;
using System.Collections.Generic;
using System.Text;
using UIAlgoritmoGenetico.Classes.EnglishAG;



public class TestShakespeare
{
    //[Header("Genetic Algorithm")]
    public string targetString;//= "Demi й muito GAY e da o toba so por hobby. #LulaLivre";
	string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ,.|!#$%&/()=?й0123456789буг ";
    public int populationSize;// = 200;
    public float mutationRate;// = 0.01f;
    public int elitism = 5;

	//[Header("Other")]
	int numCharsPerText = 15000;
	public string targetText;
	public string bestText { get; set; }
	public string bestFitnessText { get; set; }
	public string numGenerationsText { get; set; }
	List<string> populationTextParent;
	string textPrefab;

	private GeneticAlgorithm<char> ga;
	private System.Random random;

	public void Start()
	{
		targetText = targetString;

		if (string.IsNullOrEmpty(targetString))
		{
            return;
		}

		random = new System.Random();
		ga = new GeneticAlgorithm<char>(populationSize, targetString.Length, random, GetRandomCharacter, FitnessFunction, elitism, mutationRate);
	}

    public float getBestFitness()
    {
        return ga.BestFitness;
    }

	public float Update()
	{
		ga.NewGeneration();

		UpdateText(ga.BestGenes, ga.BestFitness, ga.Generation, ga.Population.Count, (j) => ga.Population[j].Genes);

        return ga.BestFitness;
	}

    public List<string> getPopulacao()
    {
        List<string> temporaria = new List<string>();

        for (int i = 0; i < ga.Population.Count; i++)
        {
            temporaria.Add(ga.Population[i].ToString());
        }

        return temporaria;
    }

	private char GetRandomCharacter()
	{
		int i = random.Next(validCharacters.Length);
		return validCharacters[i];
	}

	private float FitnessFunction(int index)
	{
		float score = 0;
		DNA<char> dna = ga.Population[index];

		for (int i = 0; i < dna.Genes.Length; i++)
		{
			if (dna.Genes[i] == targetString[i])
			{
				score += 1;
			}
		}

		score /= targetString.Length;

        //score = (score * score - 1)/1 ;
        //score = (Mathf.Pow(2, score) - 1) / (2 - 1);

        return score;
	}














	private int numCharsPerTextObj;
	private List<string> textList = new List<string>();

	
	private void UpdateText(char[] bestGenes, float bestFitness, int generation, int populationSize, Func<int, char[]> getGenes)
	{
        
        bestText = CharArrayToString(bestGenes);
		bestFitnessText = bestFitness.ToString();

		numGenerationsText = generation.ToString();

		for (int i = 0; i < textList.Count; i++)
		{
			var sb = new StringBuilder();
			int endIndex = i == textList.Count - 1 ? populationSize : (i + 1) * numCharsPerTextObj;
			for (int j = i * numCharsPerTextObj; j < endIndex; j++)
			{
				foreach (var c in getGenes(j))
				{
					sb.Append(c);
				}
				if (j < endIndex - 1) sb.AppendLine();
			}

            textList[i].Insert(0,sb.ToString());
        }
	}

	private string CharArrayToString(char[] charArray)
	{
		var sb = new StringBuilder();
		foreach (var c in charArray)
		{
			sb.Append(c);
		}

		return sb.ToString();
	}
}
