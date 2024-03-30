using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Diary
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

        }
        private void Reg_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(RegEmailTextBox.Text) && !String.IsNullOrEmpty(RegPasswordTextBox.Text) && !String.IsNullOrEmpty(FIOTextBox.Text))
            {
                DataBase db = new DataBase();
                db.OpenConnection();

                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE email = @UE ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command.Parameters.Add("@UE", MySqlDbType.VarChar).Value = RegEmailTextBox.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    User user = new User();
                    user.Email = RegEmailTextBox.Text;
                    user.Password = RegPasswordTextBox.Text;
                    user.FIO =FIOTextBox.Text;
                    user.Group = textBox1.Text;

                    MySqlCommand command1 = new MySqlCommand("INSERT INTO users (`email`, `password`, `FIO`, `group_name`,`institute`,`speciality` ) VALUES(@email, @password, @FIO, @group_name, @institute, @speciality)", db.GetConnection());
                    command1.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.Email;
                    command1.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
                    command1.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = user.FIO;
                    command1.Parameters.Add("@group_name", MySqlDbType.VarChar).Value = user.Group;
                    command1.Parameters.Add("@institute", MySqlDbType.VarChar).Value = "";
                    command1.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = "";

                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Добро пожаловать!");

                        MainMenuStudent mainMenu = new MainMenuStudent(user);
                        db.CloseConnection();
                        this.Hide();
                        mainMenu.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show("Введенный вами email уже был раннее зарегестрирован");
                }
                db.CloseConnection();
            }

        }
        private void BackToLogin_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
