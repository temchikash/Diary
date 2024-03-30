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
    public partial class AcademicPerformance : Form
    {
        public string email;
        public bool admin;
        public Performance performance;
        public List<string> disciplines = new List<string>();
        public AcademicPerformance()
        {
            InitializeComponent();
        }

        public AcademicPerformance(string Email)
        {
            email = Email;
            InitializeComponent();
        }

        public AcademicPerformance(string Email, bool Admin)
        {
            email = Email;
            admin = Admin;
            InitializeComponent();
        }


        private void GoBackButton1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }

        private void AcademicPerformance_Load(object sender, EventArgs e)
        {
            if (admin) { }
            else
            {
                button1.Hide();
                button3.Hide();
            }

            Update_Table();
            
        }


        public void Update_Table()
        {
            dataGridView1.Rows.Clear();
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM performance WHERE  email = @mail", db.GetConnection());
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();

            List<Performance> performances = new List<Performance>();


            while (reader.Read())
            {
                Performance performance = new Performance();
                performance.email = reader[1].ToString();
                performance.discipline = reader[2].ToString();
                performance.ball1 = reader[3].ToString();
                performance.tip = reader[4].ToString();
                performance.ball2 = reader[5].ToString();
                performance.date_exam = reader[6].ToString();
                performance.itog = reader[7].ToString();
                performances.Add(performance);
                disciplines.Add(reader[2].ToString());

            }
            db.CloseConnection();

            for (int i = 0; i<performances.Count; i++)

            {
                dataGridView1.Rows.Add(performances[i].discipline, performances[i].ball1, performances[i].tip, performances[i].ball2, performances[i].date_exam, performances[i].itog );
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddPerformance addPerformance= new AddPerformance(email);
            addPerformance.ShowDialog();
            Update_Table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Del_discipline del_discipline = new Del_discipline(disciplines);
            del_discipline.ShowDialog();
            Update_Table();
        }
    }
}
