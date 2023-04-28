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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet19.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter5.Fill(this.solovevkDataSet19.Продажа_билетов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet18.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter4.Fill(this.solovevkDataSet18.Продажа_билетов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet15.Возврат_билетов". При необходимости она может быть перемещена или удалена.
            this.возврат_билетовTableAdapter2.Fill(this.solovevkDataSet15.Возврат_билетов);
            
            this.возврат_билетовTableAdapter1.Fill(this.solovevkDataSet13.Возврат_билетов);
            

        }

        private void btnClose_P_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная fr1= new Главная();
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
            SqlDataAdapter продажа_билетовTableAdapter5 = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(продажа_билетовTableAdapter5);
            SolovevkDataSet19 solovevkDataSet19 = new SolovevkDataSet19();
            продажа_билетовTableAdapter5.Update(solovevkDataSet19.Продажа_билетов);
            MessageBox.Show("Вы успешно обновили базу даныых");
        }

        private void btnVozvr_Click(object sender, EventArgs e)
        {
            Возврат_билетов frm = new Возврат_билетов();
            frm.Show();
            this.Hide();
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            // Обновляем статус заказа в таблице "Заказы"
            string status = "Выполнен";
            using (SqlConnection connection2 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk"))
            {
                connection2.Open();
                string query2 = "UPDATE Продажа_билетов SET Статус_покупки = @Status WHERE Код_продажи = @kod_prodaji";
                using (SqlCommand command2 = new SqlCommand(query2, connection2))
                {
                    command2.Parameters.AddWithValue("@Status", status);
                    command2.Parameters.AddWithValue("@kod_prodaji", kod_prodaji);
                    command2.ExecuteNonQuery();
                }
            }
        }
    }
}
