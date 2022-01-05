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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("02.2020", "Тюмень", "Согласование в ОМСУ", "01.01.2020");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            //Form ifr = new Form6();
            //ifr.Show();
            //this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            //Form ifrm = new Form5();
            //ifrm.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
        }

        private void button1_Click(object sender, EventArgs e) //Открыть карту
        {
            //Form ifd = new Form2();
            //ifd.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form ifrm = new Form3();
            //ifrm.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
