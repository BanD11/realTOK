using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Training
{
    public static class Global
    {
        public static DateTime timerZeroTime = new DateTime(0001, 01, 01, 0, 0, 0);//{01.01.0001 0:00:00}
        public static Timer t = new Timer();
        public static bool isWriting = false;
        public static int timerCount = 0;
        public static int timeLimit = -1;
        public static int allCharCounter = 0;
        public static int printableCharCounter = 0;
        public static int mistakes = 0;
        public static string Text = "";

    }
}
