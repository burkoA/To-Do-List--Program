using System;
using System.Windows.Forms;
using ToDoListWinForms.Forms;

namespace ToDoListWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запустити форму логіну при старті програми
            Application.Run(new LoginForm());  // Замість TaskListView
        }
    }
}
