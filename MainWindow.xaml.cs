using Filmserwis;
using Filmserwis.models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace FilmSerwisWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public ObservableCollection<Film> filmy = new ObservableCollection<Film>();

        public MainWindow()
        {
            InitializeComponent();
            SerwisFilmow serwisFilmow = new SerwisFilmow();
            GlownyAktor glownyAktor = new GlownyAktor("Leonardo", "Di Caprio", new DateTime(1980,2,1));
            Rezyser rezyser = new Rezyser("Kris", "Nolan", new DateTime(1970, 1, 1));
            serwisFilmow.UtworzFilm("Incepcja", Film.TypFilmu.Horror, glownyAktor, rezyser, "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu.", 9);
            serwisFilmow.UtworzFilm("Skazani na Shawshank", Film.TypFilmu.Horror, glownyAktor, rezyser, "Adaptacja opowiadania Stephena Kinga. Niesłusznie skazany na dożywocie bankier, stara się przetrwać w brutalnym, więziennym świecie.", 8);
            serwisFilmow.UtworzFilm("Matrix", Film.TypFilmu.Horror, glownyAktor, rezyser, " Haker komputerowy Neo dowiaduje się od tajemniczych rebeliantów, że świat, w którym żyje, jest tylko obrazem przesyłanym do jego mózgu przez roboty.", 6);
            serwisFilmow.UtworzFilm("Znachor", Film.TypFilmu.Inny, glownyAktor, rezyser, "Historia znanego chirurga Wilczura, którego opuszcza ukochana żona. Zrozpaczony lekarz zaczyna pić i wdaje się w burdę, co skutkuje utratą pamięci.", 10);

            this.OdswiezListeFilmow();
        }

        private void UtworzFilmOnClick(object sender, RoutedEventArgs e)
        {
            {
                UtworzFilmWindow utworzFilmWindow = new UtworzFilmWindow(this);
                utworzFilmWindow.Top = this.Top;
                utworzFilmWindow.Left = this.Left;
                utworzFilmWindow.Show();
                return;
            }

        }

        public void OdswiezListeFilmow()
        {
            this.filmy = new ObservableCollection<Film>();

            
            foreach (var film in RepozytoriumFilmow.listaFilmow.Values)
            {
                filmy.Add(film);
            }

            this.listBox.ItemsSource = filmy;
        }

        private void SzukajFilmu(object sender, RoutedEventArgs e)
        {
            Dictionary<long, Film> szukaneFilmy = new Dictionary<long, Film>();

            foreach(Film film in filmy)
            {

                if(film.tytulFilmu.ToLower().StartsWith(this.szukajTextBox.Text.ToLower()))
                {
                    szukaneFilmy.Add(film.Id, film);
                }
            }

            this.listBox.ItemsSource = new BindingList<Film>(szukaneFilmy.Values.ToList());
        }

        private void SzczegolyOnClick(object sender, RoutedEventArgs e)
        {
            if(this.listBox.SelectedItem != null)
            {
                this.label.Content = "";
                Film wybranyFilm = (Film)this.listBox.SelectedItem;
                SzczegolyFilmuWindow szczegolyFilmuWindow = new SzczegolyFilmuWindow(wybranyFilm);
                szczegolyFilmuWindow.Top = this.Top;
                szczegolyFilmuWindow.Left = this.Left;
                szczegolyFilmuWindow.Show();
            } else
            {
                this.label.Content = "Nie wybrano filmu. Prosze wybrac z listy:";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.listBox.SelectedItem != null)
            {
                this.label.Content = "";
                Film wybranyFilm = (Film)this.listBox.SelectedItem;
                RepozytoriumFilmow.Usun(wybranyFilm.Id);
                OdswiezListeFilmow();
            }
            else
            {
                this.label.Content = "Nie wybrano filmu. Prosze wybrac z listy:";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.listBox.SelectedItem != null)
            {
                this.label.Content = "";
                Film wybranyFilm = (Film)this.listBox.SelectedItem;
                wybranyFilm.Serializacja();
            }
            else
            {
                this.label.Content = "Nie wybrano filmu. Prosze wybrac z listy:";
            }
        }
    }
}