using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();


        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }




        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("10:00 AM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer1.Stop();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
        //



        //20dk
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("10:00 AM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer2.Stop();
                Form3 f3 = new Form3();
                f3.Show();
            }

        }

        //10dk
        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("10:50 AM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer3.Stop();
                Form4 f4 = new Form4();
                f4.Show();
            }
        }

        //20dk
        private void timer4_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("11:30 AM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer4.Stop();
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        //10dk
        private void timer5_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("12:20 PM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer5.Stop();
                Form4 f4 = new Form4();
                f4.Show();
            }
        }

        //45dk
        private void timer6_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("01:00 PM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer6.Stop();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }


        //10dk
        private void timer7_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("02:15 PM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer7.Stop();
                Form4 f4 = new Form4();
                f4.Show();
            }
        }


        //5dk
        private void timer8_Tick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(DateTime.Now);
            DateTime ten1 = Convert.ToDateTime("02:55 PM");
            if (t1.TimeOfDay.Ticks > ten1.TimeOfDay.Ticks)
            {
                timer8.Stop();
                Form5 f5 = new Form5();
                f5.Show();
            }
        }


        //form5 5dk tenefüs
        //form4 10dk tenefüs
        //form3 20dk tenefüs
        //form2 45dk tenefüs


        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
