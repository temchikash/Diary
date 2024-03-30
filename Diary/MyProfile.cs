using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class MyProfile : Form
    {
        User user = new User();
        public bool admin = false; 
        public MyProfile()
        {
            InitializeComponent();
        }
        public MyProfile(User User)
        {
            user = User;
            InitializeComponent();
        }

        public MyProfile(User User, bool Admin)
        {
            admin = Admin;
            user = User;
            InitializeComponent();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            if (admin)
            {
                LessonNameTextBox.ReadOnly = true;
                textBox1.ReadOnly = true;
                LessonTypeTextBox.ReadOnly = false;

            }
            else
            {
                LessonNameTextBox.ReadOnly = false;
                textBox1.ReadOnly = true;
                LessonTypeTextBox.ReadOnly = true;
            }
            Show_();
        }

        private void GoBackButton1_Click(object sender, EventArgs e)
        {

            DataBase db = new DataBase();
            db.OpenConnection();


            user.FIO = LessonNameTextBox.Text;
            user.Group = LessonTypeTextBox.Text;
            user.Institute = TimeTextBox.Text;
            user.Speciality = AudienceTextBox.Text;

            MySqlCommand command = new MySqlCommand("UPDATE users SET password = @password, FIO =@FIO, group_name = @group_name, institute = @institute, speciality = @speciality WHERE email = @email", db.GetConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
            command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = user.FIO;
            command.Parameters.Add("@group_name", MySqlDbType.VarChar).Value = user.Group;
            command.Parameters.Add("@institute", MySqlDbType.VarChar).Value = user.Institute;
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = user.Speciality;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно измененно! ");
                db.CloseConnection();
                Show_();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            db.CloseConnection();
            Close();
        }

        private void Show_()
        {
            LessonNameTextBox.Text = user.FIO;
            LessonTypeTextBox.Text = user.Group;
            TimeTextBox.Text = user.Institute;
            AudienceTextBox.Text = user.Speciality;
            textBox1.Text = user.Email;
        }














        private void LessonNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
