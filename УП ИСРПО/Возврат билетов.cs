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
    public partial class Возврат_билетов : Form
    {
        public Возврат_билетов()
        {
            InitializeComponent();
        }

        private void btnVozvr_Click(object sender, EventArgs e)
        {
            if (txtProdaj.Text != "" && txtbilet_1.Text != "" && txtPassaj.Text != "" && txtCenna.Text != "" && txtdatevoz.Text != "")
            {
                string Код_продажи = txtProdaj.Text.Trim();
                string Код_билета = txtbilet_1.Text.Trim();
                string Код_пассажира = txtPassaj.Text.Trim();
                string ФИО_пассажира = txtFIO.Text.Trim();  
                string Цена_билета = txtCenna.Text.Trim();
                string Дата_возврата = txtdatevoz.Text.Trim();




                SqlConnection con1 = new SqlConnection(@"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk");
                string insertquery = "INSERT INTO Возврат_билетов(Код_продажи, Код_билета,Код_пассажира,Фамилия_пассажира,Цена_билета,Дата_возврата) VALUES ('" + Код_продажи + "','" + Код_билета + "','" + Код_пассажира + "','" + ФИО_пассажира + "','" + Цена_билета + "','"+ Дата_возврата + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con1);
                con1.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Вы успешно совершили возврат");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fr1 = new Form4();
            fr1.Show();
        }
    }
}
