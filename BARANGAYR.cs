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

    public partial class BARANGAYR : Form
    {
        
        public BARANGAYR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BARANGAYR_Load(object sender, EventArgs e)
        {
           
            string[] councilors = { BARANGAY.c1, BARANGAY.c2,BARANGAY.c3,BARANGAY.c4,BARANGAY.c5,BARANGAY.c6,BARANGAY.c7,BARANGAY.c8};
            string[] captain = { BARANGAY.Captain };
          
             label1.Text = captain[0];

               label2.Text = councilors[6];
               label3.Text = councilors[5];
               label4.Text = councilors[4];
               label5.Text = councilors[3];
               label6.Text = councilors[2];
               label7.Text = councilors[1];
               label8.Text = councilors[0];
               label9.Text = councilors[7];
           
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
           

    }
}

