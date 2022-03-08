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

// Jae Hyumg Kim, 30043320
// Cert IV C# Assesment1
// Wiki Program - use 2D Array and ListView

namespace Wiki
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
        }

        //Q 8.1	Create a global 2D string array, use static variables for the dimensions (row, column)

        int rowNum = 0;
        static int rowSize = 8;
        static int colSize = 4;  //Name, Category, Structure, Definition
        string[,] myArray = new string[rowSize, colSize];
        string defaultFileName = "definitions.dat";

        private void Wiki_Load(object sender, EventArgs e)
        {
            listViewArray.View = View.Details;
            listViewArray.GridLines = true;
            listViewArray.FullRowSelect = true;

            OpenFileDialog openFileDialogVG = new OpenFileDialog();
            openFileDialogVG.InitialDirectory = Application.StartupPath;
            openFileDialogVG.Filter = "DAT Files|*.dat";
            openFileDialogVG.Title = "Select a DAT File";
            if (openFileDialogVG.ShowDialog() == DialogResult.OK)
            {
                openRecord(openFileDialogVG.FileName);
            }
            else
            {
                for (int x = 0; x < rowSize; x++)
                {
                    myArray[x, 0] = "~";
                    myArray[x, 1] = "";
                    myArray[x, 2] = "";
                    myArray[x, 3] = "";
                }
            }
            DisplayArray();
        }

        #region DisplayArray

        //Q 8.6	Create a display method that will show the following information in a List box: Name and Category
        private void DisplayArray()
        {
            listViewArray.Items.Clear();

            for (int x = 0; x < rowSize; x++)
            {
                ListViewItem lvi = new ListViewItem(myArray[x, 0]);
                lvi.SubItems.Add(myArray[x, 1]);
                lvi.SubItems.Add(myArray[x, 2]);
                lvi.SubItems.Add(myArray[x, 3]);
                listViewArray.Items.Add(lvi);
            }
        }
        #endregion

        #region Clear
        // Q 8.3 Create a CLEAR method to clear the four text boxes so a new definition can be added
        private void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDefinition.Clear();
            textBoxName.Focus();
        }

        private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearTextBox();
        }
        #endregion

        #region Show informations
        //Q 8.7	Create a method so the user can select a definition (Name) from the Listbox and all the information is displayed in the appropriate Textboxes
        private void listViewArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewArray.SelectedItems.Count > 0)
            {
                textBoxName.Text = listViewArray.Items[listViewArray.SelectedItems[0].Index].SubItems[0].Text;
                textBoxCategory.Text = listViewArray.Items[listViewArray.SelectedItems[0].Index].SubItems[1].Text;
                textBoxStructure.Text = listViewArray.Items[listViewArray.SelectedItems[0].Index].SubItems[2].Text;
                textBoxDefinition.Text = listViewArray.Items[listViewArray.SelectedItems[0].Index].SubItems[3].Text;
            }
        }
        #endregion

        #region Add, Delete, Edit

        // Q 8.2 Create an ADD button that will store the information from the 4 text boxes into the 2D array
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            myArray[rowNum, 0] = textBoxName.Text;
            myArray[rowNum, 1] = textBoxCategory.Text;
            myArray[rowNum, 2] = textBoxStructure.Text;
            myArray[rowNum, 3] = textBoxDefinition.Text;
            rowNum++;
            ClearTextBox();
            BubbleSort();
            toolStripLabel.Text = "Data Added";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult delName = MessageBox.Show("Do you wish to delete this Name?",
                 "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delName == DialogResult.Yes)
            {
                ListView.SelectedListViewItemCollection itemColl = listViewArray.SelectedItems;

                foreach (ListViewItem item in itemColl)
                {
                    listViewArray.Items.Remove(item);
                }

                //Need to change index number after selectedrow -1

                rowNum--;
                ClearTextBox();
                toolStripLabel.Text = "Data Deleted";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            myArray[listViewArray.SelectedItems[0].Index, 0] = textBoxName.Text;
            myArray[listViewArray.SelectedItems[0].Index, 1] = textBoxCategory.Text;
            myArray[listViewArray.SelectedItems[0].Index, 2] = textBoxStructure.Text;
            myArray[listViewArray.SelectedItems[0].Index, 3] = textBoxDefinition.Text;
            ClearTextBox();
            BubbleSort();
            toolStripLabel.Text = "Data Edited";
        }

        #endregion

        #region Search
        //Q 8.5	Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        //add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods)

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
        #endregion

        #region Sort
        //8.4	Write the code for a Bubble Sort method to sort the 2D array by Name ascending,
        //ensure you use a separate swap method that passes (by reference) the array element to be swapped (do not use any built-in array methods)

        public void BubbleSort()
        {
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = i + 1; j < rowNum; j++)
                {
                    if (string.Compare(myArray[i, 0], myArray[j, 0]) > 0)
                    {
                        for (int k = 0; k < colSize; k++)
                        {
                            Swap(myArray, i, j, k);
                        }
                    }
                }
            }
            DisplayArray();
            toolStripLabel.Text = "Data sorted by Name ascending";
        }

            public void Swap(string[,] x, int i, int j, int k)
            {
                string[,] temp = new string[1, 4];
                temp[0, k] = x[i, k];
                x[i, k] = x[j, k];
                x[j, k] = temp[0, k];
            }

            #endregion

            #region Open, Save
            //Q 8.9	Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array
            private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogVG = new OpenFileDialog();
            openFileDialogVG.InitialDirectory = Application.StartupPath;
            openFileDialogVG.Filter = "dat Files|*.dat";
            openFileDialogVG.Title = "Select a Dat File";
            if (openFileDialogVG.ShowDialog() == DialogResult.OK)
            {
                openRecord(openFileDialogVG.FileName);
            }
        }
        private void openRecord(string openFileName)
        {
            try
            {
                using (Stream stream = File.Open(openFileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int y = 0; y < colSize; y++)
                    {
                        for (int x = 0; x < rowSize; x++)

                        {
                            myArray[x, y] = (string)bin.Deserialize(stream);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DisplayArray();
        }

        //Q 8.8	Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogVG = new SaveFileDialog();
            saveFileDialogVG.Filter = "dat file|*.dat";
            saveFileDialogVG.Title = "Save a Dat File";
            saveFileDialogVG.InitialDirectory = Application.StartupPath;
            saveFileDialogVG.DefaultExt = "dat";
            saveFileDialogVG.ShowDialog();

            string fileName = saveFileDialogVG.FileName;
            if (saveFileDialogVG.FileName != "")
            {
                saveRecord(fileName);
            }
            else
            {
                saveRecord(defaultFileName);
            }

        }
        private void saveRecord(string saveFileName)
        {
            try
            {
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int y = 0; y < colSize; y++)
                    {
                        for (int x = 0; x < rowSize; x++)
                        {
                            bin.Serialize(stream, myArray[x, y]);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

       
    }


}
