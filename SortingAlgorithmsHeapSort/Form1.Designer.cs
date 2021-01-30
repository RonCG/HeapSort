namespace SortingAlgorithmsHeapSort
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Valores = new System.Windows.Forms.PictureBox();
            this.HeapSort = new System.Windows.Forms.Button();
            this.GArbol = new System.Windows.Forms.PictureBox();
            this.HeapMinimo = new System.Windows.Forms.Button();
            this.ingresoNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // Valores
            // 
            this.Valores.BackColor = System.Drawing.Color.Silver;
            this.Valores.Location = new System.Drawing.Point(750, 36);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(307, 341);
            this.Valores.TabIndex = 23;
            this.Valores.TabStop = false;
            // 
            // HeapSort
            // 
            this.HeapSort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HeapSort.Enabled = false;
            this.HeapSort.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeapSort.Location = new System.Drawing.Point(53, 238);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(169, 62);
            this.HeapSort.TabIndex = 21;
            this.HeapSort.Text = "Heap Sort";
            this.HeapSort.UseVisualStyleBackColor = false;
            this.HeapSort.Click += new System.EventHandler(this.HeapSort_Click);
            // 
            // GArbol
            // 
            this.GArbol.BackColor = System.Drawing.Color.Gray;
            this.GArbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GArbol.Location = new System.Drawing.Point(274, 36);
            this.GArbol.Name = "GArbol";
            this.GArbol.Size = new System.Drawing.Size(470, 341);
            this.GArbol.TabIndex = 20;
            this.GArbol.TabStop = false;
            // 
            // HeapMinimo
            // 
            this.HeapMinimo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HeapMinimo.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeapMinimo.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeapMinimo.Location = new System.Drawing.Point(53, 170);
            this.HeapMinimo.Name = "HeapMinimo";
            this.HeapMinimo.Size = new System.Drawing.Size(169, 62);
            this.HeapMinimo.TabIndex = 19;
            this.HeapMinimo.Text = "MINUMUM HEAP";
            this.HeapMinimo.UseVisualStyleBackColor = false;
            this.HeapMinimo.Click += new System.EventHandler(this.HeapMinimo_Click);
            // 
            // ingresoNumeros
            // 
            this.ingresoNumeros.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ingresoNumeros.Location = new System.Drawing.Point(13, 60);
            this.ingresoNumeros.Name = "ingresoNumeros";
            this.ingresoNumeros.Size = new System.Drawing.Size(247, 20);
            this.ingresoNumeros.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "INPUT NODES:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 63);
            this.button1.TabIndex = 24;
            this.button1.Text = "RANDOM NODES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(810, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 75);
            this.button2.TabIndex = 25;
            this.button2.Text = "RE-ENTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(810, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 77);
            this.button3.TabIndex = 26;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "0,25",
            "0,5",
            "1",
            "2",
            "4",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(130, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 29);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "SPEED:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.GArbol);
            this.Controls.Add(this.HeapMinimo);
            this.Controls.Add(this.ingresoNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Heap Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Valores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GArbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Valores;
        private System.Windows.Forms.Button HeapSort;
        private System.Windows.Forms.PictureBox GArbol;
        private System.Windows.Forms.Button HeapMinimo;
        private System.Windows.Forms.TextBox ingresoNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

