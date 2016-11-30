﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async和Await使异步编程Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new 同步().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new 异步().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new 异步2().Show();
        }
    }
}
