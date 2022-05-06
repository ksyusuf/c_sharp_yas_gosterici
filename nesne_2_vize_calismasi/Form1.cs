using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_2_vize_calismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int vize, final;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        double ort;
        string hbn;
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime bugunTarihi = DateTime.Now;
            DateTime dogum1 = new DateTime(1999, 6, 4);
            DateTime dogum2 = new DateTime(2001, 11, 11);

            TimeSpan ts1 = bugunTarihi - dogum1;
            TimeSpan ts2 = bugunTarihi - dogum2;
            label10.Text = "" + (ts1.TotalMilliseconds/(1000*60*60*24*365.25)).ToString();
            label11.Text = "" + (ts2.TotalMilliseconds / (1000 * 60 * 60 * 24 * 365.25)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }
    }
}
