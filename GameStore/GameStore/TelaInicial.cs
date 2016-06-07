using System;
using System.Windows.Forms;

namespace GameStore
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button_insertgame_Click(object sender, EventArgs e)
        {
            InsertGame_GUI insert = new InsertGame_GUI();

            insert.Show();
        }
    }
}
