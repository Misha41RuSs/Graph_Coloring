﻿namespace Graph_Coloring_3_Methods
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.colorGraphButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMatrix = new System.Windows.Forms.Button();
            this.panelDrawingSubmenu = new System.Windows.Forms.Panel();
            this.deleteEdgeButton = new System.Windows.Forms.Button();
            this.deleteVertexButon = new System.Windows.Forms.Button();
            this.MoveVertexButton = new System.Windows.Forms.Button();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.addVertexButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTipGraph = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ifSlowModeCheckBox = new Graph_Coloring_3_Methods.RJToggleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDrawingSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(37, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // colorGraphButton
            // 
            this.colorGraphButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorGraphButton.FlatAppearance.BorderSize = 0;
            this.colorGraphButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.colorGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorGraphButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorGraphButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("colorGraphButton.Image")));
            this.colorGraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorGraphButton.Location = new System.Drawing.Point(0, 658);
            this.colorGraphButton.Name = "colorGraphButton";
            this.colorGraphButton.Size = new System.Drawing.Size(258, 88);
            this.colorGraphButton.TabIndex = 6;
            this.colorGraphButton.Text = "Жадная раскраска";
            this.colorGraphButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorGraphButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.colorGraphButton.UseVisualStyleBackColor = true;
            this.colorGraphButton.Click += new System.EventHandler(this.colorGraphButton_Click);
            this.colorGraphButton.Leave += new System.EventHandler(this.colorGraphButton_Leave);
            this.colorGraphButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorGraphButton_MouseClick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 90);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рекурсивный метод";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время раскраски: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(286, 641);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 33);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(367, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "милисекунд";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 61);
            this.button2.TabIndex = 13;
            this.button2.Text = "Убрать раскраску";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.buttonMatrix);
            this.panelMenu.Controls.Add(this.panelDrawingSubmenu);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 746);
            this.panelMenu.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 704);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 66);
            this.button4.TabIndex = 6;
            this.button4.Text = "Выйти из программы";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMatrix
            // 
            this.buttonMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMatrix.FlatAppearance.BorderSize = 0;
            this.buttonMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.buttonMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMatrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMatrix.Image = ((System.Drawing.Image)(resources.GetObject("buttonMatrix.Image")));
            this.buttonMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMatrix.Location = new System.Drawing.Point(0, 441);
            this.buttonMatrix.Name = "buttonMatrix";
            this.buttonMatrix.Size = new System.Drawing.Size(234, 53);
            this.buttonMatrix.TabIndex = 5;
            this.buttonMatrix.Text = "Задать граф";
            this.buttonMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMatrix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMatrix.UseVisualStyleBackColor = true;
            this.buttonMatrix.Click += new System.EventHandler(this.buttonMatrix_Click);
            // 
            // panelDrawingSubmenu
            // 
            this.panelDrawingSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.panelDrawingSubmenu.Controls.Add(this.deleteEdgeButton);
            this.panelDrawingSubmenu.Controls.Add(this.deleteVertexButon);
            this.panelDrawingSubmenu.Controls.Add(this.MoveVertexButton);
            this.panelDrawingSubmenu.Controls.Add(this.addEdgeButton);
            this.panelDrawingSubmenu.Controls.Add(this.addVertexButton);
            this.panelDrawingSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrawingSubmenu.Location = new System.Drawing.Point(0, 135);
            this.panelDrawingSubmenu.Name = "panelDrawingSubmenu";
            this.panelDrawingSubmenu.Size = new System.Drawing.Size(234, 306);
            this.panelDrawingSubmenu.TabIndex = 4;
            // 
            // deleteEdgeButton
            // 
            this.deleteEdgeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteEdgeButton.FlatAppearance.BorderSize = 0;
            this.deleteEdgeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.deleteEdgeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.deleteEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEdgeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEdgeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteEdgeButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteEdgeButton.Image")));
            this.deleteEdgeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEdgeButton.Location = new System.Drawing.Point(0, 250);
            this.deleteEdgeButton.Name = "deleteEdgeButton";
            this.deleteEdgeButton.Size = new System.Drawing.Size(234, 48);
            this.deleteEdgeButton.TabIndex = 8;
            this.deleteEdgeButton.Text = "Удалить Ребро";
            this.deleteEdgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEdgeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteEdgeButton.UseVisualStyleBackColor = true;
            this.deleteEdgeButton.Click += new System.EventHandler(this.deleteEdgeButton_Click_1);
            // 
            // deleteVertexButon
            // 
            this.deleteVertexButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteVertexButon.FlatAppearance.BorderSize = 0;
            this.deleteVertexButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.deleteVertexButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.deleteVertexButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteVertexButon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteVertexButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteVertexButon.Image = ((System.Drawing.Image)(resources.GetObject("deleteVertexButon.Image")));
            this.deleteVertexButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteVertexButon.Location = new System.Drawing.Point(0, 190);
            this.deleteVertexButon.Name = "deleteVertexButon";
            this.deleteVertexButon.Size = new System.Drawing.Size(234, 60);
            this.deleteVertexButon.TabIndex = 7;
            this.deleteVertexButon.Text = "Удалить Вершину";
            this.deleteVertexButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteVertexButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteVertexButon.UseVisualStyleBackColor = true;
            this.deleteVertexButon.Click += new System.EventHandler(this.deleteVertexButon_Click);
            // 
            // MoveVertexButton
            // 
            this.MoveVertexButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveVertexButton.FlatAppearance.BorderSize = 0;
            this.MoveVertexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.MoveVertexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.MoveVertexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveVertexButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveVertexButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MoveVertexButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveVertexButton.Image")));
            this.MoveVertexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoveVertexButton.Location = new System.Drawing.Point(0, 133);
            this.MoveVertexButton.Name = "MoveVertexButton";
            this.MoveVertexButton.Size = new System.Drawing.Size(234, 57);
            this.MoveVertexButton.TabIndex = 6;
            this.MoveVertexButton.Text = "Переместить вершину";
            this.MoveVertexButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoveVertexButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoveVertexButton.UseVisualStyleBackColor = true;
            this.MoveVertexButton.Click += new System.EventHandler(this.MoveVertexButton_Click);
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEdgeButton.FlatAppearance.BorderSize = 0;
            this.addEdgeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.addEdgeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.addEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEdgeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEdgeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addEdgeButton.Image = ((System.Drawing.Image)(resources.GetObject("addEdgeButton.Image")));
            this.addEdgeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEdgeButton.Location = new System.Drawing.Point(0, 64);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(234, 69);
            this.addEdgeButton.TabIndex = 5;
            this.addEdgeButton.Text = "Добавить ребро";
            this.addEdgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEdgeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // addVertexButton
            // 
            this.addVertexButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addVertexButton.FlatAppearance.BorderSize = 0;
            this.addVertexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.addVertexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.addVertexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVertexButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVertexButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addVertexButton.Image = ((System.Drawing.Image)(resources.GetObject("addVertexButton.Image")));
            this.addVertexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVertexButton.Location = new System.Drawing.Point(0, 0);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(234, 64);
            this.addVertexButton.TabIndex = 1;
            this.addVertexButton.Text = "Добавить вершину";
            this.addVertexButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVertexButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addVertexButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Нарисовать граф";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(234, 82);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Graph Colorer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ifSlowModeCheckBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 746);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 82);
            this.panel3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(279, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 40);
            this.label4.TabIndex = 14;
            this.label4.Text = "Окно для рисования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(705, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Раскраска поэтапно";
            // 
            // ifSlowModeCheckBox
            // 
            this.ifSlowModeCheckBox.AutoSize = true;
            this.ifSlowModeCheckBox.Location = new System.Drawing.Point(654, 648);
            this.ifSlowModeCheckBox.MinimumSize = new System.Drawing.Size(45, 22);
            this.ifSlowModeCheckBox.Name = "ifSlowModeCheckBox";
            this.ifSlowModeCheckBox.OffBackColor = System.Drawing.Color.Gray;
            this.ifSlowModeCheckBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.ifSlowModeCheckBox.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ifSlowModeCheckBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.ifSlowModeCheckBox.Size = new System.Drawing.Size(45, 22);
            this.ifSlowModeCheckBox.TabIndex = 16;
            this.ifSlowModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.colorGraphButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(942, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 746);
            this.panel2.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 507);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 61);
            this.button5.TabIndex = 14;
            this.button5.Text = "Математический метод";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 210);
            this.panel4.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(234, 69);
            this.button9.TabIndex = 5;
            this.button9.Text = "Матрица инцидентности";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(234, 64);
            this.button10.TabIndex = 1;
            this.button10.Text = "Матрица смежности";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(234, 69);
            this.button6.TabIndex = 6;
            this.button6.Text = "Применить";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно для рисования";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelDrawingSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button colorGraphButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.Panel panelDrawingSubmenu;
        private System.Windows.Forms.Button MoveVertexButton;
        private System.Windows.Forms.Button deleteVertexButon;
        private System.Windows.Forms.Button deleteEdgeButton;
        private System.Windows.Forms.Button buttonMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipGraph;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private RJToggleButton ifSlowModeCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
    }
}

