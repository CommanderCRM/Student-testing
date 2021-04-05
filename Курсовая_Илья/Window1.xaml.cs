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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int rez;
        public Window1()
        {
            InitializeComponent();
            TextBox1.MaxLength = 5;
            Label1.Content = "\n(2+5)*8=?";
            TextBox1.Clear();
        }
        public int[] mass = new int[10];
        public string Clear(string st)
        {
            TextBox1.Text = TextBox1.Text.Replace(" ", "");
            TextBox1.Text = TextBox1.Text.Replace("0", "");
            TextBox1.Text = TextBox1.Text.Replace(".", "");
            return st;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (rez + 1)
            {
                case 1:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "56"|| TextBox1.Text == "056" || TextBox1.Text == "56.0"|| TextBox1.Text == "56,0")
                    {
                        TextBox1.MaxLength = 7;
                        mass[rez] = 1;
                        TextBox1.Clear();
                        rez++;
                        Label1.Content = "(x + 5 )/2 = 5 \n" +
                            "Чему равен x ?";
                    }
                    else
                    {
                        
                        mass[rez] = 0;
                        rez++;
                        Label1.Content = "(x + 5 )/2 = 5 \n" +
                            "Чему равен x ?";
                    }
                    break;
                case 2:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "5"|| TextBox1.Text == "05"|| TextBox1.Text == "5.0"|| TextBox1.Text == "05.0")
                    {
                        mass[rez] = 1;
                        TextBox1.Clear();
                        rez++;
                        Label1.Content = "                 (x(x-5))/0,3 = 0 \n Напишите наибольший корень";
                    }
                    else
                    {
                        Label1.Content = "                 (x(x-5))/0,3 = 0 \n Напишите наибольший корень";
                        mass[rez] = 0;
                        rez++;
                        TextBox1.Clear();
                    }
                    break;
                case 3:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "5" || TextBox1.Text == "5.0"|| TextBox1.Text == "5,0"|| TextBox1.Text == "05"|| TextBox1.Text == "05.0")
                    {
                        mass[rez] = 1;
                        TextBox1.Clear();
                        rez++;
                        Label1.Content = "\n128/16 + 32^2 = ?";
                    }
                    else
                    {
                        Label1.Content = "\n128/16 + 32^2 = ?";
                        mass[rez] = 0;
                        rez++;
                        TextBox1.Clear();
                    }
                    break;
                case 4:
                    TextBox1.Text = Clear(TextBox1.Text);

                    if (TextBox1.Text == "1032"|| TextBox1.Text == "01032"|| TextBox1.Text == "01032.0"|| TextBox1.Text == "1032.0")
                    {
                        mass[rez] = 1;
                        TextBox1.Clear();
                        rez++;
                        Label1.Content = "   x^2 - 4 = 32 \n" +
                            "Чему равен x ?";
                    }
                    else
                    {
                        Label1.Content = "   x^2 - 4 = 32 \n" +
                            "Чему равен x ?";
                        mass[rez] = 0;
                        rez++;
                        TextBox1.Clear();
                    }
                    break;
                case 5:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "6"|| TextBox1.Text == "-6"|| TextBox1.Text == "6.0"|| TextBox1.Text == "06" || TextBox1.Text == "06.0" || TextBox1.Text == "-6.0" || TextBox1.Text == "-06" || TextBox1.Text == "-06.0")
                    {
                        mass[rez] = 1;
                        TextBox1.Clear();
                        rez++;
                        Label1.Content = "2^(8+x) = 1024 \n" +
                            "Чему равен x ? \n Введите одно число";
                    }
                    else
                    {
                        mass[rez] = 0;
                        Label1.Content = "2^(8+x) = 1024 \n" +
                           "Чему равен x ? \n Введите одно число";
                        rez++;
                        TextBox1.Clear();
                    }
                    break;
                case 6:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "2"|| TextBox1.Text == "2.0" || TextBox1.Text == "02" || TextBox1.Text == "02.0")
                    {
                        mass[rez] = 1;
                        TextBox1.Clear();
                        rez++;
                        Label1.Content = "                    x*x -5x +4 = 0  \n" +
                          "  Чему равен наибольший корень?";
                    }
                    else
                    {
                        mass[rez] = 0;
                        rez++;
                        Label1.Content = "                    x*x -5x +4 = 0  \n" +
                          " Чему равен наибольший корень ?";
                        TextBox1.Clear();
                    }
                    break;
                case 7:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "4" || TextBox1.Text == "4.0" || TextBox1.Text == "04" || TextBox1.Text == "04.0")
                    {
                        Label1.Content = "                    x*x -3x +2 =0 \n Чему равен наименьший корень?";
                        mass[rez] = 1;
                        rez++;
                        TextBox1.Clear();
                    }
                    else {
                        Label1.Content = "                    x*x -3x +2 =0 \n   Чему равен наименьший корень?" +
                        "";
                        
                        mass[rez] = 0;
                        rez++;
                        TextBox1.Clear();
                    }
                    break;
                case 8:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "1" || TextBox1.Text == "1.0" || TextBox1.Text == "01" || TextBox1.Text == "01.0")
                    {
                        Label1.Content = "                    x^2 -13x +12 =0 \n" +
                        "Найдите корни уравнения, введите их \n      через запятую по возрастанию";
                        
                        mass[rez] = 1;
                        rez++;
                        TextBox1.Clear();
                    }
                    else {
                        Label1.Content = "                    x^2 -13x +12 =0 \n" +
                        "Найдите корни уравнения, введите их \n      через запятую по возрастанию";
                        rez++;
                        mass[rez] = 0;
                        TextBox1.Clear();
                    }
                    break;
                case 9:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "1,12" || TextBox1.Text == "1.0, 12.0" || TextBox1.Text == "01, 012" || TextBox1.Text == "01.0, 012.0" || TextBox1.Text == "1, 12" || TextBox1.Text == "1.0,12.0")
                    {
                        Label1.Content = "3x^2 -14x -5 =0 \n" +
                        "Введите наибольший корень";

                        mass[rez] = 1;
                        rez++;
                        TextBox1.Clear();
                    }
                    else 
                    {

                        Label1.Content = "                    3x^2 -14x -5 =0 \n" +
                       "           Введите наибольший корень";
                        mass[rez] = 0;
                        rez++;
                        TextBox1.Clear();

                    }
                    break;
                case 10:
                    TextBox1.Text = Clear(TextBox1.Text);
                    if (TextBox1.Text == "5" || TextBox1.Text == "5.0" || TextBox1.Text == "05" || TextBox1.Text == "05.0")
                    {


                        mass[rez] = 1;

                        Window4 w1 = new Window4(mass);
                        w1.Show();

                        this.Close();
                    }
                    else
                    {


                        mass[rez] = 0;

                        Window4 w1 = new Window4(mass);

                        this.Close();
                        w1.Show();
                    }
                    break;

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
