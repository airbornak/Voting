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
    public partial class B_AND_SKR : Form
    {
        
        public B_AND_SKR()
        {
            InitializeComponent();
        }

        private void B_AND_SKR_Load(object sender, EventArgs e)
        {
            
            string[] councilors = { SK.C1, SK.C2, SK.C3, SK.C4, SK.C5, SK.C6, SK.C7, SK.C8 };
            string[] captain = { SK.Captain };
            string[] Councilors = { BARANGAY.c1, BARANGAY.c2, BARANGAY.c3, BARANGAY.c4, BARANGAY.c5, BARANGAY.c6, BARANGAY.c7, BARANGAY.c8 };
            string[] Captain = { BARANGAY.Captain };
            label1.Text = captain[0];

            label2.Text = councilors[6];
            label3.Text = councilors[5];
            label4.Text = councilors[4];
            label5.Text = councilors[3];
            label6.Text = councilors[2];
            label7.Text = councilors[1];
            label8.Text = councilors[0];
            label18.Text = councilors[7];

            /////////////



            label9.Text = Captain[0];
            label10.Text = Councilors[6];
            label11.Text = Councilors[5];
            label12.Text = Councilors[4];
            label13.Text = Councilors[3];
            label14.Text = Councilors[2];
            label15.Text = Councilors[1];
            label16.Text = Councilors[0];
            label19.Text = Councilors[7];
           



        }

        private void labelR_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
    }
}
