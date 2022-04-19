using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Jae Kim, Kirsten Kurniadi, SM Development, Sprint Two
// Date: 12/10/2021
// Version: 2.3
// Astronomical Processing
// Records and processes hourly neutrino interaction data
// Integers, Sequential Search/Math Functions, Button Functions
namespace Ass2Astro
{
    public partial class AstroForm : Form
    {
        public AstroForm()
        {
            InitializeComponent();
        }
        // declare variable
        static int max = 24;
        int[] numberList = new int[max];
        int numCount = 0;
        int dataMin = 0;
        int dataMax = 0;

        #region SprintOne
        //'Add' button function
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBoxInput.Text))
            {
                // Error Trapping - No more than 24 input, check int value
                try
                {
                    numberList[numCount] = int.Parse(TextBoxInput.Text);
                    numCount++;
                    DisplayData();
                    TextBoxInput.Clear();
                    StatusStripMessage.Text = "Added";
                }
                catch (FormatException)
                {
                    StatusStripMessage.Text = "Cannot Add: Non-integer input";
                }
                catch (IndexOutOfRangeException)
                {
                    StatusStripMessage.Text = "Cannot Add: Array is full";
                }
            }
            else
            {
                StatusStripMessage.Text = "Cannot Add: Text box is empty";
            }
        }
        // 'Edit' button function
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                // Check if items in list box have been selected
                if (ListBoxDisplay.SelectedItem != null)
                {
                    string currentItem = ListBoxDisplay.SelectedItem.ToString();
                    int taskIndex = ListBoxDisplay.FindString(currentItem);
                    try
                    {
                        numberList[taskIndex] = int.Parse(TextBoxInput.Text);
                        StatusStripMessage.Text = "Edited";
                    }
                    catch (FormatException)
                    {
                        StatusStripMessage.Text = "Cannot Edit: non-integer value";
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
            DisplayData();
            TextBoxInput.Clear();
        }
        //'Delete' button function
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxDisplay.SelectedIndex != -1)
            {
                string currentItem = ListBoxDisplay.SelectedItem.ToString();
                int taskIndex = ListBoxDisplay.FindString(currentItem);
                DialogResult deleteTask = MessageBox.Show("Are you sure you want to delete?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteTask == DialogResult.Yes)
                {
                    // Move up items after deleted item without need to sort
                    for (int i = taskIndex + 1; i < numCount; i++)
                    {
                        numberList[i - 1] = numberList[i];
                    }
                    StatusStripMessage.Text = "Deleted";
                    numCount--;
                    DisplayData();
                    TextBoxInput.Clear();
                }
                else
                {
                    StatusStripMessage.Text = "NOT deleted";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(TextBoxInput.Text))
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
        
        //'Fill Array' button function
        // Add up to 24 random numbers and Display
        private void ButtonFillArray_Click(object sender, EventArgs e)
        {
            FillArray();
            numCount = max;
            DisplayData();
            StatusStripMessage.Text = "Array has been filled";
        }

        //'Sort' button function
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Sort();
            StatusStripMessage.Text = "Sorted";
        }
        private void Sort()
        {
            // Implement bubble sort algorithm
            for (int i = 0; i < numCount; i++)
            {
                for (int j = i + 1; j < numCount; j++)
                {
                    if (!int.Equals(numberList[i], numberList[j]))
                    {
                        if (numberList[i] > numberList[j])
                        {
                            int temp = numberList[i];
                            numberList[i] = numberList[j];
                            numberList[j] = temp;
                        }
                    }
                }
            }
            DisplayData();
        }
        //'Search' button function
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Sort the array
            Sort();
            // Implement binary search algorithm
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                try
                {
                    int target = int.Parse(TextBoxInput.Text);
                    int min = 0;
                    int max = numCount - 1;
                    int mid = 0;
                    bool found = false;
                    while (min <= max)
                    {
                        mid = (min + max) / 2;
                        if (int.Equals(target, numberList[mid]))
                        {
                            found = true;
                            break;
                        }
                        else
                        {
                            if (target < numberList[mid])
                            {
                                max = mid - 1;
                            }
                            else
                            {
                                min = mid + 1;
                            }
                        }
                    }
                    if (found)
                    {
                        // Display message for successful search
                        StatusStripMessage.Text = "Success: target found at element [" + mid + "]";
                        ListBoxDisplay.SelectedIndex = mid;
                        TextBoxInput.Clear();
                    }
                    else
                    {
                        // Display error message for unsuccessful search
                        StatusStripMessage.Text = "Error: Not found";
                    }
                }
                catch (FormatException)
                {
                    StatusStripMessage.Text = "Error: cannot search for non-integer value";
                }
                
            }
            else
            {
                // Display error message if text box is empty
                StatusStripMessage.Text = "Error: Please enter a data point";
            }
        }
        
        //Make up to 24 random numbers and fill to array
        private void FillArray()
        {
            Random genData = new Random();
            for (int i = numCount; i < max; i++)
            {
                int newData = genData.Next(10, 100);
                numberList[i] = newData;
            }
            DisplayData();
        }
        //Display fucntion
        private void DisplayData()
        {
            ListBoxDisplay.Items.Clear();
            for (int x = 0; x < numCount; x++)
            {
                ListBoxDisplay.Items.Add(numberList[x]);
            }
        }
        //Show selected item to input box
        private void ListBoxDisplay_Click(object sender, EventArgs e)
        {
            if (ListBoxDisplay.SelectedIndex != -1)
            {
                string currentItem = ListBoxDisplay.SelectedItem.ToString();
                int taskIndex = ListBoxDisplay.FindString(currentItem);
                TextBoxInput.Text = numberList[taskIndex].ToString();
            }
            else
                StatusStripMessage.Text = "No task selected";
        }
        #endregion
        #region SeqSearch
        //Sequential Search function
        private void ButtonSeqSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBoxInput.Text))
            {
                int target = int.Parse(TextBoxInput.Text);
                bool found = false;
                int i = 0;
                for (i = 0; i < max; i++)
                {
                    if (int.Equals(target, numberList[i]))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    //MessageBox.Show("found");
                    StatusStripMessage.Text = "Target found";
                    ListBoxDisplay.SelectedIndex = i;
                    TextBoxInput.Clear();
                }
                else
                    // MessageBox.Show("Not found");
                    StatusStripMessage.Text = "Not Found";
            }
            else
                StatusStripMessage.Text = "Search text box is empty";
        }
        #endregion
        #region MidExMode
        //'Mid-extreme' button function
        private void ButtonMid_Click(object sender, EventArgs e)
        {
            if (numCount == 0)
            {
                StatusStripMessage.Text = "Cannot get Mid-Extreme of empty array";
            }
            else
            {
                GetMinMax();
                double midEx = (dataMin + dataMax) / 2.0;
                textBoxMid.Text = String.Format("{0:0.##}", midEx);
                StatusStripMessage.Text = "Mid-Extreme has been calculated";
            }
        }
        //'Mode' button function
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            if (numCount == 0)
            {
                StatusStripMessage.Text = "Cannot get mode of empty array";
            }
            else
            {
                // declare variable
                int element;
                int frequency = 1;
                int mode = 0;
                int counter;
                for (int i = 0; i < numCount; i++)
                {
                    counter = 0;
                    element = numberList[i];
                    for (int j = 0; j < numCount; j++)
                    {
                        if (element == numberList[j])
                        {
                            counter++;
                        }
                    }
                    if (counter >= frequency)
                    {
                        frequency = counter;
                        mode = element;
                    }
                    //show results to textBox & StatusStrip
                    textBoxMode.Text = (mode + ", Freq: " + frequency).ToString();
                    StatusStripMessage.Text = "Mode Success";
                }
            }
        }
        #endregion
        #region AvgRange
        //'Average' button function
        private void ButtonAvg_Click(object sender, EventArgs e)
        {
            if (numCount == 0)
            {
                StatusStripMessage.Text = "Cannot get average of empty array";
            }
            else
            {
                int sum = 0;
                double len = 0;
                for (int i = 0; i < numCount; i++)
                {
                    sum += numberList[i];
                    len++;
                }
                double avg = sum / len;
                // Display average to 2 decimal places
                textBoxAvg.Text = String.Format("{0:0.##}", avg);
                StatusStripMessage.Text = "Average has been calculated";
            }
        }
        //'Range' button function
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            if (numCount == 0)
            {
                StatusStripMessage.Text = "Cannot get range of empty array";
            }
            else
            {
                GetMinMax();
                int range = dataMax - dataMin;
                textBoxRange.Text = range.ToString();
                StatusStripMessage.Text = "Range has been calculated";
            }
        }
        #endregion
        #region Utilities
        //Get minimum and maximum value in array
        private void GetMinMax()
        {
            ResetMinMax();
            for (int i = 0; i < numCount; i++)
            {
                if (dataMin == 0 || numberList[i] < dataMin)
                {
                    dataMin = numberList[i];
                }
                else if (numberList[i] > dataMax)
                {
                    dataMax = numberList[i];
                }
            }
        }
        //Reset array min and max values
        private void ResetMinMax()
        {
            dataMin = 0;
            dataMax = 0;
        }
        #endregion        
    }
}
