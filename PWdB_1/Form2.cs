using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWdB_1
{
    public partial class Form2 : Form
    {
        System.Timers.Timer timer;
        int hour, min, sec, ms;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += Stoper;
        }

        private void Stoper(object? sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    sec += 1;
                }
                if (sec == 60)
                {
                    sec = 0;
                    min += 1;
                }
                if (min == 60)
                {
                    min = 0;
                    hour += 1;
                }

                label1.Text = string.Format("{0}:{1}:{2}:{3}", hour.ToString().ToString().PadLeft(2, '0'), min.ToString().ToString().PadLeft(2, '0'), sec.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));

            }));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            hour = 0;
            min = 0;
            sec = 0;
            ms = 0;
            label1.Text = "00:00:00:00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
