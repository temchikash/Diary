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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diary
{
    public partial class AddPerformance : Form
    {
        public string email;
        public Performance performance;

        public AddPerformance()
        {
            InitializeComponent();
        }

        public AddPerformance(string Email)
        {
            email = Email;
            InitializeComponent();
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            bool test = true;
            Performance performance = new Performance();
            performance.email = email;
            performance.discipline = LessonNameTextBox.Text;
            performance.ball1 = textBox1.Text;
            performance.tip = comboBox2.Text;
            performance.ball2 = textBox2.Text;
            performance.date_exam = date1.Value.ToLongDateString();
            performance.itog = AudienceTextBox.Text;

            if (!(performance.tip == "Экзамен" || performance.tip == "Зачет")) {
                MessageBox.Show("Вы неправильно ввели тип сдачи");
                test = false;
            }

            if (test)
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM performance WHERE discipline = @dis", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command1.Parameters.Add("@dis", MySqlDbType.VarChar).Value = performance.discipline ;


                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command1;
                DataTable table1 = new DataTable();
                adapter.Fill(table1);// записываем данные в объект класса DataTable

                if (table1.Rows.Count == 0)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO performance (`email`, `discipline`, `ball1`, `tip`, `ball2`,`date_exam`,`itog`) VALUES(@email, @discipline, @ball1, @tip, @ball2, @date_exam, @itog)", db.GetConnection());
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = performance.email;
                    command.Parameters.Add("@discipline", MySqlDbType.VarChar).Value = performance.discipline;
                    command.Parameters.Add("@ball1", MySqlDbType.VarChar).Value = performance.ball1;
                    command.Parameters.Add("@tip", MySqlDbType.VarChar).Value = performance.tip;
                    command.Parameters.Add("@ball2", MySqlDbType.VarChar).Value = performance.ball2;
                    command.Parameters.Add("@date_exam", MySqlDbType.VarChar).Value = performance.date_exam;
                    command.Parameters.Add("@itog", MySqlDbType.VarChar).Value = performance.itog;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Отлично! ");
                        db.CloseConnection();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                    db.CloseConnection();
                    Close();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand("UPDATE performance SET email =@email, ball1 = @ball1, tip = @tip, ball2 = @ball2, date_exam =@date_exam, itog = @itog WHERE discipline = @discipline", db.GetConnection());
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = performance.email;
                    command.Parameters.Add("@discipline", MySqlDbType.VarChar).Value = performance.discipline;
                    command.Parameters.Add("@ball1", MySqlDbType.VarChar).Value = performance.ball1;
                    command.Parameters.Add("@tip", MySqlDbType.VarChar).Value = performance.tip;
                    command.Parameters.Add("@ball2", MySqlDbType.VarChar).Value = performance.ball2;
                    command.Parameters.Add("@date_exam", MySqlDbType.VarChar).Value = performance.date_exam;
                    command.Parameters.Add("@itog", MySqlDbType.VarChar).Value = performance.itog;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Успешно измененно! ");
                        db.CloseConnection();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                    db.CloseConnection();
                    Close();
                }


                this.Close();
            }
        }

        private void AddPerformance_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(new string[] { "Экзамен", "Зачет" });

        }
    }
}