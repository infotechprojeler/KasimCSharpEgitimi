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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close(); // pencereyi kapatır
            Application.Exit(); // uygulamayı komple kapatır
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Form2_Load çalıştı";
            label1.ForeColor = Color.Crimson; // yazı rengi
            label1.BackColor = Color.White; // arkaplan rengi
        }
    }
}
