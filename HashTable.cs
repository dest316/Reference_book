using System;

namespace Laba7__HashTable_
{
    public class User
    {
        public string phoneNumber { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public static bool operator ==(User user1, User user2) => !(user1 is null) && !(user2 is null) && user1.phoneNumber == user2.phoneNumber && user1.nickname == user2.nickname && user1.password == user2.password;
        public static bool operator !=(User user1, User user2) => !(user1 is null) && !(user2 is null) && user1.phoneNumber != user2.phoneNumber && user1.nickname != user2.nickname && user1.password != user2.password;
        public User()
        {
            phoneNumber = "";
            nickname = "";
            password = "";
        }
        public User(string nickname, string password, string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            this.nickname = nickname;
            this.password = password;
        }
        public override string ToString()
        {
            return $"{nickname} {password} {phoneNumber}";
        }
    }
    public class HashTableNode
    {
        public User data { get; set; }
        public int state { get; set; }
        public string key { get; set; }
        public HashTableNode()
        {
            data = new User();
            state = 0;
            key = "";
        }
        public override string ToString()
        {
            return $"{data.nickname} {data.password} {data.phoneNumber}\t {state}";
        }
    }
    public class HashTable
    {
        private int capacity;
        private int length;
        private HashTableNode[] elements;
        public HashTable()
        {
            capacity = 20;
            length = 0;
            elements = new HashTableNode[capacity];
            for (int i = 0; i < capacity; i++)
            {
                elements[i] = new HashTableNode();
            }
        }
        public HashTable(int capacity)
        {
            this.capacity = capacity >= 20 ? capacity : 20;
            length = 0;
            elements = new HashTableNode[capacity];
            for (int i = 0; i < capacity; i++)
            {
                elements[i] = new HashTableNode();
            }
        }
        public HashTableNode[] GetElements() => elements;
        public int GetCapacity() => capacity;
        public int TestHash(User number)
        {
            var nickname = number.nickname;
            var hash = 0;
            for (int i = 0; i < nickname.Length; i++) { hash += nickname[i]; }
            return hash % capacity;
        }
       
        private int SecondHash(int step, int index)
        {
            if (step > capacity || step < 1) { step = 1; }
            while (capacity % step == 0 && step != 1) { step++; }
            index += step;
            if (index > (capacity - 1)) { index -= capacity; }
            return index;
        }
        public bool IsEmpty() => length == 0;
        public int Add(User newUser)
        {
            var hash = TestHash(newUser);
            var step = 1; //пока захардкодил 2
            bool samePhoneNumber = IsNumberInTable(newUser.phoneNumber);
            if (newUser.nickname == elements[hash].data.nickname || samePhoneNumber) { return -1; }
            while (elements[hash].state == 1)
            {
                hash = SecondHash(step, hash);
                if (newUser.nickname == elements[hash].data.nickname || newUser.phoneNumber == elements[hash].data.phoneNumber) { return -1; }
            }
            elements[hash].data = newUser;
            elements[hash].key = newUser.phoneNumber;
            elements[hash].state = 1;
            length++;
            if ((double)length / capacity > 0.75) { Rehash(true); }
            return 0;
        }
        public void Print()
        {
            for (int i = 0; i < capacity; i++)
            {
                Console.Write(i + "\t");
                Console.WriteLine(elements[i]);
            }
            Console.WriteLine();
        }
        public void Delete(User deletedUser)
        {
            var hash = TestHash(deletedUser);
            var step = 1;
            while (elements[hash].state != 0 || elements[hash].data.phoneNumber !="")
            {
                if (elements[hash].data == deletedUser)
                {
                    if (elements[hash].state == 1) 
                    {
                        elements[hash].state = 0;
                        length--;
                    }
                    if ((double)length / capacity < 0.2 && capacity > 20)
                    { Rehash(false); }
                    return;
                }
                hash = SecondHash(step, hash);
            }
        }
        public bool IsNumberInTable(string number)
        {
            bool samePhoneNumber = false;
            for (int i = 0; i < capacity; i++)
            {
                if (number == elements[i].data.phoneNumber) { samePhoneNumber = true; }
            }
            return samePhoneNumber;
        }
        public int Search(User soughtUser)
        {
            var hash = TestHash(soughtUser);
            var step = 1;
            while (elements[hash].state != 0 || elements[hash].data.phoneNumber != "")
            {
                if (elements[hash].data == soughtUser) { return 0; }
                hash = SecondHash(step, hash);
            }
            return -1;
        }
        public string SearchPhoneNumber(string nickname)
        {
            User tmpUser = new User(nickname, "", "");
            var step = 1;
            var hash = TestHash(tmpUser);
            while (elements[hash].state != 0 || elements[hash].data.phoneNumber != "")
            {
                if (elements[hash].data.nickname == nickname) { return elements[hash].data.phoneNumber; }
                hash = SecondHash(step, hash);
            }
            return null;
        }
        public void Clear()
        {
            length = 0;
            capacity = 20;
            elements = new HashTableNode[20];
            for (int i = 0; i < capacity; i++)
            {
                elements[i] = new HashTableNode();
            }
        }
        private void Rehash(bool increase)
        {
            length = 0;
            int newCapacity = increase ? capacity * 2 : capacity / 2;
            if (newCapacity < 20) { return; }
            var tmp = new HashTableNode[elements.Length];
            Array.Copy(elements, tmp, elements.Length);
            elements = new HashTableNode[newCapacity];
            for (int i = 0; i < newCapacity; i++)
            {
                elements[i] = new HashTableNode();
            }
            capacity = newCapacity;
            foreach (var node in tmp)
            {
                if (!(node.data is null) && node.data.phoneNumber != "" && node.state == 1)
                    Add(node.data);
            }
            
        }
    }
}
