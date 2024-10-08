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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItemsCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarritoInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdministrador
            // 
            this.labelAdministrador.AutoSize = true;
            this.labelAdministrador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(104)))), ((int)(((byte)(150)))));
            this.labelAdministrador.Location = new System.Drawing.Point(344, 32);
            this.labelAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdministrador.Name = "labelAdministrador";
            this.labelAdministrador.Size = new System.Drawing.Size(313, 37);
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
            this.BtnComprarPagar.Location = new System.Drawing.Point(1032, 474);
            this.BtnComprarPagar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnComprarPagar.Name = "BtnComprarPagar";
            this.BtnComprarPagar.Size = new System.Drawing.Size(203, 39);
            this.BtnComprarPagar.TabIndex = 102;
            this.BtnComprarPagar.Text = "Pagar";
            // 
            // PictureBoxItemsCarrito
            // 
            this.PictureBoxItemsCarrito.BorderRadius = 25;
            this.PictureBoxItemsCarrito.Image = global::TecnoLabsSA_Proyecto1.Properties.Resources.Carrito_de_compras;
            this.PictureBoxItemsCarrito.ImageRotate = 0F;
            this.PictureBoxItemsCarrito.Location = new System.Drawing.Point(124, 97);
            this.PictureBoxItemsCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxItemsCarrito.Name = "PictureBoxItemsCarrito";
            this.PictureBoxItemsCarrito.Size = new System.Drawing.Size(1160, 52);
            this.PictureBoxItemsCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxItemsCarrito.TabIndex = 13;
            this.PictureBoxItemsCarrito.TabStop = false;
            // 
            // PictureBoxCarrito
            // 
            this.PictureBoxCarrito.BorderRadius = 20;
            this.PictureBoxCarrito.Image = global::TecnoLabsSA_Proyecto1.Properties.Resources.carrito1;
            this.PictureBoxCarrito.ImageRotate = 0F;
            this.PictureBoxCarrito.Location = new System.Drawing.Point(12, 2);
            this.PictureBoxCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxCarrito.Name = "PictureBoxCarrito";
            this.PictureBoxCarrito.Size = new System.Drawing.Size(321, 92);
            this.PictureBoxCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCarrito.TabIndex = 10;
            this.PictureBoxCarrito.TabStop = false;
            // 
            // PictureBoxCarritoInferior
            // 
            this.PictureBoxCarritoInferior.BorderRadius = 25;
            this.PictureBoxCarritoInferior.Image = global::TecnoLabsSA_Proyecto1.Properties.Resources.PARODI_PROMOS;
            this.PictureBoxCarritoInferior.ImageRotate = 0F;
            this.PictureBoxCarritoInferior.Location = new System.Drawing.Point(12, 518);
            this.PictureBoxCarritoInferior.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxCarritoInferior.Name = "PictureBoxCarritoInferior";
            this.PictureBoxCarritoInferior.Size = new System.Drawing.Size(1315, 155);
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
            this.BtnVolverInicio.Location = new System.Drawing.Point(1335, 564);
            this.BtnVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVolverInicio.Name = "BtnVolverInicio";
            this.BtnVolverInicio.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnVolverInicio.Size = new System.Drawing.Size(119, 71);
            this.BtnVolverInicio.TabIndex = 112;
            this.BtnVolverInicio.Text = "VOLVER";
            this.BtnVolverInicio.Click += new System.EventHandler(this.BtnVolverInicio_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotal.Location = new System.Drawing.Point(657, 480);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 29);
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
            this.btnActualizar.Location = new System.Drawing.Point(423, 470);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(213, 39);
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
            this.BtnRegresar.Location = new System.Drawing.Point(162, 470);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(213, 39);
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
            this.guna2Button1.Location = new System.Drawing.Point(162, 180);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(213, 39);
            this.guna2Button1.TabIndex = 115;
            this.guna2Button1.Text = "Quitar Producto";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.dgvCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCarrito.Location = new System.Drawing.Point(423, 153);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.Size = new System.Drawing.Size(823, 313);
            this.dgvCarrito.TabIndex = 109;
            this.dgvCarrito.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCarrito.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.dgvCarrito.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCarrito.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCarrito.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCarrito.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCarrito.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCarrito.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCarrito.ThemeStyle.ReadOnly = false;
            this.dgvCarrito.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCarrito.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCarrito.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCarrito.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCarrito.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCarrito.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1472, 678);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCarrito";
            this.Text = "FormCarrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItemsCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCarritoInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
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
    }
}