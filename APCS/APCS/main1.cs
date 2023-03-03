using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;




namespace APCS
{
    public partial class main1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3410PBF\\HASNAINSQL;Initial Catalog=APCS;Integrated Security=True");
        SqlCommand cmd;
        WebCam webcam;

        Image<Bgr, Byte> imgOrg; //image type RGB (or Bgr as we say in Open CV)
        private Capture capturecam;
        private bool CaptureInProgress;

        public main1()
        {
            InitializeComponent();
        }
       
              
        private void main1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPCSDataSet1.pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter1.Fill(this.aPCSDataSet1.pictures);
            // TODO: This line of code loads data into the 'aPCSDataSet.pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(this.aPCSDataSet.pictures);

            try
            {
                capturecam = new Capture();
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            Application.Idle += new EventHandler(ProcessFunction);


            // FULL SCREEN CODE

            {
                // timer1.Start();

                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;
                this.Location = new Point(0, 0);
                this.Size = new Size(w, h);

            }

        }
        private void ProcessFunction(object sender, EventArgs arg)
        {
            Mat imgOrg = new Mat(); // instead of: Image<Bgr, Byte> imgOrg;
            imgOrg = capturecam.QuerySmallFrame();
            
            imgboxstart.Image = imgOrg;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (capturecam == null)
            {
                try
                {
                    capturecam = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            if (capturecam != null)
            {
                if (CaptureInProgress)
                {
                    btnstart.Text = "Start!";
                    Application.Idle -= ProcessFunction;
                }
                else
                {
                    btnstart.Text = "Stop!";
                    Application.Idle += ProcessFunction;
                }
                CaptureInProgress = !CaptureInProgress;
            }
        }

        private void ReleaseData()
        {
            if (capturecam != null)
                capturecam.Dispose();
        }

        private void btncapture_Click(object sender, EventArgs e)
        {
            captureimgbox.Image = imgboxstart.Image;
        }
      
        private void btnsaveimage_Click(object sender, EventArgs e)
        {

            conn.Open();

             SqlCommand mySqlCmd = new SqlCommand("imgadd", conn);
             mySqlCmd.CommandType = CommandType.StoredProcedure;
             mySqlCmd.Parameters.AddWithValue("p_id", 0);

             MemoryStream stream = new MemoryStream();

             int width = Convert.ToInt32(captureimgbox.Width);
             int height = Convert.ToInt32(captureimgbox.Height);
             Bitmap bmp = new Bitmap(width, height);
             captureimgbox.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));

             bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

             byte[] pic = stream.ToArray();


             mySqlCmd.Parameters.AddWithValue("p_picture", pic);


             mySqlCmd.ExecuteNonQuery();
             MessageBox.Show("Added Successfully");

        }

        private void btnshowimage_Click(object sender, EventArgs e)
        {
            imageshow ms = new imageshow();
            ms.Show();
        }
    }
}
        
        /*
        private Capture capture;
        private bool CaptureInProgress;

        public main1()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object sender , EventArgs arg)
        {
            Image<Bgr, Byte> ImageFrame = capture.QuerySmallFrame();
            imgboxstart.Image = ImageFrame;

        }
        */

           
    

