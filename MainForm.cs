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
        private Spectator spectator;

        public MainForm()
        {
            InitializeComponent();
            cinema = new Cinema();
            spectatorPanels = new List<Panel>();
            spectator = new Spectator();

            for (int i = 0; i < 2; i++)
            {
                Panel panel = CreateSpectatorPanel(i);
                spectatorPanels.Add(panel);
            }
            cinema.MovieShowing += spectator.HandleMovieShowing;
        }

        private Panel CreateSpectatorPanel(int index)
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new System.Drawing.Size(460, 200),
                Location = new System.Drawing.Point(50, 50 + index * 220)
            };
            Label label_film = new Label
            {
                Text = "Введите название фильма:",
                Location = new System.Drawing.Point(10, 10)
            };

            TextBox textBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 25),
                Size = new System.Drawing.Size(120, 20)
            };
            Label label_date = new Label
            {
                Text = "Выберите дату:",
                Location = new System.Drawing.Point(10, 50)
            };

            DateTimePicker dateTimePicker = new DateTimePicker
            {
                Location = new System.Drawing.Point(10, 65),
                Size = new System.Drawing.Size(120, 20)
            };

            Button button = new Button
            {
                Text = "Показать фильм",
                Location = new System.Drawing.Point(10, 170),
                Size = new System.Drawing.Size(110, 23)
            };
            button.Click += (sender, e) => ShowMovie(textBox, dateTimePicker);

            Button connectButton = new Button
            {
                Text = "Подключиться",
                Location = new System.Drawing.Point(120, 170),
                Size = new System.Drawing.Size(110, 23)
            };
            connectButton.Click += (sender, e) => ConnectToCinema();

            Button disconnectButton = new Button
            {
                Text = "Отключиться",
                Location = new System.Drawing.Point(230, 170),
                Size = new System.Drawing.Size(110, 23)
            };
            disconnectButton.Click += (sender, e) => DisconnectFromCinema();

            Button showInfoButton = new Button
            {
                Text = "Показать инфо",
                Location = new System.Drawing.Point(340, 170),
                Size = new System.Drawing.Size(110, 23)
            };
            showInfoButton.Click += (sender, e) => ShowInfo(panel);

            ListBox listBox = new ListBox
            {
                Location = new System.Drawing.Point(140, 10),
                Size = new System.Drawing.Size(310, 150)
            };

            panel.Controls.Add(textBox);
            panel.Controls.Add(dateTimePicker);
            panel.Controls.Add(button);
            panel.Controls.Add(connectButton);
            panel.Controls.Add(disconnectButton);
            panel.Controls.Add(showInfoButton);
            panel.Controls.Add(listBox);
            panel.Controls.Add(label_film);
            panel.Controls.Add(label_date);
            this.Controls.Add(panel);

            return panel;
        }

        private void ShowMovie(TextBox filmTextBox, DateTimePicker dateTimePicker)
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

        private void ConnectToCinema()
        {
            cinema.MovieShowing += spectator.HandleMovieShowing;
            MessageBox.Show("Вы подключились к прослушиванию.", "Статус соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisconnectFromCinema()
        {
            cinema.MovieShowing -= spectator.HandleMovieShowing;
            MessageBox.Show("Вы отключились от прослушивания.", "Статус соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowInfo(Panel panel)
        {
            ListBox listBox = panel.Controls.OfType<ListBox>().FirstOrDefault();
            if (listBox != null)
            {
                listBox.Items.Clear();
                foreach (string movieInfo in spectator.GetMovieList())
                {
                    listBox.Items.Add(movieInfo);
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
            OnMovieShowing(new CinemaEvent(film, date));
        }

        protected virtual void OnMovieShowing(CinemaEvent e)
        {
            MovieShowing?.Invoke(this, e);
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