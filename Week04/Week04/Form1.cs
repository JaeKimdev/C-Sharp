using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue myTasks = new Queue();

        private void DisplayQueue()
        {
            listBox1.Items.Clear();
            foreach (object obj in myTasks)
            {
                listBox1.Items.Add(obj.ToString());
            }
        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(textBox1.Text)))
                {
                myTasks.Enqueue(textBox1.Text);
                textBox1.Clear();
                DisplayQueue();
            }
            else
            {
                MessageBox.Show("Please enter Data into TextBox", "ERROR MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            if(myTasks.Count > 0)
            {
                myTasks.Dequeue();
                DisplayQueue();
            }
            else
            {
                MessageBox.Show("The queue is empty", "Information",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPeek_Click(object sender, EventArgs e)
        {
            textBox1.Text = myTasks.Peek().ToString();
        }
    }
}
