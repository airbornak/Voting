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
    public partial class SK : Form
    {
        public static string C1;
        public static string C2;
        public static string C3;
        public static string C4;
        public static string C5;
        public static string C6;
        public static string C7;
        public static string C8;
        public static string Captain;


        public SK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> councilors = new List<String>();
            List<String> captain = new List<String>();
         SKR skr = new SKR();


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
                councilors.Add(checkBox5.Text);


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
                C1 = councilors[0];
                C2 = councilors[1];
                C3 = councilors[2];
                C4 = councilors[3];
               C5 = councilors[4];
                C6 = councilors[5];
                C7 = councilors[6];
                C8 = councilors[6];
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
                skr.Show();
                this.Hide();

            }
          

        
        }

        private void SK_Load(object sender, EventArgs e)
        {

        }
    }
}
