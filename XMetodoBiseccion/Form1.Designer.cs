namespace MetodoBiseccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Resultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_limInfer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_solucion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_limSuper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(389, 302);
            this.Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(88, 23);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "Resultado";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el limite inferior:";
            // 
            // txt_limInfer
            // 
            this.txt_limInfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_limInfer.Location = new System.Drawing.Point(377, 172);
            this.txt_limInfer.Name = "txt_limInfer";
            this.txt_limInfer.Size = new System.Drawing.Size(100, 20);
            this.txt_limInfer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solución aproximada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_solucion
            // 
            this.txt_solucion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_solucion.Location = new System.Drawing.Point(377, 218);
            this.txt_solucion.Name = "txt_solucion";
            this.txt_solucion.Size = new System.Drawing.Size(100, 20);
            this.txt_solucion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introduce el limite superior:";
            // 
            // txt_limSuper
            // 
            this.txt_limSuper.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_limSuper.Location = new System.Drawing.Point(377, 131);
            this.txt_limSuper.Name = "txt_limSuper";
            this.txt_limSuper.Size = new System.Drawing.Size(100, 20);
            this.txt_limSuper.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::MetodoBiseccion.Properties.Resources.Gemini_Generated_Image_q5vo4nq5vo4nq5vo;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.txt_limSuper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_solucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_limInfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_limInfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_solucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_limSuper;
    }
}

