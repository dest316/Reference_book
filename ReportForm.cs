using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ReportForm : Form
    {
        private Form1 parentForm;
        public ReportForm()
        {
            InitializeComponent();
            parentForm = null;
        }
        public ReportForm(Form1 f)
        {
            parentForm = f;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + fileNameTextBox.Text + ".txt";
            StreamWriter file;
            try
            {
                 file = new StreamWriter(fileName);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Данный файл используется другим потоком, попробуйте позже или перезапустите программу", "Ошибка");
                return;
            }
            if (Program.hashTable.IsEmpty() || Program.tree.IsEmpty()) 
            {
                MessageBox.Show(
                "Отчет сформирован", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            string foundedPhoneNumber = Program.hashTable.SearchPhoneNumber(nameTextBox.Text);
            if (foundedPhoneNumber == null)
            {                
                MessageBox.Show(
                "Отчет сформирован", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            var foundedList = Program.tree.GetListWithPhoneNumber(foundedPhoneNumber);
            if (foundedList == null)
            {
                MessageBox.Show(
                "Отчет сформирован", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            MyList.ListNode cur = foundedList.head;
            
            while (cur != null)
            {
                string[] buffer = { cur.data.name, cur.data.time.ToString(), cur.data.dish, cur.data.rate.ToString(), cur.data.phoneNumber };
                file.WriteLine(string.Join(" ", buffer));
                cur = cur.next;
            }
            file.Close();
            MessageBox.Show(
                "Отчет сформирован", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
