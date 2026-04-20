namespace QuieresSerMiNovia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            buttonAceptar = new Button();
            labelSiempreSupe = new Label();
            pictureBox2 = new PictureBox();
            buttonNo = new Button();
            buttonSi = new Button();
            labelQuieresSer = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonNo);
            panel1.Controls.Add(buttonSi);
            panel1.Controls.Add(labelQuieresSer);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 215);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAceptar);
            panel2.Controls.Add(labelSiempreSupe);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 215);
            panel2.TabIndex = 4;
            // 
            // buttonAceptar
            // 
            buttonAceptar.AutoSize = true;
            buttonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAceptar.Location = new Point(109, 120);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(147, 31);
            buttonAceptar.TabIndex = 2;
            buttonAceptar.Text = "Aceptar  (´▽`ʃ♡ƪ)";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // labelSiempreSupe
            // 
            labelSiempreSupe.AutoSize = true;
            labelSiempreSupe.BackColor = Color.Transparent;
            labelSiempreSupe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSiempreSupe.Location = new Point(4, 34);
            labelSiempreSupe.Name = "labelSiempreSupe";
            labelSiempreSupe.Size = new Size(377, 32);
            labelSiempreSupe.TabIndex = 1;
            labelSiempreSupe.Text = "Siempre supe que te gustaba :D";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(387, 215);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // buttonNo
            // 
            buttonNo.AutoSize = true;
            buttonNo.FlatStyle = FlatStyle.Popup;
            buttonNo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNo.Location = new Point(210, 120);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(75, 44);
            buttonNo.TabIndex = 3;
            buttonNo.Text = "NO";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.MouseMove += buttonNo_MouseMove;
            // 
            // buttonSi
            // 
            buttonSi.AutoSize = true;
            buttonSi.FlatStyle = FlatStyle.Popup;
            buttonSi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSi.Location = new Point(81, 120);
            buttonSi.Name = "buttonSi";
            buttonSi.Size = new Size(75, 44);
            buttonSi.TabIndex = 2;
            buttonSi.Text = "SI";
            buttonSi.UseVisualStyleBackColor = true;
            buttonSi.Click += buttonSi_Click;
            // 
            // labelQuieresSer
            // 
            labelQuieresSer.AutoSize = true;
            labelQuieresSer.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuieresSer.Location = new Point(41, 34);
            labelQuieresSer.Name = "labelQuieresSer";
            labelQuieresSer.Size = new Size(301, 37);
            labelQuieresSer.TabIndex = 1;
            labelQuieresSer.Text = "¿Quieres ser mi novia?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 215);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelQuieresSer;
        private Button buttonSi;
        private Button buttonNo;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label labelSiempreSupe;
        private Button buttonAceptar;
    }
}
