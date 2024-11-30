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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // ekrandaki timer ı aktif eder
            timer1.Interval = 1000; // 1000 ms = 1 sn
            // sonrasında ekrandaki timer a çift klikle olayını aktif ediyoruz
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random(); // random nesnesi rastgele değer üretmemizi sağlar
            this.BackColor = Color.FromArgb(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)); // random.Next(1, 100) 1 ile 100 arasında rasgele sayı üret
        }
    }
}
