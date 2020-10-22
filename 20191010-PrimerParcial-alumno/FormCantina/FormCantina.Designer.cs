namespace FormCantina
{
    partial class FormCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantina));
            this.nudContenido = new System.Windows.Forms.NumericUpDown();
            this.rbBtnAgua = new System.Windows.Forms.RadioButton();
            this.rdBtnCerveza = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barra1 = new ControlCantina.Barra();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudContenido
            // 
            this.nudContenido.Location = new System.Drawing.Point(351, 357);
            this.nudContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(100, 20);
            this.nudContenido.TabIndex = 15;
            this.nudContenido.ValueChanged += new System.EventHandler(this.nudContenido_ValueChanged);
            // 
            // rbBtnAgua
            // 
            this.rbBtnAgua.AutoSize = true;
            this.rbBtnAgua.Location = new System.Drawing.Point(41, 343);
            this.rbBtnAgua.Name = "rbBtnAgua";
            this.rbBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rbBtnAgua.TabIndex = 14;
            this.rbBtnAgua.TabStop = true;
            this.rbBtnAgua.Text = "Agua";
            this.rbBtnAgua.UseVisualStyleBackColor = true;
            // 
            // rdBtnCerveza
            // 
            this.rdBtnCerveza.AutoSize = true;
            this.rdBtnCerveza.Location = new System.Drawing.Point(41, 300);
            this.rdBtnCerveza.Name = "rdBtnCerveza";
            this.rdBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rdBtnCerveza.TabIndex = 13;
            this.rdBtnCerveza.TabStop = true;
            this.rdBtnCerveza.Text = "Cerveza";
            this.rdBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(483, 357);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(351, 311);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 11;
            this.cmbBotellaTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBotellaTipo_SelectedIndexChanged);
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(180, 357);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(100, 20);
            this.nudCapacidad.TabIndex = 10;
            this.nudCapacidad.ValueChanged += new System.EventHandler(this.nudCapacidad_ValueChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(180, 311);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(186, 290);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.barra1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 275);
            this.panel1.TabIndex = 16;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(0, 0);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(564, 293);
            this.barra1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "botellaTipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contenido";
            // 
            // FormCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudContenido);
            this.Controls.Add(this.rbBtnAgua);
            this.Controls.Add(this.rdBtnCerveza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Name = "FormCantina";
            this.Text = "Maximiliano Fernandez";
            this.Load += new System.EventHandler(this.FormCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudContenido;
        private System.Windows.Forms.RadioButton rbBtnAgua;
        private System.Windows.Forms.RadioButton rdBtnCerveza;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Panel panel1;
        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

