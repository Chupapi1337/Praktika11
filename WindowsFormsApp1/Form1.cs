using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.ID_Sposob_oplati". При необходимости она может быть перемещена или удалена.
            this.iD_Sposob_oplatiTableAdapter.Fill(this.testDataSet.ID_Sposob_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.ID_Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.iD_SotrudnikTableAdapter.Fill(this.testDataSet.ID_Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.ID_Klient". При необходимости она может быть перемещена или удалена.
            this.iD_KlientTableAdapter.Fill(this.testDataSet.ID_Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.ID_Mesto". При необходимости она может быть перемещена или удалена.
            this.iD_MestoTableAdapter.Fill(this.testDataSet.ID_Mesto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.ID_Nazvanie_filma". При необходимости она может быть перемещена или удалена.
            this.iD_Nazvanie_filmaTableAdapter.Fill(this.testDataSet.ID_Nazvanie_filma);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Pokupka_biletov". При необходимости она может быть перемещена или удалена.
            this.pokupka_biletovTableAdapter.Fill(this.testDataSet.Pokupka_biletov);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            pokupka_biletovTableAdapter.Update(testDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }
    }
}
