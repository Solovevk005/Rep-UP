using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace УП_ИСРПО
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        

        }

        private void btnClose_V_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fr1 = new Form4();
            fr1.Show();
        }

        private void btnDobav_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && txtbilet.Text != "" && txtPas.Text != "" && txtdateP.Text != "" && txtCena.Text != "")
            {
                string Билет = txtbilet.Text.Trim();
                string Пассажир = txtPas.Text.Trim();
                string Дата_продажи = txtdateP.Text.Trim();
                string Цена_билета = txtCena.Text.Trim();
                string Способ_оплаты = comboBox1.Text.Trim();
               

                SqlConnection con1 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                string insertquery = "INSERT INTO Продажа_билетов(Код_билета, Код_пассажира,Дата_продажи,Цена_билета,Способ_оплаты) VALUES ('" + Билет + "','" + Пассажир + "','" + Дата_продажи + "','" + Цена_билета + "','" + Способ_оплаты + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con1);
                con1.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Вы успешно купили билет");
                //Добавление_маршрута.ActiveForm.Close();
                //con1.Close();

            }
        }
    }
}

