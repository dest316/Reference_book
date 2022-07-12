using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Laba7__HashTable_;
using RedBlackTree;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static Tree tree;
        public static HashTable hashTable;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            tree = new Tree();
            hashTable = new HashTable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            Application.Run(form);
        }
    }
}
