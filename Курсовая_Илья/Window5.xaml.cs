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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        int rez;

        public int[] mass = new int[10];

       


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)//A
        {
            switch (rez + 1)
            {
                case 1:
                    mass[rez] = 1;
                    rez++;
                    R1.IsChecked = false;
                    R1.Content = "объему выборки n";
                    R2.Content = "среднему арифметическому значений признака";
                    R3.Content = "нулю";

                    Label1.Content = "Сумма частот признака равна:";
                    break;
                case 2:
                    mass[rez] = 1;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = "Ломаная, отрезки которой соединяют точки с координатами (xi,ni), \n" +
                                     "где xi– значение вариационного ряда, ni – частота, – это: ";
                    R1.Content = "гистограмма";
                    R2.Content = "эмпирическая функция распределения";
                    R3.Content = "полигон";

                    break;
                case 3:
                    mass[rez] = 0;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = " Уточненная выборочная дисперсия S^2 случайной \n" +
    "величины X обладает следующими свойствами: ";
                    R1.Content = "является смещенной оценкой дисперсии случайной величины X";
                    R2.Content = "является несмещенной оценкой дисперсии случайной величины X ";
                    R3.Content = "является смещенной оценкой среднеквадратического \n" +
                        "  отклонения случайной величины X";
                    break;
                case 4:
                    mass[rez] = 0;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = " По выборке объема n=10 получена выборочная диcперсия \n" +
    "D∗= 90.Тогда уточненная выборочная дисперсия S2 равна";
                    R1.Content = "100";
                    R2.Content = "80 ";
                    R3.Content = "90";
                    break;
                case 5:

                    mass[rez] = 1;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = "Оценка a∗ параметра a называется несмещенной, если:";
                    R1.Content = "она не зависит от объема испытаний";
                    R2.Content = "она приближается к оцениваемому параметру при увеличении\n объема испытаний ";
                    R3.Content = "выполняется условие M(a∗)=a+";

                    break;
                case 6:
                    mass[rez] = 0;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = "При увеличении объема выборки n и одном и том же\n уровне значимости a"
+ ", ширина доверительного интервала";
                    R1.Content = "может как уменьшиться, так и увеличиться";
                    R2.Content = "уменьшается ";
                    R3.Content = "не изменяется";
                    break;
                case 7:
                    mass[rez] = 0;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = "Может ли неизвестная дисперсия случайной величины выйти за границы, \nустановленные при" +
                        " построении ее доверительного интервала \nс доверительной вероятностью γ?";



                    R1.Content = "может с вероятностью 1−γ ";
                    R2.Content = "может с вероятностью γ ";
                    R3.Content = "может только в том случае, если исследователь ошибся в расчетах";
                    break;
                case 8:
                    mass[rez] = 1;
                    rez++;
                    R1.IsChecked = false;
                    Label1.Content = "Статистической гипотезой называют: ";



                    R1.Content = "предположение относительно статистического критерия";
                    R2.Content = "предположение относительно параметров или вида\n закона распределения генеральной совокупности ";
                    R3.Content = "предположение относительно объема генеральной совокупности";

                    break;
                case 9:
                    mass[rez] = 0;
                    R1.IsChecked = false;
                    Label1.Content = "Какие из названных распределений используются при проверке\n " +
                        "гипотезы о числовом значении математического ожидания при\nнеизвестной дисперсии?";
                    R1.Content = "распределение Стьюдента";
                    R2.Content = "распределение Фишера";
                    R3.Content = "нормальное распределение";
                    rez++;
                    break;
                case 10:
                    mass[rez] = 1;
                    Window4 w1 = new Window4(mass);

                    w1.Show();

                    this.Close();
                    break;



            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)//B
        {
            switch (rez + 1)
            {
                case 1:
                    mass[rez] = 0;
                    rez++;
                    R2.IsChecked = false;
                    R1.Content = "объему выборки n";
                    R2.Content = "среднему арифметическому значений признака";
                    R3.Content = "нулю";

                    Label1.Content = "Сумма частот признака равна:";
                    break;
                case 2:
                    mass[rez] = 0;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = "Ломаная, отрезки которой соединяют точки с координатами (xi,ni), \n" +
                                 "где xi– значение вариационного ряда, ni – частота, – это: ";
                    R1.Content = "гистограмма";
                    R2.Content = "эмпирическая функция распределения";
                    R3.Content = "полигон";
                    break;
                case 3:
                    mass[rez] = 0;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = " Уточненная выборочная дисперсия S^2 случайной \n" +
    "величины X обладает следующими свойствами: ";
                    R1.Content = "является смещенной оценкой дисперсии случайной величины X";
                    R2.Content = "является несмещенной оценкой дисперсии случайной величины X ";
                    R3.Content = "является смещенной оценкой среднеквадратического \n" +
                        "  отклонения случайной величины X";
                    break;
                case 4:
                    mass[rez] = 1;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = " По выборке объема n=10 получена выборочная диcперсия \n" +
                        "D∗= 90.Тогда уточненная выборочная дисперсия S2 равна";


                    R1.Content = "100";
                    R2.Content = "80 ";
                    R3.Content = "90";

                    break;
                case 5:
                    mass[rez] = 0;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = "Оценка a∗ параметра a называется несмещенной, если:";
                    R1.Content = "она не зависит от объема испытаний";
                    R2.Content = "она приближается к оцениваемому параметру при увеличении\n объема испытаний ";
                    R3.Content = "выполняется условие M(a∗)=a+";
                    break;
                case 6:
                    mass[rez] = 0;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = "При увеличении объема выборки n и одном и том же\n уровне значимости a"
+ ", ширина доверительного интервала";

                    R1.Content = "может как уменьшиться, так и увеличиться";
                    R2.Content = "уменьшается ";
                    R3.Content = "не изменяется";
                    break;
                case 7:
                    mass[rez] = 1;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = "Может ли неизвестная дисперсия случайной величины выйти за границы, \nустановленные при" +
                        " построении ее доверительного интервала \nс доверительной вероятностью γ?";



                    R1.Content = "может с вероятностью 1−γ ";
                    R2.Content = "может с вероятностью γ ";
                    R3.Content = "может только в том случае, если исследователь ошибся в расчетах";

                    break;
                case 8:
                    mass[rez] = 0;
                    rez++;
                    R2.IsChecked = false;
                    Label1.Content = "Статистической гипотезой называют: ";
                    R1.Content = "предположение относительно статистического критерия";
                    R2.Content = "предположение относительно параметров или вида\n закона распределения генеральной совокупности ";
                    R3.Content = "предположение относительно объема генеральной совокупности";
                    break;
                case 9:
                    mass[rez] = 1;
                    R2.IsChecked = false;
                    Label1.Content = "Какие из названных распределений используются при проверке\n " +
                        "гипотезы о числовом значении математического ожидания при\nнеизвестной дисперсии?";
                    R1.Content = "распределение Стьюдента";
                    R2.Content = "распределение Фишера";
                    R3.Content = "нормальное распределение";
                    rez++;
                    break;
                case 10:
                    mass[rez] = 0;
                    Window4 w1 = new Window4(mass);

                    w1.Show();


                    this.Close();
                    break;


            }

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)//C
        {
            switch (rez + 1)
            {
                case 1:
                    mass[rez] = 0;
                    rez++;
                    R3.IsChecked = false;
                    R1.Content = "объему выборки n";
                    R2.Content = "среднему арифметическому значений признака";
                    R3.Content = "нулю";

                    Label1.Content = "Сумма частот признака равна:";
                    break;
                case 2:
                    mass[rez] = 0;
                    rez++;
                    R3.IsChecked = false;
                    Label1.Content = "Ломаная, отрезки которой соединяют точки с координатами (xi,ni), \n" +
                                 "где xi– значение вариационного ряда, ni – частота, – это: ";
                    R1.Content = "гистограмма";
                    R2.Content = "эмпирическая функция распределения";
                    R3.Content = "полигон";
                    break;
                case 3:
                    mass[rez] = 1;
                    rez++;
                    R3.IsChecked = false;
                    Label1.Content = " Уточненная выборочная дисперсия S^2 случайной \n" +
                        "величины X обладает следующими свойствами: ";
                    R1.Content = "является смещенной оценкой дисперсии случайной величины X";
                    R2.Content = "является несмещенной оценкой дисперсии случайной величины X ";
                    R3.Content = "является смещенной оценкой среднеквадратического \n" +
                        "  отклонения случайной величины X";
                    break;
                case 4:
                    mass[rez] = 0;
                    rez++;
                    R3.IsChecked = false;
                    Label1.Content = " По выборке объема n=10 получена выборочная диcперсия \n" +
    "D∗= 90.Тогда уточненная выборочная дисперсия S2 равна";


                    R1.Content = "100";
                    R2.Content = "80 ";
                    R3.Content = "90";
                    break;
                case 5:
                    mass[rez] = 0;
                    rez++;
                    R3.IsChecked = false;
                    Label1.Content = "Оценка a∗ параметра a называется несмещенной, если:";
                    R1.Content = "она не зависит от объема испытаний";
                    R2.Content = "она приближается к оцениваемому параметру при увеличении\n объема испытаний ";
                    R3.Content = "выполняется условие M(a∗)=a+";
                    break;
                case 6:
                    mass[rez] = 1;
                    rez++;
                    Label1.Content = "При увеличении объема выборки n и одном и том же\n уровне значимости a"
+ ", ширина доверительного интервала";

                    R3.IsChecked = false;

                    R1.Content = "может как уменьшиться, так и увеличиться";
                    R2.Content = "уменьшается ";
                    R3.Content = "не изменяется";
                    break;
                case 7:
                    mass[rez] = 0;
                    rez++;
                    R3.IsChecked = false;
                    Label1.Content = "Может ли неизвестная дисперсия случайной величины выйти за границы, \nустановленные при" +
                        " построении ее доверительного интервала \nс доверительной вероятностью γ?";



                    R1.Content = "может с вероятностью 1−γ ";
                    R2.Content = "может с вероятностью γ ";
                    R3.Content = "может только в том случае, если исследователь ошибся в расчетах";
                    break;
                case 8:
                    mass[rez] = 0;
                    rez++;
                    R3.IsChecked = false;
                    Label1.Content = "Статистической гипотезой называют: ";
                    R1.Content = "предположение относительно статистического критерия";
                    R2.Content = "предположение относительно параметров или вида\n закона распределения генеральной совокупности ";
                    R3.Content = "предположение относительно объема генеральной совокупности";
                    break;
                case 9:
                    mass[rez] = 0;
                    R3.IsChecked = false;
                    Label1.Content = "Какие из названных распределений используются при проверке\n " +
                        "гипотезы о числовом значении математического ожидания при\nнеизвестной дисперсии?";
                    R1.Content = "распределение Стьюдента";
                    R2.Content = "распределение Фишера";
                    R3.Content = "нормальное распределение";
                    rez++;
                    break;
                case 10:
                    mass[rez] = 0;

                    Window4 w1 = new Window4(mass);
                    w1.Show();

                    this.Close();
                    break;


            }
        }

    }
}
