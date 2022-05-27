using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmDog.Objects
{
    class ConsoleOutput
    {
        private static ConsoleOutput _instance = null;
        private static ListBox _listBox = null;
        ConsoleOutput() { }

        public static ConsoleOutput getInstance()
        {
            if (_instance == null)
                _instance = new ConsoleOutput();
            return _instance;
        }

        public void SendMessage(string message)
        {
            if(_listBox == null)
            {
                Console.WriteLine($"Error: message \"{message}\" wasn't sent");
                return;
            }
            _listBox.Items.Insert(0, message);
        }

        static public void SetOutputListBox(ListBox listBox)
        {
            _listBox = listBox;
        }
    }
}
