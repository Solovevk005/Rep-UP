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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace УП_ИСРПО
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        //    txtPassword_R.PasswordChar = '*';
        //    txtPodver.PasswordChar= '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtLogin_R.Text != "" && txtPassword_R.Text != "" && txtPodver.Text != "" && txtRole.Text != "")
            {
                if (txtPodver.Text == txtPassword_R.Text)
                {
                    string Логин = txtLogin_R.Text.Trim();
                    string Пароль = txtPassword_R.Text.Trim();
                    string Роль = txtRole.Text.Trim();
                    if (CheckPassword(Пароль))
                    {
                        SqlConnection con1 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                        string query = "Select * FROM Пользователи  WHERE Логин='" + txtLogin_R.Text + "' and Пароль='" + txtPassword_R.Text + "'";
                        con1.Open();
                        SqlCommand cmd = new SqlCommand(query, con1);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже сушествует");
                            reader.Close();
                            MessageBox.Show("Вы зарегистрированы");
                            Регистрация.ActiveForm.Close();

                        }
                        else
                        {
                            reader.Close();
                            string insertquery = "INSERT INTO Пользователи (Логин, Пароль,Роль) VALUES ('" + Логин + "','" + Пароль + "','"+Роль+"')";
                            SqlCommand cmd2 = new SqlCommand(insertquery, con1);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы");


                        }
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен содержать минимум 6 символов, включая как минимум 1 прописную букву, 1 цифру и 1 символ из набора: ! @ # $ % ^.");
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

        private bool CheckPassword(string Password)
        {
            // Проверяем длину пароля
            if (Password.Length < 6)
                return false;

            // Проверяем наличие прописных букв
            if (!Regex.IsMatch(Password, "[A-Z]"))
                return false;

            // Проверяем наличие цифр
            if (!Regex.IsMatch(Password, "[0-9]"))
                return false;

            // Проверяем наличие специальных символов
            if (!Regex.IsMatch(Password, "[!@#$%^]"))
                return false;

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLogin_R.Text = "";
            txtPassword_R.Text = "";
            txtPodver.Text = "";
        }

        private void BtnClose_R_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация fr = new Авторизация();
            fr.Show();
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
