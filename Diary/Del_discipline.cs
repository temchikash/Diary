using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Diary
{
    public partial class Del_discipline : Form
    {
        public List<string> disciplines;
        public Del_discipline()
        {
            InitializeComponent();
        }
        public Del_discipline(List<string> Disciplines)
        {
            disciplines = Disciplines;
            InitializeComponent();
        }
        private void Del_discipline_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < disciplines.Count; i++)
            {
                comboBox1.Items.Add(disciplines[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM performance WHERE discipline = @dis", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@dis", MySqlDbType.VarChar).Value = comboBox1.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);// записываем данные в объект класса DataTable

            if(disciplines.Contains(comboBox1.Text))
            {
                MessageBox.Show("Успешно удалено!");
                disciplines.Clear();
                db.CloseConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такой группы не существует");
            }
            db.CloseConnection();


            
            
        }
    }
}
