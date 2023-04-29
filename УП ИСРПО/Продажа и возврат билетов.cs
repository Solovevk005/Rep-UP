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
    public partial class Form4 : Form
    {
        

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet22.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter.Fill(this.solovevkDataSet22.Продажа_билетов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet21.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter7.Fill(this.solovevkDataSet21.Продажа_билетов);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet15.Возврат_билетов". При необходимости она может быть перемещена или удалена.
            this.возврат_билетовTableAdapter2.Fill(this.solovevkDataSet15.Возврат_билетов);




        }

        private void btnClose_P_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная fr1 = new Главная();
            fr1.Show();
        }

        private void btnKupit_Click(object sender, EventArgs e)
        {

            Form5 fr1 = new Form5();
            fr1.Show();
            this.Hide();
        }

        private void btnUpdate_1_Click(object sender, EventArgs e)
        {
            string sql = @"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter Продажа_билетовTableAdapter7 = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(Продажа_билетовTableAdapter7);
            SolovevkDataSet21 solovevkDataSet21 = new SolovevkDataSet21();
            продажа_билетовTableAdapter7.Update(solovevkDataSet21.Продажа_билетов);
            MessageBox.Show("Вы успешно обновили базу данных");
        }
       

        private void btnVozvr_Click(object sender, EventArgs e)
        {
            Возврат_билетов frm = new Возврат_билетов();
            frm.Show();
            this.Hide();
        }

        //private void btnKup_Click(object sender, EventArgs e)
        //{
        //    // Обновляем статус заказа в таблице "Заказы"
        //    string status = "Куплен";
        //    string marshrut = textBox1.Text;
        //    using (SqlConnection connection2 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk"))
        //    {
        //        connection2.Open();
        //        string query2 = "UPDATE Продажа_билетов SET Статус_покупки = @Status WHERE Маршрут = @marshrut";
        //        using (SqlCommand command2 = new SqlCommand(query2, connection2))
        //        {
        //            command2.Parameters.AddWithValue("@Status", status);
        //            command2.Parameters.AddWithValue("@marshrut", marshrut);
        //            command2.ExecuteNonQuery();
        //        }
        //        MessageBox.Show("Вы успешно купили билет!");
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            // Обновляем количество билетов и статус заказа в таблице "Заказы"
            string marshrut = textBox1.Text;
            using (SqlConnection connection = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk"))
            {
                connection.Open();
                // Получаем текущее количество билетов
                string query1 = "SELECT Колво_билетов FROM Продажа_билетов WHERE Маршрут = @marshrut";
                int availableTickets = 0;
                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@marshrut", marshrut);
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            availableTickets = reader.GetInt32(0);
                        }
                    }
                }
                // Если билетов больше нет, выводим соответствующее сообщение
                if (availableTickets == 0)
                {
                    MessageBox.Show("Извините, все билеты уже проданы!");
                    return;
                }
                // Обновляем количество билетов и статус заказа
                string query2 = "UPDATE Продажа_билетов SET Колво_билетов = @newTickets, Статус_покупки = 'Куплен' WHERE Маршрут = @marshrut";
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@newTickets", availableTickets - 1);
                    command2.Parameters.AddWithValue("@marshrut", marshrut);
                    command2.ExecuteNonQuery();
                }
                MessageBox.Show("Вы успешно купили билет!");
            }
        }
    }
}
