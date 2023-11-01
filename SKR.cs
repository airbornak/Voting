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
    
    public partial class SKR : Form
    {
        public static string Captain1;
        public static string Captain2;
        Form1 log = new Form1();

        public SKR()
        {
            InitializeComponent();
        }

        private void SKR_Load(object sender, EventArgs e)
        {
            string[] councilors = { SK.C1,SK.C2, SK.C3, SK.C4, SK.C5, SK.C6, SK.C7,SK.C8 };
            string[] captain = { SK.Captain };

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Hide();

        }
    }
}
