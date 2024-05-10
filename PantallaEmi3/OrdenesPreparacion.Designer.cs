
namespace PantallaEmi3
{
    partial class OrdenesPreparacion
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
            listBox1 = new ListBox();
            label1 = new Label();
            DetalleOrdenPreparacion = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            listBox2 = new ListBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonFinalizar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 84);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 20);
            label1.TabIndex = 1;
            label1.Text = "Órdenes en preparación disponibles";
            label1.Click += label1_Click;
            // 
            // DetalleOrdenPreparacion
            // 
            DetalleOrdenPreparacion.FormattingEnabled = true;
            DetalleOrdenPreparacion.Location = new Point(340, 38);
            DetalleOrdenPreparacion.MultiColumn = true;
            DetalleOrdenPreparacion.Name = "DetalleOrdenPreparacion";
            DetalleOrdenPreparacion.Size = new Size(241, 104);
            DetalleOrdenPreparacion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 9);
            label2.Name = "label2";
            label2.Size = new Size(241, 20);
            label2.TabIndex = 3;
            label2.Text = "Detalle de la orden en preparación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(11, 168);
            label3.Name = "label3";
            label3.Size = new Size(192, 22);
            label3.TabIndex = 4;
            label3.Text = "Generar orden de selección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(223, 20);
            label4.TabIndex = 5;
            label4.Text = "Ingrese la orden en preparación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 277);
            label5.Name = "label5";
            label5.Size = new Size(284, 20);
            label5.TabIndex = 6;
            label5.Text = "Ingese el código del producto a entregar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 353);
            label6.Name = "label6";
            label6.Size = new Size(210, 20);
            label6.TabIndex = 7;
            label6.Text = "Ingrese la cantidad a entregar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(17, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 376);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 201);
            label7.Name = "label7";
            label7.Size = new Size(337, 20);
            label7.TabIndex = 11;
            label7.Text = "Productos a entregar: (Orden-Producto-Cantidad)";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(340, 228);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(302, 164);
            listBox2.TabIndex = 12;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(217, 415);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(118, 27);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(341, 415);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(118, 27);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(507, 415);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(170, 27);
            buttonFinalizar.TabIndex = 15;
            buttonFinalizar.Text = "Finalizar y Guardar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(692, 415);
            button1.Name = "button1";
            button1.Size = new Size(93, 27);
            button1.TabIndex = 16;
            button1.Text = "Menú";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrdenesPreparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DetalleOrdenPreparacion);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "OrdenesPreparacion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ListBox DetalleOrdenPreparacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private ListBox listBox2;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonFinalizar;
        private Button button1;
    }
}
