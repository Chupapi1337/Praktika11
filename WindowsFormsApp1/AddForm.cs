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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbCena.Text;
                nRow[2] = tbNomer.Text;
                main.testDataSet.Tables[8].Rows.Add(nRow);
                main.pokupka_biletovTableAdapter.Update(main.testDataSet.Pokupka_biletov);
                main.testDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                tbCena.Text = "";
                tbNomer.Text = "";
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
