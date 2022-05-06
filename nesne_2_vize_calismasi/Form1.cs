using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yas_Hesaplayici
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        void yil_yas_hesaplayici(int gun, int ay, int yil, Label label_adi)
        {
            DateTime bugunTarihi = DateTime.Now;
            DateTime dogum1 = new DateTime(yil, ay, gun);

            TimeSpan ts1 = bugunTarihi - dogum1;
            label_adi.Text = "" + (ts1.TotalMilliseconds / (1000 * 60 * 60 * 24 * 365.25)).ToString();
        }
        void yil_yas_dogum_gunu_kalan(int gun, int ay, int yil, Label label_adi)
        {
            DateTime gelecek_yil;
            if (DateTime.Now > new DateTime(DateTime.Now.Year, ay, gun))
            {
                // eğer mevcut yıl içerisinde o doğmu günü geçmişse
                // sonraki yıla göre kalan hesabı yapıyor işte.
                gelecek_yil = new DateTime(DateTime.Now.Year+1, ay, gun);
            }
            else
            {
                gelecek_yil = new DateTime(DateTime.Now.Year, ay, gun);
            }
            DateTime dogum1 = DateTime.Now;
            TimeSpan kalan_yil = gelecek_yil - dogum1;
            label_adi.Text = "" + (kalan_yil.TotalMilliseconds / (1000 * 60 * 60 * 24 * 365.25)).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //fonksiyon burada çalışacak
            yil_yas_hesaplayici(4, 6, 1999, label10); //ysf
            yil_yas_hesaplayici(17, 1, 1999, label1); //elife
            yil_yas_dogum_gunu_kalan(4, 6, 1999, label7); //ysf
            yil_yas_dogum_gunu_kalan(17, 1, 1999, label4); //elife
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
