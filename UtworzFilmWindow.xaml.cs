using Filmserwis;
using Filmserwis.models;
using System.Windows;
using static Filmserwis.Film;

namespace FilmSerwisWPF
{
    /// <summary>
    /// Logika interakcji dla klasy UtworzFilmWindow.xaml
    /// </summary>
    public partial class UtworzFilmWindow : Window
    {
        MainWindow mainWindow;
        public UtworzFilmWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            this.typFilmuCombobox.ItemsSource = Enum.GetValues(typeof(TypFilmu)).Cast<TypFilmu>();
            for (int i = 1; i <= 10; i++)
            {
                this.ocenaCombobox.Items.Add(i);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tytulFilmu = this.tytulFilmuTextbox.Text;
            TypFilmu typFilmu = (TypFilmu)this.typFilmuCombobox.SelectedValue;
            string opisFilmu = this.opisFilmuTextbox.Text;
            string imieRezysera = this.imieRezyseraTextbox.Text;
            string nazwiskoRezysera = this.nazwiskoRezyseraTextbox.Text;
            DateTime dataUrodzeniaRezysera = (DateTime)this.dataUrodzeniaRezyseraDatepicker.SelectedDate;
            string imieAktora = this.imieAktoraTextbox.Text;
            string nazwiskoAktora = this.nazwiskoAktoraTextbox.Text;
            DateTime dataUrodzeniaAktora = (DateTime)this.dataUrodzeniaAktoraDatepicker.SelectedDate;
            int ocena = (int)this.ocenaCombobox.SelectedValue;
            Rezyser rezyser = new Rezyser(imieRezysera, nazwiskoRezysera, dataUrodzeniaRezysera);
            GlownyAktor aktor = new GlownyAktor(imieAktora, nazwiskoAktora, dataUrodzeniaAktora);
            SerwisFilmow serwisFilmow = new SerwisFilmow();
            Film film = new Film(tytulFilmu, typFilmu, aktor, rezyser, opisFilmu, ocena);
            RepozytoriumFilmow.Zapisz(film.Id, film);
            mainWindow.OdswiezListeFilmow();
            this.Close();
        }
    }
}
