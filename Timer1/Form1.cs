using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form1 : Form
    {
        float timer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            textBox1.Text = timer.ToString("0.0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer = 0;
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Timer form = new Timer();
            form.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(354, 222);
            this.MaximumSize = new Size(354, 222);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clock form = new clock();
            form.Show();
            this.Hide();
        }
    }
}