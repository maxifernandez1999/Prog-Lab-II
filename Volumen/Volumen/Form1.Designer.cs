namespace Volumen
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
            this.btnCm3 = new System.Windows.Forms.Button();
            this.btnMl = new System.Windows.Forms.Button();
            this.txtBoxMl = new System.Windows.Forms.TextBox();
            this.txtBoxCm3 = new System.Windows.Forms.TextBox();
            this.cmbMl = new System.Windows.Forms.ComboBox();
            this.cmbCm3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCm3
            // 
            this.btnCm3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCm3.Location = new System.Drawing.Point(478, 28);
            this.btnCm3.Name = "btnCm3";
            this.btnCm3.Size = new System.Drawing.Size(163, 32);
            this.btnCm3.TabIndex = 0;
            this.btnCm3.Text = "Convertir ";
            this.btnCm3.UseVisualStyleBackColor = true;
            this.btnCm3.Click += new System.EventHandler(this.btnCm3_Click);
            // 
            // btnMl
            // 
            this.btnMl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMl.Location = new System.Drawing.Point(478, 89);
            this.btnMl.Name = "btnMl";
            this.btnMl.Size = new System.Drawing.Size(163, 32);
            this.btnMl.TabIndex = 1;
            this.btnMl.Text = " Convertir";
            this.btnMl.UseVisualStyleBackColor = true;
            this.btnMl.Click += new System.EventHandler(this.btnMl_Click);
            // 
            // txtBoxMl
            // 
            this.txtBoxMl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMl.Location = new System.Drawing.Point(119, 27);
            this.txtBoxMl.Name = "txtBoxMl";
            this.txtBoxMl.Size = new System.Drawing.Size(157, 33);
            this.txtBoxMl.TabIndex = 2;
            // 
            // txtBoxCm3
            // 
            this.txtBoxCm3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCm3.Location = new System.Drawing.Point(119, 90);
            this.txtBoxCm3.Name = "txtBoxCm3";
            this.txtBoxCm3.Size = new System.Drawing.Size(157, 33);
            this.txtBoxCm3.TabIndex = 3;
            // 
            // cmbMl
            // 
            this.cmbMl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMl.FormattingEnabled = true;
            this.cmbMl.Items.AddRange(new object[] {
            "mm3",
            "cm3",
            "dm3",
            "dam3",
            "hm3",
            "km3"});
            this.cmbMl.Location = new System.Drawing.Point(313, 27);
            this.cmbMl.Name = "cmbMl";
            this.cmbMl.Size = new System.Drawing.Size(121, 34);
            this.cmbMl.TabIndex = 4;
            // 
            // cmbCm3
            // 
            this.cmbCm3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbCm3.FormattingEnabled = true;
            this.cmbCm3.Items.AddRange(new object[] {
            "ml",
            "cl",
            "dl",
            "l",
            "dal",
            "hl",
            "kl"});
            this.cmbCm3.Location = new System.Drawing.Point(313, 89);
            this.cmbCm3.Name = "cmbCm3";
            this.cmbCm3.Size = new System.Drawing.Size(121, 34);
            this.cmbCm3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(692, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(692, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Litros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "dm3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 156);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCm3);
            this.Controls.Add(this.cmbMl);
            this.Controls.Add(this.txtBoxCm3);
            this.Controls.Add(this.txtBoxMl);
            this.Controls.Add(this.btnMl);
            this.Controls.Add(this.btnCm3);
            this.MaximumSize = new System.Drawing.Size(870, 195);
            this.MinimumSize = new System.Drawing.Size(870, 195);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCm3;
        private System.Windows.Forms.Button btnMl;
        private System.Windows.Forms.TextBox txtBoxMl;
        private System.Windows.Forms.TextBox txtBoxCm3;
        private System.Windows.Forms.ComboBox cmbMl;
        private System.Windows.Forms.ComboBox cmbCm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

