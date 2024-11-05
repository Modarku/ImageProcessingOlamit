using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageProcessingOlamit
{
    
    partial class Camera
    {
        public PictureBox pbLoadedBox;
        public PictureBox pbProcessedBox;
        public PictureBox pbBackgroundLoadedBox;

        private Filters filter = new Filters();

        public FilterInfoCollection filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        public VideoCaptureDevice videoCapture;
        public Bitmap videoCaptureRaw;
        public Thread processingThread;
        private Boolean shouldStop = false;

        public Camera(PictureBox pbLoadedBox, PictureBox pbProcessedBox, PictureBox pbBackgroundLoadedBox)
        {
            this.pbLoadedBox = pbLoadedBox;
            this.pbProcessedBox = pbProcessedBox;
            this.pbBackgroundLoadedBox = pbBackgroundLoadedBox;
        }

        public void startVideoCapture()
        {
            videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
            videoCapture.NewFrame += VideoCapture_NewFrame;
            videoCapture.Start();
        }

        private void VideoCapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbLoadedBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void startBasicCopyVideoCapture()
        {
            shouldStop = false;
            processingThread = new Thread(BasicCopyVideo);
            processingThread.IsBackground = true;
            processingThread.Start();
        }

        private void BasicCopyVideo()
        {
            Bitmap loaded, processed;
            int tick = 0;
            do
            {
                if (shouldStop) break;
                loaded = new Bitmap((Bitmap)pbLoadedBox.Image.Clone());
                
                processed = filter.basicCopy(loaded);

                tick++;

                if (!shouldStop)
                {
                    pbProcessedBox.Invoke((MethodInvoker)(() => pbProcessedBox.Image = processed));
                }

            } while (tick <= 100);

        }

        public void startGrayScaleVideoCapture()
        {
            shouldStop = false;
            processingThread = new Thread(GrayScaleVideo);
            processingThread.IsBackground = true;
            processingThread.Start();
        }

        private void GrayScaleVideo()
        {
            Bitmap loaded, processed;
            int tick = 0;
            do
            {
                if (shouldStop) break;
                loaded = new Bitmap((Bitmap)pbLoadedBox.Image.Clone());

                processed = filter.grayScale(loaded);

                tick++;

                if (!shouldStop)
                {
                    pbProcessedBox.Invoke((MethodInvoker)(() => pbProcessedBox.Image = processed));
                }

            } while (tick <= 100);

        }

        public void startSepiaScaleVideoCapture()
        {
            shouldStop = false;
            processingThread = new Thread(SepiaScaleVideo);
            processingThread.IsBackground = true;
            processingThread.Start();
        }

        private void SepiaScaleVideo()
        {
            Bitmap loaded, processed;
            int tick = 0;
            do
            {
                if (shouldStop) break;
                loaded = new Bitmap((Bitmap)pbLoadedBox.Image.Clone());

                processed = filter.sepiaScale(loaded);

                tick++;

                if (!shouldStop)
                {
                    pbProcessedBox.Invoke((MethodInvoker)(() => pbProcessedBox.Image = processed));
                }

            } while (tick <= 100);

        }

        public void startColorInverseVideoCapture()
        {
            shouldStop = false;
            processingThread = new Thread(ColorInverseVideo);
            processingThread.IsBackground = true;
            processingThread.Start();
        }

        private void ColorInverseVideo()
        {
            Bitmap loaded, processed;
            int tick = 0;
            do
            {
                if (shouldStop) break;
                loaded = new Bitmap((Bitmap)pbLoadedBox.Image.Clone());

                processed = filter.colorInverse(loaded);

                tick++;

                if (!shouldStop)
                {
                    pbProcessedBox.Invoke((MethodInvoker)(() => pbProcessedBox.Image = processed));
                }

            } while (tick <= 100);

        }

        public void startHistogramVideoCapture()
        {
            shouldStop = false;
            processingThread = new Thread(HistogramVideo);
            processingThread.IsBackground = true;
            processingThread.Start();
        }

        private void HistogramVideo()
        {
            Bitmap loaded, processed;
            int tick = 0;
            do
            {
                if (shouldStop) break;
                loaded = new Bitmap((Bitmap)pbLoadedBox.Image.Clone());

                processed = filter.histogram(loaded);

                tick++;

                if (!shouldStop)
                {
                    pbProcessedBox.Invoke((MethodInvoker)(() => pbProcessedBox.Image = processed));
                }

            } while (tick <= 100);

        }

        public void startSubtractionVideoCapture()
        {
            shouldStop = false;
            processingThread = new Thread(SubtractionVideo);
            processingThread.IsBackground = true;
            processingThread.Start();
        }

        private void SubtractionVideo()
        {
            Bitmap loaded, processed, backgroundLoaded;
            int tick = 0;
            do
            {
                if (shouldStop) break;
                loaded = new Bitmap((Bitmap)pbLoadedBox.Image.Clone());
                backgroundLoaded = new Bitmap((Bitmap)pbBackgroundLoadedBox.Image.Clone());

                processed = filter.subtract(loaded, backgroundLoaded);

                tick++;

                if (!shouldStop)
                {
                    pbProcessedBox.Invoke((MethodInvoker)(() => pbProcessedBox.Image = processed));
                }

            } while (tick <= 100);

        }

        public void stopThread()
        {

            if (processingThread != null && processingThread.IsAlive)
            {
                shouldStop = true;
                pbProcessedBox.Image = null;
            }
        }

        public void stopVideoCapture()
        {
            //devices[0].Stop();
            if (videoCapture != null)
            {
                if (videoCapture.IsRunning)
                {
                    videoCapture.SignalToStop();
                    pbLoadedBox.Image = null;
                }
            }


            if (processingThread != null && processingThread.IsAlive)
            {
                shouldStop = true;
                pbProcessedBox.Image = null;
            }
        }
    }
}
