namespace TecnoLabsSA_Proyecto1
{
    partial class FormCarrito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAdministrador = new System.Windows.Forms.Label();
            this.BtnComprarPagar = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxItemsCarrito = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxCarrito = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxCarritoInferior = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnVolverInicio = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegresar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCarrito = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSesionCliente = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaClienteInicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailClienteInicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInicioSesionCliente = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItemsCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarritoInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelSesionCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdministrador
            // 
            this.labelAdministrador.AutoSize = true;
            this.labelAdministrador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(104)))), ((int)(((byte)(150)))));
            this.labelAdministrador.Location = new System.Drawing.Point(258, 26);
            this.labelAdministrador.Name = "labelAdministrador";
            this.labelAdministrador.Size = new System.Drawing.Size(244, 30);
            this.labelAdministrador.TabIndex = 11;
            this.labelAdministrador.Text = "CARRITO DE COMPRAS";
            // 
            // BtnComprarPagar
            // 
            this.BtnComprarPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            this.BtnComprarPagar.BorderRadius = 15;
            this.BtnComprarPagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnComprarPagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnComprarPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnComprarPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnComprarPagar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(71)))));
            this.BtnComprarPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprarPagar.ForeColor = System.Drawing.Color.White;
            this.BtnComprarPagar.Location = new System.Drawing.Point(774, 385);
            this.BtnComprarPagar.Name = "BtnComprarPagar";
            this.BtnComprarPagar.Size = new System.Drawing.Size(152, 32);
            this.BtnComprarPagar.TabIndex = 102;
            this.BtnComprarPagar.Text = "Pagar";
            // 
            // PictureBoxItemsCarrito
            // 
            this.PictureBoxItemsCarrito.BorderRadius = 25;
            this.PictureBoxItemsCarrito.Image = global::TecnoLabsSA_Proyecto1.Properties.Resources.Carrito_de_compras;
            this.PictureBoxItemsCarrito.ImageRotate = 0F;
            this.PictureBoxItemsCarrito.Location = new System.Drawing.Point(93, 79);
            this.PictureBoxItemsCarrito.Name = "PictureBoxItemsCarrito";
            this.PictureBoxItemsCarrito.Size = new System.Drawing.Size(870, 42);
            this.PictureBoxItemsCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxItemsCarrito.TabIndex = 13;
            this.PictureBoxItemsCarrito.TabStop = false;
            // 
            // PictureBoxCarrito
            // 
            this.PictureBoxCarrito.BorderRadius = 20;
            this.PictureBoxCarrito.Image = global::TecnoLabsSA_Proyecto1.Properties.Resources.carrito1;
            this.PictureBoxCarrito.ImageRotate = 0F;
            this.PictureBoxCarrito.Location = new System.Drawing.Point(9, 2);
            this.PictureBoxCarrito.Name = "PictureBoxCarrito";
            this.PictureBoxCarrito.Size = new System.Drawing.Size(241, 75);
            this.PictureBoxCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCarrito.TabIndex = 10;
            this.PictureBoxCarrito.TabStop = false;
            // 
            // PictureBoxCarritoInferior
            // 
            this.PictureBoxCarritoInferior.BorderRadius = 25;
            this.PictureBoxCarritoInferior.Image = global::TecnoLabsSA_Proyecto1.Properties.Resources.PARODI_PROMOS;
            this.PictureBoxCarritoInferior.ImageRotate = 0F;
            this.PictureBoxCarritoInferior.Location = new System.Drawing.Point(9, 421);
            this.PictureBoxCarritoInferior.Name = "PictureBoxCarritoInferior";
            this.PictureBoxCarritoInferior.Size = new System.Drawing.Size(986, 126);
            this.PictureBoxCarritoInferior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCarritoInferior.TabIndex = 9;
            this.PictureBoxCarritoInferior.TabStop = false;
            // 
            // BtnVolverInicio
            // 
            this.BtnVolverInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolverInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVolverInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVolverInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVolverInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVolverInicio.FillColor = System.Drawing.Color.RosyBrown;
            this.BtnVolverInicio.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverInicio.ForeColor = System.Drawing.Color.Black;
            this.BtnVolverInicio.Location = new System.Drawing.Point(1001, 458);
            this.BtnVolverInicio.Name = "BtnVolverInicio";
            this.BtnVolverInicio.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnVolverInicio.Size = new System.Drawing.Size(89, 58);
            this.BtnVolverInicio.TabIndex = 112;
            this.BtnVolverInicio.Text = "VOLVER";
            this.BtnVolverInicio.Click += new System.EventHandler(this.BtnVolverInicio_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotal.Location = new System.Drawing.Point(493, 390);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 24);
            this.labelTotal.TabIndex = 113;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.Crimson;
            this.btnActualizar.BorderRadius = 15;
            this.btnActualizar.BorderThickness = 2;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(317, 382);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 32);
            this.btnActualizar.TabIndex = 114;
            this.btnActualizar.Text = "Calcular Total";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            this.BtnRegresar.BorderColor = System.Drawing.Color.Crimson;
            this.BtnRegresar.BorderRadius = 15;
            this.BtnRegresar.BorderThickness = 2;
            this.BtnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(122, 382);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(160, 32);
            this.BtnRegresar.TabIndex = 104;
            this.BtnRegresar.Text = "Regresar";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            this.guna2Button1.BorderColor = System.Drawing.Color.Crimson;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(122, 146);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 32);
            this.guna2Button1.TabIndex = 115;
            this.guna2Button1.Text = "Quitar Producto";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.ColumnHeadersHeight = 30;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCarrito.Location = new System.Drawing.Point(317, 124);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.Size = new System.Drawing.Size(617, 254);
            this.dgvCarrito.TabIndex = 109;
            this.dgvCarrito.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCarrito.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.dgvCarrito.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCarrito.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCarrito.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCarrito.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCarrito.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCarrito.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCarrito.ThemeStyle.ReadOnly = false;
            this.dgvCarrito.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCarrito.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCarrito.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCarrito.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCarrito.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCarrito.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSesionCliente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 402);
            this.panel1.TabIndex = 116;
            // 
            // panelSesionCliente
            // 
            this.panelSesionCliente.Controls.Add(this.label1);
            this.panelSesionCliente.Controls.Add(this.txtContraseñaClienteInicio);
            this.panelSesionCliente.Controls.Add(this.txtEmailClienteInicio);
            this.panelSesionCliente.Controls.Add(this.label2);
            this.panelSesionCliente.Controls.Add(this.btnInicioSesionCliente);
            this.panelSesionCliente.Controls.Add(this.label3);
            this.panelSesionCliente.Controls.Add(this.label4);
            this.panelSesionCliente.Location = new System.Drawing.Point(25, 17);
            this.panelSesionCliente.Name = "panelSesionCliente";
            this.panelSesionCliente.Size = new System.Drawing.Size(500, 368);
            this.panelSesionCliente.TabIndex = 21;
            this.panelSesionCliente.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "       Iniciar Sesion";
            // 
            // txtContraseñaClienteInicio
            // 
            this.txtContraseñaClienteInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.txtContraseñaClienteInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.txtContraseñaClienteInicio.BorderRadius = 10;
            this.txtContraseñaClienteInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseñaClienteInicio.DefaultText = "";
            this.txtContraseñaClienteInicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseñaClienteInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseñaClienteInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaClienteInicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaClienteInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.txtContraseñaClienteInicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaClienteInicio.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaClienteInicio.ForeColor = System.Drawing.Color.Black;
            this.txtContraseñaClienteInicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaClienteInicio.Location = new System.Drawing.Point(104, 134);
            this.txtContraseñaClienteInicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtContraseñaClienteInicio.Name = "txtContraseñaClienteInicio";
            this.txtContraseñaClienteInicio.PasswordChar = '*';
            this.txtContraseñaClienteInicio.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtContraseñaClienteInicio.PlaceholderText = "    Contraseña";
            this.txtContraseñaClienteInicio.SelectedText = "";
            this.txtContraseñaClienteInicio.Size = new System.Drawing.Size(277, 31);
            this.txtContraseñaClienteInicio.TabIndex = 11;
            // 
            // txtEmailClienteInicio
            // 
            this.txtEmailClienteInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.txtEmailClienteInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.txtEmailClienteInicio.BorderRadius = 10;
            this.txtEmailClienteInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailClienteInicio.DefaultText = "";
            this.txtEmailClienteInicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailClienteInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailClienteInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailClienteInicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailClienteInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.txtEmailClienteInicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailClienteInicio.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailClienteInicio.ForeColor = System.Drawing.Color.Black;
            this.txtEmailClienteInicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailClienteInicio.Location = new System.Drawing.Point(106, 83);
            this.txtEmailClienteInicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmailClienteInicio.Name = "txtEmailClienteInicio";
            this.txtEmailClienteInicio.PasswordChar = '\0';
            this.txtEmailClienteInicio.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtEmailClienteInicio.PlaceholderText = "    Email";
            this.txtEmailClienteInicio.SelectedText = "";
            this.txtEmailClienteInicio.Size = new System.Drawing.Size(277, 31);
            this.txtEmailClienteInicio.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(104)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(250, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "REGISTRATE";
            // 
            // btnInicioSesionCliente
            // 
            this.btnInicioSesionCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicioSesionCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicioSesionCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicioSesionCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicioSesionCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.btnInicioSesionCliente.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesionCliente.ForeColor = System.Drawing.Color.White;
            this.btnInicioSesionCliente.Location = new System.Drawing.Point(103, 235);
            this.btnInicioSesionCliente.Name = "btnInicioSesionCliente";
            this.btnInicioSesionCliente.Size = new System.Drawing.Size(278, 40);
            this.btnInicioSesionCliente.TabIndex = 9;
            this.btnInicioSesionCliente.Text = "Iniciar sesion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "¿No tienes cuenta?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "¿Olvidaste tu contraseña?";
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1035, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.BtnVolverInicio);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnComprarPagar);
            this.Controls.Add(this.PictureBoxItemsCarrito);
            this.Controls.Add(this.labelAdministrador);
            this.Controls.Add(this.PictureBoxCarrito);
            this.Controls.Add(this.PictureBoxCarritoInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarrito";
            this.Text = "FormCarrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItemsCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarritoInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelSesionCliente.ResumeLayout(false);
            this.panelSesionCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxCarritoInferior;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxCarrito;
        private System.Windows.Forms.Label labelAdministrador;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxItemsCarrito;
        private Guna.UI2.WinForms.Guna2Button BtnComprarPagar;
        private Guna.UI2.WinForms.Guna2CircleButton BtnVolverInicio;
        private System.Windows.Forms.Label labelTotal;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button BtnRegresar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCarrito;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel panelSesionCliente;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseñaClienteInicio;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailClienteInicio;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnInicioSesionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}