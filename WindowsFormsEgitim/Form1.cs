using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // backend-codebehind
            label1.Text = "button1_Click çalıştı!";
            Form2 form2 = new Form2(); // Form2 nesnesi oluştur
            // form2.ShowDialog(); // form2 yi göster // alttaki forma geçişe izin vermez
            form2.Show(); // alttaki forma geçişe izin verir
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form ekrana getirilirken bu metot çalışır, veritabanından kayıt getirme listeleme gibi işlemleri buradan yönetebiliriz.
            label1.Text += " - Form1_Load çalıştı";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // ilgili formu kapatma metodu
        }
    }
}
