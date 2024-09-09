using System.Collections;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Cronometro
{
    public partial class MainWindow : Window
    {
        private ArrayList _imageFiles;
        DispatcherTimer DpT = new DispatcherTimer();
        public int increSeg = 0;
        Tiempo tp;

        public MainWindow()
        {
            tp = new Tiempo();
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            DpT.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            increSeg = 0;
            MostraEnPantalla();
            DpT.Stop();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            DpT.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DpT.Interval = TimeSpan.FromSeconds(1);// para que realize intervalos de 1s en 1s
            DpT.Tick += Incrementa;
        }

        private void Incrementa(object sender, EventArgs e)
        {
            MostraEnPantalla();
            increSeg++;
        }

        private void MostraEnPantalla()
        {
            Hora.Text = tp.hora(increSeg);
            Minutos.Text = tp.minuto(increSeg);
            Segundos.Text = tp.segundo(increSeg);
        }

    }
}