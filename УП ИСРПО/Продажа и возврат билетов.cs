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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet13.Возврат_билетов". При необходимости она может быть перемещена или удалена.
            this.возврат_билетовTableAdapter1.Fill(this.solovevkDataSet13.Возврат_билетов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet12.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter2.Fill(this.solovevkDataSet12.Продажа_билетов);

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
            SqlDataAdapter продажа_билетовTableAdapter2 = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(продажа_билетовTableAdapter2);
            SolovevkDataSet13 solovevkDataSet = new SolovevkDataSet13();
            продажа_билетовTableAdapter2.Update(solovevkDataSet12.Продажа_билетов);
            MessageBox.Show("Вы успешно обновили базу даныых");
        }

        private void btnVozvr_Click(object sender, EventArgs e)
        {
            Возврат_билетов frm = new Возврат_билетов();
            frm.Show();
            this.Hide();
        }
    }
}
