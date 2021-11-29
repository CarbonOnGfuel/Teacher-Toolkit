using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(311, 489);
            this.MaximumSize = new Size(311, 489);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerSettings form = new TimerSettings();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClockSettings form = new ClockSettings();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
