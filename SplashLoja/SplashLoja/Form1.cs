﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplashLoja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
                progressBar.Value = progressBar.Value + 1;
            else
            {
                timer.Enabled = false;
                this.Visible = false;
                frmLoguin objfLog=new frmLoguin();
                objfLog.Show();
        }
    }
}
}