using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

using System.Drawing.Imaging;
using IronOcr;
using System.Net;
using System.Web;
using System.Collections.Specialized;
using System.IO;




namespace APCS
{
    public partial class Main : Form
    {


        // The original image.
        private Bitmap OriginalImage;
        Bitmap bitmap4;


        // True when we're selecting a rectangle.
        private bool IsSelecting = false;

        // The area we are selecting.
        private int X0, Y0, X1, Y1;
        



        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3410PBF\\HASNAINSQL;Initial Catalog=APCS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        SqlDataAdapter sda;
        SqlCommandBuilder sb;
        DataTable dt;
        vehicle_own model = new vehicle_own();
        tow model1 = new tow();
        station model2 = new station();
        user model3 = new user();
        vehicle model4 = new vehicle();

        public Main()
        {

            
            //Console.Read(); //to keep console window open if trying in visual studio 

            InitializeComponent();
            PopulateDataGridView();
            Populatetowdgv();
            populateuserdgv();
            Populatevehicledgv();
            Populatestationdgv();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string SendSMS(string Masking, string toNumber, string MessageText, string MyUsername , string MyPassword) 
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


        private void btnsignout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.Show();


        }


        //#####################################################################################################################################


        //VEHICLE_OWEND CLASS STARTS!!!!!!!!!!!!!!!********************************************************************************************


        private void btnnewf_Click(object sender, EventArgs e)
        {
            //   comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //CLEAR METHOD
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            btninsertf.Text = "Save";
            btndeletef.Enabled = false;
            model.w_id = 0;
        }

        //POPULATE METHOD
        void PopulateDataGridView()
        {
            dgv_vo.AutoGenerateColumns = false;
            using (APCSEntities db = new APCSEntities())
            {
                dgv_vo.DataSource = db.vehicle_own.ToList<vehicle_own>();

            }
        }

        //INSERT AND UPDATE
        private void btninsertf_Click(object sender, EventArgs e)
        {
            try
            {

                model.w_active = textBox1.Text.Trim();
                model.vehicle_num = int.Parse(textBox2.Text);
                model.user_num = int.Parse(textBox3.Text);

                using (APCSEntities db = new APCSEntities())
                {
                    if (model.w_id == 0)                //Insert
                        db.vehicle_own.Add(model);
                    else                                //Update
                        db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Submitted Successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("INVALID REQUEST");
            }

        }


        //DELETE
        private void btndeletef_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (APCSEntities db = new APCSEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.vehicle_own.Attach(model);
                    db.vehicle_own.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
               
                }

            }
        }


        //DOUBLE CLICK
        private void dgv_vo_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_vo.CurrentRow.Index != -1)
            {
                model.w_id = Convert.ToInt32(dgv_vo.CurrentRow.Cells["w_id"].Value);
                using (APCSEntities db = new APCSEntities())
                {

                    model = db.vehicle_own.Where(x => x.w_id == model.w_id).FirstOrDefault();
                    textBox1.Text = model.w_active;
                    textBox2.Text = model.vehicle_num.ToString();
                    textBox3.Text = model.user_num.ToString();

                }
                btninsertf.Text = "Update";
                btndeletef.Enabled = true;
            }
        }

        //VEHICLE OWEND CLASS END!!!!!!!!!!!!!!!********************************************************************************************


        //##########################################################################################################################################


        //##########################################################################################################################################


        //TOW_CLASS START!!!!!!!!!!!!!!!********************************************************************************************

        //NEW
        private void towb1_Click(object sender, EventArgs e)
        {
            towt1.Text = "";
            towt2.Text = "";
            towt3.Text = "";
            towt4.Text = "";
            towt5.Text = "";

        }


        //CLEAR METHOD

        void Clear1()
        {
            towt1.Text = towt2.Text = towt3.Text = towt4.Text = towt5.Text = "";
            towb2.Text = "Save";
            towb3.Enabled = false;
            model1.t_id = 0;
        }


        //POPULATE METHOD

        void Populatetowdgv()
        {
            towdgv.AutoGenerateColumns = false;
            using (APCSEntities db = new APCSEntities())
            {
                towdgv.DataSource = db.tows.ToList<tow>();

            }
        }

        //INSERT AND UPDATE
        private void towb2_Click(object sender, EventArgs e)
        {
            try{
                model1.station = int.Parse(towt1.Text);
                model1.user_number = int.Parse(towt2.Text);
                model1.vehicle_number = int.Parse(towt3.Text);
                //model1.t_date_time = int.Parse(towt4.Text);
                model1.t_location = towt5.Text.Trim();

                using (APCSEntities db = new APCSEntities())
                {
                    if (model1.t_id == 0)             //Insert
                        db.tows.Add(model1);
                    else                              //Update
                        db.Entry(model1).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Submitted Successfully");
            
            
            }


                        catch (Exception ex)
            {
                MessageBox.Show("INVALID REQUEST");
            }
        }

        //DELETE 
        private void towb3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (APCSEntities db = new APCSEntities())
                {
                    var entry = db.Entry(model1);
                    if (entry.State == EntityState.Detached)
                        db.tows.Attach(model1);
                    db.tows.Remove(model1);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }

            }
        }

        //DOUBLE CLICK

        private void towdgv_DoubleClick(object sender, EventArgs e)
        {
            if (towdgv.CurrentRow.Index != -1)
            {
                model1.t_id = Convert.ToInt32(towdgv.CurrentRow.Cells["t_id"].Value);
                using (APCSEntities db = new APCSEntities())
                {

                    model1 = db.tows.Where(x => x.t_id == model1.t_id).FirstOrDefault();

                    towt1.Text = model1.station.ToString();
                    towt2.Text = model1.user_number.ToString();
                    towt3.Text = model1.vehicle_number.ToString();
                    towt4.Text = model1.t_date_time.ToString();
                    towt5.Text = model1.t_location;

                }
                towb2.Text = "Update";
                towb3.Enabled = true;
            }

        }



        //TOW_CLASS ENDED!!!!!!!!!!!!!!!**********************************************************************************************


        //############################################################################################################################

        //############################################################################################################################


        //STATION_CLASS START!!!!!!!!!!!!!!!**********************************************************************************************

        //NEW
        private void stationb1_Click(object sender, EventArgs e)
        {
            stationt1.Text = "";
            stationt2.Text = "";
            stationt3.Text = "";
        }

        //CLEAR METHOD
        void Clear2()
        {
            stationt1.Text = stationt2.Text = stationt3.Text = "";
            stationb2.Text = "Save";
            stationb3.Enabled = false;
            model2.s_id = 0;
        }

        //POPULATE METHOD

        void Populatestationdgv()
        {
            stationdgv.AutoGenerateColumns = false;
            using (APCSEntities db = new APCSEntities())
            {
                stationdgv.DataSource = db.stations.ToList<station>();

            }
        }


        //INSERT AND UPDATE
        private void stationb2_Click(object sender, EventArgs e)
        {
            try
            {
                model2.s_name = stationt1.Text.Trim();
                model2.s_longitude = stationt2.Text.Trim();
                model2.s_latitude = stationt3.Text.Trim();

                using (APCSEntities db = new APCSEntities())
                {
                    if (model2.s_id == 0)               //Insert
                        db.stations.Add(model2);
                    else                                //Update
                        db.Entry(model2).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                Populatestationdgv();
                MessageBox.Show("Submitted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID REQUEST");
            }
        }


        //DELETE 
        private void stationb3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (APCSEntities db = new APCSEntities())
                {
                    var entry = db.Entry(model2);
                    if (entry.State == EntityState.Detached)
                        db.stations.Attach(model2);
                    db.stations.Remove(model2);
                    db.SaveChanges();
                    Populatestationdgv();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }

            }
        }


        //DOUBLE CLICK
        private void stationdgv_DoubleClick(object sender, EventArgs e)
        {
            if (stationdgv.CurrentRow.Index != -1)
            {
                model2.s_id = Convert.ToInt32(stationdgv.CurrentRow.Cells["s_id"].Value);
                using (APCSEntities db = new APCSEntities())
                {

                    model2 = db.stations.Where(x => x.s_id == model2.s_id).FirstOrDefault();

                    stationt1.Text = model2.s_name.ToString();
                    stationt2.Text = model2.s_longitude.ToString();
                    stationt3.Text = model2.s_latitude.ToString();
                }
                stationb2.Text = "Update";
                stationb3.Enabled = true;
            }
        }

        //STATION_CLASS ENDED!!!!!!!!!!!!!!!**********************************************************************************************


        //################################################################################################################################

        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        //################################################################################################################################


        //USER_CLASS START!!!!!!!!!!!!!!!**********************************************************************************************


        //NEW
        private void userb1_Click(object sender, EventArgs e)
        {
            usert1.Text = "";
            usert2.Text = "";
            usert3.Text = "";
            usert4.Text = "";
        }

        //CLEAR METHOD
        void Clear3()
        {
            usert1.Text = usert2.Text = usert3.Text = usert4.Text = "";
            userb2.Text = "Save";
            userb3.Enabled = false;
            model3.u_id = 0;
        }

        //POPULATE METHOD
        void populateuserdgv()
        {
            userdgv.AutoGenerateColumns = false;
            using (APCSEntities db = new APCSEntities())
            {
                userdgv.DataSource = db.users.ToList<user>();

            }
        }

        //INSERT AND UPDATE
        private void userb2_Click(object sender, EventArgs e)
        {
            try
            {
                model3.u_name = usert1.Text.Trim();
                model3.u_address = usert2.Text.Trim();
                model3.u_contact = usert3.Text.Trim();
                model3.role = int.Parse(usert4.Text);

                using (APCSEntities db = new APCSEntities())
                {
                    if (model3.u_id == 0)              //Insert
                        db.users.Add(model3);
                    else                               //Update
                        db.Entry(model3).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                populateuserdgv();
                MessageBox.Show("Submitted Successfully");


            }
 
              catch (Exception ex)
            {
                MessageBox.Show("INVALID REQUEST");
            }
        }


        //DELETE
        private void userb3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (APCSEntities db = new APCSEntities())
                {
                    var entry = db.Entry(model3);
                    if (entry.State == EntityState.Detached)
                        db.users.Attach(model3);
                    db.users.Remove(model3);
                    db.SaveChanges();
                    populateuserdgv();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }

            }
        }


        //DOUBLE CLICK
        private void userdgv_DoubleClick(object sender, EventArgs e)
        {
            if (userdgv.CurrentRow.Index != -1)
            {
                model3.u_id = Convert.ToInt32(userdgv.CurrentRow.Cells["u_id"].Value);
                using (APCSEntities db = new APCSEntities())
                {

                    model3 = db.users.Where(x => x.u_id == model3.u_id).FirstOrDefault();

                    usert1.Text = model3.u_name.ToString();
                    usert2.Text = model3.u_address.ToString();
                    usert3.Text = model3.u_contact.ToString();
                    usert4.Text = model3.role.ToString();
                }
                userb2.Text = "Update";
                userb3.Enabled = true;
            }
        }


        //USER_CLASS ENDED!!!!!!!!!!!!!!!**********************************************************************************************


        //################################################################################################################################

        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        //################################################################################################################################


        //VEHICLE_CLASS START!!!!!!!!!!!!!!!**********************************************************************************************

        //NEW BTN
        private void vehicleb1_Click(object sender, EventArgs e)
        {
            vehiclet1.Text = "";
            vehiclet2.Text = "";
            vehiclet3.Text = "";
            vehiclet4.Text = "";
            vehiclet5.Text = "";
            vehiclet6.Text = "";
            vehiclet7.Text = "";
            vehiclet8.Text = "";
            vehiclet9.Text = "";

        }

        //CLEAR METHOD
        void Clear4()
        {
            vehiclet1.Text = vehiclet2.Text = vehiclet3.Text = vehiclet4.Text = vehiclet5.Text = vehiclet6.Text = vehiclet7.Text = vehiclet8.Text = vehiclet9.Text = "";
            vehicleb2.Text = "Save";
            vehicleb3.Enabled = false;
            model4.v_id = 0;
        }

        //POPULATE METHOD
        void Populatevehicledgv()
        {
            vehicledgv.AutoGenerateColumns = false;
            using (APCSEntities db = new APCSEntities())
            {
                vehicledgv.DataSource = db.vehicles.ToList<vehicle>();

            }
        }

        //INSERT AND UPDATE
        private void vehicleb2_Click(object sender, EventArgs e)
        {

            try
            {
                model4.v_num_plate = vehiclet1.Text.Trim();
                model4.v_type = vehiclet2.Text.Trim();
                model4.v_color = vehiclet3.Text.Trim();
                model4.v_model = vehiclet4.Text.Trim();
                // model4.v_picture = vehiclet5.Text.Trim();
                model4.v_brand = vehiclet6.Text.Trim();
                model4.v_chassis = vehiclet7.Text.Trim();
                model4.v_generation = vehiclet8.Text.Trim();
                model4.v_engine = vehiclet9.Text.Trim();

                using (APCSEntities db = new APCSEntities())
                {
                    if (model4.v_id == 0)              //Insert
                        db.vehicles.Add(model4);
                    else                               //Update
                        db.Entry(model4).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                Populatevehicledgv();
                MessageBox.Show("Submitted Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("INVALID REQUEST");
            }


        }

        //DELETE
        private void vehicleb3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (APCSEntities db = new APCSEntities())
                {
                    var entry = db.Entry(model4);
                    if (entry.State == EntityState.Detached)
                        db.vehicles.Attach(model4);
                    db.vehicles.Remove(model4);
                    db.SaveChanges();
                    Populatevehicledgv();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }

            }

        }

        //DOUBLE CLICK
        private void vehicledgv_DoubleClick(object sender, EventArgs e)
        {
            if (vehicledgv.CurrentRow.Index != -1)
            {
                model4.v_id = Convert.ToInt32(vehicledgv.CurrentRow.Cells["v_id"].Value);
                using (APCSEntities db = new APCSEntities())
                {

                    model4 = db.vehicles.Where(x => x.v_id == model4.v_id).FirstOrDefault();

                    vehiclet1.Text = model4.v_num_plate.ToString();
                    vehiclet2.Text = model4.v_type.ToString();
                    vehiclet3.Text = model4.v_color.ToString();
                    vehiclet4.Text = model4.v_model.ToString();
                    // vehiclet5.Text = model4.v_picture.ToString();
                    vehiclet6.Text = model4.v_brand.ToString();
                    vehiclet7.Text = model4.v_chassis.ToString();
                    vehiclet8.Text = model4.v_generation.ToString();
                    vehiclet9.Text = model4.v_engine.ToString();
                }
                vehicleb2.Text = "Update";
                vehicleb3.Enabled = true;
            }

        }


        //VEHICLE_CLASS ENDED!!!!!!!!!!!!!!!**********************************************************************************************


        //################################################################################################################################

        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        //############################################################################################################################


        // FULL SCREEN AND TIMER METHOD START
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        //FULL SCREEN AND TIMER METHOD END

        //##########################################################################################################################################


        //##########################################################################################################################################

        //TIMER CLASS START
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        //TIMER CLASS END

        //##########################################################################################################################################


        //##########################################################################################################################################

        //VISIBLE SIDE BAR(TRUE AND FALSE PORTION) START
        private void btnvehicleowner_Click(object sender, EventArgs e)
        {
            pnlmain.Visible = true;
            pnltow.Visible = false;
            pnlstation.Visible = false;
            pnluser.Visible = false;
            pnlvehicle.Visible = false;
            pnldashboard.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btntowedvehicle_Click(object sender, EventArgs e)
        {
            pnltow.Visible = true;
            pnlmain.Visible = false;
            pnlstation.Visible = false;
            pnluser.Visible = false;
            pnlvehicle.Visible = false;
            pnldashboard.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btnstation_Click(object sender, EventArgs e)
        {
            pnlstation.Visible = true;
            pnlmain.Visible = false;
            pnltow.Visible = false;
            pnluser.Visible = false;
            pnlvehicle.Visible = false;
            pnldashboard.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            pnluser.Visible = true;
            pnlmain.Visible = false;
            pnltow.Visible = false;
            pnlstation.Visible = false;
            pnlvehicle.Visible = false;
            pnldashboard.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btnvehicle_Click(object sender, EventArgs e)
        {
            pnlvehicle.Visible = true;
            pnluser.Visible = false;
            pnlmain.Visible = false;
            pnltow.Visible = false;
            pnlstation.Visible = false;
            pnldashboard.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnldashboard.Visible = true;
            pnlvehicle.Visible = false;
            pnluser.Visible = false;
            pnlmain.Visible = false;
            pnltow.Visible = false;
            pnlstation.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlconvertimg.Visible = true;
            pnldashboard.Visible = false;
            pnlvehicle.Visible = false;
            pnluser.Visible = false;
            pnlmain.Visible = false;
            pnltow.Visible = false;
            pnlstation.Visible = false;
        }

        //VISIBLE SIDE BAR(TRUE AND FALSE PORTION) END

        //##########################################################################################################################################


        //##########################################################################################################################################

        //VISIBLE DESKTOP BUTTONS(TRUE AND FALSE PORTION) START
        private void btnvehicleownerdb_Click(object sender, EventArgs e)
        {
            pnlmain.Visible = true;
            pnldashboard.Visible = false;
            pnlvehicle.Visible = false;
            pnluser.Visible = false;
            pnltow.Visible = false;
            pnlstation.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btntowedvehicledb_Click(object sender, EventArgs e)
        {
            pnltow.Visible = true;
            pnlmain.Visible = false;
            pnldashboard.Visible = false;
            pnlvehicle.Visible = false;
            pnluser.Visible = false;
            pnlstation.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btnstationdb_Click(object sender, EventArgs e)
        {
            pnlstation.Visible = true;
            pnltow.Visible = false;
            pnlmain.Visible = false;
            pnldashboard.Visible = false;
            pnlvehicle.Visible = false;
            pnluser.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btnuserdb_Click(object sender, EventArgs e)
        {
            pnluser.Visible = true;
            pnlvehicle.Visible = false;
            pnlstation.Visible = false;
            pnltow.Visible = false;
            pnlmain.Visible = false;
            pnldashboard.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void btnvehicldb_Click(object sender, EventArgs e)
        {
            pnlvehicle.Visible = true;
            pnlstation.Visible = false;
            pnltow.Visible = false;
            pnlmain.Visible = false;
            pnldashboard.Visible = false;
            pnluser.Visible = false;
            pnlconvertimg.Visible = false;

        }

        private void imgtotxtdb_Click(object sender, EventArgs e)
        {
            pnlconvertimg.Visible = true;
            pnlvehicle.Visible = false;
            pnlstation.Visible = false;
            pnltow.Visible = false;
            pnlmain.Visible = false;
            pnldashboard.Visible = false;
            pnluser.Visible = false;

        }

        //VISIBLE DESKTOP BUTTONS (TRUE AND FALSE PORTION) END

        //##########################################################################################################################################


        //##########################################################################################################################################


        Bitmap image = new Bitmap("picture.jpg");
        private void btnselect_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(file.FileName);
                picboxselect.Image = image;

                //cropping fuction



                bitmap4 = new Bitmap(picboxselect.Image);

            }
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {

           /* bitmap4 = new Bitmap(pictureBox6.Image);

                  var ocrpc = new AutoOcr();
                  string textpc = ocrpc.Read(bitmap4).ToString();
                  txtconvert.Text = textpc;
            */

            //previous
          var ocr = new AutoOcr();
            string text = ocr.Read(image).ToString();
            txtconvert.Text = text;
            //previous


             conn.Open();
              cmd.Connection = conn; // This solves the problem you see
            // HERE you SHOULD use a SQL paramter instead of appending strings to build your SQL !!!
             cmd.CommandText = "Select u_contact from users where u_id=(select user_num from vehicle_own where vehicle_num=(select v_id from vehicle where v_num_plate='" + text + "'))";
             string amt = cmd.ExecuteScalar().ToString();  //arror is at this part
             txtapi.Text = amt ;

  
 }

        private void btnsend_Click(object sender, EventArgs e)
        {
            
            /*string result;
            string apiKey = txtapi.Text;
            string number = "+923022037116,00923022037116"; // in a comma seperated list
            string message = txtmsg.Text;
            string send = txtsend.Text;
            String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + number + "&message=" + message + "&sender=" + send;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
            }
            catch (Exception ex)
            {
                //return e.Message;
                MessageBox.Show(null, "the error is" + ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                 result = sr.ReadToEnd();
            // Close and clean up the StreamReader
                  sr.Close();
            }
            //return result;
            MessageBox.Show(null, "The message is" + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
              */

            /* const string accountSid = "AC2f5bc843df6c5d231ad0ddfa3ff4279e";
             const string authToken = "c20ec429c4cffc5faf4a0166d4459671";
             TwilioClient.Init(accountSid, authToken);

             var message = MessageResource.Create(
                 body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                 from: new Twilio.Types.PhoneNumber("+12014488616"),
                 to: new Twilio.Types.PhoneNumber("+92 302 2037116")
             );
             Console.WriteLine(message.Sid);
             */

            //==============================================================================================================




        }

        private void SendSMS()
        {
            throw new NotImplementedException();
        }

        private void btnsend_Click_1(object sender, EventArgs e)
        {
            string MyUsername = "923318077234"; //Your Username At Sendpk.com 
            string MyPassword = "7954"; //Your Password At Sendpk.com 
            string toNumber = txtapi.Text; //Recepient cell phone number with country code 
            string Masking = "APCS"; //Your Company Brand Name 
            string MessageText = "Your vehicle was towed and you can take your vehicle from IQRA UNIVERSITY PARKING. Get Directions: https://goo.gl/maps/fmBk1jQBDutj6M3Y9";
            string jsonResponse = SendSMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
            Console.Write(jsonResponse);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconvert_TextChanged(object sender, EventArgs e)
        {

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

            OriginalImage = bitmap4;

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
            pictureBox6.Image = area;
        }

        }

        //  public string MessageText { get; set;}
        //  }
    }


