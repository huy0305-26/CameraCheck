using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace CameraCheck
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public Form1()
        {
            InitializeComponent();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            cbCamera.SelectedIndex = 0;
            Notification.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ptbIMG.Image = bitmap;
        }

        private void btStop_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            ptbIMG.Image = null;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private HashSet<string> scannedQRs = new HashSet<string>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptbIMG.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptbIMG.Image);
                if (result != null)
                {
                    string qrText = result.ToString();
                    if (!scannedQRs.Contains(qrText))
                    {
                        scannedQRs.Add(qrText);
                        txtQR.Text += qrText + Environment.NewLine;
                        Notification.Text = "Học sinh đã điểm danh thành công!";
                        Notification.ForeColor = Color.Green;
                        Notification.Visible = true;
                    }
                    else
                    {
                        Notification.Text = "Học sinh này đã điểm danh rồi!";
                        Notification.ForeColor = Color.Red;
                        Notification.Visible = true;
                    }   
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Notification_Click(object sender, EventArgs e)
        {

        }

        private void bButton1_Click(object sender, EventArgs e)
        {

        }

        private void bButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
