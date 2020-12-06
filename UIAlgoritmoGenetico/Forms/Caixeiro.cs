using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIAlgoritmoGenetico.Classes;

namespace UIAlgoritmoGenetico.Forms
{
    public partial class Caixeiro : Form
    {
        FormHome formHome;
        List<City> cities;
        Random random = new Random();
        Brush aBrush = Brushes.Black;
        Graphics g;
        int xSquarePopulation = 50;
        int ySquarePopulation = 50;
        int squaresWidth = 400;
        int squaresHeight = 400;
        int xSquareBest = 600;
        int ySquareBest = 50;
        List<City> path;


        public Caixeiro(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
            cities = new List<City>();
            xSquareBest = xSquarePopulation + squaresWidth + 50;
            path = new List<City>();
            g = this.CreateGraphics();

        }

        private void Caixeiro_Load(object sender, EventArgs e)
        {
        }

        private void Caixeiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cities.Clear();
            path.Clear();

            if (!int.TryParse(textBox1.Text, out int quantidadeDeCidades))
            {
                MessageBox.Show("O número de pontos deve ser informado!");
                return;
            }

            for (int i = 0; i < quantidadeDeCidades; i++)
            {
                int randomX = random.Next(xSquarePopulation + 10, squaresWidth + xSquarePopulation - 10);
                int randomY = random.Next(xSquarePopulation + 10, squaresWidth + xSquarePopulation - 10);

                City city = new City();
                city.x = randomX;
                city.y = randomY;

                cities.Add(city);
                path.Add(city);
            }
            PrintScreen();
        }

        private double calculatePathDistance(List<City> path)
        {
            double distance = 0;
            for (int i = 1; i < path.Count; i++)
            {
                distance += CalculateDistance(path[i - 1], path[i]);
            }
            return distance;
        }

        private double CalculateDistance(City city1, City city2)
        {
            return (double)Math.Sqrt(Math.Pow(city2.x - city1.x, 2) + Math.Pow(city2.y - city1.y, 2));
        }

        private void PrintScreen()
        {
            g.Clear(DefaultBackColor);
            DrawPopulations();
            DrawBest();
            lblBestScoreOfPopulation.Text = calculatePathDistance(cities).ToString("F2");
            lblBestScoreEver.Text = calculatePathDistance(path).ToString("F2");
        }


        private void DrawPopulations()
        {
            g.DrawRectangle(new Pen(aBrush), xSquarePopulation, ySquarePopulation, squaresWidth, squaresHeight);

            for (int i = 0; i < cities.Count; i++)
            {
                g.FillEllipse(aBrush, cities[i].x - 3, cities[i].y - 3, 6, 6);
            }

            Pen linePen = new Pen(Brushes.Black, 1);

            for (int i = 0; i < cities.Count - 1; i++)
            {
                Point pt1 = new Point(cities[i].x, cities[i].y);
                Point pt2 = new Point(cities[i + 1].x, cities[i + 1].y);
                g.DrawLine(linePen, pt1, pt2);
            }
        }

        private void DrawBest()
        {

            g.DrawRectangle(new Pen(aBrush), xSquareBest, ySquareBest, squaresWidth, squaresHeight);
            for (int i = 0; i < path.Count; i++)
            {
                int xShifted = (path[i].x - xSquarePopulation) + xSquareBest;
                g.FillEllipse(aBrush, xShifted - 3, path[i].y - 3, 6, 6);
            }

            Pen linePen = new Pen(Brushes.Black, 1);

            for (int i = 0; i < path.Count - 1; i++)
            {
                int xShifter = xSquareBest - xSquarePopulation;
                Point pt1 = new Point(path[i].x + xShifter, path[i].y);
                Point pt2 = new Point(path[i + 1].x + xShifter, path[i + 1].y);
                g.DrawLine(linePen, pt1, pt2);
            }

        }

        private void btnMutate_Click(object sender, EventArgs e)
        {
            int tries = 0;
            while (tries < 1000)
            {
                SwapOrder();
                CheckNewBest();
                PrintScreen();
                tries++;
            }
        }

        private void SwapOrder()
        {
            int iCity1 = random.Next(0, cities.Count - 1);
            int iCity2 = random.Next(0, cities.Count - 1);

            City tempCity = cities[iCity1];
            cities[iCity1] = cities[iCity2];
            cities[iCity2] = tempCity;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SwapOrder();
            CheckNewBest();
            PrintScreen();
        }

        private void CheckNewBest()
        {
            if (calculatePathDistance(cities) < calculatePathDistance(path))
            {
                City[] array = new City[cities.Count];
                cities.CopyTo(array);
                path = array.ToList();
            }
        }
    }
}
