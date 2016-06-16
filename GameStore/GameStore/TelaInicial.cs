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
            this.Hide();
            insert.ShowDialog();
            this.Show();
        }

        private void Store_button_Click(object sender, EventArgs e)
        {
            Store_iGUI storeform = new Store_iGUI(-1);
            this.Hide();
            storeform.ShowDialog();
            this.Show();
        }

        private void newUser_button_Click(object sender, EventArgs e)
        {
            newUser_GUI newUserform = new newUser_GUI();
            this.Hide();
            newUserform.ShowDialog();
            this.Show();
        }

        private void deleteUser_button_Click(object sender, EventArgs e)
        {
            deleteUser_GUI delUserform = new deleteUser_GUI();
            this.Hide();
            delUserform.ShowDialog();
            this.Show();
        }

        private void deleteGame_button_Click(object sender, EventArgs e)
        {
            Store_iGUI storeform = new Store_iGUI(-2);
            this.Hide();
            storeform.ShowDialog();
            this.Show();
        }
    }
}
