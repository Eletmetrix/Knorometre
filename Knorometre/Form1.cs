using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knorometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Knorometrenin çalışmaya başladığı andan itibaren tüm zamanı gösterir.
        ///</summary>
        protected TimeSpan TamZaman;

        ///<summary>
        /// En son atılan turdan bu zamana kadar geçen zamanı gösterir.
        ///</summary>
        protected TimeSpan TurZamani;

        ///<summary>
        /// Tur atlama işlemi gerçekleştiyse true döndürür.
        ///</summary>
        protected bool TurAtildi = false;

        ///<summary>
        /// Toplam Tur Sayısı.
        ///</summary>
        protected int TurSayisi = 0;

        ///<summary>
        /// Btn1 nesnesinin Click fonksiyonu. timer1 nesnesini çalışıyorsa durdurur, durmuşsa çalıştırır.
        ///</summary>
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                Btn1.Text = "Devam Ettir";
                Btn2.Text = "Sıfırla";
            }
            else
            {
                timer1.Start();
                Btn1.Text = "Durdur";
                Btn2.Text = "Tur";
                Btn2.Enabled = true;
            }
        }

        ///<summary>
        /// Bu fonksiyon tick saniyede bir kere çalışarak knorometreyi güncellememizi sağlar
        ///</summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tüm sayaçlar burada güncellenir
            TamZaman += new TimeSpan(0, 0, 0, 0, 10);
            TurZamani += new TimeSpan(0, 0, 0, 0, 10);

            TurSayac.Text = TamZaman.ToString(@"hh\:mm\:ss\.ff");

            if (TurAtildi)
            {
                GenelSayac.Text = TurZamani.ToString(@"hh\:mm\:ss\.ff");
            }
        }

        ///<summary>
        /// Btn2 nesnesinin Click fonksiyonu. timer1 nesnesini çalışıyorsa tur atlatır, durmuşsa her şeyi sıfırlar.
        ///</summary>
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                TurAtildi = true;
                TurSayisi++;

                // Listeyi görünür yapıyoruz.
                TurListesi.Visible = true;

                // Geçen süreyi listeye ekliyoruz.
                TurListesi.Items.Add(new ListViewItem(new[]{ TurSayisi.ToString(), TurZamani.ToString(@"hh\:mm\:ss\.ff"), TamZaman.ToString(@"hh\:mm\:ss\.ff") }));

                // Her zaman en sondaki turun gözükmesini sağlıyoruz.
                TurListesi.Items[TurListesi.Items.Count - 1].EnsureVisible();

                // Artık tur sayacını sıfırlamamız gerekiyor çünkü yeni tura giriyoruz.
                TurZamani = new TimeSpan();
            }
            else
            {
                TurAtildi = false;
                TurSayisi = 0;

                // Listeyi silip ardından tekrardan görünmez yapıyoruz.
                TurListesi.Visible = false;
                TurListesi.Items.Clear();

                // Sayaçları sıfırlıyoruz.
                TamZaman = new TimeSpan();
                TurZamani = new TimeSpan();

                // Butonların özelliklerini değiştiriyoruz.
                Btn1.Text = "Başla";
                Btn2.Text = "Tur";
                Btn2.Enabled = false;

                // Yazıları düzenliyoruz.
                TurSayac.Text = TurZamani.ToString(@"hh\:mm\:ss\.ff");
                GenelSayac.Text = "";
            }
        }
    }
}
