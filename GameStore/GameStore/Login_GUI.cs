﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameStore
{
    public partial class Login_GUI : Form
    {

        public int userID;
        ClientManager client = new ClientManager();

        public Login_GUI()
        {
            InitializeComponent();
        }

        private void Login_GUI_Load(object sender, EventArgs e)
        {
            AcceptButton = Login_btn; //When user press Enter this button is clicked
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string password = Password_tb.Text;
            string user = Login_tb.Text;            

            if ((Login_tb.Text == "admin") && (password == "ESGames123"))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(client.validate(password, ref userID))
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                Error.Visible = true;
                DialogResult = DialogResult.No;
            }
            

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

        private void Login_GUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
