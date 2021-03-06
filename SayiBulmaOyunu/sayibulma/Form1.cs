﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayibulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Global değişkenler
        int sayac;
        int can;
        int[] sayilar;
        bool gecersiz = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
             if (tbisim.Text == string.Empty || tbhak.Text == string.Empty || tbsure.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.");
                    gecersiz = true;
                }
            

             if(gecersiz == true)
             {
                Application.Restart();
             }

            // Buton click eventi ile birlikte açılan paneller
            paneltime.Visible = true;
            panelhak.Visible = true;
            timeresim.Visible = true;
            hakresim.Visible = true;
            sayigirpanel.Visible = true;
            baslabtn.Visible = false;
            btntahmin.Visible = true;
            haklabel.Text = tbhak.Text;  
            can = int.Parse(tbhak.Text.ToString());
            sayac = int.Parse(tbsure.Text.ToString());


            
            // Geri sayım sayacı başlatma ve 1000ms interval ataması
            timer1.Interval = 1000;
            timer1.Start();

            // Kullanıcı isminin harf sayısını almak için char dizisi oluşturuluyor
            String s = tbisim.Text;
            var harfler = s.ToCharArray();

            // Harf sayısına göre basamak sayısına uygun textboxlar gösteriliyor
            for (int i = 0; i < harfler.Length; i++)
            {
                var txts = this.Controls.Find("textbox" + i, true);
                var pnls = this.Controls.Find("panel" + i, true);
                foreach (TextBox txt in txts)
                {
                    txt.Visible = true;
                }
                foreach (Panel pnl in pnls)
                {
                    pnl.Visible = true;
                }
            }

           


            sayilar = new int[harfler.Length];
            Random rnd = new Random();

            // Rakamları tekrar eden random sayı dizisi doldurma işlemi
            if (tekrar.Checked)
            {
                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar[i] = rnd.Next(0, 9);
                }
            }

            // Rakamları tekrar etmeyen random sayı dizisi doldurma işlemi
            if (tekrarsiz.Checked)
            {
                int sayac = 0;
                int j;

                while (sayac < sayilar.Length){
                    j = rnd.Next(0, 9);
                    if (Array.IndexOf(sayilar, j) == -1)
                    {
                        sayilar[sayac] = j;
                        sayac++;
                    }
                }
            }

           // string gosterdizi = string.Join(Environment.NewLine, sayilar);
           // MessageBox.Show(gosterdizi);

        }

        int pos;
        int a;
        int flag = 0;
        int[] dizi2;
        private void btntahmin_Click(object sender, EventArgs e)
        {
                // Oyunu kazanmak için geçiçi bir list oluşturuluyor **
                List<int> temp = new List<int>();


                // Oyun mekanizması
                for (int i = 0; i < sayilar.Length; i++)
                {
                    var txts = this.Controls.Find("textbox" + i, true);
                    var pnls = this.Controls.Find("panel" + i, true);
                    foreach (TextBox txt in txts)
                    {
                        a = int.Parse(txt.Text.ToString());

                        pos = Array.IndexOf(sayilar, a);
                    }
                    foreach (Panel pnl in pnls)
                    {
                        // Eğer girilen sayı dizide varsa...
                        if (pos > -1)
                        {
                            // Panel kırmızı oluyor
                            pnl.BackColor = Color.Red;
                            // Eğer sayı dizinin indisiyle aynı yerdeyse mavi olacak
                            if (a == sayilar[i])
                            {
                                pnl.BackColor = Color.Blue;
                            // ** Eğer girilen sayı tam anlamıyla doğruysa geçici liste atılıyor
                                temp.Add(a);
                            }
                        }
                        else
                        {
                            pnl.BackColor = Color.Silver;
                        }

                        if(pos > -1 && a != sayilar[i])
                        {
                            // Sayı dizide varsa ama yeri doğru değilse hak 1 azalıyor
                            can = can - 1;
                            haklabel.Text = can.ToString();
                        }  
                    }                    
                }

                // Geçiçi list diziye dönüştürülüyor
               dizi2 = temp.ToArray();

            // ** Eğer geçiçi dizi rastgele sayılardan oluşan dizi ile aynıysa oyunu kazanırız
            if (dizi2.SequenceEqual(sayilar))
            {
                MessageBox.Show("TEBRİKLER BİLDİNİZ !!!");
                yeniOyun();
            }

            // Hakkımız biterse...
            if (can <= 0)
                {
                MessageBox.Show("HAKKINIZ BİTTİ");
                yeniOyun();
                }
        }

        // Yeni oyun diyaloğu için method..
        public void yeniOyun()
        {
            string gosterdizi = string.Join(Environment.NewLine, sayilar);
            MessageBox.Show("Sayılar şunlardı :" + Environment.NewLine + "" + gosterdizi);
            DialogResult r = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Yeni Oyun?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (r == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Geri sayım için timer..

            if(sayac > 0)
            {
                sayac = sayac - 1;
                sure.Text = sayac.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("SÜRE BİTTİ !");
                yeniOyun();
            }
        }

        private void tbsure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbhak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
