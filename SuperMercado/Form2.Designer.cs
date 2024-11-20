namespace SuperMercado
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_codigo = new TextBox();
            txt_nombre = new TextBox();
            label2 = new Label();
            txt_marca = new TextBox();
            label3 = new Label();
            txt_precio = new TextBox();
            label4 = new Label();
            txt_existencia = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(99, 49);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(210, 23);
            txt_codigo.TabIndex = 1;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(99, 101);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(210, 23);
            txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(99, 156);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(210, 23);
            txt_marca.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 159);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Marca";
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(99, 214);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(210, 23);
            txt_precio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 217);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txt_existencia
            // 
            txt_existencia.Location = new Point(99, 268);
            txt_existencia.Name = "txt_existencia";
            txt_existencia.Size = new Size(210, 23);
            txt_existencia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 271);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Existencia";
            // 
            // button1
            // 
            button1.Location = new Point(139, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 10;
            button1.Text = "Aregar producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(button1);
            Controls.Add(txt_existencia);
            Controls.Add(label5);
            Controls.Add(txt_precio);
            Controls.Add(label4);
            Controls.Add(txt_marca);
            Controls.Add(label3);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(txt_codigo);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_codigo;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_marca;
        private Label label3;
        private TextBox txt_precio;
        private Label label4;
        private TextBox txt_existencia;
        private Label label5;
        private Button button1;
    }
}