using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using IronOcr;
using System.Net;
using System.Web;
using Tesseract;



namespace APCS
{
    public partial class main1 : Form
    {
        
   
        // The original image.
        private Bitmap OriginalImage;

        private Bitmap CropedImage;
        private Bitmap tesaractimage;


        // True when we're selecting a rectangle.
        private bool IsSelecting = false;

        // The area we are selecting.
        private int X0, Y0, X1, Y1;
        
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3410PBF\\HASNAINSQL;Initial Catalog=APCS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter sda;
        SqlCommandBuilder sb;
       
       

        Image<Bgr, Byte> imgOrg; //image type RGB (or Bgr as we say in Open CV)
        private Capture capturecam;
        private bool CaptureInProgress;


        Bitmap bitmap3;
        string text3;

        public main1()
        {
            InitializeComponent();
        }

        public static string SendSMS(string Masking, string toNumber, string MessageText, string MyUsername, string MyPassword)
        {
            String URI = "http://Sendpk.com" +
            "/api/sms.php?" +
            "username=" + MyUsername +
            "&password=" + MyPassword +
            "&sender=" + Masking +
            "&mobile=" + toNumber +
            "&message=" + Uri.UnescapeDataString(MessageText); // Visual Studio 10-15 
            //"//&message=" + System.Net.WebUtility.UrlEncode(MessageText);// Visual Studio 12 
            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                var httpWebResponse = ex.Response as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            return "404:URL not found :" + URI;
                            break;
                        case HttpStatusCode.BadRequest:
                            return "400:Bad Request";
                            break;
                        default:
                            return httpWebResponse.StatusCode.ToString();
                    }
                }
            }
            return null;
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


             SaveFileDialog s = new SaveFileDialog();
             s.FileName = "Image";// Default file name
             s.DefaultExt = ".Jpg";// Default file extension
             s.Filter = "Image (.jpg)|*.jpg";
             conn.Close();
        }

        private void btnshowimage_Click(object sender, EventArgs e)
        {

            var ocr = new AutoOcr();
            string text1 = ocr.Read(bitmap3).ToString();
            txtconvert.Text = text1;
            
                conn.Open();
                //    string veh = text;
                cmd.Connection = conn; // This solves the problem you see
                // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
                cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + text1 + "'))";
                string amt = cmd.ExecuteScalar().ToString(); 
                txtapi.Text = amt;
  
        }

        private void captureimgbox_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       // Bitmap images = new Bitmap("picture.jpg");
        private void btnselect_Click(object sender, EventArgs e)
        {
           try
            {
                bitmap3 = new Bitmap(captureimgbox.Image.Bitmap);
                picboxselect.Image = bitmap3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID REQUEST");
            }
            finally
            {
                conn.Close();
            }
          
        }

        private void picboxselect_Click(object sender, EventArgs e)
        {

        }

        private void imgboxstart_Click(object sender, EventArgs e)
        {

        }
        Bitmap image = new Bitmap("picture.jpg");
        
        private void btnselectpc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(file.FileName);
                picboxselect.Image = image;
            }
        }

        private void btnconvertpc_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3410PBF\\HASNAINSQL;Initial Catalog=APCS;Integrated Security=True");
            SqlCommand cmdd = new SqlCommand();

            SqlDataAdapter sda;
            SqlCommandBuilder sb;
       
       

            var ocr1 = new AutoOcr();
            string text1 = ocr1.Read(image).ToString();
            txtconvert.Text = text1;
            con.Open();
                //    string veh = text;
                cmd.Connection = con; // This solves the problem you see
                // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
                cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + text1 + "'))";

                try
                {
                    string amt1 = cmd.ExecuteScalar().ToString();  //arror is at this part

                    txtapi.Text = amt1;
                   
                }
                catch
                {
                    MessageBox.Show("NO RECORD FOUND ");
                }

                con.Close();
           
        }

        private void btnconvertimg_Click(object sender, EventArgs e)
        {

/*
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3410PBF\\HASNAINSQL;Initial Catalog=APCS;Integrated Security=True");
            SqlCommand cmdd = new SqlCommand();

            SqlDataAdapter sda;
            SqlCommandBuilder sb;

            */

            var ocr1 = new AutoOcr();
            string text1 = ocr1.Read(bitmap3).ToString();
            txtconvert.Text = text1;


            /*
            con.Open();
            //    string veh = text;
            cmd.Connection = con; // This solves the problem you see
            // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
            cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + text1 + "'))";

            try
            {
                string amt1 = cmd.ExecuteScalar().ToString();  //arror is at this part

                txtapi.Text = amt1;

            }
            catch
            {
                MessageBox.Show("record not ");
            }

            con.Close();
             
             */ 
        }

        private void picboxselect_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelecting = true;

            // Save the start point.
            X0 = e.X;
            Y0 = e.Y;
        }

        private void picboxselect_MouseMove(object sender, MouseEventArgs e)
        {
            // Do nothing it we're not selecting an area.
            if (!IsSelecting) return;

            // Save the new point.
            X1 = e.X;
            Y1 = e.Y;

            OriginalImage = bitmap3;

            // Make a Bitmap to display the selection rectangle.
            Bitmap bm = new Bitmap(OriginalImage);

            // Draw the rectangle.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawRectangle(Pens.Red,
                    Math.Min(X0, X1), Math.Min(Y0, Y1),
                    Math.Abs(X0 - X1), Math.Abs(Y0 - Y1));
            }

            // Display the temporary bitmap.
            picboxselect.Image = bm;
        }

        private void picboxselect_MouseUp(object sender, MouseEventArgs e)
        {
            // Do nothing it we're not selecting an area.
            if (!IsSelecting) return;
            IsSelecting = false;

            // Display the original image.
            picboxselect.Image = OriginalImage;

            // Copy the selected part of the image.
            int wid = Math.Abs(X0 - X1);
            int hgt = Math.Abs(Y0 - Y1);
            if ((wid < 1) || (hgt < 1)) return;

            Bitmap area = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(area))
            {
                Rectangle source_rectangle =
                    new Rectangle(Math.Min(X0, X1), Math.Min(Y0, Y1),
                        wid, hgt);
                Rectangle dest_rectangle =
                    new Rectangle(0, 0, wid, hgt);
                gr.DrawImage(OriginalImage, dest_rectangle,
                    source_rectangle, GraphicsUnit.Pixel);
            }

            // Display the result.
            picBoxaft.Image = area;
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string MyUsername = "923318077234"; //Your Username At Sendpk.com 
            string MyPassword = "7954"; //Your Password At Sendpk.com 
            string toNumber = txtapi.Text; //Recepient cell phone number with country code 
            string Masking = "APCS"; //Your Company Brand Name 
            string MessageText = "Your vehicle was towed and you can take your vehicle from IQRA UNIVERSITY PARKING. Get Directions: https://goo.gl/maps/fmBk1jQBDutj6M3Y9";
            string jsonResponse = SendSMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
            Console.Write(jsonResponse);
        }

        private void btnconvertnum_Click(object sender, EventArgs e)
        {
          string inputnum=txtboxnum.Text;


          try
          {
              conn.Open();
              cmd.Connection = conn; // This solves the problem you see
              // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
              cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + inputnum + "'))";
              string amt = cmd.ExecuteScalar().ToString();  //arror is at this part
              txtapi.Text = amt;
              conn.Close();
          
          
          }

          catch (Exception ex)
          {
              MessageBox.Show("Record not found");
          }
          finally
          {
              conn.Close();
          }
            
        }

        private void btnconvertimg_Click_1(object sender, EventArgs e)
        {
            try
            {
                CropedImage = new Bitmap(picBoxaft.Image);

                var ocr2 = new AdvancedOcr()
                {

                    CleanBackgroundNoise = true,
                    EnhanceContrast = true,
                    EnhanceResolution = true,
                    //   Language = IronOcr.Languages.English.OcrLanguagePack,
                    Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced,
                    ColorSpace = AdvancedOcr.OcrColorSpace.Color,
                    DetectWhiteTextOnDarkBackgrounds = true,
                    InputImageType = AdvancedOcr.InputTypes.AutoDetect,
                    RotateAndStraighten = true,
                    ReadBarCodes = false,
                    ColorDepth = 4


                };
                string textcroped = ocr2.Read(CropedImage).ToString();
                txtconvert.Text = textcroped;

                string inputnum;

                conn.Open();
                cmd.Connection = conn; // This solves the problem you see
                // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
                cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + textcroped + "'))";
                string amt = cmd.ExecuteScalar().ToString();  //arror is at this part
                txtapi.Text = amt;
                conn.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("no recoord");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           


            try
            {
                tesaractimage = new Bitmap(picBoxaft.Image);


                TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                Page page = engine.Process(tesaractimage, PageSegMode.Auto);
                string result = page.GetText();
                txtconvert.Text = result;

                string inputnum;

                conn.Open();
                cmd.Connection = conn; // This solves the problem you see
                // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
                cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + result + "'))";
                string amt = cmd.ExecuteScalar().ToString();  //arror is at this part
                txtapi.Text = amt;
                conn.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("no recoord");
            }
            finally
            {
                conn.Close();

            }

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

           
    

