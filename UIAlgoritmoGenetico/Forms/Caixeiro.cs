using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAlgoritmoGenetico.Forms
{
    public partial class Caixeiro : Form
    {
        FormHome formHome;
        List<int[]> cities;

        public Caixeiro(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
            cities = new List<int[]>();
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

            int quantidadeDeCidades = int.Parse(textBox1.Text);
            Random random = new Random();
            
            for (int i =0; i< quantidadeDeCidades; i++)
            {

                int randomX = random.Next(0, this.Width);
                int randomY = random.Next(0, this.Height);


                int[] city;
                city = new int[2];
                city[0] = randomX;
                city[1] = randomY;

                cities.Add(city);
            }

            Brush aBrush = Brushes.Black;
            Graphics g = this.CreateGraphics();

            for (int i = 0; i < cities.Count; i++)
            {
                g.FillRectangle(aBrush, cities[i][0], cities[i][1], 5, 5);
            }
        }

      }
}
