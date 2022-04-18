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
// Cert IV C#2 Assesment1
// Wiki Program - using 2D Array and ListView

namespace Wiki
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
        }

        //Q 8.1	Create a global 2D string array, use static variables for the dimensions (row, column)

        static int rowSize = 12;
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
            BubbleSort();
        }

        #region DisplayArray

        //Q 8.6	Create a display method that will show the following information in a List box: Name and Category
        private void DisplayArray()
        {
            listViewArray.Items.Clear();
            listViewArray.ForeColor = Color.Black;

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
        private void textBoxSearch_DoubleClick(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
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
            toolStripLabel.Text = "";
            if (rowSize > 0 && rowSize < 12)
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                  !string.IsNullOrWhiteSpace(textBoxCategory.Text) &&
                  !string.IsNullOrWhiteSpace(textBoxStructure.Text) &&
                  !string.IsNullOrWhiteSpace(textBoxDefinition.Text))
                {
                    for (int x = 0; x < rowSize; x++)
                    {
                        if (myArray[x, 0] == "")
                        {
                            myArray[x, 0] = textBoxName.Text;
                            myArray[x, 1] = textBoxCategory.Text;
                            myArray[x, 2] = textBoxStructure.Text;
                            myArray[x, 3] = textBoxDefinition.Text;

                            var result = MessageBox.Show("Proceed with new Record?", "Add New Record",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                toolStripLabel.Text = "Data Added";
                                break;
                            }
                            else
                            {
                                myArray[x, 0] = "~";
                                myArray[x, 1] = "";
                                myArray[x, 2] = "";
                                myArray[x, 2] = "";
                                toolStripLabel.Text = "Data Not Added";
                                break;
                            }
                        }
                    }
                }
                else
                {
                    toolStripLabel.Text = "Please input every fields to Add data";
                }
                ClearTextBox();
                BubbleSort();
            }
            else
            {
                toolStripLabel.Text = "Error! Data Full!";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
            try
            {
                int currentRecord = listViewArray.SelectedIndices[0];
                if (currentRecord >= 0)
                {
                    DialogResult delName = MessageBox.Show("Do you wish to delete this Name?",
                     "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (delName == DialogResult.Yes)
                    {
                        myArray[currentRecord, 0] = "~";
                        myArray[currentRecord, 1] = "";
                        myArray[currentRecord, 2] = "";
                        myArray[currentRecord, 3] = "";
                        toolStripLabel.Text = "Data Deleted";
                        ClearTextBox();
                        BubbleSort();
                    }                   
                    else // If user click 'No', show messege
                    {
                        toolStripLabel.Text = "Data NOT Deleted";
                    }
                }
            }
            catch (Exception) // Prevent to click without select data
            {
                toolStripLabel.Text = "Please select data to delete";
                ClearTextBox();
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
            try
            {
                int currentRecord = listViewArray.SelectedIndices[0];
                if (currentRecord >= 0)
                {
                    var result = MessageBox.Show("Proceed with update?", "Edit Record",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        myArray[currentRecord, 0] = textBoxName.Text;
                        myArray[currentRecord, 1] = textBoxCategory.Text;
                        myArray[currentRecord, 2] = textBoxStructure.Text;
                        myArray[currentRecord, 3] = textBoxDefinition.Text;
                        ClearTextBox();
                        BubbleSort();
                        toolStripLabel.Text = "Data Edited";
                    }
                    else // If user click 'No', show messege
                    {
                        toolStripLabel.Text = "Data NOT Edited";
                    }
                }
            }
            catch(Exception) // Prevent to click without select data
            {
                toolStripLabel.Text = "Please select data to Edit!";
                ClearTextBox();
            }
        }
        #endregion

        #region Search
        //Q 8.5	Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        //add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods)

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewArray.ForeColor = Color.Black;
            BubbleSort();
            toolStripLabel.Text = "";
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                string target = textBoxSearch.Text;
                int max = rowSize - 1;
                int min = 0;
                int mid = 0;
                bool found = false;

                while (min <= max)
                {
                    mid = (min + max) / 2;
                    if (string.Compare(target, myArray[mid, 0]) == 0)
                    {
                        found = true;
                        break;
                    }
                    else if (string.Compare(target, myArray[mid, 0]) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                if (found)
                {
                    toolStripLabel.Text = "Data Found!";
                    listViewArray.Items[mid].ForeColor = Color.Blue;

                    textBoxName.Text = myArray[mid, 0];
                    textBoxCategory.Text = myArray[mid, 1];
                    textBoxStructure.Text = myArray[mid, 2];
                    textBoxDefinition.Text = myArray[mid, 3];
                }

                // Another way to search instead of Binary Search
                // for (int x = 0; x < rowSize; x++)
                // {
                //     if (string.Compare(myArray[x, 0], textBoxSearch.Text) == 0)  //name search
                //     {
                //         ListViewItem lvi = new ListViewItem(myArray[x, 0]);
                //         listViewArray.Items[x].ForeColor = Color.Blue;
                //         toolStripLabel.Text = "Data Found!";
                //     }
                //     else if (toolStripLabel.Text != "Data Found!")  // data Not Found
                //     {
                //         toolStripLabel.Text = "Data NOT Found!";
                //     }
                // }

                else // data Not Found
                {
                    toolStripLabel.Text = "Data NOT Found!"; 
                }

            }
            else // Error trapping for no data Search
            {
                toolStripLabel.Text = "Please input data to Search!";
            }
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        }
        #endregion

        #region Sort
        //8.4	Write the code for a Bubble Sort method to sort the 2D array by Name ascending,
        //ensure you use a separate swap method that passes (by reference) the array element to be swapped (do not use any built-in array methods)

        public void BubbleSort()
        {
            for (int x = 0; x < rowSize -1; x++)
            {
                for (int y = 0; y < rowSize - 1; y++)
                {
                    if (string.CompareOrdinal(myArray[y, 0], myArray[y + 1, 0]) > 0)
                    {
                        for (int i = 0; i < colSize; i++)
                        {
                            string temp = myArray[y, i];
                            myArray[y, i] = myArray[y + 1, i];
                            myArray[y + 1, i] = temp;
                        }
                    }
                }
            }
            DisplayArray();
            //toolStripLabel.Text = "Data sorted by Name ascending";
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
