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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet6.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.solovevkDataSet6.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet3.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.solovevkDataSet3.Расписание);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr3 = new Form4();
            fr3.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fr2 = new Form5();
            fr2.Show();
            this.Hide();
        }
        
        //поиск динамический
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

        //фильтр
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        //поиск
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

        //удаление
        private void button5_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.CurrentCell = null;
                dataGridView2.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                    {
                        dataGridView2.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = @"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter РасписаниеTableAdapter = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(РасписаниеTableAdapter);
            SolovevkDataSet3 solovevkDataSet = new SolovevkDataSet3();
            расписаниеTableAdapter.Update(solovevkDataSet3.Расписание);
            MessageBox.Show("Вы успешно обновили базу даныых");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql = @"Data Source=KONSTANTIN\SQLEXPRESS;Integrated Security=True;Initial Catalog=Solovevk";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter МаршрутыTableAdapter = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(МаршрутыTableAdapter);
            SolovevkDataSet6 solovevkDataSet = new SolovevkDataSet6();
            маршрутыTableAdapter.Update(solovevkDataSet6.Маршруты);
            MessageBox.Show("Вы успешно обновили базу даныых");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form6 frm= new Form6();
            frm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
