
namespace CapaPresentacion.FrmSecundarios
{
    partial class AddPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbSocios = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.Btncerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtInteres = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtDuraccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCuotas = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbTiempo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCodPagos = new System.Windows.Forms.Label();
            this.LblIdPres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(221, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(90, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Socios";
            // 
            // CmbSocios
            // 
            this.CmbSocios.BackColor = System.Drawing.Color.Transparent;
            this.CmbSocios.BorderRadius = 10;
            this.CmbSocios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbSocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSocios.FocusedColor = System.Drawing.Color.Empty;
            this.CmbSocios.FocusedState.Parent = this.CmbSocios;
            this.CmbSocios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSocios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbSocios.FormattingEnabled = true;
            this.CmbSocios.HoverState.Parent = this.CmbSocios;
            this.CmbSocios.ItemHeight = 30;
            this.CmbSocios.ItemsAppearance.Parent = this.CmbSocios;
            this.CmbSocios.Location = new System.Drawing.Point(9, 174);
            this.CmbSocios.Name = "CmbSocios";
            this.CmbSocios.ShadowDecoration.Parent = this.CmbSocios;
            this.CmbSocios.Size = new System.Drawing.Size(257, 36);
            this.CmbSocios.TabIndex = 2;
            // 
            // CmbTipo
            // 
            this.CmbTipo.BackColor = System.Drawing.Color.Transparent;
            this.CmbTipo.BorderRadius = 10;
            this.CmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FocusedColor = System.Drawing.Color.Empty;
            this.CmbTipo.FocusedState.Parent = this.CmbTipo;
            this.CmbTipo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.HoverState.Parent = this.CmbTipo;
            this.CmbTipo.ItemHeight = 30;
            this.CmbTipo.Items.AddRange(new object[] {
            "Personal",
            "Hipotecario"});
            this.CmbTipo.ItemsAppearance.Parent = this.CmbTipo;
            this.CmbTipo.Location = new System.Drawing.Point(349, 174);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.ShadowDecoration.Parent = this.CmbTipo;
            this.CmbTipo.Size = new System.Drawing.Size(241, 36);
            this.CmbTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(401, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Prestamos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(225, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto Prestamos";
            // 
            // TxtMonto
            // 
            this.TxtMonto.BorderColor = System.Drawing.Color.Silver;
            this.TxtMonto.BorderRadius = 10;
            this.TxtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMonto.DefaultText = "";
            this.TxtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMonto.DisabledState.Parent = this.TxtMonto;
            this.TxtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMonto.FocusedState.Parent = this.TxtMonto;
            this.TxtMonto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMonto.HoverState.Parent = this.TxtMonto;
            this.TxtMonto.Location = new System.Drawing.Point(170, 271);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.PasswordChar = '\0';
            this.TxtMonto.PlaceholderText = "Monto, Solo Numeos";
            this.TxtMonto.SelectedText = "";
            this.TxtMonto.ShadowDecoration.Parent = this.TxtMonto;
            this.TxtMonto.Size = new System.Drawing.Size(276, 38);
            this.TxtMonto.TabIndex = 6;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.White;
            this.guna2Separator1.Enabled = false;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.Location = new System.Drawing.Point(10, 350);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(568, 10);
            this.guna2Separator1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(170, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 27);
            this.label5.TabIndex = 45;
            this.label5.Text = "Detalle del Prestamos";
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackColor = System.Drawing.Color.White;
            this.Btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btncerrar.Image")));
            this.Btncerrar.ImageActive = ((System.Drawing.Image)(resources.GetObject("Btncerrar.ImageActive")));
            this.Btncerrar.Location = new System.Drawing.Point(549, 6);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(32, 32);
            this.Btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Btncerrar.TabIndex = 46;
            this.Btncerrar.TabStop = false;
            this.Btncerrar.Zoom = 10;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(90, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Intereses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(410, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Duracion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(410, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "Cuotas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(90, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Tiempo";
            // 
            // TxtInteres
            // 
            this.TxtInteres.BackColor = System.Drawing.Color.Transparent;
            this.TxtInteres.BorderRadius = 10;
            this.TxtInteres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtInteres.FocusedColor = System.Drawing.Color.Empty;
            this.TxtInteres.FocusedState.Parent = this.TxtInteres;
            this.TxtInteres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TxtInteres.FormattingEnabled = true;
            this.TxtInteres.HoverState.Parent = this.TxtInteres;
            this.TxtInteres.ItemHeight = 30;
            this.TxtInteres.Items.AddRange(new object[] {
            "5",
            "7",
            "10"});
            this.TxtInteres.ItemsAppearance.Parent = this.TxtInteres;
            this.TxtInteres.Location = new System.Drawing.Point(9, 442);
            this.TxtInteres.Name = "TxtInteres";
            this.TxtInteres.ShadowDecoration.Parent = this.TxtInteres;
            this.TxtInteres.Size = new System.Drawing.Size(257, 36);
            this.TxtInteres.TabIndex = 51;
            // 
            // TxtDuraccion
            // 
            this.TxtDuraccion.BorderColor = System.Drawing.Color.Silver;
            this.TxtDuraccion.BorderRadius = 10;
            this.TxtDuraccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDuraccion.DefaultText = "";
            this.TxtDuraccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDuraccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDuraccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDuraccion.DisabledState.Parent = this.TxtDuraccion;
            this.TxtDuraccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDuraccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDuraccion.FocusedState.Parent = this.TxtDuraccion;
            this.TxtDuraccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDuraccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDuraccion.HoverState.Parent = this.TxtDuraccion;
            this.TxtDuraccion.Location = new System.Drawing.Point(322, 444);
            this.TxtDuraccion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDuraccion.Name = "TxtDuraccion";
            this.TxtDuraccion.PasswordChar = '\0';
            this.TxtDuraccion.PlaceholderText = "Duraccion";
            this.TxtDuraccion.SelectedText = "";
            this.TxtDuraccion.ShadowDecoration.Parent = this.TxtDuraccion;
            this.TxtDuraccion.Size = new System.Drawing.Size(268, 34);
            this.TxtDuraccion.TabIndex = 52;
            this.TxtDuraccion.TextChanged += new System.EventHandler(this.TxtDuraccion_TextChanged);
            this.TxtDuraccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDuraccion_KeyPress);
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
            this.TxtCuotas.Location = new System.Drawing.Point(322, 558);
            this.TxtCuotas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.PasswordChar = '\0';
            this.TxtCuotas.PlaceholderText = "Cuotas";
            this.TxtCuotas.SelectedText = "";
            this.TxtCuotas.ShadowDecoration.Parent = this.TxtCuotas;
            this.TxtCuotas.Size = new System.Drawing.Size(268, 34);
            this.TxtCuotas.TabIndex = 53;
            // 
            // CmbTiempo
            // 
            this.CmbTiempo.BackColor = System.Drawing.Color.Transparent;
            this.CmbTiempo.BorderRadius = 10;
            this.CmbTiempo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTiempo.FocusedColor = System.Drawing.Color.Empty;
            this.CmbTiempo.FocusedState.Parent = this.CmbTiempo;
            this.CmbTiempo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbTiempo.FormattingEnabled = true;
            this.CmbTiempo.HoverState.Parent = this.CmbTiempo;
            this.CmbTiempo.ItemHeight = 30;
            this.CmbTiempo.Items.AddRange(new object[] {
            "Meses",
            "Años"});
            this.CmbTiempo.ItemsAppearance.Parent = this.CmbTiempo;
            this.CmbTiempo.Location = new System.Drawing.Point(10, 558);
            this.CmbTiempo.Name = "CmbTiempo";
            this.CmbTiempo.ShadowDecoration.Parent = this.CmbTiempo;
            this.CmbTiempo.Size = new System.Drawing.Size(257, 36);
            this.CmbTiempo.StartIndex = 0;
            this.CmbTiempo.TabIndex = 54;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BorderRadius = 15;
            this.BtnAceptar.CheckedState.Parent = this.BtnAceptar;
            this.BtnAceptar.CustomImages.Parent = this.BtnAceptar;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.HoverState.Parent = this.BtnAceptar;
            this.BtnAceptar.Location = new System.Drawing.Point(368, 672);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.ShadowDecoration.Parent = this.BtnAceptar;
            this.BtnAceptar.Size = new System.Drawing.Size(180, 45);
            this.BtnAceptar.TabIndex = 55;
            this.BtnAceptar.Text = "Agregar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(25, 672);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 56;
            this.guna2Button2.Text = "Cancelar";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // LblCodPagos
            // 
            this.LblCodPagos.AutoSize = true;
            this.LblCodPagos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodPagos.ForeColor = System.Drawing.Color.Gray;
            this.LblCodPagos.Location = new System.Drawing.Point(21, 32);
            this.LblCodPagos.Name = "LblCodPagos";
            this.LblCodPagos.Size = new System.Drawing.Size(69, 23);
            this.LblCodPagos.TabIndex = 58;
            this.LblCodPagos.Text = "Socios";
            this.LblCodPagos.Visible = false;
            // 
            // LblIdPres
            // 
            this.LblIdPres.AutoSize = true;
            this.LblIdPres.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdPres.ForeColor = System.Drawing.Color.Gray;
            this.LblIdPres.Location = new System.Drawing.Point(21, 67);
            this.LblIdPres.Name = "LblIdPres";
            this.LblIdPres.Size = new System.Drawing.Size(69, 23);
            this.LblIdPres.TabIndex = 59;
            this.LblIdPres.Text = "Socios";
            this.LblIdPres.Visible = false;
            // 
            // AddPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 733);
            this.Controls.Add(this.LblIdPres);
            this.Controls.Add(this.LblCodPagos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CmbTiempo);
            this.Controls.Add(this.TxtCuotas);
            this.Controls.Add(this.TxtDuraccion);
            this.Controls.Add(this.TxtInteres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btncerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbSocios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPrestamos";
            this.Load += new System.EventHandler(this.AddPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox CmbSocios;
        private Guna.UI2.WinForms.Guna2ComboBox CmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TxtMonto;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton Btncerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox TxtInteres;
        private Guna.UI2.WinForms.Guna2TextBox TxtDuraccion;
        private Guna.UI2.WinForms.Guna2TextBox TxtCuotas;
        private Guna.UI2.WinForms.Guna2ComboBox CmbTiempo;
        private Guna.UI2.WinForms.Guna2Button BtnAceptar;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblCodPagos;
        private System.Windows.Forms.Label LblIdPres;
    }
}