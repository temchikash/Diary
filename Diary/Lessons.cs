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
using static Diary.Lessons;

namespace Diary
{
    public partial class Lessons : Form
    {
        public bool admin = false;
        public User user = new User();
        public List<string> groups = new List<string>();
        public List<Lesson> lessons = new List<Lesson>();
        public Lessons()
        {
            InitializeComponent();
        }

        public Lessons(User User)
        {
            user = User;
            InitializeComponent();
        }

        public Lessons(bool Admin)
        {
            admin = Admin;
            InitializeComponent();
        }


        private void Lessons_Load(object sender, EventArgs e)
        {
            ShowNames();

            if (admin)
            {
                DataBase db = new DataBase();
                DataTable dataTable = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.GetConnection());

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command;

                adapter.Fill(dataTable);

                db.OpenConnection();
                DbDataReader reader = command.ExecuteReader();

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

                for (int i = 0; i < groups.Count;i++)
                {
                    comboBox1.Items.Add(groups[i]);
                }

            }
            else
            {
                comboBox1.Hide();
                GoBackButton1.Hide();
            }

        }

        private void ShowNames()
        {

            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM lesson WHERE  group_name = @group", db.GetConnection());
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = user.Group;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                Lesson lesson = new Lesson();
                lesson.name = reader[1].ToString();
                lesson.type = reader[2].ToString();
                lesson.x_day = reader[3].ToString();
                lesson.y_time = reader[4].ToString();
                lesson.lector = reader[5].ToString();
                lesson.audience = reader[6].ToString();
                lessons.Add(lesson);
                
            }
            db.CloseConnection();

            label1_1.Text = "";
            label2_1.Text = "";
            label3_1.Text = "";
            label4_1.Text = "";
            label5_1.Text = "";
            label6_1.Text = "";
            label7_1.Text = "";
            label1_2.Text = "";
            label2_2.Text = "";
            label3_2.Text = "";
            label4_2.Text = "";
            label5_2.Text = "";
            label6_2.Text = "";
            label7_2.Text = "";
            label1_3.Text = "";
            label2_3.Text = "";
            label3_3.Text = "";
            label4_3.Text = "";
            label5_3.Text = "";
            label6_3.Text = "";
            label7_3.Text = "";
            label1_4.Text = "";
            label2_4.Text = "";
            label3_4.Text = "";
            label4_4.Text = "";
            label5_4.Text = "";
            label6_4.Text = "";
            label7_4.Text = "";
            label1_5.Text = "";
            label2_5.Text = "";
            label3_5.Text = "";
            label4_5.Text = "";
            label5_5.Text = "";
            label6_5.Text = "";
            label7_5.Text = "";
            label1_6.Text = "";
            label2_6.Text = "";
            label3_6.Text = "";
            label4_6.Text = "";
            label5_6.Text = "";
            label6_6.Text = "";
            label7_6.Text = "";

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j<= 7; j++)
                {
                    for (int k = 0; k < lessons.Count; k++)
                    {
                        if (lessons[k].x_day == i.ToString() && lessons[k].y_time == j.ToString() ) {

                            switch (i)
                            {
                                case 1:
                                    switch (j)
                                    {
                                        case 1:
                                            label1_1.Text = lessons[k].name;
                                            break;
                                        case 2:
                                            label2_1.Text = lessons[k].name;
                                            break;
                                        case 3:
                                            label3_1.Text = lessons[k].name;
                                            break;
                                        case 4:
                                            label4_1.Text = lessons[k].name;
                                            break;
                                        case 5:
                                            label5_1.Text = lessons[k].name;
                                            break;
                                        case 6:
                                            label6_1.Text = lessons[k].name;
                                            break;
                                        case 7:
                                            label7_1.Text = lessons[k].name;
                                            break;
                                    }
                                    break;

                                case 2:
                                    switch (j)
                                    {
                                        case 1:
                                            label1_2.Text = lessons[k].name;
                                            break;
                                        case 2:
                                            label2_2.Text = lessons[k].name;
                                            break;
                                        case 3:
                                            label3_2.Text = lessons[k].name;
                                            break;
                                        case 4:
                                            label4_2.Text = lessons[k].name;
                                            break;
                                        case 5:
                                            label5_2.Text = lessons[k].name;
                                            break;
                                        case 6:
                                            label6_2.Text = lessons[k].name;
                                            break;
                                        case 7:
                                            label7_2.Text = lessons[k].name;
                                            break;
                                    }
                                    break;

                                case 3:
                                    switch (j)
                                    {
                                        case 1:
                                            label1_3.Text = lessons[k].name;
                                            break;
                                        case 2:
                                            label2_3.Text = lessons[k].name;
                                            break;
                                        case 3:
                                            label3_3.Text = lessons[k].name;
                                            break;
                                        case 4:
                                            label4_3.Text = lessons[k].name;
                                            break;
                                        case 5:
                                            label5_3.Text = lessons[k].name;
                                            break;
                                        case 6:
                                            label6_3.Text = lessons[k].name;
                                            break;
                                        case 7:
                                            label7_3.Text = lessons[k].name;
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (j)
                                    {
                                        case 1:
                                            label1_4.Text = lessons[k].name;
                                            break;
                                        case 2:
                                            label2_4.Text = lessons[k].name;
                                            break;
                                        case 3:
                                            label3_4.Text = lessons[k].name;
                                            break;
                                        case 4:
                                            label4_4.Text = lessons[k].name;
                                            break;
                                        case 5:
                                            label5_4.Text = lessons[k].name;
                                            break;
                                        case 6:
                                            label6_4.Text = lessons[k].name;
                                            break;
                                        case 7:
                                            label7_4.Text = lessons[k].name;
                                            break;
                                    }
                                    break;

                                case 5:
                                    switch (j)
                                    {
                                        case 1:
                                            label1_5.Text = lessons[k].name;
                                            break;
                                        case 2:
                                            label2_5.Text = lessons[k].name;
                                            break;
                                        case 3:
                                            label3_5.Text = lessons[k].name;
                                            break;
                                        case 4:
                                            label4_5.Text = lessons[k].name;
                                            break;
                                        case 5:
                                            label5_5.Text = lessons[k].name;
                                            break;
                                        case 6:
                                            label6_5.Text = lessons[k].name;
                                            break;
                                        case 7:
                                            label7_5.Text = lessons[k].name;
                                            break;
                                    }
                                    break;

                                case 6:
                                    switch (j)
                                    {
                                        case 1:
                                            label1_6.Text = lessons[k].name;
                                            break;
                                        case 2:
                                            label2_6.Text = lessons[k].name;
                                            break;
                                        case 3:
                                            label3_6.Text = lessons[k].name;
                                            break;
                                        case 4:
                                            label4_6.Text = lessons[k].name;
                                            break;
                                        case 5:
                                            label5_6.Text = lessons[k].name;
                                            break;
                                        case 6:
                                            label6_6.Text = lessons[k].name;
                                            break;
                                        case 7:
                                            label7_6.Text = lessons[k].name;
                                            break;
                                    }
                                    break;

                            }
                        }
                    }
                }
            }




        }











        private void label6_Click(object sender, EventArgs e)
        {

        }

 

        private void GoBackButton1_Click(object sender, EventArgs e)
        {
           
            if (groups.Contains(comboBox1.Text))
            {
                lessons.Clear();
                user.Group = comboBox1.Text;
                ShowNames();
            }else
            {
                MessageBox.Show("Такой группы не существует");
            }
        }

        private void lesson1_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_1_Click(object sender, EventArgs e)
        {
            
            if (label1_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].x_day == "1" && lessons[k].y_time == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label1_2_Click(object sender, EventArgs e)
        {
            if (label1_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "1" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label1_3_Click(object sender, EventArgs e)
        {
            if (label1_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "1" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label3_2_Click(object sender, EventArgs e)
        {
            if (label3_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "3" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label1_4_Click(object sender, EventArgs e)
        {
            if (label1_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "1" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label1_5_Click(object sender, EventArgs e)
        {
            if (label1_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "1" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label1_6_Click(object sender, EventArgs e)
        {
            if (label1_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "1" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label2_1_Click(object sender, EventArgs e)
        {
            if (label2_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "2" && lessons[k].x_day == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label2_2_Click(object sender, EventArgs e)
        {
            if (label2_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "2" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label2_3_Click(object sender, EventArgs e)
        {
            if (label2_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "2" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label2_4_Click(object sender, EventArgs e)
        {
            if (label2_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "2" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label2_5_Click(object sender, EventArgs e)
        {
            if (label2_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "2" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label2_6_Click(object sender, EventArgs e)
        {
            if (label2_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "2" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label3_1_Click(object sender, EventArgs e)
        {
            if (label3_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "3" && lessons[k].x_day == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label3_3_Click(object sender, EventArgs e)
        {
            if (label3_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "3" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label3_4_Click(object sender, EventArgs e)
        {
            if (label3_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "3" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label3_5_Click(object sender, EventArgs e)
        {
            if (label3_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "3" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label3_6_Click(object sender, EventArgs e)
        {
            if (label3_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "3" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label4_1_Click(object sender, EventArgs e)
        {
            if (label4_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "4" && lessons[k].x_day == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label4_2_Click(object sender, EventArgs e)
        {
            if (label4_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "4" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label4_3_Click(object sender, EventArgs e)
        {
            if (label4_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "4" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label4_4_Click(object sender, EventArgs e)
        {
            if (label4_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "4" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label4_5_Click(object sender, EventArgs e)
        {
            if (label4_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "4" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label4_6_Click(object sender, EventArgs e)
        {
            if (label4_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "4" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label5_1_Click(object sender, EventArgs e)
        {
            if (label5_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "5" && lessons[k].x_day == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label5_2_Click(object sender, EventArgs e)
        {
            if (label5_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "5" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label5_3_Click(object sender, EventArgs e)
        {
            if (label5_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "5" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label5_4_Click(object sender, EventArgs e)
        {
            if (label5_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "5" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label5_5_Click(object sender, EventArgs e)
        {
            if (label5_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "5" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label5_6_Click(object sender, EventArgs e)
        {
            if (label5_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "5" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label6_1_Click(object sender, EventArgs e)
        {
            if (label6_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "6" && lessons[k].x_day == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label6_2_Click(object sender, EventArgs e)
        {
            if (label6_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "6" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label6_3_Click(object sender, EventArgs e)
        {
            if (label6_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "6" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label6_4_Click(object sender, EventArgs e)
        {
            if (label6_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "6" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label6_5_Click(object sender, EventArgs e)
        {
            if (label6_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "6" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label6_6_Click(object sender, EventArgs e)
        {
            if (label6_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "6" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label7_1_Click(object sender, EventArgs e)
        {
            if (label7_1.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "7" && lessons[k].x_day == "1")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label7_2_Click(object sender, EventArgs e)
        {
            if (label7_2.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "7" && lessons[k].x_day == "2")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label7_3_Click(object sender, EventArgs e)
        {
            if (label7_3.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "7" && lessons[k].x_day == "3")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label7_4_Click(object sender, EventArgs e)
        {
            if (label7_4.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "7" && lessons[k].x_day == "4")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label7_5_Click(object sender, EventArgs e)
        {
            if (label7_5.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "7" && lessons[k].x_day == "5")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }

        private void label7_6_Click(object sender, EventArgs e)
        {
            if (label7_6.Text != "")
            {
                for (int k = 0; k < lessons.Count; k++)
                {
                    if (lessons[k].y_time == "7" && lessons[k].x_day == "6")
                    {
                        LessonCard lessonCard = new LessonCard(lessons[k]);
                        lessonCard.Show();
                    }
                }
            }
        }
    }
}
