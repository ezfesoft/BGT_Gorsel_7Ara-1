using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_Gorsel_7Ara_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool erkek;
            bool kadin;

            erkek = radioButton1.Checked;
            kadin = radioButton2.Checked;
            if (erkek==true)
            {
                MessageBox.Show("Cinsiyet: ERKEK");
            }
            if (kadin==true)
            {
                MessageBox.Show("Cinsiyet: KADIN");
            }
        }
    }
}
