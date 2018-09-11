namespace TPS_BugTracker
{
    partial class frmBugs
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
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.cboCriticidades = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPrioridades = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboAsignadoA = new System.Windows.Forms.ComboBox();
            this.lbl_asignado = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            this.id_bug_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_pasar_a_te = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_detalle_bug = new System.Windows.Forms.Button();
            this.pnl_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.cboProductos);
            this.pnl_filtros.Controls.Add(this.Label5);
            this.pnl_filtros.Controls.Add(this.txtFechaHasta);
            this.pnl_filtros.Controls.Add(this.Label4);
            this.pnl_filtros.Controls.Add(this.Label3);
            this.pnl_filtros.Controls.Add(this.txtFechaDesde);
            this.pnl_filtros.Controls.Add(this.cboCriticidades);
            this.pnl_filtros.Controls.Add(this.Label1);
            this.pnl_filtros.Controls.Add(this.cboPrioridades);
            this.pnl_filtros.Controls.Add(this.Label2);
            this.pnl_filtros.Controls.Add(this.btnConsultar);
            this.pnl_filtros.Controls.Add(this.cboAsignadoA);
            this.pnl_filtros.Controls.Add(this.lbl_asignado);
            this.pnl_filtros.Controls.Add(this.cboEstados);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Location = new System.Drawing.Point(12, 12);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(832, 136);
            this.pnl_filtros.TabIndex = 1;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(374, 75);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(181, 21);
            this.cboProductos.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(313, 78);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 13);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Producto:";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(374, 22);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(180, 20);
            this.txtFechaHasta.TabIndex = 13;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(302, 25);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Fecha Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Fecha desde:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(76, 22);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(181, 20);
            this.txtFechaDesde.TabIndex = 9;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // cboCriticidades
            // 
            this.cboCriticidades.FormattingEnabled = true;
            this.cboCriticidades.Location = new System.Drawing.Point(374, 48);
            this.cboCriticidades.Name = "cboCriticidades";
            this.cboCriticidades.Size = new System.Drawing.Size(181, 21);
            this.cboCriticidades.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(313, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Criticidad:";
            // 
            // cboPrioridades
            // 
            this.cboPrioridades.FormattingEnabled = true;
            this.cboPrioridades.Location = new System.Drawing.Point(76, 102);
            this.cboPrioridades.Name = "cboPrioridades";
            this.cboPrioridades.Size = new System.Drawing.Size(181, 21);
            this.cboPrioridades.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Prioridad:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(738, 103);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboAsignadoA
            // 
            this.cboAsignadoA.FormattingEnabled = true;
            this.cboAsignadoA.Location = new System.Drawing.Point(76, 75);
            this.cboAsignadoA.Name = "cboAsignadoA";
            this.cboAsignadoA.Size = new System.Drawing.Size(181, 21);
            this.cboAsignadoA.TabIndex = 3;
            // 
            // lbl_asignado
            // 
            this.lbl_asignado.AutoSize = true;
            this.lbl_asignado.Location = new System.Drawing.Point(7, 78);
            this.lbl_asignado.Name = "lbl_asignado";
            this.lbl_asignado.Size = new System.Drawing.Size(63, 13);
            this.lbl_asignado.TabIndex = 2;
            this.lbl_asignado.Text = "Asignado a:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(76, 48);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(181, 21);
            this.cboEstados.TabIndex = 1;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(32, 51);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Estado:";
            // 
            // dgvBugs
            // 
            this.dgvBugs.AllowUserToAddRows = false;
            this.dgvBugs.AllowUserToDeleteRows = false;
            this.dgvBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bug_col,
            this.colTitulo});
            this.dgvBugs.Location = new System.Drawing.Point(12, 154);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.ReadOnly = true;
            this.dgvBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBugs.Size = new System.Drawing.Size(832, 275);
            this.dgvBugs.TabIndex = 6;
            this.dgvBugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugs_CellClick);
            this.dgvBugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugs_CellContentClick);
            // 
            // id_bug_col
            // 
            this.id_bug_col.DataPropertyName = "id_bug";
            this.id_bug_col.HeaderText = "ID";
            this.id_bug_col.Name = "id_bug_col";
            this.id_bug_col.ReadOnly = true;
            this.id_bug_col.Visible = false;
            // 
            // colTitulo
            // 
            this.colTitulo.DataPropertyName = "titulo";
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // btn_pasar_a_te
            // 
            this.btn_pasar_a_te.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_pasar_a_te.Enabled = false;
            this.btn_pasar_a_te.Image = global::TPS_BugTracker.Properties.Resources.cerrarBug;
            this.btn_pasar_a_te.Location = new System.Drawing.Point(143, 445);
            this.btn_pasar_a_te.Name = "btn_pasar_a_te";
            this.btn_pasar_a_te.Size = new System.Drawing.Size(40, 40);
            this.btn_pasar_a_te.TabIndex = 18;
            this.btn_pasar_a_te.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.Image = global::TPS_BugTracker.Properties.Resources.salir;
            this.btn_salir.Location = new System.Drawing.Point(805, 445);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 40);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.Enabled = false;
            this.btn_editar.Image = global::TPS_BugTracker.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(97, 445);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(40, 40);
            this.btn_editar.TabIndex = 15;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_asignar
            // 
            this.btn_asignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_asignar.Enabled = false;
            this.btn_asignar.Image = global::TPS_BugTracker.Properties.Resources.user_log;
            this.btn_asignar.Location = new System.Drawing.Point(54, 445);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(40, 40);
            this.btn_asignar.TabIndex = 14;
            this.btn_asignar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.Enabled = false;
            this.btn_nuevo.Image = global::TPS_BugTracker.Properties.Resources.agregar;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 445);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(40, 40);
            this.btn_nuevo.TabIndex = 13;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cerrar.Enabled = false;
            this.btn_cerrar.Image = global::TPS_BugTracker.Properties.Resources.Empty_Recycle_Bin_2000;
            this.btn_cerrar.Location = new System.Drawing.Point(189, 445);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(40, 40);
            this.btn_cerrar.TabIndex = 19;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_detalle_bug
            // 
            this.btn_detalle_bug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_detalle_bug.Enabled = false;
            this.btn_detalle_bug.Image = global::TPS_BugTracker.Properties.Resources.comentar;
            this.btn_detalle_bug.Location = new System.Drawing.Point(289, 445);
            this.btn_detalle_bug.Name = "btn_detalle_bug";
            this.btn_detalle_bug.Size = new System.Drawing.Size(38, 40);
            this.btn_detalle_bug.TabIndex = 17;
            this.btn_detalle_bug.UseVisualStyleBackColor = true;
            this.btn_detalle_bug.Click += new System.EventHandler(this.btn_detalle_bug_Click);
            // 
            // frmBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 504);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_pasar_a_te);
            this.Controls.Add(this.btn_detalle_bug);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgvBugs);
            this.Controls.Add(this.pnl_filtros);
            this.Name = "frmBugs";
            this.Text = "frmBugs";
            this.Load += new System.EventHandler(this.frmBugs_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox pnl_filtros;
        internal System.Windows.Forms.ComboBox cboProductos;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.MaskedTextBox txtFechaHasta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MaskedTextBox txtFechaDesde;
        internal System.Windows.Forms.ComboBox cboCriticidades;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboPrioridades;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.ComboBox cboAsignadoA;
        internal System.Windows.Forms.Label lbl_asignado;
        internal System.Windows.Forms.ComboBox cboEstados;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.DataGridView dgvBugs;
        internal System.Windows.Forms.Button btn_cerrar;
        internal System.Windows.Forms.Button btn_pasar_a_te;
        internal System.Windows.Forms.Button btn_detalle_bug;
        internal System.Windows.Forms.Button btn_salir;
        internal System.Windows.Forms.Button btn_editar;
        internal System.Windows.Forms.Button btn_asignar;
        internal System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bug_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;

    }
}