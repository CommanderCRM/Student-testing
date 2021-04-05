using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Курсовая_Илья
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        int count;
        public Window4(int[] mass)
        {
            InitializeComponent();
            if (mass[0] == 0) Label1.Content = "Вопрос 1 : неверный ответ";

            else

            {
                Label1.Content = "Вопрос 1 : верный ответ";
                count++;
            }

            if (mass[1] == 0)

                Label2.Content = "Вопрос 2 : неверный ответ";

            else

            {
                Label2.Content = "Вопрос 2 : верный ответ";
                count++;
            }

            if (mass[2] == 0)

                Label3.Content = "Вопрос 3 : неверный ответ";

            else

            {
                Label3.Content = "Вопрос 3 : верный ответ";
                count++;
            }

            if (mass[3] == 0)

                Label4.Content = "Вопрос 4 : неверный ответ";

            else

            {
                Label4.Content = "Вопрос 4 : верный ответ";
                count++;
            }

            if (mass[4] == 0)

                Label5.Content = "Вопрос 5 : неверный ответ ";

            else

            {
                Label5.Content = "Вопрос 5 : верный ответ";
                count++;
            }

            if (mass[5] == 0)

                Label6.Content = "Вопрос 6 : неверный ответ ";

            else

            {
                Label6.Content = "Вопрос 6 : верный ответ";
                count++;
            }

            if (mass[6] == 0)

                Label7.Content = "Вопрос 7 : неверный ответ ";

            else

            {
                Label7.Content = "Вопрос 7 : верный ответ";
                count++;
            }

            if (mass[7] == 0)

                Label8.Content = "Вопрос 8 : неверный ответ ";

            else

            {
                Label8.Content = "Вопрос 8 : верный ответ";
                count++;
            }

            if (mass[8] == 0)

                Label9.Content = "Вопрос 9 : неверный ответ ";

            else
            { 
            Label9.Content = "Вопрос 9 : верный ответ";
            count++;
        }
            if (mass[9] == 0)

                Label9_Copy.Content = "Вопрос 10 : неверный ответ ";

            else

            {
                Label9_Copy.Content = "Вопрос 10 : верный ответ";
                count++;
            }
            Label9_Copy1.Content = Convert.ToString(Math.Round(Convert.ToDouble(count) / Convert.ToDouble(mass.LongCount()) * 100, 0)) + "% теста решено правильно";
        }

    }

       
}
