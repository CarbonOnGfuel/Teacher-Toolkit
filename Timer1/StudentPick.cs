using System;
using System.IO;
using System.Windows.Forms;

namespace Timer1
{
    public partial class StudentPick : Form
    {
        public StudentPick()
        {
            InitializeComponent();
        }

        private void StudentPick_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentnum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentnum].ToString();

                listBox1.Items.RemoveAt(studentnum);
            }
            else
            {
                MessageBox.Show("Please Add At Least 1 Student");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                richTextBox1.Text = text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}
