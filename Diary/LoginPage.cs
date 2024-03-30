using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Diary
{
    public partial class LoginPage : Form
    {
        private string email;
        private string password;


        UserContext db;
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(EmailTextBox.Text) && !String.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    String email = PasswordTextBox.Text;
                    String passUser = EmailTextBox.Text;








                    







                    DataBase db = new DataBase();




                    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  email = @uL AND password = @uP ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;



                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    adapter.SelectCommand = command; // выполняем команду


                    DataTable table = new DataTable();

                    adapter.Fill(table);// записываем данные в объект класса DataTable

                    db.OpenConnection();
                    DbDataReader reader = command.ExecuteReader();
                    User user = new User(email, passUser);
                    while (reader.Read())
                    {
                        user.Email = reader[1].ToString();
                        user.Password = reader[2].ToString();
                        user.FIO = reader[3].ToString();
                        user.Group = reader[4].ToString();
                        user.Institute = reader[5].ToString();
                        user.Speciality = reader[6].ToString();
                    }
                    db.CloseConnection();

                    if (table.Rows.Count > 0)
                    {
                        if (user.Email == "admin" && user.Password == "admin") {
                            MainMenu mainMenu = new MainMenu(user);
                            this.Hide();
                            mainMenu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MainMenuStudent mainMenu = new MainMenuStudent(user);
                            this.Hide();
                            mainMenu.ShowDialog();
                            this.Close();
                        }
                        

                    }

                    else
                    {
                        MessageBox.Show("Пользователь с такими данными не найден!");
                    }


                }
                else
                {
                    MessageBox.Show("Вы не ввели все данные");
                }
            }
            catch
            {
                MessageBox.Show("Подключите базу данных");
            }
            
        }

        private void RegLinkButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.ShowDialog();

        }
    }
}
