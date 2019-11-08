using System;

namespace Comanda
{
    partial class FrmRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestaurante));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnCobrar = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.ComboBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblGrid = new System.Windows.Forms.Label();
            this.LblSeleccionar = new System.Windows.Forms.Label();
            this.LblMenu = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DtgData = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbSeleccionar = new System.Windows.Forms.ListBox();
            this.CbMenu = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsHerramienta = new System.Windows.Forms.ToolStripMenuItem();
            this.TsAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsCobrar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.TsAcercaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.PbLogo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BtnCobrar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BtnClean);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TxtCantidad);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TxtPrecio);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblPrecio);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblCantidad);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BtnAdd);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblGrid);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblSeleccionar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblMenu);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TxtTotal);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblTotal);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DtgData);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LbSeleccionar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CbMenu);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(979, 528);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(979, 556);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // PbLogo
            // 
            this.PbLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbLogo.BackgroundImage")));
            this.PbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbLogo.Location = new System.Drawing.Point(741, 30);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(185, 231);
            this.PbLogo.TabIndex = 20;
            this.PbLogo.TabStop = false;
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.Location = new System.Drawing.Point(816, 411);
            this.BtnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(100, 28);
            this.BtnCobrar.TabIndex = 8;
            this.BtnCobrar.Text = "Cobrar";
            this.BtnCobrar.UseVisualStyleBackColor = true;
            this.BtnCobrar.Click += new System.EventHandler(this.buttonCobrar_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(520, 220);
            this.BtnClean.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(100, 28);
            this.BtnClean.TabIndex = 6;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.FormattingEnabled = true;
            this.TxtCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.TxtCantidad.Location = new System.Drawing.Point(509, 53);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(132, 24);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.Text = "0";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(509, 114);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(132, 22);
            this.TxtPrecio.TabIndex = 4;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(516, 95);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(48, 17);
            this.LblPrecio.TabIndex = 15;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(509, 31);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(64, 17);
            this.LblCantidad.TabIndex = 14;
            this.LblCantidad.Text = "Cantidad";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(360, 220);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 28);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // LblGrid
            // 
            this.LblGrid.AutoSize = true;
            this.LblGrid.Location = new System.Drawing.Point(391, 294);
            this.LblGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGrid.Name = "LblGrid";
            this.LblGrid.Size = new System.Drawing.Size(68, 17);
            this.LblGrid.TabIndex = 11;
            this.LblGrid.Text = "Comanda";
            // 
            // LblSeleccionar
            // 
            this.LblSeleccionar.AutoSize = true;
            this.LblSeleccionar.Location = new System.Drawing.Point(287, 30);
            this.LblSeleccionar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSeleccionar.Name = "LblSeleccionar";
            this.LblSeleccionar.Size = new System.Drawing.Size(116, 17);
            this.LblSeleccionar.TabIndex = 10;
            this.LblSeleccionar.Text = "Seleccionar Lista";
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Location = new System.Drawing.Point(80, 30);
            this.LblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(43, 17);
            this.LblMenu.TabIndex = 8;
            this.LblMenu.Text = "Menu";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(816, 348);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(132, 22);
            this.TxtTotal.TabIndex = 7;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(760, 352);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "Total";
            // 
            // DtgData
            // 
            this.DtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.DtgData.Location = new System.Drawing.Point(51, 318);
            this.DtgData.Margin = new System.Windows.Forms.Padding(4);
            this.DtgData.Name = "DtgData";
            this.DtgData.ReadOnly = true;
            this.DtgData.RowHeadersWidth = 49;
            this.DtgData.Size = new System.Drawing.Size(672, 194);
            this.DtgData.TabIndex = 9;
            this.DtgData.TabStop = false;
            this.DtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 120;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // LbSeleccionar
            // 
            this.LbSeleccionar.FormattingEnabled = true;
            this.LbSeleccionar.ItemHeight = 16;
            this.LbSeleccionar.Items.AddRange(new object[] {
            "none"});
            this.LbSeleccionar.Location = new System.Drawing.Point(279, 53);
            this.LbSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.LbSeleccionar.Name = "LbSeleccionar";
            this.LbSeleccionar.Size = new System.Drawing.Size(180, 148);
            this.LbSeleccionar.TabIndex = 2;
            // 
            // CbMenu
            // 
            this.CbMenu.FormattingEnabled = true;
            this.CbMenu.Location = new System.Drawing.Point(28, 53);
            this.CbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.CbMenu.Name = "CbMenu";
            this.CbMenu.Size = new System.Drawing.Size(160, 24);
            this.CbMenu.TabIndex = 1;
            this.CbMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsArchivo,
            this.TsHerramienta,
            this.TsAcerca});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsArchivo
            // 
            this.TsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsNuevo,
            this.TsCerrar});
            this.TsArchivo.Name = "TsArchivo";
            this.TsArchivo.Size = new System.Drawing.Size(73, 24);
            this.TsArchivo.Text = "Archivo";
            // 
            // TsNuevo
            // 
            this.TsNuevo.Name = "TsNuevo";
            this.TsNuevo.Size = new System.Drawing.Size(134, 26);
            this.TsNuevo.Text = "Nuevo";
            this.TsNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // TsCerrar
            // 
            this.TsCerrar.Name = "TsCerrar";
            this.TsCerrar.Size = new System.Drawing.Size(134, 26);
            this.TsCerrar.Text = "Cerrar";
            this.TsCerrar.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // TsHerramienta
            // 
            this.TsHerramienta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsAgregar,
            this.TsLimpiar,
            this.TsCobrar});
            this.TsHerramienta.Name = "TsHerramienta";
            this.TsHerramienta.Size = new System.Drawing.Size(106, 24);
            this.TsHerramienta.Text = "Herramienta";
            // 
            // TsAgregar
            // 
            this.TsAgregar.Name = "TsAgregar";
            this.TsAgregar.Size = new System.Drawing.Size(145, 26);
            this.TsAgregar.Text = "Agregar";
            this.TsAgregar.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // TsLimpiar
            // 
            this.TsLimpiar.Name = "TsLimpiar";
            this.TsLimpiar.Size = new System.Drawing.Size(145, 26);
            this.TsLimpiar.Text = "Limpiar";
            this.TsLimpiar.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // TsCobrar
            // 
            this.TsCobrar.Name = "TsCobrar";
            this.TsCobrar.Size = new System.Drawing.Size(145, 26);
            this.TsCobrar.Text = "Cobrar";
            this.TsCobrar.Click += new System.EventHandler(this.cobrarToolStripMenuItem_Click);
            // 
            // TsAcerca
            // 
            this.TsAcerca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsAcercaInfo});
            this.TsAcerca.Name = "TsAcerca";
            this.TsAcerca.Size = new System.Drawing.Size(89, 24);
            this.TsAcerca.Text = "Acerca de";
            // 
            // TsAcercaInfo
            // 
            this.TsAcercaInfo.Name = "TsAcercaInfo";
            this.TsAcercaInfo.Size = new System.Drawing.Size(157, 26);
            this.TsAcercaInfo.Text = "Acerca de";
            this.TsAcercaInfo.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmRestaurante
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 556);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRestaurante";
            this.Text = "Restaurante el DELIZIOSO";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DtgData;
        private System.Windows.Forms.ListBox LbSeleccionar;
        private System.Windows.Forms.ComboBox CbMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsArchivo;
        private System.Windows.Forms.Label LblGrid;
        private System.Windows.Forms.Label LblSeleccionar;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox TxtCantidad;
        private System.Windows.Forms.Button BtnCobrar;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.ToolStripMenuItem TsNuevo;
        private System.Windows.Forms.ToolStripMenuItem TsCerrar;
        private System.Windows.Forms.ToolStripMenuItem TsHerramienta;
        private System.Windows.Forms.ToolStripMenuItem TsAgregar;
        private System.Windows.Forms.ToolStripMenuItem TsLimpiar;
        private System.Windows.Forms.ToolStripMenuItem TsCobrar;
        private System.Windows.Forms.ToolStripMenuItem TsAcerca;
        private System.Windows.Forms.ToolStripMenuItem TsAcercaInfo;
    }
}

