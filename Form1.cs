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
    public partial class Form1 : Form
    {
        public int age;
        public static string id;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            BARANGAY B = new BARANGAY();
            SK sk = new SK();
            SK2 sk2 = new SK2();
          
            if (age > 30)
            {
                B.Show();
                this.Hide();
           
            }
            else if (age == 17)
            {
                sk.Show();
                this.Hide();   
            }
            else if (age >= 18  && age <=30)
            {
                sk2.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             age = Convert.ToInt32(textBox1.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            id = textBox3.Text;
        }
    }
}
