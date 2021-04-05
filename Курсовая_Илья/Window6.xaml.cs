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
using System.Security.Cryptography;
using System.Data.SQLite;

namespace Курсовая_Илья
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            db = new SQLiteConnection("Data Source = DataBase.db; Version=3");// инициализация бд
            db.Open();
        
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Password == "")
            {
                MessageBox.Show("Ошибка! Данные не введены!");
                textBox1.Text = string.Empty;
                textBox2.Password = string.Empty;
            }
            else
            {
                SQLiteCommand CMD = db.CreateCommand();// переменная, которая будет инициировать команды
                CMD.CommandText = "SELECT * FROM users where Login=" + "'" + textBox1.Text.ToLower() + "'" + ";";
                SQLiteCommand CMD2 = db.CreateCommand();
                CMD2.CommandText = "SELECT * FROM users where Password=" + "'" + Hash(textBox2.Password) + "'" + ";";
                if (string.IsNullOrEmpty((string)CMD.ExecuteScalar()))
                {
                    MessageBox.Show("Ошибка! Неверно введены логин или пароль!");
                    textBox1.Text = string.Empty;
                    textBox2.Password = string.Empty;
                }
                else
                {
                    if (string.IsNullOrEmpty((string)CMD2.ExecuteScalar()))
                    {
                        MessageBox.Show("Ошибка! Неверно введены логин или пароль!");
                        textBox1.Text = string.Empty;
                        textBox2.Password = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Успешная авторизация! Добро пожаловать!");
                        this.Hide();
                        var formMain = new Window2();
                        formMain.Closed += (s, args) => this.Close();
                        formMain.Show();
                    }
                }
            }
        }
        private SQLiteConnection db;
        private string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
