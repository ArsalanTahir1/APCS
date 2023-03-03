using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APCS
{
    public partial class Form1 : Form
    {
           

        public Form1()
        {
        
       
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);            
        }



        //#######################################################################################################
        private void txtuserrole_Enter(object sender, EventArgs e)
        {
            if (txtuserrole.Text == "role1")
            {
                txtuserrole.Text = "";
                txtuserrole.ForeColor = Color.Black;
            }
        }

        private void txtuserrole_Leave(object sender, EventArgs e)
        {
            if (txtuserrole.Text == "")
            {
                txtuserrole.Text = "role1";
                txtuserrole.ForeColor = Color.Silver;
            }

        }
    
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.Silver;
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (txtpassword.Text == "admin123" && (txtuserrole.Text == "admin" || txtuserrole.Text == "Admin"))
            {
                Main mn = new Main();
                mn.Show();
            }
            else if (txtpassword.Text == "officer123" && (txtuserrole.Text == "officer" || txtuserrole.Text == "Officer"))
            {
                main1 mn1 = new main1();
                mn1.Show();
            }

            else
            {
                MessageBox.Show("Wrong Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //#####################################################################################################
          /*SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3410PBF\HASNAINSQL;Initial Catalog=test_login;Integrated Security=True");
          string query = "select * from Admin1 where Pass = '" + txtpassword.Text.Trim() + "'" ;
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            Main main = new Main();
            main.Show();
           */
            



        }

     

      private void pictureBox1_Click(object sender, EventArgs e)
       {
           Application.Exit();

       }

      private void panel1_Paint(object sender, PaintEventArgs e)
      {
          int w = Screen.PrimaryScreen.Bounds.Width;
          int h = Screen.PrimaryScreen.Bounds.Height;
          this.Location = new Point(0, 0);
          this.Size = new Size(w, h);
      }

      
    }
    }
    

     
    

