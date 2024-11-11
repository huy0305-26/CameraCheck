using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            //duyệt danh sách các thiết bị camera có trên máy và thêm các thiết bị vào ComboBox
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            
            cbCamera.SelectedIndex = 0; // Đặt mục đầu tiên làm lựa chọn mặc định trong ComboBox
            Notification.Visible = false; // Ẩn thông báo khi khởi động

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
            // Nếu camera đang chạy, dừng camera trước khi khởi động lại
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            // Chọn thiết bị camera
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start(); // Bắt đầu truyền hình ảnh từ camera
            timer1.Start();// Bắt đầu chạy timer quét QR code.
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ptbIMG.Image = bitmap; // Hiển thị Camera mới trong `PictureBox`
        }
        // Dừng Camera điểm danh
        private void btStop_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            ptbIMG.Image = null;
        }
        // kiểm tra xem camera có đang chạy không.
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }
        // Chọn camera khác
        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu camera hiện tại có đang chạy
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();// Dừng camera hiện tại trước khi chuyển sang camera mới
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptbIMG.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptbIMG.Image);
                if (result != null)
                {
                    string studentId = result.ToString();
                    string classListFilePath = "C:\\Users\\Abc\\source\\repos\\CameraCheck\\CameraCheck\\CameraCheck\\classList.txt";

                    // Tạo tên file attendance với ngày giờ hiện tại
                    string attendanceFilePath = $"C:\\Users\\Abc\\source\\repos\\CameraCheck\\CameraCheck\\CameraCheck\\attendance_{DateTime.Now:dd-MM-yyyy}.txt";

                    // Kiểm tra nếu mã học sinh không phải là 6 chữ số
                    if (!System.Text.RegularExpressions.Regex.IsMatch(studentId, @"^\d{6}$"))
                    {
                        Notification.Text = "Mã học sinh không hợp lệ! Mã phải gồm 6 chữ số.";
                        Notification.ForeColor = Color.Red;
                        Notification.Visible = true;
                        return;
                    }
                    // Kiểm tra nếu file danh sách lớp chưa tồn tại
                    if (!File.Exists(classListFilePath))
                    {
                        Notification.Text = "File danh sách lớp không tồn tại!";
                        Notification.ForeColor = Color.Red;
                        Notification.Visible = true;
                        return;
                    }

                    // Đọc danh sách mã học sinh hợp lệ từ file danh sách lớp
                    HashSet<string> validStudents = new HashSet<string>(File.ReadAllLines(classListFilePath));

                    // Kiểm tra nếu mã học sinh không có trong danh sách lớp
                    if (!validStudents.Contains(studentId))
                    {
                        Notification.Text = "Học sinh này không ở trong lớp!";
                        Notification.ForeColor = Color.Red;
                        Notification.Visible = true;
                        return;
                    }

                    // Đọc danh sách các mã học sinh đã điểm danh trong file hiện tại
                    HashSet<string> attendedStudents = new HashSet<string>();
                    if (File.Exists(attendanceFilePath))
                    {
                        attendedStudents = new HashSet<string>(File.ReadAllLines(attendanceFilePath));
                    }

                    // Kiểm tra nếu mã học sinh đã được điểm danh
                    if (attendedStudents.Contains(studentId))
                    {
                        Notification.Text = "Học sinh này đã điểm danh rồi!";
                        Notification.ForeColor = Color.Red;
                        Notification.Visible = true;
                    }
                    else
                    {
                        // Thêm mã học sinh vào file điểm danh và cập nhật giao diện
                        File.AppendAllText(attendanceFilePath, studentId + Environment.NewLine);
                        txtQR.Text += studentId + Environment.NewLine;

                        Notification.Text = "Học sinh đã điểm danh thành công!";
                        Notification.ForeColor = Color.Green;
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
