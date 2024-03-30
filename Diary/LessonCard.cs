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

    public partial class LessonCard : Form
    {
        public Lesson lesson = new Lesson();
        public LessonCard()
        {
            InitializeComponent();
            
        }
        public LessonCard(Lesson lesson1)
        {
            lesson = lesson1;
            InitializeComponent();

        }


        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void LessonCard_Load(object sender, EventArgs e)
        {
            LessonNameTextBox.Text = lesson.name;
            LessonTypeTextBox.Text = lesson.type;
            AudienceTextBox.Text = lesson.audience;
            TeacherTextBox.Text = lesson.lector;
            switch (lesson.y_time)
            {
                case "1":
                    {
                        TimeTextBox.Text = "8:30-10:00"; break;
                    }
                case "2":
                    {
                        TimeTextBox.Text = "10:10-11:40"; break;
                    }
                case "3":
                    {
                        TimeTextBox.Text = "12:10-13:40"; break;
                    }
                case "4":
                    {
                        TimeTextBox.Text = "13:50-15:20"; break;
                    }
                case "5":
                    {
                        TimeTextBox.Text = "15:50-17:20"; break;
                    }
                case "6":
                    {
                        TimeTextBox.Text = "17:30-19:00"; break;
                    }
                case "7":
                    {
                        TimeTextBox.Text = "19:10-20:40"; break;
                    }
                default:
                    {
                        MessageBox.Show("ОШИБКА ВО ВРЕМЕНИ"); break;
                    }
            }
            switch (lesson.x_day)
            {
                case "1":
                    WeekDayTextBox.Text = "Monday"; break;
                case "2":
                    WeekDayTextBox.Text = "Tuesday"; break;
                case "3":
                    WeekDayTextBox.Text = "Wednesday"; break;
                case "4":
                    WeekDayTextBox.Text = "Thursday"; break;
                case "5":
                    WeekDayTextBox.Text = "Friday"; break;
                case "6":
                    WeekDayTextBox.Text = "Saturday"; break;
            }
        }
    }
}
