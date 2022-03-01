using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myModels
{
    [Serializable]
    internal class Drone : RCModel
    {
        private int numMotors;
        public Drone() : base()
        { }

        public Drone(string NewModelName, string NewSerialNumber, int NewCost, int NewNumMotors)
        {
            modelName = NewModelName;
            serialNumber = NewSerialNumber;
            cost = NewCost;
            numMotors = NewNumMotors;
        }
        // aceessor methods
        public int GetNumMotors()
        {
            return numMotors;
        }
        public void SetNumMotors(int NewNumMotors)
        {
            numMotors = NewNumMotors;
        }
        public string DisplayDrones()
        {
            return GetNumMotors() + " " + gsModelName + " " + gsSerialNumber + " " + gsCost;
        }
    }
}
