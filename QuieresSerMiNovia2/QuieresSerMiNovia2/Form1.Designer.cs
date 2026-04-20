namespace QuieresSerMiNovia2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.labelQuieresSer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelSiempreSupe = new System.Windows.Forms.Label();
            this.AceptarSiAcepto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonNo);
            this.panel1.Controls.Add(this.buttonSi);
            this.panel1.Controls.Add(this.labelQuieresSer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 215);
            this.panel1.TabIndex = 0;
            // 
            // buttonNo
            // 
            this.buttonNo.AutoSize = true;
            this.buttonNo.BackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.Location = new System.Drawing.Point(242, 114);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 55);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonNo_MouseMove);
            // 
            // buttonSi
            // 
            this.buttonSi.AutoSize = true;
            this.buttonSi.BackColor = System.Drawing.Color.Transparent;
            this.buttonSi.FlatAppearance.BorderSize = 0;
            this.buttonSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSi.Location = new System.Drawing.Point(63, 114);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(75, 55);
            this.buttonSi.TabIndex = 2;
            this.buttonSi.Text = "SI";
            this.buttonSi.UseVisualStyleBackColor = false;
            this.buttonSi.Click += new System.EventHandler(this.buttonSi_Click);
            // 
            // labelQuieresSer
            // 
            this.labelQuieresSer.AutoSize = true;
            this.labelQuieresSer.BackColor = System.Drawing.Color.Transparent;
            this.labelQuieresSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuieresSer.Location = new System.Drawing.Point(41, 51);
            this.labelQuieresSer.Name = "labelQuieresSer";
            this.labelQuieresSer.Size = new System.Drawing.Size(313, 31);
            this.labelQuieresSer.TabIndex = 1;
            this.labelQuieresSer.Text = "¿Quieres ser mi novia?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuieresSerMiNovia2.Properties.Resources.Fondo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AceptarSiAcepto);
            this.panel2.Controls.Add(this.labelSiempreSupe);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 215);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuieresSerMiNovia2.Properties.Resources.Fondo2;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelSiempreSupe
            // 
            this.labelSiempreSupe.AutoSize = true;
            this.labelSiempreSupe.BackColor = System.Drawing.Color.Transparent;
            this.labelSiempreSupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiempreSupe.Location = new System.Drawing.Point(10, 53);
            this.labelSiempreSupe.Name = "labelSiempreSupe";
            this.labelSiempreSupe.Size = new System.Drawing.Size(355, 29);
            this.labelSiempreSupe.TabIndex = 1;
            this.labelSiempreSupe.Text = "Siempre supe que te gustaba";
            // 
            // AceptarSiAcepto
            // 
            this.AceptarSiAcepto.AutoSize = true;
            this.AceptarSiAcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarSiAcepto.Location = new System.Drawing.Point(110, 132);
            this.AceptarSiAcepto.Name = "AceptarSiAcepto";
            this.AceptarSiAcepto.Size = new System.Drawing.Size(127, 26);
            this.AceptarSiAcepto.TabIndex = 2;
            this.AceptarSiAcepto.Text = "Aceptar  (´▽`ʃ♡ƪ)";
            this.AceptarSiAcepto.UseVisualStyleBackColor = true;
            this.AceptarSiAcepto.Click += new System.EventHandler(this.AceptarSiAcepto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuieresSer;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSiempreSupe;
        private System.Windows.Forms.Button AceptarSiAcepto;
    }
}

