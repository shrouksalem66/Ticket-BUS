﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            user1.Hide();
            route1.Hide();
            bus1.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            user1.Hide();
            route1.Hide();
            bus1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user1.Hide();
            route1.Show();

            bus1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user1.Show();
            route1.Hide();
            bus1.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            user1.Hide();
            route1.Hide();
            bus1.Show();
            
         }

        private void user1_Load(object sender, EventArgs e)
        {

        }
    }
}
