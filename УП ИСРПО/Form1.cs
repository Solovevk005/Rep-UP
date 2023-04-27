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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvtor_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                string query = "Select * FROM Пользователи  WHERE Логин='" + txtLogin.Text + "' and Пароль='" + txtPassword.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        object Login = rdr.GetValue(0);
                        object Password = rdr.GetValue(1);
                        object Role = rdr.GetValue(2);
                        string user_Login = Login.ToString();
                        string password_Login = Password.ToString();
                        string role_Login = Role.ToString();
                        if (role_Login == "True")
                        {
                            Form3 frm3 = new Form3();
                            frm3.btnDelete_1.Visible = true;
                            frm3.btnSave_1.Visible = true;
                            frm3.btnDobovlenie_1.Visible = true;
                            frm3.btnDobovlenie.Visible = true;
                            frm3.btnDelete.Visible = true;
                            frm3.button10.Visible = true;
                            frm3.Show();
                            this.Hide();
                        }
                        else if (role_Login == "False")
                        {
                            Form3 frm5 = new Form3();
                            frm5.btnDelete_1.Visible = false;
                            frm5.btnSave_1.Visible = false;
                            frm5.btnDobovlenie_1.Visible = false;
                            frm5.btnDobovlenie.Visible = false;
                            frm5.btnDelete.Visible = false;
                            frm5.button10.Visible = false;
                            frm5.Show();
                            this.Hide();
                        }
                    }
                }
        }


        private void btnreg_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
