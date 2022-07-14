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
    public partial class AddReviewForm : Form
    {
        public AddReviewForm()
        {
            InitializeComponent();
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {

        }
        public bool checkName(string str)
        {
            if (str == null || str.Length == 0) { return false; }
            if (str[0] < 1040 || str[0] > 1071) { return false; }
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] < 1072 || str[i] > 1103) { return false; }
            }
            return true;
        }
        public bool checkDate(string date, out DateTime resultDate)
        {
            resultDate = new DateTime(0);
            bool result = true;
            string[] arr = date.Split('_');
            if (arr.Length != 6) { return false; }

            int buffer;
            int[] dateParts = new int[6];
            result = int.TryParse(arr[0], out buffer);
            if (result == false || buffer < 2020 || buffer > 2022) { return false; }
            dateParts[0] = buffer;
            for (int i = 1; i < 6; i++)
            {
                if (!int.TryParse(arr[i], out buffer)) { return false; }
                dateParts[i] = buffer;
            }
            try
            {
                resultDate = new DateTime(dateParts[0], dateParts[1], dateParts[2], dateParts[3], dateParts[4], dateParts[5]);
                return true;
            }
            catch (Exception)
            {
                resultDate = new DateTime(0);
                return false;
            }
        }
        public bool checkDish(string dish)
        {
            if (dish == null || dish.Length == 0) { return false; }
            for (int i = 0; i < dish.Length; i++)
            {
                if (!((dish[i] >= 1040 && dish[i] <= 1103) || dish[i] == 95)) { return false; }
            }
            return true;
        }
        public bool checkRate(string rate) => int.TryParse(rate, out int result) && result > 0 && result < 6;
        public bool checkPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null || phoneNumber.Length < 7) { return false; }
            int delta = (phoneNumber[0] == '+') ? 1 : 0;
            for (int i = 0; i < 7; i++)
            {
                if (phoneNumber[i + delta] < 47 || phoneNumber[i + delta] > 58)
                    return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            if (checkName(nameTextBox.Text) && checkDate(datetimeTextBox.Text, out dateTime) && checkDish(dishTextBox.Text)
                && checkRate(rateTextBox.Text) && checkPhoneNumber(phoneNumberTextBox.Text))
            {
                if (!Program.hashTable.IsNumberInTable(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Посетителя с таким номером телефона нет в справочнике", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Program.tree.Add(new MyList.Review
                    {
                        name = nameTextBox.Text,
                        time = dateTime,
                        dish = dishTextBox.Text,
                        rate = int.Parse(rateTextBox.Text),
                        phoneNumber = phoneNumberTextBox.Text
                    });
                    MessageBox.Show("Отзыв успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string mess = "";
                if (!checkName(nameTextBox.Text)) { mess += "Имя введено некорректно\n"; }
                if (!checkDate(datetimeTextBox.Text, out dateTime)) { mess += "Дата была введена некорректно\n"; }
                if (!checkDish(dishTextBox.Text)) { mess += "Блюдо введено некорректно\n"; }
                if (!checkRate(rateTextBox.Text)) { mess += "Оценка введена некорректно\n"; }
                if (!checkPhoneNumber(phoneNumberTextBox.Text)) { mess += "Номер телефона введен некорректно"; }
                MessageBox.Show(mess, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var choise = MessageBox.Show("Вы уверены? Это действие необратимо", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choise == DialogResult.No) { return; }
            DateTime dateTime;
            if (checkName(nameTextBox.Text) && checkDate(datetimeTextBox.Text, out dateTime) && checkDish(dishTextBox.Text)
                && checkRate(rateTextBox.Text) && checkPhoneNumber(phoneNumberTextBox.Text))
            {
                Program.tree.Delete(new MyList.Review
                {
                    name = nameTextBox.Text,
                    time = dateTime,
                    dish = dishTextBox.Text,
                    rate = int.Parse(rateTextBox.Text),
                    phoneNumber = phoneNumberTextBox.Text
                });
                MessageBox.Show("Отзыв успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mess = "";
                if (!checkName(nameTextBox.Text)) { mess += "Имя введено некорректно\n"; }
                if (!checkDate(datetimeTextBox.Text, out dateTime)) { mess += "Дата была введена некорректно\n"; }
                if (!checkDish(dishTextBox.Text)) { mess += "Блюдо введено некорректно\n"; }
                if (!checkRate(rateTextBox.Text)) { mess += "Оценка введена некорректно\n"; }
                if (!checkPhoneNumber(phoneNumberTextBox.Text)) { mess += "Номер телефона введен некорректно"; }
                MessageBox.Show(mess, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
