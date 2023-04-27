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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП_ИСРПО
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnDobav_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string Код_поезда = textBox1.Text.Trim();
                string Код_маршрута = textBox2.Text.Trim();
                string Пункт_отправление = textBox3.Text.Trim();
                string Пункт_прибытия = textBox4.Text.Trim();
                string Станция = textBox5.Text.Trim();
                string Регион = textBox6.Text.Trim();
                string Дата_отправление = textBox7.Text.Trim();
                string Дата_прибытия = textBox8.Text.Trim();

                SqlConnection con1 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                string insertquery = "INSERT INTO Расписание(Код_поезда,Код_маршрута, Пункт_отправление,Пункт_прибытия,Станция,Регион,Дата_отправление,Дата_прибытия) VALUES ('" + Код_поезда + "','" + Код_маршрута + "','" + Пункт_отправление + "','" + Пункт_прибытия + "','" + Станция + "','" + Регион + "','" + Дата_отправление + "','" + Дата_прибытия + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con1);
                con1.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Вы успешно добавили расписание");
                Добавление_маршрута.ActiveForm.Close();
                con1.Close();

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr1 = new Form3();
            fr1.Show();
        }
    }
}
