using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_ИСРПО
{
    public partial class Добавление_маршрута : Form
    {
        public Добавление_маршрута()
        {
            InitializeComponent();
        }

        private void Добавление_маршрута_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet5.Маршруты". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet4.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.solovevkDataSet4.Маршруты);

        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!= "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string Код_поезда = comboBox1.Text.Trim();
                string Пункт_отправление = textBox1.Text.Trim();
                string Пункт_прибытия = textBox2.Text.Trim();
                string Дата_отправление = textBox3.Text.Trim();
                string Цена_билета = comboBox2.Text.Trim();
                string Станция = textBox4.Text.Trim();

                SqlConnection con1 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                string insertquery = "INSERT INTO Маршруты(Код_поезда, Пункт_отправление,Пункт_прибытия,Дата_отправление,Цена_билета,Станция) VALUES ('" + Код_поезда + "','" + Пункт_отправление + "','" + Пункт_прибытия + "','" + Дата_отправление + "','" + Цена_билета + "','"+ Станция + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con1);
                con1.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Вы успешно добавили маршрут");
                //Добавление_маршрута.ActiveForm.Close();
                //con1.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная fr1 = new Главная();
            fr1.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
