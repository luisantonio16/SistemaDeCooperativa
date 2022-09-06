
namespace CapaPresentacion.FrmSecundarios
{
    partial class FrmAhorros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAhorros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.DataListadoAhorros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarDocumento = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnNewAhorro = new Guna.UI2.WinForms.Guna2Button();
            this.SubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detalleDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoAhorros)).BeginInit();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1194, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(39, 38);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 90;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DataListadoAhorros
            // 
            this.DataListadoAhorros.AllowUserToAddRows = false;
            this.DataListadoAhorros.AllowUserToDeleteRows = false;
            this.DataListadoAhorros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListadoAhorros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListadoAhorros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataListadoAhorros.BackgroundColor = System.Drawing.Color.White;
            this.DataListadoAhorros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataListadoAhorros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataListadoAhorros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataListadoAhorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListadoAhorros.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListadoAhorros.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataListadoAhorros.GridColor = System.Drawing.Color.DimGray;
            this.DataListadoAhorros.Location = new System.Drawing.Point(12, 231);
            this.DataListadoAhorros.Name = "DataListadoAhorros";
            this.DataListadoAhorros.ReadOnly = true;
            this.DataListadoAhorros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataListadoAhorros.RowHeadersVisible = false;
            this.DataListadoAhorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoAhorros.Size = new System.Drawing.Size(1218, 394);
            this.DataListadoAhorros.TabIndex = 89;
            this.DataListadoAhorros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoAhorros_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 88;
            this.label1.Text = "Ahorros";
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
            this.TxtBuscarDocumento.Location = new System.Drawing.Point(10, 65);
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // BtnNewAhorro
            // 
            this.BtnNewAhorro.BorderRadius = 8;
            this.BtnNewAhorro.CheckedState.Parent = this.BtnNewAhorro;
            this.BtnNewAhorro.CustomImages.Parent = this.BtnNewAhorro;
            this.BtnNewAhorro.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnNewAhorro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewAhorro.ForeColor = System.Drawing.Color.White;
            this.BtnNewAhorro.HoverState.Parent = this.BtnNewAhorro;
            this.BtnNewAhorro.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewAhorro.Image")));
            this.BtnNewAhorro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnNewAhorro.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnNewAhorro.Location = new System.Drawing.Point(1062, 67);
            this.BtnNewAhorro.Name = "BtnNewAhorro";
            this.BtnNewAhorro.ShadowDecoration.Parent = this.BtnNewAhorro;
            this.BtnNewAhorro.Size = new System.Drawing.Size(176, 45);
            this.BtnNewAhorro.TabIndex = 91;
            this.BtnNewAhorro.Text = "      Nuevo Ahorro";
            this.BtnNewAhorro.Click += new System.EventHandler(this.BtnNewAhorro_Click);
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.White;
            this.SubMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalleDePagosToolStripMenuItem,
            this.realizarPagoToolStripMenuItem});
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(200, 74);
            // 
            // detalleDePagosToolStripMenuItem
            // 
            this.detalleDePagosToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.detalleDePagosToolStripMenuItem.Name = "detalleDePagosToolStripMenuItem";
            this.detalleDePagosToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.detalleDePagosToolStripMenuItem.Text = "Abonar Ahorros";
            this.detalleDePagosToolStripMenuItem.Click += new System.EventHandler(this.detalleDePagosToolStripMenuItem_Click);
            // 
            // realizarPagoToolStripMenuItem
            // 
            this.realizarPagoToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.realizarPagoToolStripMenuItem.Name = "realizarPagoToolStripMenuItem";
            this.realizarPagoToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.realizarPagoToolStripMenuItem.Text = "Ver Detalles";
            this.realizarPagoToolStripMenuItem.Click += new System.EventHandler(this.realizarPagoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Codigo de Ahorro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(539, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "Nombre del Socio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(1012, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 94;
            this.label4.Text = "Total";
            // 
            // FrmAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNewAhorro);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DataListadoAhorros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarDocumento);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmAhorros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAhorros";
            this.Load += new System.EventHandler(this.FrmAhorros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoAhorros)).EndInit();
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.DataGridView DataListadoAhorros;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtBuscarDocumento;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button BtnNewAhorro;
        private System.Windows.Forms.ContextMenuStrip SubMenu;
        private System.Windows.Forms.ToolStripMenuItem detalleDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPagoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}