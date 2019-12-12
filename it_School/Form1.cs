using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_School
{
    public partial class MainForm : Form
    {
        private static MainForm Instance;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm.Instance.dataGridView1.Show();
            MainForm.Instance.dataGridView2.Show();
            Instance.textBox1.Show();
            Instance.comboBox1.Show();
            MainForm.Instance.label1.Show();
            MainForm.Instance.label1.Show();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MainForm.Instance.button1.Show();
            MainForm.Instance.insert_button.Show();
            MainForm.Instance.add_button.Show();
            MainForm.Instance.button6.Show();
            MainForm.Instance.search_button.Show();
            MainForm.Instance.update_button.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
