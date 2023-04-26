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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox3.Text == textBox2.Text)
                {
                    if (textBox2.Text.Length >= 6 && textBox3.Text.Length >= 6)

                    {
                        string Логин = textBox1.Text.Trim();
                        string Пароль = textBox2.Text.Trim();


                        SqlConnection con1 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                        string query = "Select * FROM Пользователи  WHERE Логин='" + textBox1.Text + "' and Пароль='" + textBox2.Text + "'";
                        con1.Open();
                        SqlCommand cmd = new SqlCommand(query, con1);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже сушествует");
                            reader.Close();
                            MessageBox.Show("Вы зарегистрированы");
                            Form2.ActiveForm.Close();

                        }
                        else
                        {
                            reader.Close();
                            string insertquery = "INSERT INTO Пользователи (Логин, Пароль) VALUES ('" + Логин + "','" + Пароль + "')";
                            SqlCommand cmd2 = new SqlCommand(insertquery, con1);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы");


                        }
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен иметь длину больше или равно 6 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли должные совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
