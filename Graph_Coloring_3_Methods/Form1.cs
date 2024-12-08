using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Graph_Coloring_3_Methods
{
    public partial class From1 : Form
    {
        private Graphics graphEgitorBox;
        private Graph graph;
        private int countVertices = 0;
        private int countEdges = 0;

        public From1()
        {
            InitializeComponent();
            customizeDesign();
            graphEgitorBox = pictureBox1.CreateGraphics();
            graph = new Graph(graphEgitorBox);

            ClearEditorPictureBox();
            toolTip1.SetToolTip(addVertexButton, "Добавить вершину");
            toolTip2.SetToolTip(addEdgeButton, "Добавить ребро");
            toolTipGraph.SetToolTip(buttonMatrix, "Задать граф матрицей смежности");
        }
        private void customizeDesign()
        {
            panelDrawingSubmenu.Visible = false;
        }
        private void hideSubmenu() 
        {
            if (panelDrawingSubmenu.Visible == true)
                panelDrawingSubmenu.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ClearEditorPictureBox()
        {
            graphEgitorBox.Clear(Color.White);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (addVertexButton.Focused)
            {
                graph.AddVertex(new Point(e.X, e.Y));
                countVertices++;
            }
            else if (addEdgeButton.Focused)
            {
                if (graph.CheckIfClickedOnVert(new Point(e.X, e.Y)) && graph.CountSelectedVertexes() == 2)
                {
                    graph.AddRib();
                    countEdges++;
                }
            }
            else if (deleteVertexButon.Focused)
            {
                graph.DeleteVertex(new Point(e.X, e.Y));
                ClearEditorPictureBox();
                graph.DrawGraph();
            }
            else if (deleteEdgeButton.Focused &&
                     graph.CheckIfClickedOnVert(new Point(e.X, e.Y)) &&
                     graph.CountSelectedVertexes() == 2)
            {
                graph.DeleteRib();
                ClearEditorPictureBox();
                graph.UnselectAll();
                graph.DrawGraph();
            }
            else if (MoveVertexButton.Focused)
            {
                if (graph.CheckIfClickedOnVert(new Point(e.X, e.Y)))
                {
                    if (graph.CountSelectedVertexes() == 2)
                    {
                        ClearEditorPictureBox();
                        graph.UnselectAll();
                        graph.DrawGraph();
                    }
                }
                else
                {
                    graph.MoveVertex(new Point(e.X, e.Y));
                    ClearEditorPictureBox();
                    graph.DrawGraph();
                }
            }
        }

        private void colorGraphButton_Leave(object sender, EventArgs e)
        {
            ClearEditorPictureBox();
            graph.DrawGraph();
        }

        private void colorGraphButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            try
            {
                if (countEdges < 1 && countVertices < 2)
                {
                    throw new InvalidOperationException("В графе должно быть хотя бы две вершины.");
                }
                if (!ifSlowModeCheckBox.Checked)
                {
                    DateTime StartTime = DateTime.Now;
                    graph.Greedy(ifSlowModeCheckBox.Checked);
                    TimeSpan ts = DateTime.Now.Subtract(StartTime);
                    textBox1.Text = ts.Milliseconds.ToString();
                }
                else { graph.Greedy(ifSlowModeCheckBox.Checked); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (countEdges < 1 && countVertices < 2)
                {
                    throw new InvalidOperationException("В графе должно быть хотя бы две вершины.");
                }
                if (!ifSlowModeCheckBox.Checked)
                {
                    DateTime StartTime = DateTime.Now;
                    graph.Backtracking(ifSlowModeCheckBox.Checked);
                    TimeSpan ts = DateTime.Now.Subtract(StartTime);
                    textBox1.Text = ts.Milliseconds.ToString();
                }
                else { graph.Backtracking(ifSlowModeCheckBox.Checked); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteEdgeButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph.ClearColors();
        }

        private void colorGraphButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubmenu(panelDrawingSubmenu);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти?", "Выход из программы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                MessageBox.Show("До свидания!", "Выход из программы",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            
        }

        private void buttonMatrix_Click(object sender, EventArgs e)
        {
            
        }
    }
}
