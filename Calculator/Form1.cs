﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            kq = a + b;
            txtKQ.Text = kq.ToString();
        }
    }
}
