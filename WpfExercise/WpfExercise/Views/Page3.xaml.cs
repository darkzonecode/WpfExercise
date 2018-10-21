using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfExercise.ViewModels;

namespace WpfExercise.Views
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private VideoCaptureDevice videoSource1;
        public Page3()
        {
            InitializeComponent();
        }


        private void BtnBackToSecondtPage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();

                // Stop player.
                StopCamera();
            }

            e.Handled = true;
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());

            // Stop player.
            StopCamera();



            e.Handled = true;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            MyPlayer.VideoSource = MyVideoSourceViewModel.StartVideoSource();

            MyPlayer.Start();

            e.Handled = true;
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            StopCamera();

            e.Handled = true;
        }

        // Stop playing video from camera.
        private void StopCamera()
        {
            if (MyPlayer.IsRunning)
            {
                MyPlayer.SignalToStop();

                // just wait 3 second  
                Thread.Sleep(3000);

                MyPlayer.Stop();
            }

            MyPlayer.VideoSource = null;

            // Just make sure source is released.
            MyVideoSourceViewModel.StopVideoSource();
        }

    }
}
