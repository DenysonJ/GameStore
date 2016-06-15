using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class newUser_GUI : Form
    {
        public newUser_GUI()
        {
            InitializeComponent();
            invalidLogin_label.Visible = false;
            invalidEmail_label.Visible = false;
        }

        private void button_insertuser_Click(object sender, EventArgs e)
        {
            if ((!invalidLogin_label.Visible) && (!invalidEmail_label.Visible))
            {
                if (password_textBox.Text == confirmPassword_textBox.Text)
                {
                    string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(strcon);
                    SqlCommand cmd = new SqlCommand("INSERT INTO UserTable (UserID, UserName, BirthDate, Password, email, Phone, List, Rented, History, Login) VALUES (MAX(UserID)+1,'" + name_textBox.Text + "','" + birthdate_dateTimePicker.Value.Date.ToString("yyyyMMdd") + "','" + password_textBox.Text + "','" +email_textBox.Text + "','"+ phone_textBox.Text + "','','','','" +Login_textBox.Text+ "');", connection);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }else
                {
                    MessageBox.Show("As Senhas não correspondem.");
                }
            }else
            {
                MessageBox.Show("Arrume os campos em vermelho antes de prosseguir.");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_textBox_TextChanged(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable", connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable ds = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(ds);
                bool find = false;
                foreach (DataRow user in ds.Rows)
                {
                    if (user.Field<string>("Login") == Login_textBox.Text)
                    {
                        invalidLogin_label.Visible = true;
                        Login_textBox.BackColor = Color.Red;
                        find = true;
                        break;
                    }
                }
                if (!find)
                {
                    Login_textBox.BackColor = this.BackColor;
                    invalidLogin_label.Visible = false;
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void email_textBox_TextChanged(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable", connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable ds = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(ds);
                bool find = false;
                foreach (DataRow user in ds.Rows)
                {
                    if (user.Field<string>("email") == email_textBox.Text)
                    {
                        invalidEmail_label.Visible = true;
                        email_textBox.BackColor = Color.Red;
                        find = true;
                        break;
                    }
                }
                if (!find)
                {
                    email_textBox.BackColor = this.BackColor;
                    invalidEmail_label.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void confirmPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            makesurePasswords();
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            makesurePasswords();
        }

        private void makesurePasswords()
        {
            if(password_textBox.Text == confirmPassword_textBox.Text)
            {
                passwords_label.Visible = false;
            }
            else
            {
                passwords_label.Visible = true;
            }
        }
    }
}
