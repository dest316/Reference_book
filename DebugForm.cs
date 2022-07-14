using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private void printHashtableButton_Click(object sender, EventArgs e)
        {
            debugTextBox.Clear();
            string buffer = "";
            for (int i = 0; i < Program.hashTable.GetCapacity(); i++)
            {
                buffer += $"{Program.hashTable.GetElements()[i].data.ToString()}\t{Program.hashTable.GetElements()[i].state}\n";
            }
            debugTextBox.Text = buffer;
        }
    }
}
