using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExercise.ViewModels
{
    public class MyVideoSourceViewModel
    {
        private static VideoCaptureDevice videoSource1;


        public static VideoCaptureDevice StartVideoSource()
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                videoSource1 = form.VideoDevice;

            }
            return videoSource1;

        }

        // Stop playing video from camera.
        public static void StopVideoSource()
        {
            // Set video source to null to releaze web camera.
            if (videoSource1 != null)
            {
                if (videoSource1.IsRunning)
                {
                    videoSource1.SignalToStop();
                    videoSource1.Stop();

                }
                videoSource1 = null;

            }


        }

    }
}
