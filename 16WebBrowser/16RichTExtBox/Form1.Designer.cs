namespace _16RichTExtBox
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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonAvanzar = new System.Windows.Forms.Button();
            this.buttonRecargar = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonDetener = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonIr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 12);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 0;
            this.buttonAtras.Text = "<";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // buttonAvanzar
            // 
            this.buttonAvanzar.Location = new System.Drawing.Point(93, 12);
            this.buttonAvanzar.Name = "buttonAvanzar";
            this.buttonAvanzar.Size = new System.Drawing.Size(75, 23);
            this.buttonAvanzar.TabIndex = 1;
            this.buttonAvanzar.Text = ">";
            this.buttonAvanzar.UseVisualStyleBackColor = true;
            this.buttonAvanzar.Click += new System.EventHandler(this.buttonAvanzar_Click);
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.Location = new System.Drawing.Point(174, 12);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecargar.TabIndex = 2;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = true;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(255, 12);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 23);
            this.buttonInicio.TabIndex = 3;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonDetener
            // 
            this.buttonDetener.Location = new System.Drawing.Point(336, 12);
            this.buttonDetener.Name = "buttonDetener";
            this.buttonDetener.Size = new System.Drawing.Size(75, 23);
            this.buttonDetener.TabIndex = 4;
            this.buttonDetener.Text = "Detener";
            this.buttonDetener.UseVisualStyleBackColor = true;
            this.buttonDetener.Click += new System.EventHandler(this.buttonDetener_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(417, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(374, 20);
            this.textBoxUrl.TabIndex = 5;
            // 
            // buttonIr
            // 
            this.buttonIr.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.buttonIr.Location = new System.Drawing.Point(797, 12);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(75, 23);
            this.buttonIr.TabIndex = 6;
            this.buttonIr.Text = "Ir";
            this.buttonIr.UseVisualStyleBackColor = true;
            this.buttonIr.Click += new System.EventHandler(this.button6_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(860, 408);
            this.webBrowser1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonIr);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonDetener);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonRecargar);
            this.Controls.Add(this.buttonAvanzar);
            this.Controls.Add(this.buttonAtras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonAvanzar;
        private System.Windows.Forms.Button buttonRecargar;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonDetener;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonIr;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

