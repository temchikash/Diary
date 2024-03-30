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

namespace Diary
{
    public partial class LessonCard_Admin : Form
    {
        public LessonCard_Admin()
        {
            
            InitializeComponent();
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            bool test = true;
            Lesson lesson = new Lesson();
            lesson.name = LessonNameTextBox.Text;
            lesson.group = textBox1.Text;
            lesson.type = LessonTypeTextBox.Text;
            lesson.audience = AudienceTextBox.Text;
            lesson.lector = TeacherTextBox.Text;
            switch (comboBox1.Text)
            {
                case "8:30-10:00":
                    lesson.y_time = "1"; break;
                case "10:10-11:40":
                    lesson.y_time = "2"; break;
                case "12:10-13:40":
                    lesson.y_time = "3"; break;
                case "13:50-15:20":
                    lesson.y_time = "4"; break;
                case "15:50-17:20":
                    lesson.y_time = "5"; break;
                case "17:30-19:00":
                    lesson.y_time = "6"; break;
                case "19:10-20:40":
                    lesson.y_time = "7"; break;
                default:
                    MessageBox.Show("Вы неправильно ввели время");
                    test = false;
                    break;
            }

            switch (comboBox2.Text)
            {
                case "Понедельник":
                    lesson.x_day = "1"; break;
                case "Вторник":
                    lesson.x_day = "2"; break;
                case "Среда":
                    lesson.x_day = "3"; break;
                case "Четверг":
                    lesson.x_day = "4"; break;
                case "Пятница":
                    lesson.x_day = "5"; break;
                case "Суббота":
                    lesson.x_day = "6"; break;
                default:
                    MessageBox.Show("Вы неправильно ввели день");
                    test = false;
                    break;
            }

            if (test)
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM lesson WHERE x_day = @X AND y_time = @Y AND group_name = @gp ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command1.Parameters.Add("@X", MySqlDbType.VarChar).Value = lesson.x_day;
                command1.Parameters.Add("@Y", MySqlDbType.VarChar).Value = lesson.y_time;
                command1.Parameters.Add("@gp", MySqlDbType.VarChar).Value = lesson.group;



                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command1;
                DataTable table1 = new DataTable();
                adapter.Fill(table1);// записываем данные в объект класса DataTable


                if (table1.Rows.Count == 0 )
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO lesson (`name`, `type`, `x_day`, `y_time`, `lector`,`audience`,`group_name`) VALUES(@name, @type, @x_day, @y_time, @lector, @audience, @group_name)", db.GetConnection());
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = lesson.name;
                    command.Parameters.Add("@type", MySqlDbType.VarChar).Value = lesson.type;
                    command.Parameters.Add("@x_day", MySqlDbType.VarChar).Value = lesson.x_day;
                    command.Parameters.Add("@y_time", MySqlDbType.VarChar).Value = lesson.y_time;
                    command.Parameters.Add("@lector", MySqlDbType.VarChar).Value = lesson.lector;
                    command.Parameters.Add("@audience", MySqlDbType.VarChar).Value = lesson.audience;
                    command.Parameters.Add("@group_name", MySqlDbType.VarChar).Value = lesson.group;

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
                    MySqlCommand command = new MySqlCommand("UPDATE lesson SET name =@name, type = @type, lector = @lector, audience = @audience WHERE group_name = @group_name AND x_day = @x_day AND y_time = @y_time", db.GetConnection());
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = lesson.name;
                    command.Parameters.Add("@type", MySqlDbType.VarChar).Value = lesson.type;
                    command.Parameters.Add("@x_day", MySqlDbType.VarChar).Value = lesson.x_day;
                    command.Parameters.Add("@y_time", MySqlDbType.VarChar).Value = lesson.y_time;
                    command.Parameters.Add("@lector", MySqlDbType.VarChar).Value = lesson.lector;
                    command.Parameters.Add("@audience", MySqlDbType.VarChar).Value = lesson.audience;
                    command.Parameters.Add("@group_name", MySqlDbType.VarChar).Value = lesson.group;
                    command.ExecuteNonQuery();
                    db.CloseConnection();
                    this.Close();
                }


                this.Close();
            }





        }

        private void LessonCard_Admin_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "8:30-10:00", "10:10-11:40", "12:10-13:40",  "13:50-15:20", "15:50-17:20", "17:30-19:00", "19:10-20:40" });
            comboBox2.Items.AddRange(new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" });
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AudienceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LessonTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LessonNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}