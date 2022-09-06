
namespace CapaPresentacion.FrmPrincipales
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnAhorros = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPagos = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrestamos = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSocios = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.guna2Panel1.Controls.Add(this.BtnAhorros);
            this.guna2Panel1.Controls.Add(this.BtnPagos);
            this.guna2Panel1.Controls.Add(this.BtnPrestamos);
            this.guna2Panel1.Controls.Add(this.BtnSocios);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(259, 725);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BtnAhorros
            // 
            this.BtnAhorros.BorderRadius = 20;
            this.BtnAhorros.CheckedState.Parent = this.BtnAhorros;
            this.BtnAhorros.CustomImages.Parent = this.BtnAhorros;
            this.BtnAhorros.FillColor = System.Drawing.Color.Transparent;
            this.BtnAhorros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAhorros.ForeColor = System.Drawing.Color.White;
            this.BtnAhorros.HoverState.Parent = this.BtnAhorros;
            this.BtnAhorros.Image = ((System.Drawing.Image)(resources.GetObject("BtnAhorros.Image")));
            this.BtnAhorros.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAhorros.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAhorros.Location = new System.Drawing.Point(10, 500);
            this.BtnAhorros.Name = "BtnAhorros";
            this.BtnAhorros.PressedColor = System.Drawing.Color.DimGray;
            this.BtnAhorros.ShadowDecoration.Parent = this.BtnAhorros;
            this.BtnAhorros.Size = new System.Drawing.Size(223, 45);
            this.BtnAhorros.TabIndex = 15;
            this.BtnAhorros.Text = "Ahorros";
            this.BtnAhorros.Click += new System.EventHandler(this.BtnAhorros_Click);
            // 
            // BtnPagos
            // 
            this.BtnPagos.BorderRadius = 20;
            this.BtnPagos.CheckedState.Parent = this.BtnPagos;
            this.BtnPagos.CustomImages.Parent = this.BtnPagos;
            this.BtnPagos.FillColor = System.Drawing.Color.Transparent;
            this.BtnPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagos.ForeColor = System.Drawing.Color.White;
            this.BtnPagos.HoverState.Parent = this.BtnPagos;
            this.BtnPagos.Image = ((System.Drawing.Image)(resources.GetObject("BtnPagos.Image")));
            this.BtnPagos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPagos.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPagos.Location = new System.Drawing.Point(10, 421);
            this.BtnPagos.Name = "BtnPagos";
            this.BtnPagos.PressedColor = System.Drawing.Color.Teal;
            this.BtnPagos.ShadowDecoration.Parent = this.BtnPagos;
            this.BtnPagos.Size = new System.Drawing.Size(223, 45);
            this.BtnPagos.TabIndex = 14;
            this.BtnPagos.Text = "Pagos";
            this.BtnPagos.Click += new System.EventHandler(this.BtnPagos_Click);
            // 
            // BtnPrestamos
            // 
            this.BtnPrestamos.BorderRadius = 20;
            this.BtnPrestamos.CheckedState.Parent = this.BtnPrestamos;
            this.BtnPrestamos.CustomImages.Parent = this.BtnPrestamos;
            this.BtnPrestamos.FillColor = System.Drawing.Color.Transparent;
            this.BtnPrestamos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrestamos.ForeColor = System.Drawing.Color.White;
            this.BtnPrestamos.HoverState.Parent = this.BtnPrestamos;
            this.BtnPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrestamos.Image")));
            this.BtnPrestamos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPrestamos.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPrestamos.Location = new System.Drawing.Point(10, 342);
            this.BtnPrestamos.Name = "BtnPrestamos";
            this.BtnPrestamos.PressedColor = System.Drawing.Color.Teal;
            this.BtnPrestamos.ShadowDecoration.Parent = this.BtnPrestamos;
            this.BtnPrestamos.Size = new System.Drawing.Size(223, 45);
            this.BtnPrestamos.TabIndex = 13;
            this.BtnPrestamos.Text = "Prestamos";
            this.BtnPrestamos.Click += new System.EventHandler(this.BtnPrestamos_Click);
            // 
            // BtnSocios
            // 
            this.BtnSocios.BorderRadius = 20;
            this.BtnSocios.CheckedState.Parent = this.BtnSocios;
            this.BtnSocios.CustomImages.Parent = this.BtnSocios;
            this.BtnSocios.FillColor = System.Drawing.Color.Transparent;
            this.BtnSocios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSocios.ForeColor = System.Drawing.Color.White;
            this.BtnSocios.HoverState.Parent = this.BtnSocios;
            this.BtnSocios.Image = ((System.Drawing.Image)(resources.GetObject("BtnSocios.Image")));
            this.BtnSocios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSocios.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnSocios.Location = new System.Drawing.Point(10, 266);
            this.BtnSocios.Name = "BtnSocios";
            this.BtnSocios.PressedColor = System.Drawing.Color.Teal;
            this.BtnSocios.ShadowDecoration.Parent = this.BtnSocios;
            this.BtnSocios.Size = new System.Drawing.Size(223, 45);
            this.BtnSocios.TabIndex = 12;
            this.BtnSocios.Text = "Socios";
            this.BtnSocios.Click += new System.EventHandler(this.BtnSocios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 95);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cooperativa";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.pictureBox5);
            this.panelContenedor.Controls.Add(this.pictureBox4);
            this.panelContenedor.Controls.Add(this.pictureBox3);
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(259, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1049, 725);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(390, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ahorros y Prestamos.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(438, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cooperativa";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(416, 252);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(218, 196);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(987, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1025, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 725);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnAhorros;
        private Guna.UI2.WinForms.Guna2Button BtnPagos;
        private Guna.UI2.WinForms.Guna2Button BtnPrestamos;
        private Guna.UI2.WinForms.Guna2Button BtnSocios;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}