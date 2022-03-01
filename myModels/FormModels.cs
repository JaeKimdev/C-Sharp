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

namespace myModels
{
    public partial class FormModels : Form
    {
        public FormModels()
        {
            InitializeComponent();
        }
        RCModel[] myCollection = new RCModel[10];
        private void buttonAddDrone_Click(object sender, EventArgs e)
        {
            // manage empty cell
            Drone drone = new Drone();
            drone.gsModelName = textBoxModelName.Text;
            drone.gsSerialNumber = textBoxSerial.Text;
            drone.gsCost = int.Parse(textBoxCost.Text);
            drone.SetNumMotors(int.Parse(textBoxNumOfMotors.Text));
            Drone drone2 = new Drone("Ace", "123456", 123, 4);
            myCollection[0] = drone;
            myCollection[1] = drone2;
            DisplayAllModels();
        }
        private void DisplayAllModels()
        {
            listBoxOutput.Items.Clear();
            for (int x = 0; x < 2; x++)
            {
                if(myCollection[x].GetType() == typeof(Drone))
                {
                    Drone d = (Drone)myCollection[x];
                    listBoxOutput.Items.Add(d.DisplayDrones());
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using(Stream stream = File.Open("Model.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for(int x = 0; x < 2;x++)
                    {
                        bin.Serialize(stream, myCollection[x]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "File not Saved");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int ptr = 0;
            try
            {
                using(Stream stream = File.Open("Model.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    while(stream.Position < stream.Length)
                    {
                        myCollection[ptr] = (RCModel)bin.Deserialize(stream);
                        ptr++;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File not Openned");
            }
        }
    }
}
