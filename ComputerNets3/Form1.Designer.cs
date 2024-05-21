namespace ComputerNets3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nTextBox = new TextBox();
            rTextBox = new TextBox();
            experimentsCountTextBox = new TextBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage3 = new TabPage();
            tabControl3 = new TabControl();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabControl3.SuspendLayout();
            SuspendLayout();
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(463, 24);
            nTextBox.Name = "nTextBox";
            nTextBox.PlaceholderText = "n";
            nTextBox.Size = new Size(206, 27);
            nTextBox.TabIndex = 0;
            nTextBox.Text = "9,10,11,12,13,14,15,16,17,18,19,20";
            // 
            // rTextBox
            // 
            rTextBox.Location = new Point(238, 24);
            rTextBox.Name = "rTextBox";
            rTextBox.PlaceholderText = "r";
            rTextBox.Size = new Size(206, 27);
            rTextBox.TabIndex = 0;
            rTextBox.Text = "25";
            // 
            // experimentsCountTextBox
            // 
            experimentsCountTextBox.Location = new Point(12, 24);
            experimentsCountTextBox.Name = "experimentsCountTextBox";
            experimentsCountTextBox.PlaceholderText = "Количество экспериментов";
            experimentsCountTextBox.Size = new Size(206, 27);
            experimentsCountTextBox.TabIndex = 0;
            experimentsCountTextBox.Text = "1000";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 95);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1256, 389);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1248, 356);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Зависимость среднего количества узлов в главной компоненте";
            // 
            // tabControl2
            // 
            tabControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(6, 23);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1236, 327);
            tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1228, 294);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "От n";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.Control;
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1228, 294);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "От r";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(tabControl3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1248, 356);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Зависимость математического ожидания степени вершины";
            // 
            // tabControl3
            // 
            tabControl3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl3.Controls.Add(tabPage6);
            tabControl3.Controls.Add(tabPage7);
            tabControl3.Location = new Point(6, 23);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1236, 327);
            tabControl3.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = SystemColors.Control;
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1228, 294);
            tabPage6.TabIndex = 0;
            tabPage6.Text = "От n";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = SystemColors.Control;
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1228, 294);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "От r";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(692, 27);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 3;
            label1.Text = "Построить графики зависимости от: ";
            // 
            // button2
            // 
            button2.Location = new Point(963, 20);
            button2.Name = "button2";
            button2.Size = new Size(46, 34);
            button2.TabIndex = 1;
            button2.Text = "n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1030, 20);
            button3.Name = "button3";
            button3.Size = new Size(46, 34);
            button3.TabIndex = 1;
            button3.Text = "r";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 496);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(experimentsCountTextBox);
            Controls.Add(rTextBox);
            Controls.Add(nTextBox);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nTextBox;
        private TextBox rTextBox;
        private TextBox experimentsCountTextBox;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Label label1;
        private Button button2;
        private Button button3;
        public TabControl tabControl2;
        public TabControl tabControl3;
    }
}
