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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solovevkDataSet2.Возврат_билетов". При необходимости она может быть перемещена или удалена.
            this.возврат_билетовTableAdapter.Fill(this.solovevkDataSet2.Возврат_билетов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr1 = new Form3();
            fr1.Show();
        }
    }
}
