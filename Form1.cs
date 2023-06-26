using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace progressbar_hour_min_sec{
    public partial class Form1 : Form{
        public Form1()        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)        {
            label5.Text= DateTime.Now.Hour.ToString();
            label6.Text = DateTime.Now.Minute.ToString();
            label7.Text = DateTime.Now.Second.ToString();

            progressBar1.Value = DateTime.Now.Hour;
            progressBar2.Value = DateTime.Now.Minute;
            progressBar3.Value = DateTime.Now.Second;
        }
        private void button1_Click(object sender, EventArgs e)        {
            this.Close();
        }
    }
}

