using System;
using System.Windows.Forms;

namespace GameStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int new_login;

            
            Login_GUI login = new Login_GUI();
            Application.Run(login);

            new_login = (int) login.DialogResult;
        
            if (login.DialogResult == DialogResult.OK)
            {           //admin
                TelaInicial tela = new TelaInicial();
                Application.Run(tela);
            }
            else if (login.DialogResult == DialogResult.Yes)
            {       //user
                Store_iGUI store = new Store_iGUI();
                Application.Run(store);
            }

        }
    }

}
