using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab11TP
{
    public partial class MainForm : Form
    {
        private Cinema cinema;
        private List<Panel> spectatorPanels;
        private List<Spectator> spectators;
        private EventHandler<CinemaEvent>[] movieShowingHandlers;

        public MainForm()
        {
            InitializeComponent();
            cinema = new Cinema();
            spectatorPanels = new List<Panel>();
            spectators = new List<Spectator>();
            movieShowingHandlers = new EventHandler<CinemaEvent>[2];

            for (int i = 0; i < 2; i++)
            {
                Spectator spectator = new Spectator();
                spectators.Add(spectator);

                Panel panel = Controls.Find($"panelSpectator{i + 1}", true).FirstOrDefault() as Panel;
                panel.BorderStyle = BorderStyle.FixedSingle;
                spectatorPanels.Add(panel);

                movieShowingHandlers[i] = (sender, e) => spectator.HandleMovieShowing(sender, e);
            }
            btnShowMovie1.Click += (sender, e) => ShowMovie(txtFilm1, dateTimePicker1, 0);
            btnShowMovie2.Click += (sender, e) => ShowMovie(txtFilm2, dateTimePicker2, 1);

            btnConnect1.Click += (sender, e) => ConnectToCinema(0);
            btnConnect2.Click += (sender, e) => ConnectToCinema(1);
            btnDisconnect1.Click += (sender, e) => DisconnectFromCinema(0);
            btnDisconnect2.Click += (sender, e) => DisconnectFromCinema(1);
            btnShowInfo1.Click += (sender, e) => ShowInfo(0);
            btnShowInfo2.Click += (sender, e) => ShowInfo(1);
        }

        private void ShowMovie(TextBox filmTextBox, DateTimePicker dateTimePicker, int i)
        {
            try
            {
                string film = filmTextBox.Text;
                DateTime selectedDate = dateTimePicker.Value;

                ValidateInput(film, selectedDate);
                cinema.ShowMovie(film, selectedDate);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ValidateInput(string film, DateTime selectedDate)
        {
            if (string.IsNullOrWhiteSpace(film))
            {
                throw new ArgumentException("введите название фильма");
            }

            if (selectedDate < DateTime.Now)
            {
                throw new ArgumentException("выберите дату позже текущей");
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show("Произошла ошибка: " + message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConnectToCinema(int i)
        {
            cinema.MovieShowing += movieShowingHandlers[i];
            MessageBox.Show($"Спектатор {i + 1} подключился к прослушиванию.", "Статус соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisconnectFromCinema(int i)
        {
            cinema.MovieShowing -= movieShowingHandlers[i];
            MessageBox.Show($"Спектатор {i + 1} отключился от прослушивания.", "Статус соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowInfo(int i)
        {
            if (i >= 0 && i < spectatorPanels.Count)
            {
                Panel panel = spectatorPanels[i];
                ListBox listBox = panel.Controls.OfType<ListBox>().FirstOrDefault();
                if (listBox != null)
                {
                    listBox.Items.Clear();
                    foreach (string movieInfo in spectators[i].GetMovieList())
                    {
                        listBox.Items.Add(movieInfo);
                    }
                }
            }
        }
    }

    class CinemaEvent : EventArgs
    {
        public string Film { get; }
        public DateTime Date { get; }

        public CinemaEvent(string film, DateTime date)
        {
            Film = film;
            Date = date;
        }
    }

    class Cinema
    {
        public event EventHandler<CinemaEvent> MovieShowing;

        public void ShowMovie(string film, DateTime date)
        {
            MovieShowing?.Invoke(this, new CinemaEvent(film, date));
        }
    }

    class Spectator
    {
        private List<string> movieList = new List<string>();

        public void HandleMovieShowing(object sender, CinemaEvent e)
        {
            string message = $"Фильм {e.Film} будет показан {e.Date.ToShortDateString()}";
            movieList.Add(message);
        }

        public List<string> GetMovieList()
        {
            return movieList;
        }
    }
}