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

namespace Zarządzanie_Hurtownią
{
    public partial class OknoLogowania : Form
    {
        private Okno1 okno;
        public OknoLogowania(Okno1 okienko)
        {
            InitializeComponent();
            Text = "Kraina Świeżych Smaków - Logowanie";
            okno = okienko;
        }

        private void PrzyciskLogowanie_Click(object sender, EventArgs e)
        {
            string hasło = TextHaslo.Text;
            string login = TextLogin.Text;

            bool czyLogin = SprawdzenieLogin(login);
            bool czyHasło = SprawdzenieDane(login, hasło);

            if (login == "Admin" && hasło == "admin")
            {
                MessageBox.Show("Witaj Adminie");
                Okno2 okno2 = new Okno2();
                okno2.Show();
                okno.Hide();
                Hide();
            }
            else
            {

                if (czyLogin)
                {
                    if (czyHasło)
                    {
                        MessageBox.Show($"Logowanie przebiegło pomyślnie.\nWitaj {login}");
                        Okno2 okno2 = new Okno2();
                        okno2.Show();
                        okno.WindowState = FormWindowState.Minimized;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nieprawidłowe hasło");
                    }
                }
                else
                {
                    MessageBox.Show("Ten login nie istnieje.");
                }
            }
        }

        private bool SprawdzenieLogin(string login)
        {
            try
            {
                using (SqlConnection connection = BazaDanych.UzyskajPolaczenie())
                {
                    string query = "select 1 from użytkownicy where Login = @Login";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);


                    return command.ExecuteScalar() != null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten login nie istnieje. \nKod błedu: " + ex.Message);
                return false;
            }
        }

        private bool SprawdzenieDane(string login, string hasło)
        {
            try
            {
                using (SqlConnection connection = BazaDanych.UzyskajPolaczenie())
                {
                    string query = "select 1 from użytkownicy where Login = @Login and Hasło = @Hasło";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Hasło", hasło);

                    return command.ExecuteScalar() != null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieprawidłowy login i/lub hasło.\nKod błędu: " + ex.Message);
                return false;
            }
        }
    }
}
