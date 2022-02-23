using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiki
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
        }
        int rowNum = 0;
        static int rowSize = 8;
        static int colSize = 4;
        string[,] myArray = new string[rowSize, colSize];
        string fileName = "definitions.dat";

        #region DisplayArray
        private void DisplayArray()
        {
            listViewArray.Items.Clear();

            for (int x = 0; x < rowSize; x++)
            {
                ListViewItem lvi = new ListViewItem(myArray[x, 0]);
                lvi.SubItems.Add(myArray[x, 1]);
                lvi.SubItems.Add(myArray[x, 2]);
                listViewArray.Items.Add(lvi);
            }
        }
        #endregion

        private void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDefinition.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            myArray[rowNum, 0] = textBoxName.Text;
            myArray[rowNum, 1] = textBoxCategory.Text;
            myArray[rowNum, 2] = textBoxStructure.Text;
            myArray[rowNum, 3] = textBoxDefinition.Text;
            rowNum++;
            ClearTextBox();
            DisplayArray();
            toolStrip.Text = "Data Added";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            myArray[listViewArray.SelectedItems, 0] = textBoxName.Text;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult delName = MessageBox.Show("Do you wish to delete this Name?",
                 "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delName == DialogResult.Yes)
            {
                // add code to delete record
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String target = textBoxName.Text;
            int row = 0;
            int col = colSize - 1;
            while ((row <= rowSize - 1) && (col >= 0))
            {
              
            }
            listViewArray.Items.Add("Not Found");
        }

        private void Wiki_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }

       
    }


}
