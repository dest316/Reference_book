using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba7__HashTable_;
using RedBlackTree;
using MyList;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public User UserFileParse(string record)
        {
            string[] arr = record.Split(';');
            User user = new User(arr[0], arr[1], arr[2]);
            return user;
        }
        public Review ReviewFileParse(string record)
        {
            string[] arr = record.Split(';');
            Review review = new Review();
            review.name = arr[0];
            string[] date = arr[1].Split('_');
            review.time = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]), int.Parse(date[3]), int.Parse(date[4]), int.Parse(date[5]));
            review.dish = arr[2];
            review.rate = int.Parse(arr[3]);
            review.phoneNumber = arr[4];
            return review;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userScanButton_Click(object sender, EventArgs e)
        {
            Program.hashTable.Clear();
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + userFileName.Text + ".txt";
            try
            {
                StreamReader file = new StreamReader(fileName);
                string buffer = "";
                while (true)
                {
                    buffer = file.ReadLine();
                    if (buffer == null) { break; }
                    User newUser = UserFileParse(buffer);
                    if (Program.hashTable.Add(newUser) == -1)
                    {
                        //добавить запись в лог.
                    }
                }
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show(
                    "Данного файла не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
        }

        private void reviewScanButton_Click(object sender, EventArgs e)
        {
            Program.tree.Clear();
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + reviewFileName.Text + ".txt";
            try
            {
                StreamReader file = new StreamReader(fileName);
                string buffer = "";
                while (true)
                {
                    buffer = file.ReadLine();
                    if (buffer == null) { break; }
                    Review newReview = ReviewFileParse(buffer);
                    Program.tree.Add(newReview);
                }
                
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(
                    "Данного файла не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
