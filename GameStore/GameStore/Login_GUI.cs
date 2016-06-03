using System;
using System.Windows.Forms;

namespace GameStore
{
    public partial class Login_GUI : Form
    {
        

        public Login_GUI()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if(Login_tb.Text == "admin")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Yes;
            }
            
            Close();

        }

        private void Login_tb_Enter(object sender, EventArgs e)
        {
            if(Login_tb.Text == "Login")
                Login_tb.Text = string.Empty;
        }

        private void Login_tb_Leave(object sender, EventArgs e)
        {
            if (Login_tb.Text == string.Empty)
            {
                Login_tb.Text = "Login";
            }
        }

        private void Password_tb_Enter(object sender, EventArgs e)
        {
            Password_tb.Text = string.Empty;
        }

        private void Password_tb_Leave(object sender, EventArgs e)
        {
            if (Password_tb.Text == string.Empty)
            {
                Password_tb.Text = "Senha";
            }
        }

    }
}
