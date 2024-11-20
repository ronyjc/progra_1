namespace SuperMercado
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(214, 34);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 0;
            button1.Text = "Crear Categoría";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(357, 35);
            button2.Name = "button2";
            button2.Size = new Size(137, 22);
            button2.TabIndex = 2;
            button2.Text = "Mostrar Categorías";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 23);
            comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(26, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 74);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion de categorías";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(26, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 71);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de productos";
            // 
            // button4
            // 
            button4.Location = new Point(357, 27);
            button4.Name = "button4";
            button4.Size = new Size(137, 23);
            button4.TabIndex = 5;
            button4.Text = "Agregar producto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(214, 27);
            button3.Name = "button3";
            button3.Size = new Size(137, 23);
            button3.TabIndex = 4;
            button3.Text = "Ver productos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
    }
}
