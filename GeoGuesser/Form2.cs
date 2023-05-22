﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoGuesser
{
    public partial class Form2 : Form
    {
        private Form firstForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (firstForm == null)
                firstForm = new Form1();

            Hide();
            firstForm.Show();
        }
    }
}