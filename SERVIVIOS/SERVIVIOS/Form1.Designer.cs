namespace SERVIVIOS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpSocio = new System.Windows.Forms.GroupBox();
            this.lblCodigoSocio = new System.Windows.Forms.Label();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.lblIngresoSocio = new System.Windows.Forms.Label();
            this.txtIngresoSocio = new System.Windows.Forms.TextBox();
            this.grpPrestamo = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblTasa = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.lblRangoMonto = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.lblRangoPlazo = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.cboGarantia = new System.Windows.Forms.ComboBox();
            this.lblRequisito = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.grpSocio.SuspendLayout();
            this.grpPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(900, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitud de préstamo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSocio
            // 
            this.grpSocio.Controls.Add(this.lblCodigoSocio);
            this.grpSocio.Controls.Add(this.txtCodigoSocio);
            this.grpSocio.Controls.Add(this.btnBuscarSocio);
            this.grpSocio.Controls.Add(this.lblNombreSocio);
            this.grpSocio.Controls.Add(this.txtNombreSocio);
            this.grpSocio.Controls.Add(this.lblIngresoSocio);
            this.grpSocio.Controls.Add(this.txtIngresoSocio);
            this.grpSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpSocio.Location = new System.Drawing.Point(20, 75);
            this.grpSocio.Name = "grpSocio";
            this.grpSocio.Size = new System.Drawing.Size(860, 70);
            this.grpSocio.TabIndex = 1;
            this.grpSocio.TabStop = false;
            this.grpSocio.Text = "Socio";
            // 
            // lblCodigoSocio
            // 
            this.lblCodigoSocio.AutoSize = true;
            this.lblCodigoSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblCodigoSocio.Location = new System.Drawing.Point(15, 31);
            this.lblCodigoSocio.Name = "lblCodigoSocio";
            this.lblCodigoSocio.Size = new System.Drawing.Size(56, 19);
            this.lblCodigoSocio.TabIndex = 0;
            this.lblCodigoSocio.Text = "Código:";
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Location = new System.Drawing.Point(80, 28);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.Size = new System.Drawing.Size(100, 25);
            this.txtCodigoSocio.TabIndex = 1;
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnBuscarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSocio.FlatAppearance.BorderSize = 0;
            this.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSocio.Location = new System.Drawing.Point(186, 28);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(120, 36);
            this.btnBuscarSocio.TabIndex = 2;
            this.btnBuscarSocio.Text = "Buscar socio";
            this.btnBuscarSocio.UseVisualStyleBackColor = false;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNombreSocio.Location = new System.Drawing.Point(325, 31);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(62, 19);
            this.lblNombreSocio.TabIndex = 3;
            this.lblNombreSocio.Text = "Nombre:";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(395, 28);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(235, 25);
            this.txtNombreSocio.TabIndex = 4;
            // 
            // lblIngresoSocio
            // 
            this.lblIngresoSocio.AutoSize = true;
            this.lblIngresoSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblIngresoSocio.Location = new System.Drawing.Point(645, 31);
            this.lblIngresoSocio.Name = "lblIngresoSocio";
            this.lblIngresoSocio.Size = new System.Drawing.Size(58, 19);
            this.lblIngresoSocio.TabIndex = 5;
            this.lblIngresoSocio.Text = "Ingreso:";
            // 
            // txtIngresoSocio
            // 
            this.txtIngresoSocio.Location = new System.Drawing.Point(715, 28);
            this.txtIngresoSocio.Name = "txtIngresoSocio";
            this.txtIngresoSocio.ReadOnly = true;
            this.txtIngresoSocio.Size = new System.Drawing.Size(125, 25);
            this.txtIngresoSocio.TabIndex = 6;
            this.txtIngresoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpPrestamo
            // 
            this.grpPrestamo.Controls.Add(this.lblTipo);
            this.grpPrestamo.Controls.Add(this.cboTipoPrestamo);
            this.grpPrestamo.Controls.Add(this.lblTasa);
            this.grpPrestamo.Controls.Add(this.txtTasa);
            this.grpPrestamo.Controls.Add(this.lblFecha);
            this.grpPrestamo.Controls.Add(this.dtpFecha);
            this.grpPrestamo.Controls.Add(this.lblEstado);
            this.grpPrestamo.Controls.Add(this.txtEstado);
            this.grpPrestamo.Controls.Add(this.lblMonto);
            this.grpPrestamo.Controls.Add(this.nudMonto);
            this.grpPrestamo.Controls.Add(this.lblRangoMonto);
            this.grpPrestamo.Controls.Add(this.lblPlazo);
            this.grpPrestamo.Controls.Add(this.nudPlazo);
            this.grpPrestamo.Controls.Add(this.lblRangoPlazo);
            this.grpPrestamo.Controls.Add(this.lblGarantia);
            this.grpPrestamo.Controls.Add(this.cboGarantia);
            this.grpPrestamo.Controls.Add(this.lblRequisito);
            this.grpPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpPrestamo.Location = new System.Drawing.Point(20, 155);
            this.grpPrestamo.Name = "grpPrestamo";
            this.grpPrestamo.Size = new System.Drawing.Size(860, 200);
            this.grpPrestamo.TabIndex = 2;
            this.grpPrestamo.TabStop = false;
            this.grpPrestamo.Text = "Datos del préstamo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblTipo.Location = new System.Drawing.Point(15, 33);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 19);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipoPrestamo
            // 
            this.cboTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPrestamo.FormattingEnabled = true;
            this.cboTipoPrestamo.Location = new System.Drawing.Point(65, 30);
            this.cboTipoPrestamo.Name = "cboTipoPrestamo";
            this.cboTipoPrestamo.Size = new System.Drawing.Size(190, 25);
            this.cboTipoPrestamo.TabIndex = 1;
            this.cboTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cboTipoPrestamo_SelectedIndexChanged);
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblTasa.Location = new System.Drawing.Point(270, 33);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(74, 19);
            this.lblTasa.TabIndex = 2;
            this.lblTasa.Text = "Tasa anual:";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(365, 30);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.ReadOnly = true;
            this.txtTasa.Size = new System.Drawing.Size(65, 25);
            this.txtTasa.TabIndex = 3;
            this.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblFecha.Location = new System.Drawing.Point(445, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 19);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(503, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 25);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblEstado.Location = new System.Drawing.Point(640, 33);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 19);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(710, 30);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(130, 25);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.Text = "Pendiente";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblMonto.Location = new System.Drawing.Point(15, 78);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(80, 19);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto (Bs):";
            // 
            // nudMonto
            // 
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMonto.Location = new System.Drawing.Point(115, 75);
            this.nudMonto.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(140, 25);
            this.nudMonto.TabIndex = 9;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMonto.ThousandsSeparator = true;
            // 
            // lblRangoMonto
            // 
            this.lblRangoMonto.AutoSize = true;
            this.lblRangoMonto.ForeColor = System.Drawing.Color.Gray;
            this.lblRangoMonto.Location = new System.Drawing.Point(270, 78);
            this.lblRangoMonto.Name = "lblRangoMonto";
            this.lblRangoMonto.Size = new System.Drawing.Size(100, 19);
            this.lblRangoMonto.TabIndex = 10;
            this.lblRangoMonto.Text = "Rango: Bs - a -";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblPlazo.Location = new System.Drawing.Point(15, 123);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(94, 19);
            this.lblPlazo.TabIndex = 11;
            this.lblPlazo.Text = "Plazo (meses):";
            // 
            // nudPlazo
            // 
            this.nudPlazo.Location = new System.Drawing.Point(130, 120);
            this.nudPlazo.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(80, 25);
            this.nudPlazo.TabIndex = 12;
            this.nudPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRangoPlazo
            // 
            this.lblRangoPlazo.AutoSize = true;
            this.lblRangoPlazo.ForeColor = System.Drawing.Color.Gray;
            this.lblRangoPlazo.Location = new System.Drawing.Point(225, 123);
            this.lblRangoPlazo.Name = "lblRangoPlazo";
            this.lblRangoPlazo.Size = new System.Drawing.Size(124, 19);
            this.lblRangoPlazo.TabIndex = 13;
            this.lblRangoPlazo.Text = "Rango: - a - meses";
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblGarantia.Location = new System.Drawing.Point(470, 123);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(64, 19);
            this.lblGarantia.TabIndex = 14;
            this.lblGarantia.Text = "Garantía:";
            // 
            // cboGarantia
            // 
            this.cboGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGarantia.FormattingEnabled = true;
            this.cboGarantia.Location = new System.Drawing.Point(550, 120);
            this.cboGarantia.Name = "cboGarantia";
            this.cboGarantia.Size = new System.Drawing.Size(180, 25);
            this.cboGarantia.TabIndex = 15;
            // 
            // lblRequisito
            // 
            this.lblRequisito.AutoSize = true;
            this.lblRequisito.ForeColor = System.Drawing.Color.Gray;
            this.lblRequisito.Location = new System.Drawing.Point(15, 165);
            this.lblRequisito.Name = "lblRequisito";
            this.lblRequisito.Size = new System.Drawing.Size(78, 19);
            this.lblRequisito.TabIndex = 16;
            this.lblRequisito.Text = "Requisito: -";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(20, 365);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 36);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(140, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 36);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(260, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnDocumentos.Location = new System.Drawing.Point(660, 365);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(220, 36);
            this.btnDocumentos.TabIndex = 6;
            this.btnDocumentos.Text = "Documentos y garantías";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudes.ColumnHeadersHeight = 36;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolicitudes.EnableHeadersVisualStyles = false;
            this.dgvSolicitudes.Location = new System.Drawing.Point(20, 415);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(860, 225);
            this.dgvSolicitudes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 660);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.btnDocumentos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpPrestamo);
            this.Controls.Add(this.grpSocio);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(916, 699);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de préstamo";
            this.Load += new System.EventHandler(this.FrmSolicitudPrestamo_Load);
            this.grpSocio.ResumeLayout(false);
            this.grpSocio.PerformLayout();
            this.grpPrestamo.ResumeLayout(false);
            this.grpPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpSocio;
        private System.Windows.Forms.Label lblCodigoSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.Label lblIngresoSocio;
        private System.Windows.Forms.TextBox txtIngresoSocio;
        private System.Windows.Forms.GroupBox grpPrestamo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipoPrestamo;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label lblRangoMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.NumericUpDown nudPlazo;
        private System.Windows.Forms.Label lblRangoPlazo;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.ComboBox cboGarantia;
        private System.Windows.Forms.Label lblRequisito;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
    }
}