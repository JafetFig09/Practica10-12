namespace Practica_12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpie los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntradaAuto = new Button();
            btnSalidaAuto = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPlacas = new TextBox();
            txtPropietario = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnEntradaAuto
            // 
            btnEntradaAuto.Location = new Point(35, 171);
            btnEntradaAuto.Margin = new Padding(2, 3, 2, 3);
            btnEntradaAuto.Name = "btnEntradaAuto";
            btnEntradaAuto.Size = new Size(102, 52);
            btnEntradaAuto.TabIndex = 0;
            btnEntradaAuto.Text = "Registrar Entrada";
            btnEntradaAuto.UseVisualStyleBackColor = true;
            btnEntradaAuto.Click += btnEntradaAuto_Click;
            // 
            // btnSalidaAuto
            // 
            btnSalidaAuto.Location = new Point(153, 171);
            btnSalidaAuto.Margin = new Padding(2, 3, 2, 3);
            btnSalidaAuto.Name = "btnSalidaAuto";
            btnSalidaAuto.Size = new Size(102, 52);
            btnSalidaAuto.TabIndex = 1;
            btnSalidaAuto.Text = "Registrar Salida";
            btnSalidaAuto.UseVisualStyleBackColor = true;
            btnSalidaAuto.Click += btnSalidaAuto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Placas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Propietario";
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(134, 32);
            txtPlacas.Margin = new Padding(2, 3, 2, 3);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(121, 27);
            txtPlacas.TabIndex = 4;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(134, 89);
            txtPropietario.Margin = new Padding(2, 3, 2, 3);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(121, 27);
            txtPropietario.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(314, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(628, 284);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 351);
            Controls.Add(listBox1);
            Controls.Add(txtPropietario);
            Controls.Add(txtPlacas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalidaAuto);
            Controls.Add(btnEntradaAuto);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Práctica12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntradaAuto;
        private Button btnSalidaAuto;
        private Label label1;
        private Label label2;
        private TextBox txtPlacas;
        private TextBox txtPropietario;
        private ListBox listBox1;
    }
}
