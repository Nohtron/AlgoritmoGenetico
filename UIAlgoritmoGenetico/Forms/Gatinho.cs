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
    public partial class Gatinho : Form
    {
        FormHome formHome;
        Graphics g;

        public Gatinho(FormHome formHome)
        {
            this.formHome = formHome;
            g = CreateGraphics();
            InitializeComponent();
        }

        private void Gatinho_Load(object sender, EventArgs e)
        {

        }

        private void Gatinho_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome.Show();
        }

        private void buttonDesenhar_Click(object sender, EventArgs e)
        {

            Bitmap imagemBMP = new Bitmap(pictureBox1.Image);

            //progressBar1.Maximum = imagemBMP.Height * imagemBMP.Width;
            //progressBar1.Minimum = 0;
            //progressBar1.Value = 0;

            //int zoom = 2;

            int sizeAjuste = int.Parse(textBox1.Text);

            for (int coluna = 0; coluna < imagemBMP.Height; coluna+= sizeAjuste)
            {
                for (int linha = 0; linha < imagemBMP.Width; linha+= sizeAjuste)
                {
                    Pen corPixel = new Pen(imagemBMP.GetPixel(linha, coluna));

                    int linhaParaDesenhar = linha  + 20;
                    int colunaParaDesenhar = coluna  + 20;

                    g.DrawRectangle(corPixel, linhaParaDesenhar, colunaParaDesenhar, sizeAjuste, sizeAjuste);
                    //progressBar1.Value = linha * coluna;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {




        }
    }
}
