using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Diary
{
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GoBackButton1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Close();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();

            List <string> groups = new List<string>();
            while (reader.Read())
            {
                if (reader[4].ToString() != "admin")
                {
                    bool check = true;
                    for (int i = 0; i < groups.Count; i++)
                    {
                        if (groups[i].ToString() == reader[4].ToString())
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        groups.Add(reader[4].ToString());
                    }
                }

            }
            db.CloseConnection();


            for (int i = 0;i< groups.Count;i++)
            {
                Group_listBox.Items.Add(groups[i].ToString());
            }






        }

        public void Show_group()
        {
            try
            {
                String group = Group_listBox.SelectedItem.ToString();

                DataBase db = new DataBase();
                DataTable dataTable = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE  group_name = @group", db.GetConnection());
                command.Parameters.Add("@group", MySqlDbType.VarChar).Value = group;


                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command;

                adapter.Fill(dataTable);

                db.OpenConnection();
                DbDataReader reader = command.ExecuteReader();

                List<String> fio = new List<String>();
                while (reader.Read())
                {
                    fio.Add(reader[3].ToString());
                }
                db.CloseConnection();

                Name_listBox.Items.Clear();
                for (int i = 0; i < fio.Count; i++)
                {
                    Name_listBox.Items.Add(fio[i].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Выберите группу");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_group();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_listBox.SelectedItem.ToString() != null)
                {
                    DataBase db = new DataBase();
                    DataTable dataTable = new DataTable();
                    string email = "admin";
                    MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE  group_name = @group AND FIO = @fio", db.GetConnection());
                    command.Parameters.Add("@group", MySqlDbType.VarChar).Value = Group_listBox.SelectedItem.ToString();
                    command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = Name_listBox.SelectedItem.ToString();


                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    adapter.SelectCommand = command;

                    adapter.Fill(dataTable);

                    db.OpenConnection();
                    DbDataReader reader = command.ExecuteReader();

                    List<String> fio = new List<String>();
                    while (reader.Read())
                    {
                        email = (reader[1].ToString());
                    }
                    db.CloseConnection();

                    AcademicPerformance academic = new AcademicPerformance(email, true);
                    academic.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите группу");
                }
            }
            catch { MessageBox.Show("Выберите группу"); }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_listBox.SelectedItem.ToString() != null)
                {
                    DataBase db = new DataBase();
                    DataTable dataTable = new DataTable();
                    string email = "admin";
                    MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE  group_name = @group AND FIO = @fio", db.GetConnection());
                    command.Parameters.Add("@group", MySqlDbType.VarChar).Value = Group_listBox.SelectedItem.ToString();
                    command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = Name_listBox.SelectedItem.ToString();

                    User user = new User();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    adapter.SelectCommand = command;

                    adapter.Fill(dataTable);

                    db.OpenConnection();
                    DbDataReader reader = command.ExecuteReader();

                    List<String> fio = new List<String>();
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

                    MyProfile profile = new MyProfile(user, true);
                    profile.ShowDialog();
                    Show_group();
                }
                else
                {
                    MessageBox.Show("Выберите группу");
                }
            }
            catch { MessageBox.Show("Выберите группу"); }

        }
    }
}
