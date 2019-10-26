namespace Finter
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbValorX = new System.Windows.Forms.TextBox();
            this.btVerificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbValorY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridPuntos = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBorrarCalc = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbValorK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chMostrarPasos = new System.Windows.Forms.CheckBox();
            this.cbTipoPol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPasos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPolinomioK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPolinomio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajo Práctio Matemática Superior";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbValorX);
            this.groupBox1.Controls.Add(this.btVerificar);
            this.groupBox1.Controls.Add(this.btEliminar);
            this.groupBox1.Controls.Add(this.btAgregar);
            this.groupBox1.Controls.Add(this.tbValorY);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gridPuntos);
            this.groupBox1.Location = new System.Drawing.Point(26, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos";
            // 
            // tbValorX
            // 
            this.tbValorX.Location = new System.Drawing.Point(410, 13);
            this.tbValorX.Name = "tbValorX";
            this.tbValorX.Size = new System.Drawing.Size(67, 20);
            this.tbValorX.TabIndex = 13;
            this.tbValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorNumerico_KeyPress);
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(389, 205);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(207, 23);
            this.btVerificar.TabIndex = 12;
            this.btVerificar.Text = "Verificar puntos";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(389, 116);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(207, 23);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(389, 39);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(207, 23);
            this.btAgregar.TabIndex = 10;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbValorY
            // 
            this.tbValorY.Location = new System.Drawing.Point(529, 12);
            this.tbValorY.Name = "tbValorY";
            this.tbValorY.Size = new System.Drawing.Size(67, 20);
            this.tbValorY.TabIndex = 9;
            this.tbValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorNumerico_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "y=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "x=";
            // 
            // gridPuntos
            // 
            this.gridPuntos.AllowUserToAddRows = false;
            this.gridPuntos.AllowUserToDeleteRows = false;
            this.gridPuntos.AllowUserToOrderColumns = true;
            this.gridPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.x,
            this.y});
            this.gridPuntos.Location = new System.Drawing.Point(19, 19);
            this.gridPuntos.Name = "gridPuntos";
            this.gridPuntos.ReadOnly = true;
            this.gridPuntos.Size = new System.Drawing.Size(346, 209);
            this.gridPuntos.TabIndex = 5;
            // 
            // i
            // 
            this.i.Frozen = true;
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // x
            // 
            this.x.Frozen = true;
            this.x.HeaderText = "xi";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.HeaderText = "yi=f(xi)";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBorrarCalc);
            this.groupBox2.Controls.Add(this.btCalcular);
            this.groupBox2.Controls.Add(this.tbValorK);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chMostrarPasos);
            this.groupBox2.Controls.Add(this.cbTipoPol);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(638, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btBorrarCalc
            // 
            this.btBorrarCalc.Location = new System.Drawing.Point(110, 194);
            this.btBorrarCalc.Name = "btBorrarCalc";
            this.btBorrarCalc.Size = new System.Drawing.Size(210, 23);
            this.btBorrarCalc.TabIndex = 7;
            this.btBorrarCalc.Text = "Borrar calculos";
            this.btBorrarCalc.UseVisualStyleBackColor = true;
            this.btBorrarCalc.Click += new System.EventHandler(this.btBorrarCalc_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(110, 148);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(210, 23);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbValorK
            // 
            this.tbValorK.Location = new System.Drawing.Point(152, 98);
            this.tbValorK.Name = "tbValorK";
            this.tbValorK.Size = new System.Drawing.Size(47, 20);
            this.tbValorK.TabIndex = 5;
            this.tbValorK.Text = "0";
            this.tbValorK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorNumerico_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Especializar para K=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mostrar pasos";
            // 
            // chMostrarPasos
            // 
            this.chMostrarPasos.AutoSize = true;
            this.chMostrarPasos.Location = new System.Drawing.Point(152, 73);
            this.chMostrarPasos.Name = "chMostrarPasos";
            this.chMostrarPasos.Size = new System.Drawing.Size(15, 14);
            this.chMostrarPasos.TabIndex = 2;
            this.chMostrarPasos.UseVisualStyleBackColor = true;
            // 
            // cbTipoPol
            // 
            this.cbTipoPol.FormattingEnabled = true;
            this.cbTipoPol.Items.AddRange(new object[] {
            "Lagrange",
            "Newton-Gregory Progresivo",
            "Newton-Gregory Regresivo"});
            this.cbTipoPol.Location = new System.Drawing.Point(152, 33);
            this.cbTipoPol.Name = "cbTipoPol";
            this.cbTipoPol.Size = new System.Drawing.Size(168, 21);
            this.cbTipoPol.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de polinomio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPasos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbPolinomioK);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbPolinomio);
            this.groupBox3.Location = new System.Drawing.Point(26, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(972, 383);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // tbPasos
            // 
            this.tbPasos.Location = new System.Drawing.Point(16, 86);
            this.tbPasos.Multiline = true;
            this.tbPasos.Name = "tbPasos";
            this.tbPasos.ReadOnly = true;
            this.tbPasos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPasos.Size = new System.Drawing.Size(903, 291);
            this.tbPasos.TabIndex = 5;
            this.tbPasos.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pasos";
            this.label7.Visible = false;
            // 
            // tbPolinomioK
            // 
            this.tbPolinomioK.Location = new System.Drawing.Point(737, 26);
            this.tbPolinomioK.Name = "tbPolinomioK";
            this.tbPolinomioK.ReadOnly = true;
            this.tbPolinomioK.Size = new System.Drawing.Size(100, 20);
            this.tbPolinomioK.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "P(K)=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Polinomio interpolante";
            // 
            // tbPolinomio
            // 
            this.tbPolinomio.Location = new System.Drawing.Point(122, 26);
            this.tbPolinomio.Name = "tbPolinomio";
            this.tbPolinomio.ReadOnly = true;
            this.tbPolinomio.Size = new System.Drawing.Size(543, 20);
            this.tbPolinomio.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 696);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Finter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbValorK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chMostrarPasos;
        private System.Windows.Forms.ComboBox cbTipoPol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPolinomioK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPolinomio;
        private System.Windows.Forms.DataGridView gridPuntos;
        private System.Windows.Forms.TextBox tbPasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbValorY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbValorX;
        private System.Windows.Forms.Button btBorrarCalc;
    }
}

