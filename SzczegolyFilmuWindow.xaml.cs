using Filmserwis;
using System.Windows;


namespace FilmSerwisWPF
{
    /// <summary>
    /// Logika interakcji dla klasy SzczegolyFilmuWindow.xaml
    /// </summary>
    public partial class SzczegolyFilmuWindow : Window
    {
        public SzczegolyFilmuWindow(Film film)
        {
            InitializeComponent();
            this.tytulFilmuLabel.Content = "Tytul filmu:" + film.tytulFilmu;
            this.typFilmuLabel.Content = "Typ filmu: " + film.typFilmu.ToString();
            this.rezyserFilmuLabel.Content = "Rezyser filmu: " + film.rezyser;
            this.ocenaLabel.Content = "Ocena: " + film.ocena;
            this.glownyAktorLabel.Content = "Główny aktor: " + film.glownyAktor;
            this.opisFilmuTextBlock.Text = "Opis filmu: " + film.opis;
            
        }
    }
}
