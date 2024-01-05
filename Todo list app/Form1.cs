using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_list_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow != null)
            {
                dataGridView2.CurrentRow.Cells["taskid"].Value = textBox1.Text;
                dataGridView2.CurrentRow.Cells["task"].Value = textBox2.Text;
                dataGridView2.CurrentRow.Cells["date"].Value = dateTimePicker1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
    }
}
