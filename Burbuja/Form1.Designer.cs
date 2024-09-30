namespace Burbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnagg = new System.Windows.Forms.Button();
            this.TbNumber = new System.Windows.Forms.TextBox();
            this.LbXNumber = new System.Windows.Forms.ListBox();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un Numero:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Btnagg
            // 
            this.Btnagg.Location = new System.Drawing.Point(364, 30);
            this.Btnagg.Name = "Btnagg";
            this.Btnagg.Size = new System.Drawing.Size(110, 38);
            this.Btnagg.TabIndex = 2;
            this.Btnagg.Text = "Agregar";
            this.Btnagg.UseVisualStyleBackColor = true;
            this.Btnagg.Click += new System.EventHandler(this.Btnagg_Click);
            // 
            // TbNumber
            // 
            this.TbNumber.Location = new System.Drawing.Point(203, 28);
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.Size = new System.Drawing.Size(145, 26);
            this.TbNumber.TabIndex = 3;
            // 
            // LbXNumber
            // 
            this.LbXNumber.FormattingEnabled = true;
            this.LbXNumber.ItemHeight = 20;
            this.LbXNumber.Location = new System.Drawing.Point(36, 70);
            this.LbXNumber.Name = "LbXNumber";
            this.LbXNumber.Size = new System.Drawing.Size(251, 344);
            this.LbXNumber.TabIndex = 4;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(364, 88);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(110, 46);
            this.BtnSort.TabIndex = 5;
            this.BtnSort.Text = "Ordenar";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.LbXNumber);
            this.Controls.Add(this.TbNumber);
            this.Controls.Add(this.Btnagg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnagg;
        private System.Windows.Forms.TextBox TbNumber;
        private System.Windows.Forms.ListBox LbXNumber;
        private System.Windows.Forms.Button BtnSort;
    }
}

