﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", (float)numericUpDown1.Value);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name); // windows sisteminde bulunan fontlardan domainUpDown1 e yükle
            }
            cbFontlar.DataSource = FontFamily.Families;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }

        private void cbFontlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSeciliFont.Text = cbFontlar.SelectedItem.ToString();
        }
    }
}