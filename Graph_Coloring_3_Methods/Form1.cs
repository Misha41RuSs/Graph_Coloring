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
    public partial class Form1 : Form
    {
        private Graphics graphEgitorBox;
        private Graph graph;
        private int countVertices = 0;
        private int countEdges = 0;
        private bool addVertexClicked = false;
        private bool removeObjectClicked = false;
        private bool addEdgeClicked = false;
        private Color activeButtonColor = Color.FromArgb(25, 106, 143);
        private Color passiveButtonColor = Color.FromArgb(73, 76, 120);
        private Form activeForm = null;

        public Form1()
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
        private void SetButtonColors(Button activeButton)
        {
            // Обновляем цвета кнопок
            addVertexButton.BackColor = (activeButton == addVertexButton) ? activeButtonColor : passiveButtonColor;
            addEdgeButton.BackColor = (activeButton == addEdgeButton) ? activeButtonColor : passiveButtonColor;
            MoveVertexButton.BackColor = (activeButton == MoveVertexButton) ? activeButtonColor : passiveButtonColor;
            deleteVertexButon.BackColor = (activeButton == deleteVertexButon) ? activeButtonColor : passiveButtonColor;
            deleteEdgeButton.BackColor = (activeButton == deleteEdgeButton) ? activeButtonColor : passiveButtonColor;
        }
        private void customizeDesign()
        {
            panelDrawingSubmenu.Visible = false;
            panel4.Visible = false;
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
                SetButtonColors(addVertexButton);
                addVertexClicked = true;
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
            openChildForm(new Form2());
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
            openChildForm(new MatrixForm());
            showSubmenu(panel4);
        }

        private void addVertexButton_Click(object sender, EventArgs e)
        {
            SetButtonColors(addVertexButton);
            addVertexClicked = true;
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            SetButtonColors(addEdgeButton);
            addEdgeClicked = true;
        }

        private void MoveVertexButton_Click(object sender, EventArgs e)
        {
            SetButtonColors(MoveVertexButton);
        }

        private void deleteVertexButon_Click(object sender, EventArgs e)
        {
            SetButtonColors(deleteVertexButon);
            removeObjectClicked = true;
        }

        private void deleteEdgeButton_Click_1(object sender, EventArgs e)
        {
            SetButtonColors(deleteEdgeButton);
            removeObjectClicked = true;
        }
        private void openChildForm(Form childform) 
        {
            if (activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childform);
            this.panel3.Tag = childform;
            childform.BringToFront();
            childform.Show();
            label4.Text = childform.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Необходимо реализовать логику , чтобы при нажатии на эту кнопку считывались данные из класса
            // MatrixForm из textbox1 и textbox2 в переменные того же класса countVertices и countEdges
        }
    }
}
