namespace _14TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tacos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Guajolota");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("México", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pavo");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Chiken Fried");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Estados unidos", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Crousant");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Canada", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(127, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "Tacos";
            treeNode2.Name = "Nodo4";
            treeNode2.Text = "Guajolota";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "México";
            treeNode4.Name = "Nodo5";
            treeNode4.Text = "Pavo";
            treeNode5.Name = "Nodo6";
            treeNode5.Text = "";
            treeNode6.Name = "Nodo11";
            treeNode6.Text = "Chiken Fried";
            treeNode7.Name = "Nodo1";
            treeNode7.Text = "Estados unidos";
            treeNode8.Name = "Nodo7";
            treeNode8.Text = "Crousant";
            treeNode9.Name = "Nodo2";
            treeNode9.Text = "Canada";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

