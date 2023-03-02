using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiWinForms
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrationForm());
            if (flag == 1)
            {
                Application.Run(new Form1());
            }
        }
        static short flag = 0;
        public static void CloseReg()
        {
            flag = 1;
        }
    }
}
