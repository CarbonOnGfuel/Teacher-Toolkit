using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Timer : Form
    {
        float countDown = 5;
        public Timer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown -= timer1.Interval * 0.001f;
            textBox1.Text = countDown.ToString("0.0");
            if (countDown < 0.1)
            {
                timer1.Enabled = false;

            }
            // TimeSpan time = 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            countDown = float.Parse(textBox2.Text);
            if (textBox1.Text != "")
            {
                countDown = float.Parse(textBox1.Text);
            }

            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            countDown = float.Parse(textBox2.Text);
            textBox1.Text = countDown.ToString();
        }

        private void Timer_Load(object sender, EventArgs e)
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
