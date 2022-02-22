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

namespace myStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack myStack = new Stack();

        private void DisplayStack()
        {
            listBoxOutput.Items.Clear();
            foreach(object obj in myStack)
            {
                listBoxOutput.Items.Add(obj.ToString());
            }
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxInput.Text)))
            {
                myStack.Push(textBoxInput.Text);
                DisplayStack();
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter Data into TextBox", "ERROR MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            if (myStack.Count > 0)
            {
                myStack.Pop();
                DisplayStack();
            }
            else
            {
                MessageBox.Show("The queue is empty", "Information",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
