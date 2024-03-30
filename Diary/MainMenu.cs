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
    public partial class MainMenu : Form
    {
        User user = new User();
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(User User)
        {
            User = user;
            InitializeComponent();
        }

        private void LessonLinkButton_Click(object sender, EventArgs e)
        {
            Lessons lesson = new Lessons(true);
            lesson.ShowDialog();
        }

        private void GroupLinkButton_Click(object sender, EventArgs e)
        {
            Groups group = new Groups();
            group.ShowDialog();
        }

        private void ProfileLinkButton_Click(object sender, EventArgs e)
        {
            LessonCard_Admin lessonCard = new LessonCard_Admin();
            lessonCard.ShowDialog();
        }

        private void AcademicPerfomanceLink_Click(object sender, EventArgs e)
        {
            AcademicPerformance academic = new AcademicPerformance();
            this.Hide();
            academic.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
