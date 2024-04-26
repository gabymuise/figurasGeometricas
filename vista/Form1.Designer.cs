namespace figurasGeometrica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(262, 69);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(119, 22);
            this.txtLado3.TabIndex = 1;
            this.txtLado3.Visible = false;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(387, 69);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(119, 22);
            this.txtRadio.TabIndex = 2;
            this.txtRadio.Visible = false;
            
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(137, 69);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(119, 22);
            this.txtLado2.TabIndex = 3;
            this.txtLado2.Visible = false;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(45, 50);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(45, 16);
            this.lblLado1.TabIndex = 4;
            this.lblLado1.Text = "Lado1";
            this.lblLado1.Visible = false;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(173, 50);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(45, 16);
            this.lblLado2.TabIndex = 5;
            this.lblLado2.Text = "Lado2";
            this.lblLado2.Visible = false;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(299, 50);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(45, 16);
            this.lblLado3.TabIndex = 6;
            this.lblLado3.Text = "Lado3";
            this.lblLado3.Visible = false;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(428, 50);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(44, 16);
            this.lblRadio.TabIndex = 7;
            this.lblRadio.Text = "Radio";
            this.lblRadio.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(564, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(594, 126);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(144, 23);
            this.btnCuadrado.TabIndex = 9;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(594, 155);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(144, 23);
            this.btnTriangulo.TabIndex = 10;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(594, 184);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(144, 23);
            this.btnCirculo.TabIndex = 11;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(9, 126);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Area ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(9, 155);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(65, 16);
            this.lblPerimetro.TabIndex = 13;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(9, 182);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 16);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Altura";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAltura.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(93, 123);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(151, 22);
            this.txtArea.TabIndex = 15;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(93, 179);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.ReadOnly = true;
            this.txtAltura.Size = new System.Drawing.Size(151, 22);
            this.txtAltura.TabIndex = 16;
            this.txtAltura.Visible = false;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(93, 152);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(151, 22);
            this.txtPerimetro.TabIndex = 17;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(12, 69);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(119, 22);
            this.txtLado1.TabIndex = 18;
            this.txtLado1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 273);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtLado3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtLado1;
    }
}

