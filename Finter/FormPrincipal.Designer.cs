﻿namespace Finter
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpCargaDatos = new System.Windows.Forms.GroupBox();
            this.btLimpiarTodosLosPuntos = new System.Windows.Forms.Button();
            this.tbValorX = new System.Windows.Forms.TextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbValorY = new System.Windows.Forms.TextBox();
            this.lblInputY = new System.Windows.Forms.Label();
            this.lblInputX = new System.Windows.Forms.Label();
            this.gridPuntos = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btBorrarCalc = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbValorK = new System.Windows.Forms.TextBox();
            this.lblEspecializarParaK = new System.Windows.Forms.Label();
            this.lblMostrarPasos = new System.Windows.Forms.Label();
            this.chMostrarPasos = new System.Windows.Forms.CheckBox();
            this.cbTipoPol = new System.Windows.Forms.ComboBox();
            this.lblTipoPolinomio = new System.Windows.Forms.Label();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.tbPasos = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.tbPolinomioK = new System.Windows.Forms.TextBox();
            this.lblPolinomioK = new System.Windows.Forms.Label();
            this.lblPolinomioInterpolante = new System.Windows.Forms.Label();
            this.tbPolinomio = new System.Windows.Forms.TextBox();
            this.grpCargaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntos)).BeginInit();
            this.grpOpciones.SuspendLayout();
            this.grpResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(408, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Trabajo Práctio Matemática Superior";
            // 
            // grpCargaDatos
            // 
            this.grpCargaDatos.Controls.Add(this.btLimpiarTodosLosPuntos);
            this.grpCargaDatos.Controls.Add(this.tbValorX);
            this.grpCargaDatos.Controls.Add(this.btEliminar);
            this.grpCargaDatos.Controls.Add(this.btAgregar);
            this.grpCargaDatos.Controls.Add(this.tbValorY);
            this.grpCargaDatos.Controls.Add(this.lblInputY);
            this.grpCargaDatos.Controls.Add(this.lblInputX);
            this.grpCargaDatos.Controls.Add(this.gridPuntos);
            this.grpCargaDatos.Location = new System.Drawing.Point(26, 52);
            this.grpCargaDatos.Name = "grpCargaDatos";
            this.grpCargaDatos.Size = new System.Drawing.Size(606, 243);
            this.grpCargaDatos.TabIndex = 1;
            this.grpCargaDatos.TabStop = false;
            this.grpCargaDatos.Text = "Ingrese los datos";
            // 
            // btLimpiarTodosLosPuntos
            // 
            this.btLimpiarTodosLosPuntos.Location = new System.Drawing.Point(389, 205);
            this.btLimpiarTodosLosPuntos.Name = "btLimpiarTodosLosPuntos";
            this.btLimpiarTodosLosPuntos.Size = new System.Drawing.Size(207, 23);
            this.btLimpiarTodosLosPuntos.TabIndex = 14;
            this.btLimpiarTodosLosPuntos.Text = "Limpiar todos los puntos";
            this.btLimpiarTodosLosPuntos.UseVisualStyleBackColor = true;
            this.btLimpiarTodosLosPuntos.Click += new System.EventHandler(this.btLimpiarTodosLosPuntos_Click);
            // 
            // tbValorX
            // 
            this.tbValorX.Location = new System.Drawing.Point(410, 19);
            this.tbValorX.Name = "tbValorX";
            this.tbValorX.Size = new System.Drawing.Size(67, 20);
            this.tbValorX.TabIndex = 13;
            this.tbValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorNumerico_KeyPress);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(389, 176);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(207, 23);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar punto";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(389, 45);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(207, 23);
            this.btAgregar.TabIndex = 10;
            this.btAgregar.Text = "Agregar punto";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbValorY
            // 
            this.tbValorY.Location = new System.Drawing.Point(529, 19);
            this.tbValorY.Name = "tbValorY";
            this.tbValorY.Size = new System.Drawing.Size(67, 20);
            this.tbValorY.TabIndex = 9;
            this.tbValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorNumerico_KeyPress);
            // 
            // lblInputY
            // 
            this.lblInputY.AutoSize = true;
            this.lblInputY.Location = new System.Drawing.Point(505, 22);
            this.lblInputY.Name = "lblInputY";
            this.lblInputY.Size = new System.Drawing.Size(18, 13);
            this.lblInputY.TabIndex = 7;
            this.lblInputY.Text = "y=";
            // 
            // lblInputX
            // 
            this.lblInputX.AutoSize = true;
            this.lblInputX.Location = new System.Drawing.Point(386, 22);
            this.lblInputX.Name = "lblInputX";
            this.lblInputX.Size = new System.Drawing.Size(18, 13);
            this.lblInputX.TabIndex = 6;
            this.lblInputX.Text = "x=";
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
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.btBorrarCalc);
            this.grpOpciones.Controls.Add(this.btCalcular);
            this.grpOpciones.Controls.Add(this.tbValorK);
            this.grpOpciones.Controls.Add(this.lblEspecializarParaK);
            this.grpOpciones.Controls.Add(this.lblMostrarPasos);
            this.grpOpciones.Controls.Add(this.chMostrarPasos);
            this.grpOpciones.Controls.Add(this.cbTipoPol);
            this.grpOpciones.Controls.Add(this.lblTipoPolinomio);
            this.grpOpciones.Location = new System.Drawing.Point(638, 52);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(360, 243);
            this.grpOpciones.TabIndex = 2;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones";
            // 
            // btBorrarCalc
            // 
            this.btBorrarCalc.Location = new System.Drawing.Point(110, 205);
            this.btBorrarCalc.Name = "btBorrarCalc";
            this.btBorrarCalc.Size = new System.Drawing.Size(210, 23);
            this.btBorrarCalc.TabIndex = 7;
            this.btBorrarCalc.Text = "Borrar calculos";
            this.btBorrarCalc.UseVisualStyleBackColor = true;
            this.btBorrarCalc.Click += new System.EventHandler(this.btBorrarCalc_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(110, 136);
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
            // lblEspecializarParaK
            // 
            this.lblEspecializarParaK.AutoSize = true;
            this.lblEspecializarParaK.Location = new System.Drawing.Point(43, 103);
            this.lblEspecializarParaK.Name = "lblEspecializarParaK";
            this.lblEspecializarParaK.Size = new System.Drawing.Size(103, 13);
            this.lblEspecializarParaK.TabIndex = 4;
            this.lblEspecializarParaK.Text = "Especializar para K=";
            // 
            // lblMostrarPasos
            // 
            this.lblMostrarPasos.AutoSize = true;
            this.lblMostrarPasos.Location = new System.Drawing.Point(73, 72);
            this.lblMostrarPasos.Name = "lblMostrarPasos";
            this.lblMostrarPasos.Size = new System.Drawing.Size(73, 13);
            this.lblMostrarPasos.TabIndex = 3;
            this.lblMostrarPasos.Text = "Mostrar pasos";
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
            // lblTipoPolinomio
            // 
            this.lblTipoPolinomio.AutoSize = true;
            this.lblTipoPolinomio.Location = new System.Drawing.Point(56, 39);
            this.lblTipoPolinomio.Name = "lblTipoPolinomio";
            this.lblTipoPolinomio.Size = new System.Drawing.Size(90, 13);
            this.lblTipoPolinomio.TabIndex = 0;
            this.lblTipoPolinomio.Text = "Tipo de polinomio";
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.tbPasos);
            this.grpResultados.Controls.Add(this.lblPasos);
            this.grpResultados.Controls.Add(this.tbPolinomioK);
            this.grpResultados.Controls.Add(this.lblPolinomioK);
            this.grpResultados.Controls.Add(this.lblPolinomioInterpolante);
            this.grpResultados.Controls.Add(this.tbPolinomio);
            this.grpResultados.Location = new System.Drawing.Point(26, 301);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(972, 383);
            this.grpResultados.TabIndex = 3;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
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
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(6, 70);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(36, 13);
            this.lblPasos.TabIndex = 4;
            this.lblPasos.Text = "Pasos";
            this.lblPasos.Visible = false;
            // 
            // tbPolinomioK
            // 
            this.tbPolinomioK.Location = new System.Drawing.Point(737, 26);
            this.tbPolinomioK.Name = "tbPolinomioK";
            this.tbPolinomioK.ReadOnly = true;
            this.tbPolinomioK.Size = new System.Drawing.Size(100, 20);
            this.tbPolinomioK.TabIndex = 3;
            // 
            // lblPolinomioK
            // 
            this.lblPolinomioK.AutoSize = true;
            this.lblPolinomioK.Location = new System.Drawing.Point(697, 30);
            this.lblPolinomioK.Name = "lblPolinomioK";
            this.lblPolinomioK.Size = new System.Drawing.Size(33, 13);
            this.lblPolinomioK.TabIndex = 2;
            this.lblPolinomioK.Text = "P(K)=";
            // 
            // lblPolinomioInterpolante
            // 
            this.lblPolinomioInterpolante.AutoSize = true;
            this.lblPolinomioInterpolante.Location = new System.Drawing.Point(6, 29);
            this.lblPolinomioInterpolante.Name = "lblPolinomioInterpolante";
            this.lblPolinomioInterpolante.Size = new System.Drawing.Size(110, 13);
            this.lblPolinomioInterpolante.TabIndex = 1;
            this.lblPolinomioInterpolante.Text = "Polinomio interpolante";
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
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.grpCargaDatos);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Finter";
            this.grpCargaDatos.ResumeLayout(false);
            this.grpCargaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntos)).EndInit();
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpCargaDatos;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbValorK;
        private System.Windows.Forms.Label lblEspecializarParaK;
        private System.Windows.Forms.Label lblMostrarPasos;
        private System.Windows.Forms.CheckBox chMostrarPasos;
        private System.Windows.Forms.ComboBox cbTipoPol;
        private System.Windows.Forms.Label lblTipoPolinomio;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.TextBox tbPolinomioK;
        private System.Windows.Forms.Label lblPolinomioK;
        private System.Windows.Forms.Label lblPolinomioInterpolante;
        private System.Windows.Forms.TextBox tbPolinomio;
        private System.Windows.Forms.DataGridView gridPuntos;
        private System.Windows.Forms.TextBox tbPasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbValorY;
        private System.Windows.Forms.Label lblInputY;
        private System.Windows.Forms.Label lblInputX;
        private System.Windows.Forms.TextBox tbValorX;
        private System.Windows.Forms.Button btBorrarCalc;
        private System.Windows.Forms.Button btLimpiarTodosLosPuntos;
    }
}

