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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, что введены значения для A и B
            if (double.TryParse(textBox1.Text, out double A) && double.TryParse(textBox2.Text, out double B))
            {
                // Вычисляем выражение
                double result = Math.Pow(Math.Cos(A + Math.Pow(B, 2)), 3) * Math.Sqrt(Math.Exp(Math.Pow(A, 2) - 13.4 * B) / Math.Pow(A + B, 3));

                // Выводим результат на Label4
                label4.Text = $"Значение выражения: {result:F4}";
            }
            else
            {
                // Выводим сообщение об ошибке, если введены некорректные значения
                MessageBox.Show("Пожалуйста, введите корректные значения для A и B.");
            }
        }
    }
}
