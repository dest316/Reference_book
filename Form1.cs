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
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + userFileName.Text + ".txt";
            try
            {
                var choise = MessageBox.Show("Все ранее добавленные посетители будут удалены. Вы точно хотите продолжить?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choise == DialogResult.No) { return; }
                Program.hashTable.Clear();
                StreamReader file = new StreamReader(fileName);
                string buffer = "";
                while (true)
                {
                    buffer = file.ReadLine();
                    if (buffer == null || buffer == "") { break; }
                    User newUser = UserFileParse(buffer);
                    if (Program.hashTable.Add(newUser) == -1)
                    {
                        //добавить запись в лог.
                    }
                }
                file.Close();
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show(
                    "Данного файла не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
        }

        private void reviewScanButton_Click(object sender, EventArgs e)
        {
            var choise = MessageBox.Show("Все ранее добавленные отзывы будут удалены. Вы точно хотите продолжить?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choise == DialogResult.No) { return; }
            if (Program.hashTable.IsEmpty())
            {
                MessageBox.Show("В справочнике нет ни одного посетителя, записать отзывы не получится", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.tree.Clear();
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + reviewFileName.Text + ".txt";
            try
            {
                StreamReader file = new StreamReader(fileName);
                string buffer = "";
                while (true)
                {
                    buffer = file.ReadLine();
                    if (buffer == null || buffer == "") { break; }
                    Review newReview = ReviewFileParse(buffer);
                    if (Program.hashTable.IsNumberInTable(newReview.phoneNumber))
                        Program.tree.Add(newReview);
                }
                file.Close();
                
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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void addReviewButton_Click(object sender, EventArgs e)
        {
            AddReviewForm addReviewForm = new AddReviewForm();
            addReviewForm.Show();
        }

        private void saveUsersButton_Click(object sender, EventArgs e)
        {
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + saveUsersTextBox.Text + ".txt";
            StreamWriter file = new StreamWriter(fileName);
            for (int i = 0; i < Program.hashTable.GetCapacity(); i++)
            {
                if (Program.hashTable.GetElements()[i].state == 1)
                {
                    file.WriteLine($"{Program.hashTable.GetElements()[i].data.nickname};{Program.hashTable.GetElements()[i].data.password};" +
                        $"{Program.hashTable.GetElements()[i].data.phoneNumber}");
                }
            }
            file.Close();
            MessageBox.Show("Файл удалось сохранить", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void saveReviewsButton_Click(object sender, EventArgs e)
        {
            string fileName = "C:/Users/sergm/source/repos/WindowsFormsApp1/" + saveReviewsTextBox.Text + ".txt";
            StreamWriter file = new StreamWriter(fileName);
            Program.tree.InOrder(in file);
            file.Close();
            MessageBox.Show("Файл удалось сохранить", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            DebugForm debugForm = new DebugForm();
            debugForm.Show();
        }
    }
}
