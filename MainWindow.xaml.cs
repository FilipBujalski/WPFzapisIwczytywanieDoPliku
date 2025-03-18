using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace danexml
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Pracownik> pracownicy = new List<Pracownik>()
            {
                new Pracownik() { Id = 1, Imie = "Jan", Nazwisko = "Kowalski", Zarobki = 12234, Data_zatrudnienia = new DateTime(2025, 3, 4), Data_zwolnienia = new DateTime(1971, 7, 23) },
                new Pracownik() { Id = 2, Imie = "Piotr", Nazwisko = "Nowak", Zarobki = 9876, Data_zatrudnienia = new DateTime(2025, 3, 4), Data_zwolnienia = new DateTime(1971, 7, 23) },
                new Pracownik() { Id = 3, Imie = "Ewa", Nazwisko = "Iksińska", Zarobki = 6543, Data_zatrudnienia = new DateTime(2025, 3, 4), Data_zwolnienia = new DateTime(1971, 7, 23) }
            };

            PracownicyLista.ItemsSource = pracownicy;
        }

        private void ZapiszDaneDoPliku(List<Pracownik> pracownicy)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            using (StreamWriter writer = new StreamWriter("pracownicy.xml"))
            {
                serializer.Serialize(writer, pracownicy);
            }
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            List<Pracownik> pracownicy = (List<Pracownik>)PracownicyLista.ItemsSource;
            ZapiszDaneDoPliku(pracownicy);
        }

        private List<Pracownik> WczytajDaneZPliku()
        {
            if (File.Exists("pracownicy.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
                using (StreamReader reader = new StreamReader("pracownicy.xml"))
                {
                    return (List<Pracownik>)serializer.Deserialize(reader);
                }
            }
            return null;
        }

        private void Wczytaj_Click(object sender, RoutedEventArgs e)
        {
            List<Pracownik> pracownicy = WczytajDaneZPliku();
            if (pracownicy != null)
            {
                PracownicyLista.ItemsSource = pracownicy;
            }
            else
            {
                MessageBox.Show("Nie udało się wczytać danych z pliku.");
            }
        }
        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            DodajPracownika dodajOkno = new DodajPracownika();
            if (dodajOkno.ShowDialog() == true)
            {
                Pracownik nowyPracownik = dodajOkno.NowyPracownik;

                if (nowyPracownik != null)
                {
                    List<Pracownik> pracownicy = (List<Pracownik>)PracownicyLista.ItemsSource;
                    int nowyId = pracownicy.Max(p => p.Id) + 1;
                    nowyPracownik.Id = nowyId;

                    pracownicy.Add(nowyPracownik);
                    PracownicyLista.Items.Refresh();
                }
            }
        }

    }
}