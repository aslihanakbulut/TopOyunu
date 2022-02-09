using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopOyunu
{
    public partial class Form1 : Form
    {

        int ekrandaki_top_sayisi;
        List<RoundedButton> toplar = new List<RoundedButton>();

        Color[] renkler = { Color.Blue, Color.Red, Color.Purple, Color.Brown, Color.DimGray };

        bool hareket = false;
        Point buton_konumu;
        puan_hesaplayici puan_Hesaplayici;

        int sayac = 0;
        int timer_ile_eklenecek_top_sayisi = 5;
        public Form1()
        {
            InitializeComponent();
        }
        void yeni_top_ekle()
        {
            Random random = new Random();
            int konum_x = random.Next(100, this.Width - 100);
            int konum_y = random.Next(100, this.Height - 100);

            int aci = random.Next(0, 360);

            int renk_id = random.Next(0, renkler.Length);
            RoundedButton yeniTop = new RoundedButton(renkler[renk_id], konum_x, konum_y, (float)aci, ref puan_Hesaplayici);
            toplar.Add(yeniTop);
            ekrandaki_top_sayisi++;
            this.Controls.Add(toplar.ElementAt(ekrandaki_top_sayisi - 1));

        }
        private void btn_ply_Click(object sender, EventArgs e)
        {
            timer1.Start(); //play tusuna basinca oyunu baslat
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //pause tusuna basinca oyunu durdur
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puan_Hesaplayici = new puan_hesaplayici();
            yeni_top_ekle();

            timer_ile_eklenecek_top_sayisi -= 1;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            if (sayac > 10 * 10) // her 10 saniyede bir top ekleme saglandi
            {
                sayac = 0;
                if (timer_ile_eklenecek_top_sayisi > 0)
                {
                    yeni_top_ekle();
                    timer_ile_eklenecek_top_sayisi -= 1;
                }

            }
            for (int i = 0; i < toplar.Count; i++)
            {
                switch (toplar[i].top_durumu)
                {
                    case -1: // top asagidan ciktiysa cikan topu sil, 2 top ekle
                        toplar[i].Dispose();
                        toplar.RemoveAt(i);
                        ekrandaki_top_sayisi -= 1;
                        yeni_top_ekle();
                        yeni_top_ekle();
                        puan_Hesaplayici.top_asagidan_cikti(); // top durumuna göre puan hesapla 

                        break;
                    case 0:  // top oyunda, hareketine devam et
                        toplar[i].hareketlendir(this.Height, this.Width, button_oyuncu.Location.X);
                        break;
                    case 1: // top yukaridan ciktiysa çikan topu hem top listesinden hem de ekrandan sil
                        toplar[i].Dispose();
                        toplar.RemoveAt(i);
                        ekrandaki_top_sayisi -= 1;
                        puan_Hesaplayici.top_yukaridan_cikti(); // top durumuna göre puan hesapla 
                        break;
                }
            }

            puan_txt.Text = puan_Hesaplayici.Get_puan().ToString(); // puani yazdir


            if (ekrandaki_top_sayisi == 0)
            {
                timer1.Stop();
                MessageBox.Show("OYUNU KAZANDINIZ");
            }
            if (ekrandaki_top_sayisi >= 10)
            {
                timer1.Stop();
                MessageBox.Show("KAYBETTİNİZ");
            }

        }

        private void button_oyuncu_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            buton_konumu = e.Location;
        }

        private void button_oyuncu_MouseMove(object sender, MouseEventArgs e)
        {

            if (hareket == true)
            {
                button_oyuncu.Left = (e.X + button_oyuncu.Left - (buton_konumu.X));

            }

        }
        private void button_oyuncu_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }
    }
}
