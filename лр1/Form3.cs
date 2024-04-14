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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        static double Factorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // Функция для вычисления F(x) по ряду Тейлора
        static double TaylorSeries(double x, double epsilon)
        {
            double sum = 1; // Первый член ряда
            double term = 1; // Текущий член ряда
            int n = 1; // Индекс текущего члена ряда

            // Пока модуль разности между последующим и предыдущим членами ряда не будет меньше или равен epsilon
            while (Math.Abs(term) >= epsilon)
            {
                term *= Math.Pow(-1, n - 1) * Math.Pow(x, 2 * n) / Factorial(2 * n); // Вычисляем следующий член ряда
                sum += term; // Добавляем его к сумме
                n++;
            }

            return sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double epsilon = 0.001; // Заданное значение epsilon
            double x1 = -2;
            double x2 = 0.98;
            double x3 = 15;

            // Вычисляем F(x) для каждого значения x
            double result1 = TaylorSeries(x1, epsilon);
            double result2 = TaylorSeries(x2, epsilon);
            double result3 = TaylorSeries(x3, epsilon);

            // Выводим результаты на Label4
            label4.Text = $"F({x1}) = {result1}\nF({x2}) = {result2}\nF({x3}) = {result3}";
        }
    }
}
