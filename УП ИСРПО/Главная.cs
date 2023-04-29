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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet17.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter2.Fill(this.solovevkDataSet17.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet16.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter2.Fill(this.solovevkDataSet16.Расписание);
           
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            Form4 fr3 = new Form4();
            fr3.Show();
            this.Hide();

        }

        
        //поиск динамический
        private void txtPoisk_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtPoisk.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        //фильтр
        private void btnFiltr_1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFiltr.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        //поиск
        private void btnPoisk_1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtPoisk.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        //удаление
        private void btnDelete_1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void btnDobovlenie_Click(object sender, EventArgs e)
        {
            Добавление_маршрута frm4 = new Добавление_маршрута();
            frm4.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPoisk_1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(txtPoisk_1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(txtPoisk_1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }

        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.CurrentCell = null;
                dataGridView2.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(txtFiltr_1.Text))
                    {
                        dataGridView2.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
        }

        private void btnSave_1_Click(object sender, EventArgs e)
        {
            string sql = @"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter расписаниеTableAdapter2 = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(расписаниеTableAdapter2);
            SolovevkDataSet16 solovevkDataSet16 = new SolovevkDataSet16();
            расписаниеTableAdapter2.Update(solovevkDataSet16.Расписание);
            MessageBox.Show("Вы успешно обновили базу даныых");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter МаршрутыTableAdapter2 = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(МаршрутыTableAdapter2);
            SolovevkDataSet17 solovevkDataSet17 = new SolovevkDataSet17();
            маршрутыTableAdapter2.Update(solovevkDataSet17.Маршруты);
            MessageBox.Show("Вы успешно обновили базу даныых");
        }

        private void btnDobovlenie_1_Click(object sender, EventArgs e)
        {
            Form6 frm= new Form6();
            frm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация fr = new Авторизация();
            fr.Show();
        }

        private void txtFiltr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
