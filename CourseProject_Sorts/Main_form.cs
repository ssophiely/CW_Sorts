using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_Sorts
{
    public partial class Main_form : Form
    {
        private ArrayInitialization in1;
        private Random r = new Random();
        private const int k = 10;
        public Main_form()
        {
            InitializeComponent();
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            // Очистка таблицы и графика
            sortingDataTable.Rows.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            // Инициализация массива
            int size = (int)numericUpDown_size.Value;
            in1 = new ArrayInitialization(size);

            string type;
            if (radioButton_o.Checked)
            {
                in1.Ordered();
                type = "Упорядоченный";
            }
            else if (radioButton_ro.Checked)
            {
                in1.ReverseOrdered();
                type = "Упорядоченный в обратном порядке";
            }
            else if (radioButton_po.Checked)
            {
                double percent = (int)numericUpDown_percent.Value / 100;
                in1.PartOrdered(percent);
                type = "Частично упорядоченный";
            }
            else
            {
                in1.NonOrdered();
                type = "Неупорядоченный";
            }

            // Сортировка
            int N = in1.GetLength();
            int n = N / k + N % 10;
            while (n <= N)
            {
                int StartTime1 = Environment.TickCount;
                Sorting.Direct_choice((int[])in1.GetArray().Clone(), n);
                int ResultTime1 = Environment.TickCount - StartTime1;

                int StartTime2 = Environment.TickCount;
                Sorting.Direct_choice_minmax((int[])in1.GetArray().Clone(), n);
                int ResultTime2 = Environment.TickCount - StartTime2;

                int StartTime3 = Environment.TickCount;
                Sorting.Direct_inclusion((int[])in1.GetArray().Clone(), n);
                int ResultTime3 = Environment.TickCount - StartTime3;

                CreateDataGridView(type, n, ResultTime1, ResultTime3, ResultTime2);
                n += N / k;
            }

            // Выравнивание строк
            foreach (DataGridViewRow row in sortingDataTable.Rows)
            {
                row.Height = (sortingDataTable.ClientRectangle.Height - sortingDataTable.ColumnHeadersHeight) / sortingDataTable.Rows.Count;
            }

            CreateChart(type);
        }


        // Добавление строк в таблицу
        public void CreateDataGridView(string type, int n, int t1, int t2, int t3)
        {
            string[] row = new string[] { type, n.ToString(), t1.ToString(), t2.ToString(), t3.ToString() };
            sortingDataTable.Rows.Add(row);
        }

        // Создание графика
        public void CreateChart(string t)
        {
            int[,] array1 = new int[k, 2]; // значения методом выбора
            int[,] array2 = new int[k, 2]; // значения методом включения
            int[,] array3 = new int[k, 2]; // значением методом двойного выбора 

            for (int i = 0; i < k; i++)
            {
                int k2 = 1;
                int k3 = 1;
                for (int j = 0; j < 2; j++)
                {
                    array1[i, j] = int.Parse(sortingDataTable.Rows[i].Cells[j + 1].Value.ToString());
                    array2[i, j] = int.Parse(sortingDataTable.Rows[i].Cells[j + k2].Value.ToString());
                    array3[i, j] = int.Parse(sortingDataTable.Rows[i].Cells[j + k3].Value.ToString());
                    k2 = 2;
                    k3 = 3;
                }
            }

            chart1.Titles[0].Text = "График зависимости времени сортировок от размера массива (" + t.ToLower() + ')';
            for (int i = 0; i < k; i++)
            {
                chart1.Series[0].Points.AddXY(array1[i, 0], array1[i, 1]);
                chart1.Series[1].Points.AddXY(array2[i, 0], array2[i, 1]);
                chart1.Series[2].Points.AddXY(array3[i, 0], array3[i, 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown_size_DoubleClick(object sender, EventArgs e)
        {
            numericUpDown_size.Value = r.Next(10000, 30000);
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            numericUpDown_size.Value = r.Next(10000, 30000);
            numericUpDown_percent.Value = r.Next(1, 101);
            sortingDataTable.RowTemplate.MinimumHeight = 50;
        }

        private void numericUpDown_percent_DoubleClick(object sender, EventArgs e)
        {
            numericUpDown_percent.Value = r.Next(1, 101);
        }

        private void OpenTable(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
