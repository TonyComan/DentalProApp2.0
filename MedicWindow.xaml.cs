using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DentalProApp
{
    /// <summary>
    /// Interaction logic for MedicWindow.xaml
    /// </summary>
    public partial class MedicWindow : Window
    {
        public MedicWindow()
        {
            InitializeComponent();
            txtBunVenitMedic.Text = $"Bun venit!";
            StartClock();
        }

        private void BtnColaborare_Click(object sender, RoutedEventArgs e)
        {
            var fereastra = new ColaborareWindow();
            fereastra.ShowDialog();
        }

        private void BtnAdaugaTehnician_Click(object sender, RoutedEventArgs e)
        {
            var fereastra = new TehnicianWindow();
            fereastra.ShowDialog();
        }

        private void BtnAdaugaTratament_Click(object sender, RoutedEventArgs e)
        {
            
            var fereastra = new TratamenteWindow("medic");
            fereastra.Show();

        }

        private void BtnConsimtamant_Click(object sender, RoutedEventArgs e)
        {
            var fereastra = new ConsimtamantPacientWindow();
            fereastra.ShowDialog();
        }

        private void BtnIstoricPacient_Click(object sender, RoutedEventArgs e)
        {
            var fereastra = new IstoricPacientWindow();
            fereastra.ShowDialog();
        }

        private void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) =>
            {
                txtDataOraMedic.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            };
            timer.Start();
        }
        private void BtnDeconectare_Click(object sender, RoutedEventArgs e)
        {
            var login = new LoginWindow();
            login.Show();
            this.Close();
        }


    }


    
}
