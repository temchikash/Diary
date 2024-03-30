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
    public partial class MainMenuStudent : Form
    {
        public User user = new User();
        public MainMenuStudent()
        {
            InitializeComponent();
        }
        public MainMenuStudent(User User)
        {
            user = User;
            InitializeComponent();
        }

        private void LessonLinkButton_Click(object sender, EventArgs e)
        {
            Lessons lesson = new Lessons(user);
            lesson.ShowDialog();
        }

        private void AcademicPerfomanceLink_Click(object sender, EventArgs e)
        {
            AcademicPerformance academic = new AcademicPerformance(user.Email);
            academic.ShowDialog();
        }

        private void ProfileLinkButton_Click(object sender, EventArgs e)
        {
            MyProfile profile = new MyProfile(user);
            profile.ShowDialog();
        }

        private void MainMenuStudent_Load(object sender, EventArgs e)
        {
            
        }
    }
}
