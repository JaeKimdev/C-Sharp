using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiki_Advancement
{

    // 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide).
    // Use auto-implemented properties for the fields which must be of type “string”. Save the class as “Information.cs”.

    [Serializable]
    internal class Information : IComparable
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public object GetName { get; internal set; }

        public Information() { }
        public Information(string newName, string newCategory, string newStructure, string newDefinition)
        {
            name = newName;
            category = newCategory;
            structure = newStructure;
            definition = newDefinition;
        }
        public int CompareTo(object obj)
        {
            Information compare = obj as Information;
            return name.CompareTo(compare.name);
        }

        public void setName(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }
        public void setCategory(string newCategory)
        {
            category = newCategory;
        }
        public string getCategory()
        {
            return category;
        }
        public void setStructure(string newStructure)
        {
            structure = newStructure;
        }
        public string getStructure()
        {
            return structure;
        }

        public void setDefinition(string newDefinition)
        {
            definition = newDefinition;
        }
        public string getDefinition()
        {
            return definition;
        }
        public ListViewItem displayInformation()
        {
            ListViewItem lvi = new ListViewItem(getName());
            lvi.SubItems.Add(getCategory());
            return lvi;
        }
    }
}
