using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Coloring_3_Methods
{
    public partial class MatrixForm : Form
    {
        private int countVertices = 0;
        private int countEdges = 0;

        public MatrixForm()
        {
            InitializeComponent();
        }

        // Публичное свойство для получения количества вершин
        public int CountVertices
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int result))
                    return result;
                else
                    throw new InvalidOperationException("Неверный ввод для количества вершин.");
            }
        }

        // Публичное свойство для получения количества рёбер
        public int CountEdges
        {
            get
            {
                if (int.TryParse(textBox2.Text, out int result))
                    return result;
                else
                    throw new InvalidOperationException("Неверный ввод для количества рёбер.");
            }
        }

        // Метод для создания матрицы смежности
        public void CreateAdjacencyMatrix(int size)
        {
            if (size < 1 || size > 6)
                throw new ArgumentOutOfRangeException("Размер матрицы должен быть от 1 до 6.");

            dataGridViewAdjacencyMatrix.Columns.Clear();
            dataGridViewAdjacencyMatrix.Rows.Clear();

            // Добавляем столбцы
            for (int i = 0; i < size; i++)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = (i + 1).ToString(),
                    Width = 40,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dataGridViewAdjacencyMatrix.Columns.Add(column);
            }

            // Добавляем строки
            for (int i = 0; i < size; i++)
            {
                dataGridViewAdjacencyMatrix.Rows.Add();
                dataGridViewAdjacencyMatrix.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            // Ограничиваем размер
            dataGridViewAdjacencyMatrix.MaximumSize = new Size(size * 50 + 20, size * 22 + 20);
        }

        // Метод для получения матрицы смежности
        public int[,] GetAdjacencyMatrix()
        {
            int size = dataGridViewAdjacencyMatrix.Columns.Count;
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    string cellValue = dataGridViewAdjacencyMatrix.Rows[i].Cells[j].Value?.ToString() ?? "0";
                    if (int.TryParse(cellValue, out int val) && (val == 0 || val == 1))
                    {
                        matrix[i, j] = val;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Неверное значение в ячейке ({i + 1}, {j + 1}). Используйте 0 или 1.");
                    }
                }
            }

            return matrix;
        }
    }
}
