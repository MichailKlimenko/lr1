using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Входные значения
            double x = 0.1722;
            double y = 6.33;
            double z = 3.25 * Math.Pow(10, -4);

            // Расчет формулы
            double result = (5 * Math.Atan(x)) - (1.0 / 4) * (Math.Atan(x) * ((x + 3 * (Math.Abs(x - y)) + Math.Pow(x, 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2))));

            // Вывод результата
            label4.Text = result.ToString();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
