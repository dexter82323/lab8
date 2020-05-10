using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_laba_C_2._3
{
    public partial class Form1 : Form
    {
        public static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(t_Tick);
            timer.Start();
           
        }
        void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 50;
            if (progressBar1.Value >= 100) this.Close();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
