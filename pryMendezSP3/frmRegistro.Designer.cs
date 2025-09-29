namespace pryMendezSP3
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbMarca = new ComboBox();
            lblMarcaRepuesto = new Label();
            lblOrigenRepuesto = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            cmbOrigen = new ComboBox();
            btnIngresar = new Button();
            gbDatosRepuestos = new GroupBox();
            mtbPrecio = new MaskedTextBox();
            mtbNumero = new MaskedTextBox();
            txtDescripcion = new TextBox();
            lblMarcaConsulta = new Label();
            lblOrigenConsulta = new Label();
            cmbMarcaConsultar = new ComboBox();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            gbConsultar = new GroupBox();
            btnConsultar = new Button();
            tbcDatos = new TabControl();
            tbRepuestos = new TabPage();
            tbConsultas = new TabPage();
            lstDatos = new ListBox();
            gbDatosRepuestos.SuspendLayout();
            gbConsultar.SuspendLayout();
            tbcDatos.SuspendLayout();
            tbRepuestos.SuspendLayout();
            tbConsultas.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(128, 54);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 0;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // lblMarcaRepuesto
            // 
            lblMarcaRepuesto.AutoSize = true;
            lblMarcaRepuesto.Location = new Point(41, 62);
            lblMarcaRepuesto.Name = "lblMarcaRepuesto";
            lblMarcaRepuesto.Size = new Size(43, 15);
            lblMarcaRepuesto.TabIndex = 1;
            lblMarcaRepuesto.Text = "Marca ";
            // 
            // lblOrigenRepuesto
            // 
            lblOrigenRepuesto.AutoSize = true;
            lblOrigenRepuesto.Location = new Point(41, 107);
            lblOrigenRepuesto.Name = "lblOrigenRepuesto";
            lblOrigenRepuesto.Size = new Size(43, 15);
            lblOrigenRepuesto.TabIndex = 2;
            lblOrigenRepuesto.Text = "Origen";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(41, 152);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Numero";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 197);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(41, 242);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(128, 96);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 1;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.GradientActiveCaption;
            btnIngresar.Enabled = false;
            btnIngresar.Location = new Point(174, 303);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // gbDatosRepuestos
            // 
            gbDatosRepuestos.Controls.Add(mtbPrecio);
            gbDatosRepuestos.Location = new Point(20, 24);
            gbDatosRepuestos.Name = "gbDatosRepuestos";
            gbDatosRepuestos.Size = new Size(267, 320);
            gbDatosRepuestos.TabIndex = 8;
            gbDatosRepuestos.TabStop = false;
            gbDatosRepuestos.Text = "Datos De Repuestos";
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(108, 210);
            mtbPrecio.Mask = "99999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(100, 23);
            mtbPrecio.TabIndex = 0;
            mtbPrecio.ValidatingType = typeof(int);
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(128, 144);
            mtbNumero.Mask = "99999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 23);
            mtbNumero.TabIndex = 2;
            mtbNumero.ValidatingType = typeof(int);
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(128, 189);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblMarcaConsulta
            // 
            lblMarcaConsulta.AutoSize = true;
            lblMarcaConsulta.Location = new Point(66, 72);
            lblMarcaConsulta.Name = "lblMarcaConsulta";
            lblMarcaConsulta.Size = new Size(40, 15);
            lblMarcaConsulta.TabIndex = 11;
            lblMarcaConsulta.Text = "Marca";
            // 
            // lblOrigenConsulta
            // 
            lblOrigenConsulta.AutoSize = true;
            lblOrigenConsulta.Location = new Point(46, 104);
            lblOrigenConsulta.Name = "lblOrigenConsulta";
            lblOrigenConsulta.Size = new Size(43, 15);
            lblOrigenConsulta.TabIndex = 12;
            lblOrigenConsulta.Text = "Origen";
            // 
            // cmbMarcaConsultar
            // 
            cmbMarcaConsultar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcaConsultar.FormattingEnabled = true;
            cmbMarcaConsultar.Location = new Point(132, 64);
            cmbMarcaConsultar.Name = "cmbMarcaConsultar";
            cmbMarcaConsultar.Size = new Size(90, 23);
            cmbMarcaConsultar.TabIndex = 13;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(133, 104);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 19);
            rbNacional.TabIndex = 14;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(133, 129);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(81, 19);
            rbImportado.TabIndex = 15;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // gbConsultar
            // 
            gbConsultar.Controls.Add(rbImportado);
            gbConsultar.Controls.Add(lblOrigenConsulta);
            gbConsultar.Controls.Add(rbNacional);
            gbConsultar.Controls.Add(lstDatos);
            gbConsultar.Controls.Add(btnConsultar);
            gbConsultar.Location = new Point(20, 19);
            gbConsultar.Name = "gbConsultar";
            gbConsultar.Size = new Size(259, 335);
            gbConsultar.TabIndex = 16;
            gbConsultar.TabStop = false;
            gbConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.InactiveCaption;
            btnConsultar.Location = new Point(139, 295);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // tbcDatos
            // 
            tbcDatos.Controls.Add(tbRepuestos);
            tbcDatos.Controls.Add(tbConsultas);
            tbcDatos.Location = new Point(76, 40);
            tbcDatos.Name = "tbcDatos";
            tbcDatos.SelectedIndex = 0;
            tbcDatos.Size = new Size(310, 400);
            tbcDatos.TabIndex = 0;
            // 
            // tbRepuestos
            // 
            tbRepuestos.Controls.Add(cmbMarca);
            tbRepuestos.Controls.Add(lblMarcaRepuesto);
            tbRepuestos.Controls.Add(lblOrigenRepuesto);
            tbRepuestos.Controls.Add(lblNumero);
            tbRepuestos.Controls.Add(lblDescripcion);
            tbRepuestos.Controls.Add(txtDescripcion);
            tbRepuestos.Controls.Add(lblPrecio);
            tbRepuestos.Controls.Add(mtbNumero);
            tbRepuestos.Controls.Add(cmbOrigen);
            tbRepuestos.Controls.Add(btnIngresar);
            tbRepuestos.Controls.Add(gbDatosRepuestos);
            tbRepuestos.Location = new Point(4, 24);
            tbRepuestos.Name = "tbRepuestos";
            tbRepuestos.Padding = new Padding(3);
            tbRepuestos.Size = new Size(302, 372);
            tbRepuestos.TabIndex = 0;
            tbRepuestos.Text = "Datos Repuestos";
            tbRepuestos.UseVisualStyleBackColor = true;
            // 
            // tbConsultas
            // 
            tbConsultas.Controls.Add(lblMarcaConsulta);
            tbConsultas.Controls.Add(cmbMarcaConsultar);
            tbConsultas.Controls.Add(gbConsultar);
            tbConsultas.Location = new Point(4, 24);
            tbConsultas.Name = "tbConsultas";
            tbConsultas.Padding = new Padding(3);
            tbConsultas.Size = new Size(302, 372);
            tbConsultas.TabIndex = 1;
            tbConsultas.Text = "Consultas";
            tbConsultas.UseVisualStyleBackColor = true;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(19, 161);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(195, 124);
            lstDatos.TabIndex = 9;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(462, 495);
            Controls.Add(tbcDatos);
            Name = "frmRegistro";
            Text = "Venta De Repuestos";
            Load += frmRegistro_Load;
            gbDatosRepuestos.ResumeLayout(false);
            gbDatosRepuestos.PerformLayout();
            gbConsultar.ResumeLayout(false);
            gbConsultar.PerformLayout();
            tbcDatos.ResumeLayout(false);
            tbRepuestos.ResumeLayout(false);
            tbRepuestos.PerformLayout();
            tbConsultas.ResumeLayout(false);
            tbConsultas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMarca;
        private Label lblMarcaRepuesto;
        private Label lblOrigenRepuesto;
        private Label lblNumero;
        private Label lblDescripcion;
        private Label lblPrecio;
        private ComboBox cmbOrigen;
        private Button btnIngresar;
        private GroupBox gbDatosRepuestos;
        private MaskedTextBox mtbNumero;
        private TextBox txtDescripcion;
        private Label lblMarcaConsulta;
        private Label lblOrigenConsulta;
        private ComboBox cmbMarcaConsultar;
        private RadioButton rbNacional;
        private RadioButton rbImportado;
        private GroupBox gbConsultar;
        private Button btnConsultar;
        private TabControl tbcDatos;
        private TabPage tbRepuestos;
        private TabPage tbConsultas;
        private MaskedTextBox mtbPrecio;
        private ListBox lstDatos;
    }
}
