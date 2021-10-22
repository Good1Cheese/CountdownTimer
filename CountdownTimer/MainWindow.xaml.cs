using System;
using System.Windows;
using System.Windows.Threading;

namespace CountdownTimer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dispatcherTimer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 1, 0)
            };

            dispatcherTimer.Tick += new EventHandler(DisplayCurrentTime);
            dispatcherTimer.Start();
        }

        private void DisplayCurrentTime(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime newYear = new(now.Year, 12, 31);
            TimeSpan timeTillNewYear = newYear - now;

            daysAmount.Content = timeTillNewYear.Days;
            hoursAmount.Content = timeTillNewYear.Hours;
            minutesAmount.Content = timeTillNewYear.Minutes;
            secondsAmount.Content = timeTillNewYear.Seconds;
        }
    }
}
