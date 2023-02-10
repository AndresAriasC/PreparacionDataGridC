namespace TrabajoPractico
{
    partial class PracticaData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.campoInventarioInicial = new System.Windows.Forms.MaskedTextBox();
            this.campoIngresos = new System.Windows.Forms.MaskedTextBox();
            this.campoEgresos = new System.Windows.Forms.MaskedTextBox();
            this.campoUAI = new System.Windows.Forms.TextBox();
            this.campoUDI = new System.Windows.Forms.TextBox();
            this.campoDepre = new System.Windows.Forms.TextBox();
            this.campoImpuesto = new System.Windows.Forms.TextBox();
            this.tablaRegistro = new System.Windows.Forms.DataGridView();
            this.invIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utiAImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilDespImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FLUJO NETO DE EFECTIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVERSION INICIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EGRESOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "UTILIDAD ANTES DE IMPUESTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "UTILIDAD DESPUES DE IMPUESTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DEPRECIACION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "IMPUESTO";
            // 
            // campoInventarioInicial
            // 
            this.campoInventarioInicial.Location = new System.Drawing.Point(157, 72);
            this.campoInventarioInicial.Mask = "999999999999";
            this.campoInventarioInicial.Name = "campoInventarioInicial";
            this.campoInventarioInicial.Size = new System.Drawing.Size(76, 20);
            this.campoInventarioInicial.TabIndex = 8;
            this.campoInventarioInicial.ValidatingType = typeof(int);
            // 
            // campoIngresos
            // 
            this.campoIngresos.Location = new System.Drawing.Point(157, 121);
            this.campoIngresos.Mask = "999999999999";
            this.campoIngresos.Name = "campoIngresos";
            this.campoIngresos.Size = new System.Drawing.Size(76, 20);
            this.campoIngresos.TabIndex = 9;
            this.campoIngresos.ValidatingType = typeof(int);
            // 
            // campoEgresos
            // 
            this.campoEgresos.Location = new System.Drawing.Point(157, 166);
            this.campoEgresos.Mask = "999999999999";
            this.campoEgresos.Name = "campoEgresos";
            this.campoEgresos.Size = new System.Drawing.Size(76, 20);
            this.campoEgresos.TabIndex = 10;
            this.campoEgresos.ValidatingType = typeof(int);
            // 
            // campoUAI
            // 
            this.campoUAI.Enabled = false;
            this.campoUAI.Location = new System.Drawing.Point(637, 73);
            this.campoUAI.Name = "campoUAI";
            this.campoUAI.Size = new System.Drawing.Size(76, 20);
            this.campoUAI.TabIndex = 11;
            // 
            // campoUDI
            // 
            this.campoUDI.Enabled = false;
            this.campoUDI.Location = new System.Drawing.Point(637, 166);
            this.campoUDI.Name = "campoUDI";
            this.campoUDI.Size = new System.Drawing.Size(76, 20);
            this.campoUDI.TabIndex = 12;
            // 
            // campoDepre
            // 
            this.campoDepre.Enabled = false;
            this.campoDepre.Location = new System.Drawing.Point(332, 166);
            this.campoDepre.Name = "campoDepre";
            this.campoDepre.Size = new System.Drawing.Size(76, 20);
            this.campoDepre.TabIndex = 13;
            // 
            // campoImpuesto
            // 
            this.campoImpuesto.Enabled = false;
            this.campoImpuesto.Location = new System.Drawing.Point(527, 121);
            this.campoImpuesto.Name = "campoImpuesto";
            this.campoImpuesto.Size = new System.Drawing.Size(76, 20);
            this.campoImpuesto.TabIndex = 14;
            // 
            // tablaRegistro
            // 
            this.tablaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invIni,
            this.Ingresos,
            this.Egresos,
            this.utiAImpuesto,
            this.Impuesto,
            this.utilDespImpuesto,
            this.dep});
            this.tablaRegistro.Location = new System.Drawing.Point(12, 246);
            this.tablaRegistro.Name = "tablaRegistro";
            this.tablaRegistro.Size = new System.Drawing.Size(733, 126);
            this.tablaRegistro.TabIndex = 15;
            this.tablaRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRegistro_CellClick);
            // 
            // invIni
            // 
            this.invIni.HeaderText = "InversionInicial";
            this.invIni.Name = "invIni";
            // 
            // Ingresos
            // 
            this.Ingresos.HeaderText = "Ingresos";
            this.Ingresos.Name = "Ingresos";
            // 
            // Egresos
            // 
            this.Egresos.HeaderText = "Egresos";
            this.Egresos.Name = "Egresos";
            // 
            // utiAImpuesto
            // 
            this.utiAImpuesto.HeaderText = "Utilidad Antes de Imp.";
            this.utiAImpuesto.Name = "utiAImpuesto";
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            // 
            // utilDespImpuesto
            // 
            this.utilDespImpuesto.HeaderText = "Utilidad Despues De Impuestos";
            this.utilDespImpuesto.Name = "utilDespImpuesto";
            // 
            // dep
            // 
            this.dep.HeaderText = "Depreciación";
            this.dep.Name = "dep";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(257, 401);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(478, 401);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(588, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(367, 401);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 23);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.Location = new System.Drawing.Point(637, 227);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(0, 13);
            this.Delete.TabIndex = 20;
            // 
            // del
            // 
            this.del.AutoSize = true;
            this.del.Location = new System.Drawing.Point(637, 210);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(0, 13);
            this.del.TabIndex = 21;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(745, 210);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 22;
            // 
            // PracticaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 446);
            this.Controls.Add(this.info);
            this.Controls.Add(this.del);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tablaRegistro);
            this.Controls.Add(this.campoImpuesto);
            this.Controls.Add(this.campoDepre);
            this.Controls.Add(this.campoUDI);
            this.Controls.Add(this.campoUAI);
            this.Controls.Add(this.campoEgresos);
            this.Controls.Add(this.campoIngresos);
            this.Controls.Add(this.campoInventarioInicial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PracticaData";
            this.Text = "PracticaData";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox campoInventarioInicial;
        private System.Windows.Forms.MaskedTextBox campoIngresos;
        private System.Windows.Forms.MaskedTextBox campoEgresos;
        private System.Windows.Forms.TextBox campoUAI;
        private System.Windows.Forms.TextBox campoUDI;
        private System.Windows.Forms.TextBox campoDepre;
        private System.Windows.Forms.TextBox campoImpuesto;
        private System.Windows.Forms.DataGridView tablaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn utiAImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilDespImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label Delete;
        private System.Windows.Forms.Label del;
        private System.Windows.Forms.Label info;
    }
}