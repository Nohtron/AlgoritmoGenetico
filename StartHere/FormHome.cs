using System;
using System.Windows.Forms;

namespace StartHere
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonShakespeare_Click(object sender, EventArgs e)
        {
            FormShakespeare formShakespeare = new FormShakespeare(this);
            formShakespeare.Show();

            this.Hide();
        }

        private void buttonNavalha_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
