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

        private void Store_button_Click(object sender, EventArgs e)
        {
            Store_iGUI storeform = new Store_iGUI();
            storeform.ShowDialog();
        }

        private void newUser_button_Click(object sender, EventArgs e)
        {
            newUser_GUI newUserform = new newUser_GUI();
            newUserform.ShowDialog();
        }

        private void deleteUser_button_Click(object sender, EventArgs e)
        {
            deleteUser_GUI delUserform = new deleteUser_GUI();
            delUserform.ShowDialog();
        }

        private void deleteGame_button_Click(object sender, EventArgs e)
        {

        }
    }
}
