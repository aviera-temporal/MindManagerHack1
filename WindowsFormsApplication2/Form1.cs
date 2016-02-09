using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mindjet.MindManager.Interop.Application app = new Mindjet.MindManager.Interop.Application();
            Mindjet.MindManager.Interop.Documents docs = app.Documents;
            docs.Open(@"C:\Users\avd\Documents\@Docs\@Working\x901\Project x901Server\Learning Docker Networking.mmap", "", true);
            app.Visible = true;
            MessageBox.Show("done");


        }
    }
}
