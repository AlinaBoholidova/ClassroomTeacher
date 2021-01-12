using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    static class Program
    {
        private static string СonnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            //Application.Run(new Pupils());
            //Application.Run(new PupilData());
            //Application.Run(new PersonnelFiles());
            //Application.Run(new Statistics());
            //Application.Run(new ViewReceipt());
            //Application.Run(new ViewScores());
            //Application.Run(new JournalRecord());
            //Application.Run(new Subjects());
            //Application.Run(new Payments());
            //Application.Run(new Rating());
            //Application.Run(new AdditionalActivity());
            Application.Run(new Login());
            //Application.Run(new Points());
            //Application.Run(new Payments());

            //DataContext db = new DataContext(СonnectionString);

            //// Получаем таблицу пользователей
            //Table<User> users = db.GetTable<User>();

            //foreach (var user in users)
            //{
            //    Console.WriteLine("{0} \t{1} \t{2} \t{3}", user.User_ID, user.Login, user.Password, user.Status);
            //}
            //Console.ReadKey();

        }
    }
}
