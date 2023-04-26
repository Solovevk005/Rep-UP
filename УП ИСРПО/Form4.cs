using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet1.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter.Fill(this.solovevkDataSet1.Продажа_билетов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr1= new Form3();
            fr1.Show();
        }
    }
}
