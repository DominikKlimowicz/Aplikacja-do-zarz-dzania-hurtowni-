using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarządzanie_Hurtownią
{
    public static class BazaDanych
    {
        private const string ConnectionString = "Server=DOM;Database=Hurtownia;INtegrated Security=True";

        public static SqlConnection UzyskajPolaczenie()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
        public static List<Osoba> PobierzPracownikow()
        {
            List<Osoba> pracownicy = new List<Osoba>();
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select * from Pracownicy order by ID_Pracownika";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID_Pracownika"]);
                        string imię = reader["Imię"].ToString();
                        string nazwisko = reader["Nazwisko"].ToString();
                        string ulica = reader["Ulica"].ToString();
                        string nrBudynku = reader["Numer_Budynku"].ToString();
                        string miasto = reader["Miasto"].ToString();
                        string nrTelefonu = reader["Numer_Telefonu"].ToString();

                        Adres adres = new Adres(miasto, ulica, nrBudynku);
                        Osoba pracownik = new Osoba(id, imię, nazwisko, adres, nrTelefonu);
                        pracownicy.Add(pracownik);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania pracowników z bazy danych: " + ex.Message);
            }
            return pracownicy;
        }

        public static List<Klient> PobierzKlientow()
        {
            List<Klient> klienci = new List<Klient>();
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select * from Klienci order by ID_Klienta";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID_Klienta"]);
                        string imię = reader["Imię"].ToString();
                        string nazwisko = reader["Nazwisko"].ToString();
                        string email = reader["Email"].ToString();
                        string nazwaFirmy = reader["Nazwa_Firmy"].ToString();
                        string ulica = reader["Ulica"].ToString();
                        string nrBudynku = reader["Numer_Budynku"].ToString();
                        string miasto = reader["Miasto"].ToString();
                        string nrTelefonu = reader["Numer_Telefonu"].ToString();
                        string fax = reader["Fax"].ToString();

                        Adres adres = new Adres(miasto, ulica, nrBudynku);
                        Klient klient = new Klient(id, imię, nazwisko, adres, nrTelefonu, email, nazwaFirmy, fax);
                        klienci.Add(klient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania pracowników z bazy danych: " + ex.Message);
            }
            return klienci;
        }

        public static List<Magazyn> PobierzMagazyny()
        {
            List<Magazyn> magazyny = new List<Magazyn>();
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select * from Magazyny order by ID_Magazynu";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID_Magazynu"]);
                        string nazwa = reader["Nazwa_Magazynu"].ToString();
                        string miasto = reader["Miasto"].ToString();
                        string ulica = reader["Ulica"].ToString();
                        string nrBudynku = reader["Numer_Budynku"].ToString();

                        Adres adres = new Adres(miasto, ulica, nrBudynku);
                        Magazyn mag = new Magazyn(id, nazwa, adres);
                        magazyny.Add(mag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania magazynów z bazy danych: " + ex.Message);
            }
            return magazyny;
        }

        public static List<Produkt> PobierzProdukty()
        {
            List<Produkt> produkty = new List<Produkt>();
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select ID_Produktu, ID_Magazynu, Nazwa_Produktu, Ilość, Cena_Za_Jednostkę from Produkty";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id_produktu = Convert.ToInt32(reader["ID_Produktu"]);
                        int id_magazynu = Convert.ToInt32(reader["ID_Magazynu"]);
                        string nazwa = reader["Nazwa_Produktu"].ToString();
                        int ilosc = Convert.ToInt32(reader["Ilość"]);
                        double cena = Convert.ToDouble(reader["Cena_Za_Jednostkę"].ToString());

                        Produkt produkt = new Produkt(id_produktu, id_magazynu, nazwa, ilosc, cena);
                        produkty.Add(produkt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania produktów z bazy danych: " + ex.Message);
            }
            return produkty;
        }

        public static void AktualizacjaProduktow(string nazwa, int ilosc, int id_magazynu)
        {
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "update Produkty set Ilość = @NowaIlosc where Nazwa_Produktu = @NazwaProduktu and ID_Magazynu = @ID_Magazynu";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NowaIlosc", ilosc);
                        command.Parameters.AddWithValue("@NazwaProduktu", nazwa);
                        command.Parameters.AddWithValue("@ID_Magazynu", id_magazynu);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd podczas aktualizowania ilości produktów z bazy danych: " + e.Message);

            }
        }
        public static void AktualizacjaProduktow(string nazwa, int ilosc, int id_magazynu, double cena)
        {
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "update Produkty set Ilość = @NowaIlosc, Cena_Za_Jednostkę = @Cena where Nazwa_Produktu = @NazwaProduktu and ID_Magazynu = @ID_Magazynu";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NowaIlosc", ilosc );
                        command.Parameters.AddWithValue("@NazwaProduktu", nazwa);
                        command.Parameters.AddWithValue("@ID_Magazynu", id_magazynu);
                        command.Parameters.AddWithValue("@Cena", cena);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd podczas aktualizowania ilości produktów z bazy danych: " + e.Message);

            }
        }

        public static void DodawanieProduktu(int id_produktu, int id_kategorii, int id_magazynu, string nazwa, double cena, int ilosc)
        {
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = $"INSERT INTO Produkty (ID_Produktu, ID_Kategorii, ID_Magazynu, Nazwa_Produktu, Cena_Za_Jednostkę, Ilość) " +
               $"VALUES (@ID_Produktu, @ID_Kategorii, @ID_Magazynu, @NazwaProduktu, @Cena, @Ilosc)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Produktu", id_produktu);
                        command.Parameters.AddWithValue("@ID_Kategorii", id_kategorii);
                        command.Parameters.AddWithValue("@ID_Magazynu", id_magazynu);
                        command.Parameters.AddWithValue("@NazwaProduktu", nazwa);
                        command.Parameters.AddWithValue("@Cena", cena);
                        command.Parameters.AddWithValue("@Ilosc", ilosc);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd podczas aktualizowania ilości produktów z bazy danych: " + e.Message);

            }
        }
        public static void UsunProdukt(Produkt P)
        {
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "delete from Produkty where ID_Produktu = @ID_Produktu and ID_Magazynu = @ID_Magazynu";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Produktu", P.ID_Produktu);
                        command.Parameters.AddWithValue("@ID_Magazynu", P.ID_Magazynu);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Błąd podczas aktualizowania ilości produktów z bazy danych: " + e.Message);
            }
        }

        public static void DodajGodziny(Osoba o)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select * from Godziny_Pracy";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID_Pracownika"]);
                        if (id == o.ID)
                        {
                            int godziny = Convert.ToInt32(reader["Ilość_Godzin"]);
                            o.Godziny += godziny;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania magazynów z bazy danych: " + ex.Message);
            }
        }

        public static void UsunPracownika(Osoba o)
        {
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "delete from Pracownicy where ID_Pracownika = @ID_Pracownika";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Pracownika", o.ID);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy w tabeli Pracownicy: {command.ExecuteNonQuery()}");
                    }
                }
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select * from Godziny_Pracy where ID_Pracownika = @ID_Pracownika";
                    using (SqlCommand commandGodziny = new SqlCommand(query, connection))
                    {
                        commandGodziny.Parameters.AddWithValue("@ID_Pracownika", o.ID);
                        int liczba = Convert.ToInt32(commandGodziny.ExecuteScalar());
                        if (liczba > 0)
                        {
                            MessageBox.Show($"{o.ID}, {o.Imię}, {o.Nazwisko}");
                            string usun = "delete from Godziny_Pracy where ID_Pracownika = @ID_Pracownika";
                            using (SqlCommand c = new SqlCommand(usun, connection))
                            {
                                c.Parameters.AddWithValue("@ID_Pracownika", o.ID);
                                MessageBox.Show($"Ilość zaktualizowanych wierszy w tabeli Godziny Pracy: {c.ExecuteNonQuery()}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Pracownik {o.Imię + " " + o.Nazwisko} nie przepracował ani jednej godziny.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd podczas Usuwania pracownika z bazy danych: " + e.Message);
            }
        }
        public static void AktualizacjaPracownika(Osoba pracownik)
        {
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {

                    string query = "UPDATE Pracownicy SET " +
                                   "Imię = @Imie, " +
                                   "Nazwisko = @Nazwisko, " +
                                   "Miasto = @Miasto, " +
                                   "Ulica = @Ulica, " +
                                   "Numer_Budynku = @NumerBudynku, " +
                                   "Numer_Telefonu = @NumerTelefonu " +
                                   "WHERE ID_Pracownika = @ID_Pracownika";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", pracownik.Imię ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Nazwisko", pracownik.Nazwisko ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Miasto", pracownik.Adres.Miasto ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Ulica", pracownik.Adres.Ulica ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NumerBudynku", pracownik.Adres.Numer_Lokalu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NumerTelefonu", pracownik.NrTelefonu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ID_Pracownika", pracownik.ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show($"Zaktualizowano dane w bazie. Ilość zaktualizowanych wierszy: {rowsAffected}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji danych w bazie: {ex.Message}");
            }
        }
        public static void AktualizacjaKlienta(Klient k)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "Update Klienci set " +
                        "Imię =@Imie," + 
                        "Nazwisko = @Nazwisko," +
                        "Email = @Email," + 
                        "Nazwa_Firmy = @NazwaFirmy," +
                        "Miasto = @Miasto," +
                        "Ulica = @Ulica," +
                        "Numer_Budynku = @NrBud," +
                        "Numer_Telefonu = @NrTel," +
                        "Fax = @Fax " +
                        "where ID_Klienta = @ID";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", k.Imię ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Nazwisko", k.Nazwisko ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Email", k.Email ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NazwaFirmy", k.NazwaFirmy ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Miasto", k.Adres.Miasto ?? (object)DBNull.Value) ;
                        command.Parameters.AddWithValue("@Ulica", k.Adres.Ulica ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NrBud", k.Adres.Numer_Lokalu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NrTel", k.NrTelefonu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Fax", k.Fax ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ID", k.ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Zaktualizowano dane w bazie. Ilość zaktualizowanych wierszy: {rowsAffected}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji danych w bazie: {ex.Message}");
            }
        }
        public static int NajwiekszeMagazynID()
        {
            int ID=0;
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select max(ID_Magazynu) from Magazyny";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        object wynik = command.ExecuteScalar();
                        if (wynik != DBNull.Value)
                        {
                            ID = Convert.ToInt32(wynik);
                            MessageBox.Show($"Najwięsze ID to {ID}");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Błąd podczas poszukiwań największego ID magazynu: {ex.Message}");
            }
            return ID;
        }
        public static int NajwiekszePracID()
        {
            int ID=0;
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select max(ID_Pracownika) from Pracownicy";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        object wynik = command.ExecuteScalar();
                        if (wynik != DBNull.Value)
                        {
                            ID = Convert.ToInt32(wynik);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas poszukiwań największego ID pracownika: {ex.Message}");
            }
            return ID;
        }
        public static int NajwiekszeKlientID()
        {
            int ID = 0;
            try
            {
                using (SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "select max(ID_Klienta) from Klienci";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object wynik = command.ExecuteScalar();
                        if (wynik != DBNull.Value)
                        {
                            ID = Convert.ToInt32(wynik);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas poszukiwań największego ID pracownika: {ex.Message}");
            }
            return ID;
        }
        public static void DodawanieMagazynu(Magazyn m)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "insert into Magazyny (ID_Magazynu, Nazwa_Magazynu, Miasto, Ulica, Numer_Budynku)" +
                        $"values (@ID_Magazynu, @Nazwa_Magazynu, @Miasto, @Ulica, @Numer_Budynku)";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Magazynu", m.ID);
                        command.Parameters.AddWithValue("@Nazwa_Magazynu", m.Nazwa);
                        command.Parameters.AddWithValue("@Miasto", m.Adres.Miasto);
                        command.Parameters.AddWithValue("@Ulica", m.Adres.Ulica);
                        command.Parameters.AddWithValue("@Numer_Budynku", m.Adres.Numer_Lokalu);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania nowego magazynu: {ex.Message}");
            }
        }
        public static void DodawaniePracownika(Osoba prac)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "insert into Pracownicy (ID_Pracownika, Imię, Nazwisko, Ulica, Numer_Budynku, Miasto, Numer_Telefonu)" +
                        $"values (@ID_Pracownika, @Imię, @Nazwisko, @Ulica, @Numer_Budynku, @Miasto, @Numer_Telefonu)";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Pracownika", prac.ID);
                        command.Parameters.AddWithValue("@Imię", prac.Imię);
                        command.Parameters.AddWithValue("@Nazwisko", prac.Nazwisko);
                        command.Parameters.AddWithValue("@Ulica", prac.Adres.Ulica);
                        command.Parameters.AddWithValue("@Numer_Budynku", prac.Adres.Numer_Lokalu);
                        command.Parameters.AddWithValue("@Miasto", prac.Adres.Miasto);
                        command.Parameters.AddWithValue("@Numer_Telefonu", prac.NrTelefonu);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania nowego pracownika: {ex.Message}");
            }
        }
        public static void DodawanieKlienta(Klient k)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "insert into Klienci(ID_Klienta, Imię, Nazwisko, Email, Nazwa_Firmy, Miasto, Ulica, Numer_Budynku, Numer_Telefonu, FAX)" +
                        $"values (@ID_Klienta, @Imię, @Nazwisko, @Email, @Nazwa_Firmy, @Miasto, @Ulica, @Numer_Budynku, @Numer_Telefonu, @Fax)";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Klienta", k.ID);
                        command.Parameters.AddWithValue("@Imię", k.Imię);
                        command.Parameters.AddWithValue("@Nazwisko", k.Nazwisko);
                        command.Parameters.AddWithValue("@Email", k.Email);
                        command.Parameters.AddWithValue("@Nazwa_Firmy", k.NazwaFirmy);
                        command.Parameters.AddWithValue("@Miasto", k.Adres.Miasto);
                        command.Parameters.AddWithValue("@Ulica", k.Adres.Ulica);
                        command.Parameters.AddWithValue("@Numer_Budynku", k.Adres.Numer_Lokalu);
                        command.Parameters.AddWithValue("@Numer_Telefonu", k.NrTelefonu);
                        command.Parameters.AddWithValue("@Fax", k.Fax);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania nowego Klienta: {ex.Message}");
            }
        }
        public static void UsunKlienta(Klient k)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "delete from Klienci where ID_Klienta = @ID_Klienta";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Klienta", k.ID);

                        MessageBox.Show($"Ilość zaktualizowanych wierszy w tabeli Klienci: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Błąd podczas Usuwania klienta z bazy danych: " + ex.Message);
            }
            
        }
        public static void DodajGodzine(Osoba p ,int g)
        {
            try
            {
                using(SqlConnection connection = UzyskajPolaczenie())
                {
                    string query = "insert into Godziny_Pracy(ID_Pracownika, Ilość_Godzin, Data)" +
                        "values (@ID, @Ilosc, @Data)";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", p.ID);
                        command.Parameters.AddWithValue("@Ilosc", g);
                        command.Parameters.AddWithValue("@Data", DateTime.Now.Date.ToString("dd-MM-yyyy"));

                        MessageBox.Show($"Ilość zaktualizowanych wierszy w tabeli Godziny Pracy: {command.ExecuteNonQuery()}");
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show("Błąd podczas dodawania godzin pracy do bazy danych: " + ex.Message);
            }
        }

    }
}
