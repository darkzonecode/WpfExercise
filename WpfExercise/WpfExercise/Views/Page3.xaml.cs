using AForge.Video.DirectShow;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExercise.Views
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }


        private void BtnBackToSecondtPage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }

            e.Handled = true;
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());

            // Stop player.
            if (MyPlayer.IsRunning)
            {
                MyPlayer.SignalToStop();

                // just wait 3 second  
                //Thread.Sleep(3000);

                MyPlayer.Stop();
            }

            MyPlayer.VideoSource = null;



            e.Handled = true;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                VideoCaptureDevice videoSource1 = form.VideoDevice;

                MyPlayer.VideoSource = videoSource1;

                MyPlayer.Start();


            }


            // Enumerate video devices.
            //var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Create video source.
            //VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            //VideoCaptureDevice videoSource = form.VideoDevice;



            //videoSource.Start();

            //VideoSourcePlayer player = new VideoSourcePlayer();

            //player.AutoSizeControl = true;
            //player.Start();


            //MyPlayer.VideoSource = videoSource;

            //MyPlayer.Start();

        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            if (MyPlayer.IsRunning)
            {
                MyPlayer.SignalToStop();

                // just wait 3 second  
                //Thread.Sleep(3000);

                MyPlayer.Stop();
            }

            MyPlayer.VideoSource = null;
        }



        // Close video source if it is running
        //private void CloseCurrentVideoSource()
        //{
        //    if (videoSourcePlayer.VideoSource != null)
        //    {
        //        videoSourcePlayer.SignalToStop();

        //        // wait ~ 3 seconds
        //        for (int i = 0; i < 30; i++)
        //        {
        //            if (!videoSourcePlayer.IsRunning)
        //                break;
        //            System.Threading.Thread.Sleep(100);
        //        }

        //        if (videoSourcePlayer.IsRunning)
        //        {
        //            videoSourcePlayer.Stop();
        //        }

        //        videoSourcePlayer.VideoSource = null;
        //    }
        //}


    }
}
