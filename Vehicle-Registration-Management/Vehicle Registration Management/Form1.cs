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

namespace Vehicle_Registration_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayList();
        }

 //Question Two
 //The prototype must use a List<> data structure of data type “string”.

        List<string> VehicleList = new List<string>();
        string currentFileName = "";

        #region AddDeleteEditTag

//Question Four
//ENTER: To add a rego plate to the List<> the user will type the data value (rego plate info) into the TextBox and click the ENTER button.
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxInput.Text))
            {
                if (!ValidName(textBoxInput.Text))
                {
                    MessageBox.Show("Error! Cannot Add - Number duplicate");
                }
                else
                {
                    VehicleList.Add(textBoxInput.Text);
                    DisplayList();
                    textBoxInput.Clear();
                    StatusStripMessage.Text = "Plate added";
                }
            }
            else
            {
                StatusStripMessage.Text = "Cannot Add: Text box is empty";
            }
        }

//Question Five
//LEAVE: To remove rego plate: There are two options to remove a rego plate item from the List<>
//Method Two: the user will enter the rego plate information into the TextBox and click the DELETE button
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (listBoxDisplay.SelectedIndex != -1)
            {
                string currentItem = listBoxDisplay.SelectedItem.ToString();
                int taskIndex = listBoxDisplay.FindString(currentItem);
                DialogResult deleteTask = MessageBox.Show("Are you sure you want to delete?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteTask == DialogResult.Yes)
                {
                    listBoxDisplay.SetSelected(listBoxDisplay.SelectedIndex, true);
                    VehicleList.RemoveAt(listBoxDisplay.SelectedIndex);
                    DisplayList();
                    textBoxInput.Clear();
                    StatusStripMessage.Text = "deleted";
                }
                else
                {
                    StatusStripMessage.Text = "NOT deleted";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxInput.Text))
                {
                    // Display message for when no items are selected
                    StatusStripMessage.Text = "Cannot Delete: No items selected";
                }
                else
                {
                    //MessageBox.Show("No task selected");
                    StatusStripMessage.Text = "Cannot Delete: Text box is empty";
                }
            }
        }
//Q6.EDIT: To edit a rego plate click (select) a data item from the ListBox so that is appears in the TextBox.
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text))
            {
                // Check if items in list box have been selected
                if (listBoxDisplay.SelectedItem != null)
                {
                    if (!ValidName(textBoxInput.Text))
                    {
                        MessageBox.Show("Error! Cannot Edit - Number duplicate");
                    }
                    else
                    {
                        string currentItem = listBoxDisplay.SelectedItem.ToString();
                        int taskIndex = listBoxDisplay.FindString(currentItem);
                        VehicleList[taskIndex] = textBoxInput.Text;
                        StatusStripMessage.Text = "Edited";
                    }
                }
                else
                {
                    StatusStripMessage.Text = "Cannot Edit: No items selected";
                }
            }
            else
            {
                //MessageBox.Show("No Text in Text box");
                StatusStripMessage.Text = "Cannot Edit: Text box is empty";
            }
            DisplayList();
            textBoxInput.Clear();
        }

//Q13.TAG: Create tag method and associated TAG button to mark a rego plate.When a rego plate is selected from the ListBox and “tagged
//an additional character value “z” will be prefixed to the rego plate.The List<> will be re-sorted and displayed.
        private void checkTag_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text))
            {
                // Check if items in list box have been selected
                if (listBoxDisplay.SelectedItem != null)
                {

                    if (!checkTag.Checked)
                    {
                        string currentItem = listBoxDisplay.SelectedItem.ToString();
                        int taskIndex = listBoxDisplay.FindString(currentItem);
                        VehicleList[taskIndex] = "Z-" + textBoxInput.Text;
                        StatusStripMessage.Text = "item Taged";
                    }
                    else
                    {
                        string currentItem = listBoxDisplay.SelectedItem.ToString();
                        int taskIndex = listBoxDisplay.FindString(currentItem);
                        VehicleList[taskIndex] = textBoxInput.Text.Remove(0, 2);
                        StatusStripMessage.Text = "item UnTaged";
                    }
                }
                else
                {
                    StatusStripMessage.Text = "Cannot Tag: No items selected";
                }
            }
            else
            {
                //MessageBox.Show("No Text in Text box");
                StatusStripMessage.Text = "Cannot Tag: Text box is empty";
            }
            DisplayList();
            textBoxInput.Clear();
        }
        #endregion

        #region BinLinearSearch

//Q.10 BINARY SEACH: To find a specific rego plate the user will type the information into the TextBox and click the BINARY SEARCH button.
        private void buttonBinSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxInput.Text))
            {
                if (VehicleList.BinarySearch(textBoxInput.Text) >= 0)
                {
                    listBoxDisplay.SelectedItem = textBoxInput.Text;
                    MessageBox.Show("Found");
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                }
                else
                {
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    MessageBox.Show("Not Found");
                }
            }
            else
                StatusStripMessage.Text = "text box is empty";
        }

//Q11. LINEAR SEARCH: Add a second search button that implements a linear search algorithm.
        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxInput.Text))
            {
                string target = textBoxInput.Text;
                bool found = false;
                int x = 0;
                for (x = 0; x < VehicleList.Count; x++)
                {
                    if (Equals(target, VehicleList[x]))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    listBoxDisplay.SelectedIndex = x;
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    MessageBox.Show("Found");
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                }
            }
            else
            {
                StatusStripMessage.Text = "text box is empty";
            }
        }
        #endregion

        #region BinaryFileIOandReset

//Question Three
// OPEN: When the OPEN button is clicked the user can select different data from pre-saved text files.
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string fileName = "demo_01.txt";
            OpenFileDialog OpenText = new OpenFileDialog();
            OpenText.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            OpenText.Filter = "text File|*.txt";
            DialogResult sr = OpenText.ShowDialog();
            if (sr == DialogResult.OK)
            {
                fileName = OpenText.FileName;
            }
            currentFileName = fileName;
            try
            {
                VehicleList.Clear();
                using (StreamReader reader = new StreamReader(File.OpenRead(fileName)))
                {
                    while (!reader.EndOfStream)
                    {
                        VehicleList.Add(reader.ReadLine());
                    }
                }
                DisplayList();
                StatusStripMessage.Text = "Data Loaded";
            }
            catch (IOException)
            {
                MessageBox.Show("file not openned");
            }
        }

//Q12.The dialog box must have a filter to display text files only. Add a SAVE button that can utilise the save method
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = "demo_01.txt";
            SaveFileDialog SaveText = new SaveFileDialog();
            SaveText.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            SaveText.Filter = "text File|*.txt";
            DialogResult sr = SaveText.ShowDialog();
            if (sr == DialogResult.OK)
            {
                fileName = SaveText.FileName;
            }
            if (sr == DialogResult.Cancel)
            {
                SaveText.FileName = fileName;
            }
            // Validate file name and increment
            SaveTextFile(fileName);
        }
 
 //Q7. RESET: Add a RESET button to clear all the data items from the List<>. The ListBox and TextBox should also be cleared.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult deleteTask = MessageBox.Show("Are you sure you want to Reset?",
                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteTask == DialogResult.Yes)
            {
                VehicleList.Clear();
                listBoxDisplay.Items.Clear();
                StatusStripMessage.Text = "Reset Complete";
            }
            else
            {
                StatusStripMessage.Text = "Not deleted";
            }
        }
        #endregion

        #region Utility

//Q9. DISPLAY and SORT: All the rego plates should be displayed in the ListBox which is sorted alphabetically using the built-in List Sort method.
        private void DisplayList()
        {
            listBoxDisplay.Items.Clear();
            VehicleList.Sort();
            foreach (var vehicle in VehicleList)
            {
                listBoxDisplay.Items.Add(vehicle);
            }
            textBoxInput.Focus();
        }
        private bool ValidName(string checkThisName)
        {
            if (VehicleList.Exists(duplicate => duplicate.Equals(checkThisName)))
                return false;
            else
                return true;
        }

//Q8.SINGLE DATA DISPLAY: Create a single click method to do the following: when a data item is selected from the ListBox on the left,
//the information is displayed in the TextBox on the right.

        private void listBoxDisplay_Click(object sender, EventArgs e)
        {
            if (listBoxDisplay.SelectedIndex != -1)
            {
                string currentItem = listBoxDisplay.SelectedItem.ToString();
                int taskIndex = listBoxDisplay.FindString(currentItem);
                textBoxInput.Text = VehicleList[taskIndex].ToString();
            }
            else
                StatusStripMessage.Text = "Nothing selected";
        }

        private void textBoxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxInput.Clear();
        }

//Q5.Method One: double click a data item from the ListBox and click the OK button in the popup dialog box.
//The data item will be removed from the List<>. 
        private void listBoxDisplay_DoubleClick(object sender, EventArgs e)
        {
            DialogResult deleteTask = MessageBox.Show("Are you sure you want to delete?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteTask == DialogResult.Yes)
            {
                listBoxDisplay.SetSelected(listBoxDisplay.SelectedIndex, true);
                VehicleList.RemoveAt(listBoxDisplay.SelectedIndex);
                DisplayList();
                textBoxInput.Clear();
                StatusStripMessage.Text = "deleted";
            }
            else
            {
                StatusStripMessage.Text = "NOT deleted";
            }
        }

 //Q12. Create a method to save the data, this method will open a save dialog box and allow the user to save all the data back to a text file.

        private void SaveTextFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (var vehicle in VehicleList)
                    {
                        writer.WriteLine(vehicle);
                    }
                }

            }
            catch (IOException)
            {
                MessageBox.Show("File NOT saved");
            }
        }

//Q12.  Create a FORM closing method using the save method so all data from the List<>
//will be written back to a single text file called “demo_##.txt” file which is auto incremented

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //currentFileName = Path.GetFileNameWithoutExtension(currentFileName);
                //string strnumy = currentFileName.Remove(0, 5);
                //int num = int.Parse(strnumy);
                int num = int.Parse(Path.GetFileNameWithoutExtension(currentFileName).Remove(0, 5));
                num++;
                string newValue;
                if (num < 10)
                    newValue = "0" + num.ToString();
                else
                    newValue = num.ToString();

                string newfileName = "demo_" + newValue + ".txt";
                SaveTextFile(newfileName);
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}