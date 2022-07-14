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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
       
        public bool checkNickname(string nickname)
        {
            if (nickname == null || nickname.Length == 0) { return false; }
            for (int i = 0; i < nickname.Length; i++)
                if ((nickname[i] > 47 && nickname[i] < 58) || (nickname[i] > 64 && nickname[i] < 91) || (nickname[i] > 96 && nickname[i] < 123) || nickname[i] == 95)
                { continue; }
                else return false;
            return true;
        }
        public bool checkPassword(string password) => checkNickname(password);
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
            if (checkNickname(nicknameTextBox.Text) && checkPassword(passwordTextBox.Text) && checkPhoneNumber(phoneNumberTextBox.Text))
            {
                if (Program.hashTable.Add(new Laba7__HashTable_.User { nickname = nicknameTextBox.Text, password = passwordTextBox.Text, phoneNumber = phoneNumberTextBox.Text }) == 0)
                {
                    MessageBox.Show("Посетитель успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Посетитель с таким никнеймом и/или номером телефона уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mess = "";
                if (!checkNickname(nicknameTextBox.Text)) { mess += "Никнейм введен некорректно\n"; }
                if (!checkPassword(passwordTextBox.Text)) { mess += "Пароль введен некорректно\n"; }
                if (!checkPhoneNumber(phoneNumberTextBox.Text)) { mess += "Номер телефона введен некорректно"; }                
                MessageBox.Show(mess, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var choise = MessageBox.Show("Внимание: удаление посетителя повлечет за собой удаление всех связанных с ним отзывов. " +
                "Это действие необратимо. Вы уверены? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choise == DialogResult.No) { return; }
            if (checkNickname(nicknameTextBox.Text) && checkPassword(passwordTextBox.Text) && checkPhoneNumber(phoneNumberTextBox.Text))
            {
                var deletedUser = new Laba7__HashTable_.User { nickname = nicknameTextBox.Text, password = passwordTextBox.Text, phoneNumber = phoneNumberTextBox.Text };
                var listWithDeletingReviews = Program.tree.GetListWithPhoneNumber(deletedUser.phoneNumber);
                if (listWithDeletingReviews != null)
                {
                    var cur = listWithDeletingReviews.head;
                    while (cur != null)
                    {
                        var tmp = cur;
                        cur = cur.next;
                        Program.tree.Delete(tmp.data);
                    }
                }
                
                Program.hashTable.Delete(deletedUser);
                MessageBox.Show("Операция успешно завершена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mess = "Связанные отзывы не были удалены\n";
                if (!checkNickname(nicknameTextBox.Text)) { mess += "Никнейм введен некорректно\n"; }
                if (!checkPassword(passwordTextBox.Text)) { mess += "Пароль введен некорректно\n"; }
                if (!checkPhoneNumber(phoneNumberTextBox.Text)) { mess += "Номер телефона введен некорректно"; }
                MessageBox.Show(mess, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
