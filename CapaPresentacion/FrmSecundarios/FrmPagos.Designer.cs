
namespace CapaPresentacion.FrmSecundarios
{
    partial class FrmPagos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.DataListadoPagos = new System.Windows.Forms.DataGridView();
            this.MontoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscarDocumento = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detalleDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoPagos)).BeginInit();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1211, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(46, 40);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 89;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DataListadoPagos
            // 
            this.DataListadoPagos.AllowUserToAddRows = false;
            this.DataListadoPagos.AllowUserToDeleteRows = false;
            this.DataListadoPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListadoPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListadoPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataListadoPagos.BackgroundColor = System.Drawing.Color.White;
            this.DataListadoPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataListadoPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataListadoPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListadoPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataListadoPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListadoPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MontoNeto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListadoPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataListadoPagos.GridColor = System.Drawing.Color.DimGray;
            this.DataListadoPagos.Location = new System.Drawing.Point(4, 243);
            this.DataListadoPagos.Name = "DataListadoPagos";
            this.DataListadoPagos.ReadOnly = true;
            this.DataListadoPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataListadoPagos.RowHeadersVisible = false;
            this.DataListadoPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoPagos.Size = new System.Drawing.Size(1254, 394);
            this.DataListadoPagos.TabIndex = 88;
            this.DataListadoPagos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoPagos_CellContentDoubleClick);
            // 
            // MontoNeto
            // 
            this.MontoNeto.HeaderText = "MontoNeto";
            this.MontoNeto.Name = "MontoNeto";
            this.MontoNeto.ReadOnly = true;
            // 
            // TxtBuscarDocumento
            // 
            this.TxtBuscarDocumento.BackColor = System.Drawing.Color.White;
            this.TxtBuscarDocumento.BorderColor = System.Drawing.Color.DarkGray;
            this.TxtBuscarDocumento.BorderRadius = 10;
            this.TxtBuscarDocumento.BorderThickness = 2;
            this.TxtBuscarDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscarDocumento.DefaultText = "";
            this.TxtBuscarDocumento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBuscarDocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBuscarDocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscarDocumento.DisabledState.Parent = this.TxtBuscarDocumento;
            this.TxtBuscarDocumento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscarDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscarDocumento.FocusedState.Parent = this.TxtBuscarDocumento;
            this.TxtBuscarDocumento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarDocumento.ForeColor = System.Drawing.Color.Gray;
            this.TxtBuscarDocumento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscarDocumento.HoverState.Parent = this.TxtBuscarDocumento;
            this.TxtBuscarDocumento.Location = new System.Drawing.Point(4, 83);
            this.TxtBuscarDocumento.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtBuscarDocumento.Name = "TxtBuscarDocumento";
            this.TxtBuscarDocumento.PasswordChar = '\0';
            this.TxtBuscarDocumento.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtBuscarDocumento.PlaceholderText = "Buscar";
            this.TxtBuscarDocumento.SelectedText = "";
            this.TxtBuscarDocumento.ShadowDecoration.Parent = this.TxtBuscarDocumento;
            this.TxtBuscarDocumento.Size = new System.Drawing.Size(375, 40);
            this.TxtBuscarDocumento.TabIndex = 87;
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.White;
            this.SubMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalleDePagosToolStripMenuItem,
            this.realizarPagoToolStripMenuItem});
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(209, 52);
            // 
            // detalleDePagosToolStripMenuItem
            // 
            this.detalleDePagosToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.detalleDePagosToolStripMenuItem.Name = "detalleDePagosToolStripMenuItem";
            this.detalleDePagosToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.detalleDePagosToolStripMenuItem.Text = "Detalle de Pagos";
            this.detalleDePagosToolStripMenuItem.Click += new System.EventHandler(this.detalleDePagosToolStripMenuItem_Click);
            // 
            // realizarPagoToolStripMenuItem
            // 
            this.realizarPagoToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.realizarPagoToolStripMenuItem.Name = "realizarPagoToolStripMenuItem";
            this.realizarPagoToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.realizarPagoToolStripMenuItem.Text = "Realizar Pago";
            this.realizarPagoToolStripMenuItem.Click += new System.EventHandler(this.realizarPagoToolStripMenuItem_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.BorderThickness = 3;
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1270, 660);
            this.guna2CustomGradientPanel1.TabIndex = 90;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 660);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DataListadoPagos);
            this.Controls.Add(this.TxtBuscarDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoPagos)).EndInit();
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.DataGridView DataListadoPagos;
        private Guna.UI2.WinForms.Guna2TextBox TxtBuscarDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoNeto;
        private System.Windows.Forms.ContextMenuStrip SubMenu;
        private System.Windows.Forms.ToolStripMenuItem detalleDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPagoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}