using System;
using System.Windows;
using System.Windows.Input;

namespace danexml
{
    public partial class DodajPracownika : Window
    {
        public Pracownik NowyPracownik { get; private set; }

        public DodajPracownika()
        {
            InitializeComponent();
        }

        private void ZarobkiTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, 0);
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (ImieTextBox.Text == "" || NazwiskoTextBox.Text == "")
            {
                MessageBox.Show("Imię i nazwisko są wymagane!");
                return;
            }

            int zarobki;
            if (!int.TryParse(ZarobkiTextBox.Text, out zarobki) || zarobki <= 0)
            {
                MessageBox.Show("Zarobki muszą być liczbą dodatnią!");
                return;
            }

            if (DataZatrudnieniaPicker.SelectedDate == null)
            {
                MessageBox.Show("Wybierz datę zatrudnienia!");
                return;
            }

            DateTime dataZwolnienia = DataZwolnieniaPicker.SelectedDate ?? DateTime.MinValue;

            NowyPracownik = new Pracownik
            {
                Imie = ImieTextBox.Text,
                Nazwisko = NazwiskoTextBox.Text,
                Zarobki = zarobki,
                Data_zatrudnienia = DataZatrudnieniaPicker.SelectedDate.Value,
                Data_zwolnienia = dataZwolnienia
            };

            DialogResult = true;
            Close();
        }

        private void Anuluj_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
