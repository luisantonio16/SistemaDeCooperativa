
namespace CapaPresentacion.FrmSecundarios
{
    partial class FrmAbonarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbonarPago));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TxtCuotas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lblid = new System.Windows.Forms.Label();
            this.BtnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.LblRestas = new System.Windows.Forms.Label();
            this.LblCodPrestamos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(383, 6);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 40);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCerrar.TabIndex = 90;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 91;
            this.label2.Text = "Nombre:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblNombre.Location = new System.Drawing.Point(91, 58);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(15, 22);
            this.LblNombre.TabIndex = 92;
            this.LblNombre.Text = ".";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Separator1.Location = new System.Drawing.Point(24, 85);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(399, 10);
            this.guna2Separator1.TabIndex = 93;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TxtCuotas
            // 
            this.TxtCuotas.BorderColor = System.Drawing.Color.Silver;
            this.TxtCuotas.BorderRadius = 10;
            this.TxtCuotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCuotas.DefaultText = "";
            this.TxtCuotas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCuotas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCuotas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCuotas.DisabledState.Parent = this.TxtCuotas;
            this.TxtCuotas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCuotas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCuotas.FocusedState.Parent = this.TxtCuotas;
            this.TxtCuotas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuotas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCuotas.HoverState.Parent = this.TxtCuotas;
            this.TxtCuotas.Location = new System.Drawing.Point(106, 152);
            this.TxtCuotas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.PasswordChar = '\0';
            this.TxtCuotas.PlaceholderText = "Cuotas";
            this.TxtCuotas.SelectedText = "";
            this.TxtCuotas.ShadowDecoration.Parent = this.TxtCuotas;
            this.TxtCuotas.Size = new System.Drawing.Size(230, 34);
            this.TxtCuotas.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 95;
            this.label3.Text = "Pago de Cuotas";
            // 
            // Lblid
            // 
            this.Lblid.AutoSize = true;
            this.Lblid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblid.ForeColor = System.Drawing.Color.SteelBlue;
            this.Lblid.Location = new System.Drawing.Point(12, 13);
            this.Lblid.Name = "Lblid";
            this.Lblid.Size = new System.Drawing.Size(15, 22);
            this.Lblid.TabIndex = 96;
            this.Lblid.Text = ".";
            this.Lblid.Visible = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BorderRadius = 8;
            this.BtnAceptar.CheckedState.Parent = this.BtnAceptar;
            this.BtnAceptar.CustomImages.Parent = this.BtnAceptar;
            this.BtnAceptar.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.HoverState.Parent = this.BtnAceptar;
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAceptar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAceptar.Location = new System.Drawing.Point(158, 265);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.ShadowDecoration.Parent = this.BtnAceptar;
            this.BtnAceptar.Size = new System.Drawing.Size(127, 45);
            this.BtnAceptar.TabIndex = 97;
            this.BtnAceptar.Text = "      Pagar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblRestas
            // 
            this.LblRestas.AutoSize = true;
            this.LblRestas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestas.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblRestas.Location = new System.Drawing.Point(20, 98);
            this.LblRestas.Name = "LblRestas";
            this.LblRestas.Size = new System.Drawing.Size(15, 22);
            this.LblRestas.TabIndex = 98;
            this.LblRestas.Text = ".";
            this.LblRestas.Visible = false;
            // 
            // LblCodPrestamos
            // 
            this.LblCodPrestamos.AutoSize = true;
            this.LblCodPrestamos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodPrestamos.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblCodPrestamos.Location = new System.Drawing.Point(20, 132);
            this.LblCodPrestamos.Name = "LblCodPrestamos";
            this.LblCodPrestamos.Size = new System.Drawing.Size(15, 22);
            this.LblCodPrestamos.TabIndex = 99;
            this.LblCodPrestamos.Text = ".";
            this.LblCodPrestamos.Visible = false;
            // 
            // FrmAbonarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 324);
            this.Controls.Add(this.LblCodPrestamos);
            this.Controls.Add(this.LblRestas);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.Lblid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCuotas);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAbonarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbonarPago";
            this.Load += new System.EventHandler(this.FrmAbonarPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label LblNombre;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Lblid;
        internal Guna.UI2.WinForms.Guna2TextBox TxtCuotas;
        private Guna.UI2.WinForms.Guna2Button BtnAceptar;
        internal System.Windows.Forms.Label LblRestas;
        internal System.Windows.Forms.Label LblCodPrestamos;
    }
}