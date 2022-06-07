using System.Diagnostics;
using System.Text;

namespace Wiki_Advancement
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
            string[] categories = { "Array", "Tree", "Graphs", "List", "Hash", "Abstract" };
            comboBoxCat.DataSource = categories;

            Stream myTraceTestFile = File.Create("TestFile.txt");
            TextWriterTraceListener myTraceListner = new TextWriterTraceListener(myTraceTestFile);
            Trace.Listeners.Add(myTraceListner);
            Trace.AutoFlush = true;
            Trace.WriteLine("### Debug Data Log Start ###");
            Trace.WriteLine("");
        }


     
    }
}