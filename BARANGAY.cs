using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTINGMACHINE2
{

    public partial class BARANGAY : Form
    {
        public static string c1;
        public static string c2;
        public static string c3;
        public static string c4;
        public static string c5;
        public static string c6;
        public static string c7;
        public static string c8;
        public static string Captain;



     
        public BARANGAY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> councilors = new List<String>();
            List<String> captain = new List<String>();
            BARANGAYR bb = new BARANGAYR();
           
           
           if (checkBox1.Checked)
            {
                captain.Add(checkBox1.Text);
            }

            if (checkBox2.Checked)
            {
                captain.Add(checkBox2.Text);
            }
           
           
          
            /////////////////

            if (checkBox3.Checked)
            {
        
                councilors.Add(checkBox3.Text);
          
            } //COUNCILOR1

          

            if (checkBox4.Checked)
            {
             
                councilors.Add(checkBox4.Text);
        

            }//COUNCILOR2;
           

            if (checkBox5.Checked)
            {
                 councilors.Add( checkBox5.Text);
          

            } //COUNCILOR3;

            if (checkBox6.Checked)
            {
                councilors.Add(checkBox6.Text);
          

            } //COUNCILOR4;

            if (checkBox7.Checked)
            {
                councilors.Add(checkBox7.Text);
      

            } //COUNCILOR5;

            if (checkBox8.Checked)
            {
                councilors.Add(checkBox8.Text);
             

            } //COUNCILOR6;

            if (checkBox9.Checked)
            {
                councilors.Add(checkBox9.Text);
          

            } //COUNCILOR7;

            if (checkBox10.Checked)
            {
                councilors.Add(checkBox10.Text);
         

            } //COUNCILOR8;

            if (checkBox11.Checked)
            {
                councilors.Add(checkBox11.Text);
        

            } //COUNCILOR9;

            if (checkBox12.Checked)
            {
                councilors.Add(checkBox12.Text);
            

            } //COUNCILOR10;

            if (checkBox13.Checked)
            {
                councilors.Add(checkBox13.Text);
              

            } //COUNCILOR11;

            if (checkBox14.Checked)
            {
                councilors.Add(checkBox14.Text);
             

            } //COUNCILOR12;

            if (checkBox15.Checked)
            {
                councilors.Add(checkBox15.Text);
     

            } //COUNCILOR13;


            if (checkBox16.Checked)
            {
                councilors.Add(checkBox16.Text);
          

            } //COUNCILOR14;



            if (councilors.Count == 8)
            {
                c1 = councilors[0];
                c2 = councilors[1];
                c3 = councilors[2];
                c4 = councilors[3];
                c5 = councilors[4];
                c6 = councilors[5];
                c7 = councilors[6];
                c8 = councilors[7];
            }
            else
            {
                MessageBox.Show("You must 8 candidate in councilors");
            
            }
            if (captain.Count == 1)
            {
                Captain = captain[0];

            }
            else
            {
                MessageBox.Show("You musT vote only 1 captain");
            }

            if (captain.Count == 1 && councilors.Count == 8)
            {
                bb.Show();
                this.Hide();

            }
          
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BARANGAY_Load(object sender, EventArgs e)
        {

        }
    }
}
